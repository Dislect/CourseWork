using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Models;

namespace сoursework.Data.Repository
{
    public class BookRep
    {
        private readonly BookStoreDBContext _dBContext;
        public List<Book> books { get; set; }

        public BookRep(BookStoreDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public List<Book> GetBooks()
        {
            return _dBContext.books.ToList();
        }
    }
}
