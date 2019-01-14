using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public class GrupoQuestaoController : BaseCrudController<IGrupoQuestaoAppService, GrupoQuestaoViewModel>
    {
        public GrupoQuestaoController(IGrupoQuestaoAppService context) : base(context)
        {
        }
    }
}