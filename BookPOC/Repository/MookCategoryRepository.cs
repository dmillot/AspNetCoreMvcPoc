using BookPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookPOC.Repository
{
    public class MookCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Big data", Description = "Books of big data" },
                new Category { Id = 2, Name = "Database", Description = "Books of database" },
                new Category { Id = 3, Name = "Front-End", Description = "Books of front end" },
                new Category { Id = 4, Name = "Back-End", Description = "Books of back end" }
            };
        }

        public Category GetCategoryById(int id)
        {
            return GetAllCategories().FirstOrDefault(category => category.Id == id);
        }
    }
}
