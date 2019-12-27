using BookPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookPOC.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int id);
    }
}
