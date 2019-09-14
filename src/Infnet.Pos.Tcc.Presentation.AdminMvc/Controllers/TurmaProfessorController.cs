using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    //Este é um CRUD de relacionamento apenas, usado para "manutenção dos dados".
    public class TurmaProfessorController : BaseCrudController<ITurmaProfessorAppService, TurmaProfessorViewModel>
    {
        private readonly IStringLocalizer<TurmaProfessorController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public TurmaProfessorController(
            ITurmaProfessorAppService appService,
            IStringLocalizer<TurmaProfessorController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        protected override void GridConfigureColumns(Grid<TurmaProfessorViewModel> grid)
        {
            grid.Columns.Add(x => x.Turma.Descricao).Titled(_sharedLocalizer["Turma"]);
            grid.Columns.Add(x => x.Professor.Nome).Titled(_sharedLocalizer["Nome do Professor"]);;
            grid.Columns.Add(x => x.Professor.Cpf).Titled(_sharedLocalizer["CPF do Professor"]);
        }
    }
}