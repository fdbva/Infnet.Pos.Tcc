using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class GrupoQuestaoAppService : BaseAppService<IGrupoQuestaoService, GrupoQuestao, GrupoQuestaoViewModel>, IGrupoQuestaoAppService
    {
        public GrupoQuestaoAppService(IGrupoQuestaoService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}