using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infnet.Pos.Tcc.Domain.Model.Entities;

namespace Infnet.Pos.Tcc.Domain.Model.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity tEntity);
        Task<TEntity> FindAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsNoTrackingAsync();
        TEntity Update(TEntity tEntity);
        Task RemoveAsync(Guid id);
        void Remove(TEntity tEntity);
        void Dispose();
    }
}