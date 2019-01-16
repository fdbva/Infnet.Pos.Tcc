using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class TurmaController : BaseCrudController<ITurmaAppService, TurmaViewModel>
    {
        private readonly IStringLocalizer<TurmaController> _localizer;

        public TurmaController(
            ITurmaAppService appService,
            IStringLocalizer<TurmaController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<TurmaViewModel> grid)
        {
            grid.Columns.Add(x => x.Descricao);
            grid.Columns.Add(x => x.Modulo);
            grid.Columns.Add(x => x.Inicio);
            grid.Columns.Add(x => x.Termino);
        }
    }
}