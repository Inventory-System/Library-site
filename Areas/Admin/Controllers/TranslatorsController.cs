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
    }
}