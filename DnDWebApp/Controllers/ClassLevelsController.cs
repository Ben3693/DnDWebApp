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
    public class ClassLevelsController : Controller
    {
        private readonly DnDContext _context;

        public ClassLevelsController(DnDContext context)
        {
            _context = context;
        }

        // GET: ClassLevels
        public async Task<IActionResult> Index(string sortOrder, string id)
        {
            ViewBag.ClassNameSortParm = sortOrder == "Class Name" ? "Class_Name_desc" : "Class Name";
            ViewBag.HitDiceSortParm = sortOrder == "Hit Dice" ? "Hit_Dice_desc" : "Hit Dice";
            ViewBag.LevelSortParm = string.IsNullOrEmpty(sortOrder) ? "Level_desc" : "";
            ViewBag.FeaturesSortParm = sortOrder == "Features" ? "Features_desc" : "Features";

            var levels = from l in _context.ClassLevel
                         select l;

            if (!string.IsNullOrEmpty(id))
            {
                levels = levels.Where(l => l.ClassName.Contains(id));
            }

            switch (sortOrder)
            {
                case "Class Name":
                    levels = levels.OrderBy(l => l.ClassName);
                    break;
                case "Class_Name_desc":
                    levels = levels.OrderByDescending(l => l.ClassName);
                    break;
                case "Hit Dice":
                    levels = levels.OrderBy(l => l.HitDice);
                    break;
                case "Hit_Dice_desc":
                    levels = levels.OrderByDescending(l => l.HitDice);
                    break;
                case "Level_desc":
                    levels = levels.OrderByDescending(l => l.Level);
                    break;
                case "Features":
                    levels = levels.OrderBy(l => l.Features);
                    break;
                case "Features_desc":
                    levels = levels.OrderByDescending(l => l.Features);
                    break;
                default:
                    levels = levels.OrderBy(l => l.Level);
                    break;
            }

            return View(await levels.ToListAsync());
        }

        // GET: ClassLevels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classLevel = await _context.ClassLevel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classLevel == null)
            {
                return NotFound();
            }

            return View(classLevel);
        }

        // GET: ClassLevels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassName,HitDice,Level,Features")] ClassLevel classLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(classLevel);
        }

        // GET: ClassLevels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classLevel = await _context.ClassLevel.FindAsync(id);
            if (classLevel == null)
            {
                return NotFound();
            }
            return View(classLevel);
        }

        // POST: ClassLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassName,HitDice,Level,Features")] ClassLevel classLevel)
        {
            if (id != classLevel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassLevelExists(classLevel.Id))
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
            return View(classLevel);
        }

        // GET: ClassLevels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classLevel = await _context.ClassLevel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classLevel == null)
            {
                return NotFound();
            }

            return View(classLevel);
        }

        // POST: ClassLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classLevel = await _context.ClassLevel.FindAsync(id);
            _context.ClassLevel.Remove(classLevel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassLevelExists(int id)
        {
            return _context.ClassLevel.Any(e => e.Id == id);
        }
    }
}
