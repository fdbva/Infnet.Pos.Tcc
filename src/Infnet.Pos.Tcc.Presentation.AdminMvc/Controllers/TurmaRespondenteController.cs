using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class TurmaRespondenteController : BaseCrudController<ITurmaRespondenteAppService, TurmaRespondenteViewModel>
    {
        private readonly IStringLocalizer<TurmaRespondenteController> _localizer;

        public TurmaRespondenteController(
            ITurmaRespondenteAppService appService,
            IStringLocalizer<TurmaRespondenteController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<TurmaRespondenteViewModel> grid)
        {
            grid.Columns.Add(x => x.Turma);
            grid.Columns.Add(x => x.Respondente);
        }
    }
}