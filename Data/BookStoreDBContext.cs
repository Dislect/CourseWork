using Microsoft.EntityFrameworkCore;
using сoursework.Data.Models.ObjectsDB;

namespace сoursework.Data.Models
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options) { }

        public DbSet<Book> books { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Position> positions { get; set; }
    }
}
