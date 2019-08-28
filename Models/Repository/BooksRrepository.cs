using BookShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public class BooksRrepository
    {
        private readonly BookShopContext _context;
        public BooksRrepository(BookShopContext context)
        {
            _context = context;
        }
        public void BindSubCategory(TreeViewCategory category)
        {
            var SubCategories = (from c in _context.Categories where (c.ParentCategoryID == category.CategoryID)
                                 select new TreeViewCategory { CategoryID = c.CategoryID, CategoryName = c.CategoryName }).ToList();

            foreach (var item in SubCategories)
            {
                BindSubCategory(item);
                category.SubCategories.Add(item);
            }
        }
    }
}
