using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class TurmaRespondenteAppService : BaseAppService<ITurmaRespondenteService, TurmaRespondente, TurmaRespondenteViewModel>, ITurmaRespondenteAppService
    {
        public TurmaRespondenteAppService(ITurmaRespondenteService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}