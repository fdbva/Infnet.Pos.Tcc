using System;
using System.Linq;
using System.Threading.Tasks;
using Infnet.Pos.Tcc.Application.AppServices;
using Infnet.Pos.Tcc.Application.ViewModels;
using Infnet.Pos.Tcc.Infrastructure.CrossCutting.Resources;
using Infnet.Pos.Tcc.Presentation.AdminMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace Infnet.Pos.Tcc.Presentation.AdminMvc.Controllers
{
    public abstract class BaseCrudController<TIAppService, TEntityViewModel> : BaseGridController<TIAppService, TEntityViewModel>
        where TEntityViewModel : BaseViewModel
        where TIAppService : IBaseAppService<TEntityViewModel>
    {
        private readonly TIAppService _appService;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        private readonly IOptionsMonitor<AvaliacaoOptions> _options;

        protected BaseCrudController(
            TIAppService appService,
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptionsMonitor<AvaliacaoOptions> options) : base(appService, sharedLocalizer, options)
        {
            _appService = appService;
            _sharedLocalizer = sharedLocalizer;
            _options = options;
        }

        public virtual async Task<IActionResult> Index()
        {
            return View(await CriarGridIndex());
        }

        public virtual async Task<IActionResult> Details(Guid? id)
        {
            return await GetEntityViewModel(id);
        }

        public virtual IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Create(TEntityViewModel entityViewModel)
        {
            if (ModelState.IsValid)
            {
                entityViewModel.Id = Guid.NewGuid();
                await _appService.AddAsync(entityViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(entityViewModel);
        }

        public virtual async Task<IActionResult> Edit(Guid? id)
        {
            return await GetEntityViewModel(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Edit(Guid id, TEntityViewModel entityViewModel)
        {
            if (id != entityViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.Update(entityViewModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!(await EntityViewModelExists(entityViewModel.Id)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(entityViewModel);
        }

        public virtual async Task<IActionResult> Delete(Guid? id)
        {
            return await GetEntityViewModel(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<IActionResult> GetEntityViewModel(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entityViewModel = await _appService.FindAsync(id.Value);
            if (entityViewModel == null)
            {
                return NotFound();
            }

            return View(entityViewModel);
        }

        private async Task<bool> EntityViewModelExists(Guid id)
        {
            return (await _appService.GetAllAsNoTrackingAsync()).Any(e => e.Id == id);
        }
    }
}