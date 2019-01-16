﻿using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NonFactors.Mvc.Grid;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class GrupoQuestaoController : BaseCrudController<IGrupoQuestaoAppService, GrupoQuestaoViewModel>
    {
        private readonly IStringLocalizer<GrupoQuestaoController> _localizer;

        public GrupoQuestaoController(
            IGrupoQuestaoAppService appService,
            IStringLocalizer<GrupoQuestaoController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _localizer = localizer;
        }

        protected override void GridConfigureColumns(Grid<GrupoQuestaoViewModel> grid)
        {
            grid.Columns.Add(x => x.Codigo);
            grid.Columns.Add(x => x.Descricao);
        }
    }
}