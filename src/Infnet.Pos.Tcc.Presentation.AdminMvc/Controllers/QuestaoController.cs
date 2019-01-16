using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class QuestaoController : BaseCrudController<IQuestaoAppService, QuestaoViewModel>
    {
        private readonly IStringLocalizer<QuestaoController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public QuestaoController(
            IQuestaoAppService appService,
            IStringLocalizer<QuestaoController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        protected override void GridConfigureColumns(Grid<QuestaoViewModel> grid)
        {
            grid.Columns.Add(x => x.Codigo);
            grid.Columns.Add(x => x.Descricao);
            grid.Columns.Add(x => x.Ativa);
            grid.Columns.Add(x => x.GrupoQuestao.Codigo).Titled(_sharedLocalizer["Codigo do Grupo de Questão"]);
        }
    }
}