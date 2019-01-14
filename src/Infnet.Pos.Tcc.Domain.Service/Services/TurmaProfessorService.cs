using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;

namespace Infnet.Pos.Tcc.Domain.Service.Services
{
    public class TurmaProfessorService : BaseService<TurmaProfessor>, ITurmaProfessorService
    {
        public TurmaProfessorService(ITurmaProfessorRepository repository) : base(repository)
        {
        }
    }
}