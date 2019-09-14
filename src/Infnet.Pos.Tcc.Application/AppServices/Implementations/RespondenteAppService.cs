using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UoW;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class RespondenteAppService : BaseAppService<IRespondenteService, Respondente, RespondenteViewModel>, IRespondenteAppService
    {
        public RespondenteAppService(IRespondenteService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}