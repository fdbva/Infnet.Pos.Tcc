using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infnet.Pos.Tcc.Application.ViewModels;

namespace Infnet.Pos.Tcc.Application.AppServices
{
    public interface IBaseAppService<TEntityViewModel>
        where TEntityViewModel : BaseViewModel
    {
        Task<TEntityViewModel> AddAsync(TEntityViewModel tEntityViewModel);
        Task<TEntityViewModel> FindAsync(Guid id);
        Task<IEnumerable<TEntityViewModel>> GetAllAsNoTrackingAsync();
        TEntityViewModel Update(TEntityViewModel tEntityViewModel);
        Task RemoveAsync(Guid id);
        void Remove(TEntityViewModel tEntityViewModel);
        void Dispose();
    }
}