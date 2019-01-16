using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class RespostaAvaliacaoLogController : BaseCrudController<IRespostaAvaliacaoLogAppService, RespostaAvaliacaoLogViewModel>
    {
        private readonly IStringLocalizer<RespostaAvaliacaoLogController> _localizer;

        public RespostaAvaliacaoLogController(
            IRespostaAvaliacaoLogAppService appService,
            IStringLocalizer<RespostaAvaliacaoLogController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<RespostaAvaliacaoLogViewModel> grid)
        {
            grid.Columns.Add(x=>x.AvaliacaoCodigo);
            grid.Columns.Add(x=>x.Questao);
            grid.Columns.Add(x=>x.Resposta);
            grid.Columns.Add(x=>x.ProfessorCpf);
            grid.Columns.Add(x=>x.ProfessorNome);
            grid.Columns.Add(x=>x.AlunoCpf);
            grid.Columns.Add(x=>x.AlunoNome);
            grid.Columns.Add(x=>x.TurmaDescricao);
            grid.Columns.Add(x=>x.TurmaInicio);
            grid.Columns.Add(x=>x.TurmaTermino);
            grid.Columns.Add(x=>x.ModuloDescricao);
            grid.Columns.Add(x=>x.BlocoDescricao);
            grid.Columns.Add(x=>x.CursoDescricao);
        }
    }
}