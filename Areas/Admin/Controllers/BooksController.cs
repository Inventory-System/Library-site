using BookShop.Models;
using BookShop.Models.Repository;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly BookShopContext _context;
        private readonly BooksRepository _repository;
        public BooksController(BookShopContext context, BooksRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public IActionResult Index(int page=1,int row=5,string sortExpression="Title",string title="")
        {
            title = String.IsNullOrEmpty(title) ? "" : title;
            List<int> Rows = new List<int>
            {
                5,10,15,20,50,100
            };

            ViewBag.RowID = new SelectList(Rows,row);
            ViewBag.NumOfRow = (page - 1) * row + 1;
            ViewBag.Search = title;

            var PagingModel = PagingList.Create(_repository.GetAllBooks(title,"","","","","",""),row, page,sortExpression,"Title");
            PagingModel.RouteValue = new RouteValueDictionary
            {
                {"row",row},
                {"title",title }
            };

            ViewBag.Categories = _repository.GetAllCategories();
            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageName", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherName", "PublisherName");
            ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "NameFamily", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "NameFamily", "NameFamily");

            return View(PagingModel);
        }


        public IActionResult AdvancedSearch(BooksAdvancedSearch ViewModel)
        {
            ViewModel.Title = String.IsNullOrEmpty(ViewModel.Title) ? "" : ViewModel.Title;
            ViewModel.ISBN = String.IsNullOrEmpty(ViewModel.ISBN) ? "" : ViewModel.ISBN;
            ViewModel.Publisher = String.IsNullOrEmpty(ViewModel.Publisher) ? "" : ViewModel.Publisher;
            ViewModel.Author = String.IsNullOrEmpty(ViewModel.Author) ? "" : ViewModel.Author;
            ViewModel.Translator = String.IsNullOrEmpty(ViewModel.Translator) ? "" : ViewModel.Translator;
            ViewModel.Category = String.IsNullOrEmpty(ViewModel.Category) ? "" : ViewModel.Category;
            ViewModel.Language = String.IsNullOrEmpty(ViewModel.Language) ? "" : ViewModel.Language;
            var Books = _repository.GetAllBooks(ViewModel.Title,ViewModel.ISBN,ViewModel.Language,ViewModel.Publisher,ViewModel.Author,ViewModel.Translator,ViewModel.Category);
            return View(Books);
        }

        public IActionResult Create()
        {
            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
            ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

            BooksCreateViewModel ViewModel = new BooksCreateViewModel(_repository.GetAllCategories());
            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BooksCreateViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                List<Author_Book> authors = new List<Author_Book>();
                List<Book_Translator> translators = new List<Book_Translator>();
                List<Book_Category> categories = new List<Book_Category>();
                DateTime? PublishDate = null;
                if (ViewModel.IsPublish == true)
                {
                    PublishDate = DateTime.Now;
                }
                Book book = new Book()
                {
                    Delete = false,
                    ISBN = ViewModel.ISBN,
                    IsPublish = ViewModel.IsPublish,
                    NumOfPages = ViewModel.NumOfPages,
                    Stock = ViewModel.Stock,
                    Price = ViewModel.Price,
                    LanguageID = ViewModel.LanguageID,
                    Summary = ViewModel.Summary,
                    Title = ViewModel.Title,
                    PublishYear = ViewModel.PublishYear,
                    PublishDate = PublishDate,
                    Weight = ViewModel.Weight,
                    PublisherID = ViewModel.PublisherID,
                };

                await _context.Books.AddAsync(book);

                if (ViewModel.AuthorID != null)
                {
                    for (int i = 0; i < ViewModel.AuthorID.Length; i++)
                    {
                        Author_Book author = new Author_Book()
                        {
                            BookID = book.BookID,
                            AuthorID = ViewModel.AuthorID[i],
                        };

                        authors.Add(author);
                    }

                    await _context.Author_Books.AddRangeAsync(authors);
                }


                if (ViewModel.TranslatorID != null)
                {
                    for (int i = 0; i < ViewModel.TranslatorID.Length; i++)
                    {
                        Book_Translator translator = new Book_Translator()
                        {
                            BookID = book.BookID,
                            TranslatorID = ViewModel.TranslatorID[i],
                        };

                        translators.Add(translator);
                    }

                    await _context.Book_Translators.AddRangeAsync(translators);
                }

                if (ViewModel.CategoryID != null)
                {
                    for (int i = 0; i < ViewModel.CategoryID.Length; i++)
                    {
                        Book_Category category = new Book_Category()
                        {
                            BookID = book.BookID,
                            CategoryID = ViewModel.CategoryID[i],
                        };

                        categories.Add(category);
                    }

                    await _context.Book_Categories.AddRangeAsync(categories);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
                ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
                ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
                ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");
                ViewModel.Categories = _repository.GetAllCategories();
                return View(ViewModel);
            }
        }

        public IActionResult Details(int id)
        {
            var BookInfo = _context.Books.FromSql("select *from dbo.BookInfo where BookID={0}", id)
                .Include(l=>l.Language)
                .Include(p=>p.Publisher).First();

            ViewBag.Authors = _context.Authors.FromSql("EXEC dbo.GetAuthorsByBookID {0}", id).ToList();

            ViewBag.Translators = (from r in _context.Book_Translators
                                   join t in _context.Translator on r.TranslatorID equals t.TranslatorID
                                   where(r.BookID==id)
                                   select new Translator {Name=t.Name,Family=t.Family}).ToList();

            ViewBag.Categories = (from o in _context.Book_Categories
                                  join c in _context.Categories on o.CategoryID equals c.CategoryID
                                  where (o.BookID == id)
                                  select new Category {CategoryName=c.CategoryName}).ToList();

            return View(BookInfo);
        }
    }
}