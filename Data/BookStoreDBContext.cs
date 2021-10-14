using Microsoft.EntityFrameworkCore;

namespace сoursework.Data.Models
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        {
        }

        public DbSet<Book> books { get; set; }

        public DbSet<Topic> topics { get; set; }
    }
}
