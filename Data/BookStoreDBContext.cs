using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext() : base() { }

        public DbSet<Book> books { get; set; }

        public DbSet<Topic> topics { get; set; }
    }
}
