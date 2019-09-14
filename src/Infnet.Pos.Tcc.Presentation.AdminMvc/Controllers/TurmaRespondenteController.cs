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
    public class TurmaRespondenteController : BaseCrudController<ITurmaRespondenteAppService, TurmaRespondenteViewModel>
    {
        private readonly IStringLocalizer<TurmaRespondenteController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public TurmaRespondenteController(
            ITurmaRespondenteAppService appService,
            IStringLocalizer<TurmaRespondenteController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        protected override void GridConfigureColumns(Grid<TurmaRespondenteViewModel> grid)
        {
            grid.Columns.Add(x => x.Turma.Descricao).Titled(_sharedLocalizer["Turma"]);
            grid.Columns.Add(x => x.Respondente.Nome).Titled(_sharedLocalizer["Nome do Respondente"]);;
            grid.Columns.Add(x => x.Respondente.Cpf).Titled(_sharedLocalizer["CPF do Respondente"]);
        }
    }
}