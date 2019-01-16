using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class ModuloController : BaseCrudController<IModuloAppService, ModuloViewModel>
    {
        private readonly IStringLocalizer<ModuloController> _localizer;

        public ModuloController(
            IModuloAppService appService,
            IStringLocalizer<ModuloController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<ModuloViewModel> grid)
        {
            grid.Columns.Add(x => x.Descricao);
            grid.Columns.Add(x => x.Bloco);
        }
    }
}