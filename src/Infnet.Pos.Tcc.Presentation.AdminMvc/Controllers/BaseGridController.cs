using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public abstract class BaseGridController<TIAppService, TEntityViewModel> : Controller
        where TEntityViewModel : BaseViewModel
        where TIAppService : IBaseAppService<TEntityViewModel>
    {
        private readonly TIAppService _appService;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        private readonly IOptionsMonitor<AvaliacaoOptions> _options;

        protected BaseGridController(
            TIAppService appService,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options)
        {
            _appService = appService;
            _sharedLocalizer = sharedLocalizer;
            _options = options;
        }

        protected abstract void GridConfigureColumns(Grid<TEntityViewModel> grid);

        protected async Task<IGrid<TEntityViewModel>> CriarGridIndex(bool exibirNaTela = true)
        {
            var entidade = await _appService.GetAllAsNoTrackingAsync();
            var grid = new Grid<TEntityViewModel>(entidade)
            {
                ViewContext = new ViewContext { HttpContext = HttpContext },
                Query = Request.Query,
                EmptyText = _sharedLocalizer["Nenhum dado para exibir"],
                Attributes = { ["class"] = "table-striped" }
            };

            GridConfigureColumns(grid);

            if (exibirNaTela)
            {
                GridAddFilterSort(grid);
                grid.Pager = new GridPager<TEntityViewModel>(grid);
                grid.Processors.Add(grid.Pager);
                grid.Pager.RowsPerPage = _options.CurrentValue.IndexDefaultRowsPerPage;
                grid.Columns.Add()
                    .Encoded(false)
                    .RenderedAs(x =>
                    {
                        var key = new { id = x.Id };
                        var tagBuilder = new TagBuilder("<b>");
                        tagBuilder.InnerHtml.AppendHtml(
                            $"<a href='{Url.Action("Edit", key)}'>{_sharedLocalizer["Editar"]}</a>");
                        tagBuilder.InnerHtml.AppendHtml(
                            "<span>|</span>");
                        tagBuilder.InnerHtml.AppendHtml(
                            $"<a href='{Url.Action("Details", key)}'>{_sharedLocalizer["Detalhe"]}</a>");
                        tagBuilder.InnerHtml.AppendHtml(
                            "<span>|</span>");
                        tagBuilder.InnerHtml.AppendHtml(
                            $"<a href='{Url.Action("Delete", key)}'>{_sharedLocalizer["Remover"]}</a>");

                        return tagBuilder.InnerHtml;
                    });
            }

            return grid;
        }

        private static void GridAddFilterSort(IGrid<TEntityViewModel> grid)
        {
            foreach (var column in grid.Columns)
            {
                column.Filter.IsEnabled = true;
                column.Filter.IsMulti = true;
                column.Sort.IsEnabled = true;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GerarRelatorio()
        {
            var grid = await CriarGridIndex(false);
            return GerarCsv(grid);
        }

        private static FileStreamResult GerarCsv(IGrid<TEntityViewModel> grid)
        {
            var fileResult = GerarCsvHelperVirgula(grid);

            fileResult.FileDownloadName = $"{typeof(TEntityViewModel).Name}{DateTime.Now:yyyyMMMdd}.csv";

            return fileResult;
        }

        private static FileStreamResult GerarCsvHelperVirgula(IGrid<TEntityViewModel> grid)
        {
            var memoryStream = new MemoryStream();
            var streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
            var csvWriter = new CsvWriter(streamWriter);

            foreach (var column in grid.Columns)
            {
                csvWriter.WriteField(column.Title);
            }

            csvWriter.NextRecord();

            foreach (var gridRow in grid.Rows)
            {
                foreach (var column in grid.Columns)
                {
                    column.IsEncoded = false;
                    csvWriter.WriteField(column.ValueFor(gridRow));
                }

                csvWriter.NextRecord();
            }

            streamWriter.Flush();
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "text/csv");
        }
    }
}