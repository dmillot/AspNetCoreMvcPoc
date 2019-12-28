using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookPOC.Repository;
using BookPOC.ViewModels;
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
            var booksListViewModel = new BookListViewModel
            {
                Books = _bookRepository.GetAllBooks()
            };

            return this.View(booksListViewModel);
        }

        public IActionResult Detail(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
                return NotFound();

            return this.View(book);
        }
    }
}