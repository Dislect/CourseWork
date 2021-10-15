using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Models;
using сoursework.Data.Models.ObjectsDB;

namespace сoursework.Data.Repository
{
    public class BookRep
    {
        private readonly BookStoreDBContext _dBContext;

        public BookRep(BookStoreDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public List<Author> GetAuthors()
        {
            return _dBContext.authors.ToList();
        }

        public List<Book> GetBooks()
        {
            return _dBContext.books.ToList();
        }

        public List<Employee> GetEmployees()
        {
            return _dBContext.employees.ToList();
        }

        public List<Genre> GetGenres()
        {
            return _dBContext.genres.ToList();
        }

        public List<Position> GetPositions()
        {
            return _dBContext.positions.ToList();
        }

        public List<Publisher> GetPublishers()
        {
            return _dBContext.publishers.ToList();
        }

        public List<Store> GetStores()
        {
            return _dBContext.stores.ToList();
        }
    }
}
