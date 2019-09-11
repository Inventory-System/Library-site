using BookShop.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public class BooksRepository
    {
        private readonly BookShopContext _context;
        public BooksRepository(BookShopContext context)
        {
            _context = context;
        }  


        public List<TreeViewCategory> GetAllCategories()
        {
            var Categories = (from c in _context.Categories
                              where (c.ParentCategoryID == null)
                              select new TreeViewCategory { id = c.CategoryID, title = c.CategoryName }).ToList();
            foreach (var item in Categories)
            {
                BindSubCategories(item);
            }

            return Categories;
        }

        public void BindSubCategories(TreeViewCategory category)
        {
            var SubCategories = (from c in _context.Categories
                                 where (c.ParentCategoryID == category.id)
                                 select new TreeViewCategory { id = c.CategoryID, title = c.CategoryName }).ToList();
            foreach(var item in SubCategories)
            {
                BindSubCategories(item);
                category.subs.Add(item);
            }
        }

        public List<BooksIndexViewModel> GetAllBooks(string title,string ISBN,string Language,string Publisher,string Author,string Translator,string Category)
        {
            string AuthersName = "";
            string TranslatorName = "";
            string CategotyName = "";
            List<BooksIndexViewModel> ViewModel = new List<BooksIndexViewModel>();
            var Books = (from u in _context.Author_Books.Include(b => b.Book).ThenInclude(p => p.Publisher)
                         .Include(a => a.Author) 
                         join l in _context.Languages on u.Book.LanguageID equals l.LanguageID
                         join s in _context.Book_Translators on u.Book.BookID equals s.BookID into bt
                         from bts in bt.DefaultIfEmpty()
                         join t in _context.Translator on bts.TranslatorID equals t.TranslatorID into tr
                         from trl in tr.DefaultIfEmpty()
                         join r in _context.Book_Categories on u.Book.BookID equals r.BookID into bc
                         from bct in bc.DefaultIfEmpty()
                         join c in _context.Categories on bct.CategoryID equals c.CategoryID into cg
                         from cog in cg.DefaultIfEmpty()
                         where (u.Book.Title.Contains(title.TrimStart().TrimEnd())
                         && u.Book.ISBN.Contains(ISBN.TrimStart().TrimEnd())
                         && EF.Functions.Like(l.LanguageName,"%"+Language+"%")
                         && u.Book.Publisher.PublisherName.Contains(Publisher.TrimStart().TrimEnd()))
                         select new
                         {
                             Author = u.Author.FirstName + " " + u.Author.LastName,
                             Translator=trl!=null?trl.Name+" "+trl.Family :"",
                             Category=cog!=null ? cog.CategoryName : "",
                             u.Book.BookID,
                             u.Book.ISBN,
                             u.Book.IsPublish,
                             u.Book.Price,
                             u.Book.PublishDate,
                             u.Book.Publisher.PublisherName,
                             u.Book.Stock,
                             u.Book.Title,
                             l.LanguageName,
                         }).Where(a=>a.Author.Contains(Author.TrimStart().TrimEnd()) && a.Translator.Contains(Translator.TrimStart().TrimEnd())&& a.Category.Contains(Category.TrimStart().TrimEnd()))
                         .GroupBy(b => b.BookID).Select(g => new { BookID = g.Key, BookGroups = g }).ToList(); ;

            foreach (var item in Books)
            {
                AuthersName = "";
                TranslatorName = "";
                CategotyName = "";
                foreach (var a in item.BookGroups.Select(a=>a.Author).Distinct())
                {
                    if (AuthersName == "")
                        AuthersName = a;
                    else
                        AuthersName = AuthersName + " - " + a;
                }

                foreach (var a in item.BookGroups.Select(a => a.Translator).Distinct())
                {
                    if (TranslatorName == "")
                        TranslatorName = a;
                    else
                        TranslatorName = TranslatorName + " - " + a;
                }

                foreach (var a in item.BookGroups.Select(a => a.Category).Distinct())
                {
                    if (CategotyName == "")
                        CategotyName = a;
                    else
                        CategotyName = CategotyName + " - " + a;
                }

                BooksIndexViewModel VM = new BooksIndexViewModel()
                {
                    Author = AuthersName,
                    BookID = item.BookID,
                    ISBN = item.BookGroups.First().ISBN,
                    Title = item.BookGroups.First().Title,
                    Price = item.BookGroups.First().Price,
                    IsPublish = item.BookGroups.First().IsPublish,
                    PublishDate = item.BookGroups.First().PublishDate,
                    PublisherName = item.BookGroups.First().PublisherName,
                    Stock = item.BookGroups.First().Stock,
                    Language=item.BookGroups.First().LanguageName,
                    Category=CategotyName,
                    Translator=TranslatorName,
                };

                ViewModel.Add(VM);
            }

            return ViewModel;
        }
    }
}
