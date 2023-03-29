using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheCause.Data;
using TheCause.Models;

namespace TheCause.Areas.Admin
{
    [Area("Admin")]
    public class PetitionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetitionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Dashboard
        public async Task<IActionResult> Dashboard()
        {
            return View(await _context.Petitions.ToListAsync());
        }

        // GET: Admin/Petitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Petitions.ToListAsync());
        }

        // GET: Admin/Petitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petition = await _context.Petitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petition == null)
            {
                return NotFound();
            }

            return View(petition);
        }

        // GET: Admin/Petitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Petitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,CreatedAt,UpdatedAt,UserId,SignCount,PhotoUrl")] Petition petition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(petition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petition);
        }

        // GET: Admin/Petitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petition = await _context.Petitions.FindAsync(id);
            if (petition == null)
            {
                return NotFound();
            }
            return View(petition);
        }

        // POST: Admin/Petitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,CreatedAt,UpdatedAt,UserId,SignCount,PhotoUrl")] Petition petition)
        {
            if (id != petition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetitionExists(petition.Id))
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
            return View(petition);
        }

        // GET: Admin/Petitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petition = await _context.Petitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petition == null)
            {
                return NotFound();
            }

            return View(petition);
        }

        // POST: Admin/Petitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var petition = await _context.Petitions.FindAsync(id);
            _context.Petitions.Remove(petition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetitionExists(int id)
        {
            return _context.Petitions.Any(e => e.Id == id);
        }
    }
}
