using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models
{
    [Table("Books")]
    public class Book
    {
        public Guid id { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string description { get; set; }

        public uint cost { get; set; }

        public string publisherСode { get; set; }

        public uint? year { get; set; }

        public string imgPath { get; set; }

        public string imgAlterText { get; set; }

        public virtual Topic topic { get; set; }
    }
}
