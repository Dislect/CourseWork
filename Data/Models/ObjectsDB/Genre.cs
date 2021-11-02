using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace сoursework.Data.Models
{
    [Table("Genres")]
    public class Genre
    {
        public int id { get; set; }
        public string titleGenre { get; set; }
        public virtual List<Book> books { get; set; } = new();
    }
}
