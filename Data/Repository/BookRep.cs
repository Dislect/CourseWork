using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Author>> GetAuthors()
        {
            return await _dBContext.authors.ToListAsync();
        }

        public async Task<List<Book>> GetBooksThis(Author author)
        {
            return await _dBContext.books.Where(x => x.author.name == author.name).ToListAsync();
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _dBContext.books.ToListAsync();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _dBContext.employees.ToListAsync();
        }

        public string GetAddressThis(Employee employee)
        {
            return _dBContext.stores.FirstOrDefault(x => x.employees.Contains(employee)).address.ToString();
        }

        public async Task<List<Genre>> GetGenres()
        {
            return await _dBContext.genres.ToListAsync();
        }

        public async Task<List<Book>> GetBooksThis(Genre genre)
        {
            return await _dBContext.books.Where(x => x.genres.Contains(genre)).ToListAsync();
        }

        public async Task<List<Position>> GetPositions()
        {
            return await _dBContext.positions.ToListAsync();
        }

        public async Task<List<Employee>> GetEmployeesThis(Position position)
        {
            return await _dBContext.employees.Where(x => x.idPosition == position).ToListAsync();
        }

        public async Task<List<Publisher>> GetPublishers()
        {
            return await _dBContext.publishers.ToListAsync();
        }

        public async Task<List<Book>> GetBooksThis(Publisher publisher)
        {
            return await _dBContext.books.Where(x => x.publisher == publisher).ToListAsync();
        }

        public async Task<List<Store>> GetStores()
        {
            return await _dBContext.stores.ToListAsync();
        }

        public async Task<List<Book>> GetBooksThis(Store store)
        {
            return await _dBContext.books.Where(x => x.stores.Contains(store)).ToListAsync();
        }

        public async Task<List<Employee>> GetEmployeesThis(Store store)
        {
            return await _dBContext.employees.Where(x => x.idStore == store).ToListAsync();
        }
    }
}
