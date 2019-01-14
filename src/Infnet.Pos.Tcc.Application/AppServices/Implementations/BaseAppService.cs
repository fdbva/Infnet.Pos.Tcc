using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Infnet.Pos.Tcc.Application.AutoMapper;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class BaseAppService<TIService, TEntity, TEntityViewModel> : IBaseAppService<TEntityViewModel>
        where TEntity : BaseEntity
        where TEntityViewModel : BaseViewModel
        where TIService : IBaseService<TEntity>
    {
        private readonly TIService _baseService;
        protected readonly IMapper AutoMapper;
        protected readonly IUnitOfWork Uow;

        public BaseAppService(TIService baseService, IUnitOfWork uow) //, IMapper autoMapper)
        {
            _baseService = baseService;
            Uow = uow;
            AutoMapper = new Mapper(AutoMapperConfig.RegisterMappings()); // autoMapper;
        }

        public virtual Task<TEntityViewModel> AddAsync(TEntityViewModel obj)
        {
            Uow.BeginTransaction();
            var ret = _baseService.AddAsync(AutoMapper.Map<TEntity>(obj));
            Uow.CommitAsync();
            return AutoMapper.Map<Task<TEntityViewModel>>(ret);
        }

        public virtual Task<TEntityViewModel> FindAsync(Guid id)
        {
            return AutoMapper.Map<Task<TEntityViewModel>>(_baseService.FindAsync(id));
        }

        public virtual async Task<IEnumerable<TEntityViewModel>> GetAllAsNoTrackingAsync()
        {
            return AutoMapper.Map<IQueryable<TEntityViewModel>>(await _baseService.GetAllAsNoTrackingAsync());
        }

        public virtual TEntityViewModel Update(TEntityViewModel obj)
        {
            Uow.BeginTransaction();
            var ret = _baseService.Update(AutoMapper.Map<TEntity>(obj));
            Uow.Commit();
            return AutoMapper.Map<TEntityViewModel>(ret);
        }

        public virtual Task RemoveAsync(Guid id)
        {
            Uow.BeginTransaction();
            var ret = _baseService.RemoveAsync(id);
            Uow.CommitAsync();
            return ret;
        }

        public virtual void Remove(TEntityViewModel obj)
        {
            Uow.BeginTransaction();
            _baseService.Remove(AutoMapper.Map<TEntity>(obj));
            Uow.CommitAsync();
        }

        public void Dispose()
        {
            _baseService.Dispose();
        }
    }
}