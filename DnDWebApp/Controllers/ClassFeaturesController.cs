using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DnDWebApp.Data;
using DnDWebApp.Models;

namespace DnDWebApp.Controllers
{
    public class ClassFeaturesController : Controller
    {
        private readonly DnDContext _context;

        public ClassFeaturesController(DnDContext context)
        {
            _context = context;
        }

        // GET: ClassFeatures
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClassFeature.ToListAsync());
        }

        // GET: ClassFeatures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classFeature = await _context.ClassFeature
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classFeature == null)
            {
                return NotFound();
            }

            return View(classFeature);
        }

        // GET: ClassFeatures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassFeatures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FeatureName,FeatureDescription,Active,Combat")] ClassFeature classFeature)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classFeature);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classFeature);
        }

        // GET: ClassFeatures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classFeature = await _context.ClassFeature.FindAsync(id);
            if (classFeature == null)
            {
                return NotFound();
            }
            return View(classFeature);
        }

        // POST: ClassFeatures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FeatureName,FeatureDescription,Active,Combat")] ClassFeature classFeature)
        {
            if (id != classFeature.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classFeature);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassFeatureExists(classFeature.Id))
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
            return View(classFeature);
        }

        // GET: ClassFeatures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classFeature = await _context.ClassFeature
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classFeature == null)
            {
                return NotFound();
            }

            return View(classFeature);
        }

        // POST: ClassFeatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classFeature = await _context.ClassFeature.FindAsync(id);
            _context.ClassFeature.Remove(classFeature);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassFeatureExists(int id)
        {
            return _context.ClassFeature.Any(e => e.Id == id);
        }
    }
}
