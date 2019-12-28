using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookPOC.Repository;
using BookPOC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookPOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            var listBook = new BookListViewModel
            {
                Books = _bookRepository.GetAllBooks().Take(3)
            };

            return View(listBook);
        }
    }
}