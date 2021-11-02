using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace сoursework.Data.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        public int id { get; set; }
        public string title { get; set; }
        public string address { get; set; }
        public string director { get; set; }
        public string email { get; set; }
        public virtual List<Book> books { get; set; } = new();
    }
}
