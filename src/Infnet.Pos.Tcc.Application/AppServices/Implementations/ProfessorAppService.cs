using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class ProfessorAppService : BaseAppService<IProfessorService, Professor, ProfessorViewModel>, IProfessorAppService
    {
        public ProfessorAppService(IProfessorService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}