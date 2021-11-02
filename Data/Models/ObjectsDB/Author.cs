using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace сoursework.Data.Models
{
    [Table("Authors")]
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public virtual List<Book> books { get; set; } = new();
    }
}
