using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class RespondenteController : BaseCrudController<IRespondenteAppService, RespondenteViewModel>
    {
        private readonly IStringLocalizer<RespondenteController> _localizer;

        public RespondenteController(
            IRespondenteAppService appService,
            IStringLocalizer<RespondenteController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<RespondenteViewModel> grid)
        {
            grid.Columns.Add(x => x.Cpf);
            grid.Columns.Add(x => x.Nome);
            grid.Columns.Add(x => x.Nascimento);
        }
    }
}