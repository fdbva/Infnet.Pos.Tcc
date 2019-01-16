using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class BlocoController : BaseCrudController<IBlocoAppService, BlocoViewModel>
    {
        private readonly IStringLocalizer<BlocoController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public BlocoController(
            IBlocoAppService appService,
            IStringLocalizer<BlocoController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        protected override void GridConfigureColumns(Grid<BlocoViewModel> grid)
        {
            grid.Columns.Add(x => x.Descricao);
            grid.Columns.Add(x => x.Curso.Descricao).Titled(_sharedLocalizer["Descrição do Curso"]);
        }
    }
}