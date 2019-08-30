using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TranslatorsController : Controller
    {
        private readonly BookShopContext _context;

        public TranslatorsController(BookShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            return View(await _context.Translator.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View( _context.Translator.ToList());
        //}


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TranslatorsCreateViewModel ViewModel)
        {
            if(ModelState.IsValid)
            {
                Translator translator = new Translator()
                {
                    Name = ViewModel.Name,
                    Family=ViewModel.Family,
                };

                _context.Translator.Add(translator);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ViewModel);
        }


        public async Task<IActionResult>  Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            else
            {
                var Translator = await _context.Translator.FirstOrDefaultAsync(m => m.TranslatorID == id);
                if(Translator==null)
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
            if(ModelState.IsValid)
            {
                _context.Update(translator);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(translator);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            else
            {
                var Tranlator = await _context.Translator.FirstOrDefaultAsync(m => m.TranslatorID == id);
                if(Tranlator==null)
                {
                    return NotFound();
                }

                else
                {
                    return View(Tranlator);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deleted(int? id)
        {
            var Translator = await _context.Translator.FindAsync(id);
            _context.Translator.Remove(Translator);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}