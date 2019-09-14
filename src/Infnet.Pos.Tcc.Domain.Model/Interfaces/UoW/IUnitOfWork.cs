using System.Threading.Tasks;

namespace Infnet.Pos.Tcc.Domain.Model.Interfaces.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        Task CommitAsync();
        void Commit();
    }
}