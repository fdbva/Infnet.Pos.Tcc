using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UoW;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class TurmaProfessorAppService : BaseAppService<ITurmaProfessorService, TurmaProfessor, TurmaProfessorViewModel>, ITurmaProfessorAppService
    {
        public TurmaProfessorAppService(ITurmaProfessorService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}