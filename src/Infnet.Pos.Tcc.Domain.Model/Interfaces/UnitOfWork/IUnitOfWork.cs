using System.Threading.Tasks;

namespace Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        Task CommitAsync();
        void Commit();
    }
}