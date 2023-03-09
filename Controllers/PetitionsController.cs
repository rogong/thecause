﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheCause.Data;
using TheCause.Models;
using TheCause.ViewModel;

namespace TheCause.Controllers
{
    public class PetitionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _hostingEnv;

        public PetitionsController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _hostingEnv = env;
        }

        // GET: Petitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Petitions.ToListAsync());
        }

        // GET: Petitions/Details/5
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

            var signs = await _context.Signs.
               Where(s => s.PetitionId == id).
               ToListAsync();

            ViewBag.SignsCount = signs.Count;
            ViewBag.Signs = signs;



            ViewBag.CreatedAt = DateTime.Now;
            ViewBag.UpdatedAt = DateTime.Now;
            ViewBag.UserId = User.Identity.Name;
            ViewBag.PetitionId = id;



            return View(petition);
        }

      
        // GET: Petitions/Create
        public IActionResult Create()
        {

            ViewBag.CreatedAt = DateTime.Now;
            ViewBag.UpdatedAt = DateTime.Now;
            ViewBag.UserId = User.Identity.Name;

            return View();
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,CreatedAt,UpdatedAt,UserId,PhotoUrl")] Petition petition,
            IFormFile file, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                //Upload data
                if (file != null)
                {
                    var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), _hostingEnv.WebRootPath, "uploads", fileName);
                    //var stream = new FileStream(path, FileMode.Create);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    var WebUrl = $"{this.Request.Scheme}://{this.Request.Host}/uploads/";

                    petition.PhotoUrl = WebUrl + fileName;
                }

                _context.Add(petition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petition);
        }

        [Authorize]
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

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,CreatedAt,UpdatedAt,UserId")] Petition petition)
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

        [Authorize]
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

        [Authorize]
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

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sign([Bind("Id,UserId,PetitionId,CreatedAt,UpdatedAt")] Sign sign,
          string returnUrl = null)
        {
            var signs = await _context.Signs.
                Where(s => s.PetitionId == sign.PetitionId).
                ToListAsync();

            foreach(var sig in signs)
            {
                if(sig.UserId == sign.UserId) {
                    ViewBag.progressMessage = "You have Signed before, no multiple signatures!";
                    returnUrl = returnUrl ?? Url.Content("~/");
                    return LocalRedirect(returnUrl);
                }
            }

            if (ModelState.IsValid)
            {

                
                _context.Add(sign);
                await _context.SaveChangesAsync();

               

                ViewBag.progressMessage = "Your Sign added successfully";
                
            }

            returnUrl = returnUrl ?? Url.Content("~/");
            return LocalRedirect(returnUrl);
        }

    }
}
