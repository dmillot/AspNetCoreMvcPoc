using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookPOC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookPOC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var books = _bookRepository.GetAllBooks();
            return this.View(books);
        }
    }
}