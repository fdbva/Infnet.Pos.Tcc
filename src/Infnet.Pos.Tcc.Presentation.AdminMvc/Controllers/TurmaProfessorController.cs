using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class TurmaProfessorController : BaseCrudController<ITurmaProfessorAppService, TurmaProfessorViewModel>
    {
        private readonly IStringLocalizer<TurmaProfessorController> _localizer;

        public TurmaProfessorController(
            ITurmaProfessorAppService appService,
            IStringLocalizer<TurmaProfessorController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<TurmaProfessorViewModel> grid)
        {
            grid.Columns.Add(x => x.Turma);
            grid.Columns.Add(x => x.Professor);
        }
    }
}