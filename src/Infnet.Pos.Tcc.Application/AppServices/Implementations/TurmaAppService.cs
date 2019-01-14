using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class TurmaAppService : BaseAppService<ITurmaService, Turma, TurmaViewModel>, ITurmaAppService
    {
        public TurmaAppService(ITurmaService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}