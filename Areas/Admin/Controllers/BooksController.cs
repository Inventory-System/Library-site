using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.Repository;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
       
        private readonly BookShopContext _context;
        private readonly BooksRrepository _repository;
        public BooksController(BookShopContext context,BooksRrepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var categories = (from c in _context.Categories
                              where (c.ParentCategoryID == null)
                              select new TreeViewCategory { CategoryID = c.CategoryID, CategoryName = c.CategoryName }).ToList();
            foreach (var item in categories)
            {
                _repository.BindSubCategory(item);
            }

            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "Publisher", "PublisherName");
            ViewBag.AutherID = new SelectList(_context.Authors.Select(t=>new AutherList {AutherID=t.AuthorID,NameFamily=t.FirstName+ " "+t.LastName }), "AutherID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t=>new TranslatorList {TranslatorID=t.TranslatorID,NameFamily=t.Name+ " "+t.Family }), "TranslatorID", "NameFamily");
            return View();
        }
    }
}