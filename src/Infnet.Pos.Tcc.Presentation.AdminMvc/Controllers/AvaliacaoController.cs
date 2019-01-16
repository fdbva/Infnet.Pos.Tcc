using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class AvaliacaoController : BaseCrudController<IAvaliacaoAppService, AvaliacaoViewModel>
    {
        private readonly IStringLocalizer<AvaliacaoController> _localizer;

        public AvaliacaoController(
            IAvaliacaoAppService appService,
            IStringLocalizer<AvaliacaoController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<AvaliacaoViewModel> grid)
        {
            grid.Columns.Add(x => x.Codigo);
            grid.Columns.Add(x => x.Abertura);
            grid.Columns.Add(x => x.Fechamento);
        }
    }
}