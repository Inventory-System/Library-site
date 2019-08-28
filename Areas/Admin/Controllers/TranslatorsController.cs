using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    [Area("Admin")]
    public class TranslatorsController : Controller
    {
        private readonly BookShopContext _context;
        public TranslatorsController( BookShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Translator.ToListAsync()); 
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TranslatorCreateViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                Translator translator = new Translator()
                {
                    Name = ViewModel.Name,
                    Family = ViewModel.Family,
                };
                _context.Translator.Add(translator);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ViewModel);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            else
            {
                var Translator = await _context.Translator.FirstOrDefaultAsync(m => m.TranslatorID == id);
                if (Translator == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(Translator);
                }
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Translator translator)
        {
            if (ModelState.IsValid)
            {
                _context.Update(translator);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
                
            }
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var Translator = await _context.Translator.FirstOrDefaultAsync(m=>m.TranslatorID==id);
                if (Translator==null)
                {
                    return NotFound();
                }
                else
                {
                    return View(Translator);
                }
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deleted(int? id)
        {
            var translator = await _context.Translator.FindAsync(id);
            _context.Translator.Remove(translator);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}