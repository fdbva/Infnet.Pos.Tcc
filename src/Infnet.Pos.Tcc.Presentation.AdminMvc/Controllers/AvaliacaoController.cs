using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    //TODO: o Create de Avaliacao tem que ser especial. Na tela de criação deve ser possível escolher as questões (que é de 1-many)
    // e as turmas (que tbm é 1-many), no entanto, ao escolher as turmas, a tabela de relacionamento que será populada é AvaliacaoRespondente
    // e não AvaliacaoTurma pois esta não existe.
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