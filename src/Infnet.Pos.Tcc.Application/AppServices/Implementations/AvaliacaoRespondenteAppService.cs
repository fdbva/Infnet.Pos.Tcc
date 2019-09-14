using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UoW;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class AvaliacaoRespondenteAppService : BaseAppService<IAvaliacaoRespondenteService, AvaliacaoRespondente, AvaliacaoRespondenteViewModel>, IAvaliacaoRespondenteAppService
    {
        public AvaliacaoRespondenteAppService(IAvaliacaoRespondenteService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}