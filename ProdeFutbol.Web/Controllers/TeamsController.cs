using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdeFutbol.Web.Data;
using ProdeFutbol.Web.Data.Entities;
using ProdeFutbol.Web.Helpers;
using ProdeFutbol.Web.Models;
using System;
using System.Threading.Tasks;

namespace ProdeFutbol.Web.Controllers
{
    public class TeamsController : Controller
    {
        private readonly DataContext _context;
        private readonly IImageHelper _imageHelper;
        private readonly IConverterHelper _converterHelper;

        public TeamsController(DataContext context,
            IImageHelper imageHelper,
            IConverterHelper converterHelper)
        {
            _context = context;
            _imageHelper = imageHelper;
            _converterHelper = converterHelper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Teams.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeamEntity teamEntity = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamEntity == null)
            {
                return NotFound();
            }

            return View(teamEntity);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamViewModel teamViewModel)
        {
            if (ModelState.IsValid)
            {
                string path = string.Empty;

                if (teamViewModel.LogoFile != null)
                {
                    path = await _imageHelper.UploadImageAsync(teamViewModel.LogoFile, "Teams");
                }

                TeamEntity teamEntity = _converterHelper.ToTeamEntity(teamViewModel, path, true);
                _context.Add(teamEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, $"Already exists the team: {teamEntity.Name}.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }
            }
            return View(teamViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeamEntity teamEntity = await _context.Teams.FindAsync(id);
            if (teamEntity == null)
            {
                return NotFound();
            }

            TeamViewModel teamViewModel = _converterHelper.ToTeamViewModel(teamEntity);
            return View(teamViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TeamViewModel teamViewModel)
        {
            if (id != teamViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string path = teamViewModel.LogoPath;

                if (teamViewModel.LogoFile != null)
                {
                    path = await _imageHelper.UploadImageAsync(teamViewModel.LogoFile, "Teams");
                }

                TeamEntity teamEntity = _converterHelper.ToTeamEntity(teamViewModel, path, false);
                _context.Update(teamEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, $"Already exists the team: {teamEntity.Name}.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }
            }
            return View(teamViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeamEntity teamEntity = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamEntity == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(teamEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
