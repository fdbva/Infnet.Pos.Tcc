using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class AvaliacaoRespondenteController : BaseCrudController<IAvaliacaoRespondenteAppService, AvaliacaoRespondenteViewModel>
    {
        private readonly IStringLocalizer<AvaliacaoRespondenteController> _localizer;

        public AvaliacaoRespondenteController(
            IAvaliacaoRespondenteAppService appService,
            IStringLocalizer<AvaliacaoRespondenteController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<AvaliacaoRespondenteViewModel> grid)
        {
            grid.Columns.Add(x => x.Avaliacao);
            grid.Columns.Add(x => x.Respondente);
            grid.Columns.Add(x => x.Enviado);
            grid.Columns.Add(x => x.Respondido);
            grid.Columns.Add(x => x.StatusEmail);
        }
    }
}