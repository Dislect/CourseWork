using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace сoursework.Data.Models
{
    [Table("Books")]
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public virtual Author author { get; set; }
        public string description { get; set; }
        public uint? cost { get; set; }
        public uint? quantity { get; set; }
        public virtual Publisher publisher { get; set; }
        public uint? year { get; set; }
        public string imgPath { get; set; }
        public string imgAlterText { get; set; }
        public virtual List<Genre> genres { get; set; } = new();
        public virtual List<Store> stores { get; set; } = new();
    }
}
