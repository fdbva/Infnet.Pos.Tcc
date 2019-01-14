using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Domain.Model.Entities;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.Services;
using Infnet.Pos.Tcc.Domain.Model.Interfaces.UnitOfWork;

namespace Infnet.Pos.Tcc.Application.AppServices.Implementations
{
    public class ModuloAppService : BaseAppService<IModuloService, Modulo, ModuloViewModel>, IModuloAppService
    {
        public ModuloAppService(IModuloService repository, IUnitOfWork uoW)
            : base(repository, uoW)
        {
        }
    }
}