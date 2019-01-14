using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;

namespace Infnet.Pos.Tcc.Domain.Service.Services
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        public TurmaService(ITurmaRepository repository) : base(repository)
        {
        }
    }
}