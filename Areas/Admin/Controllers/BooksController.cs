using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
       
        private readonly BookShopContext _context;
        public BooksController(BookShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "Publisher", "PublisherName");
            ViewBag.AutherID = new SelectList(_context.Authors.Select(t=>new AutherList {AutherID=t.AuthorID,NameFamily=t.FirstName+ " "+t.LastName }), "AutherID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t=>new TranslatorList {TranslatorID=t.TranslatorID,NameFamily=t.Name+ " "+t.Family }), "TranslatorID", "NameFamily");
            return View();
        }
    }
}