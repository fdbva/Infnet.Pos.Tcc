using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class ProfessorController : BaseCrudController<IProfessorAppService, ProfessorViewModel>
    {
        private readonly IStringLocalizer<ProfessorController> _localizer;

        public ProfessorController(
            IProfessorAppService appService,
            IStringLocalizer<ProfessorController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<ProfessorViewModel> grid)
        {
            grid.Columns.Add(x => x.Cpf);
            grid.Columns.Add(x => x.Nome);
        }
    }
}