using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models
{
    public class Book
    {
        public int id { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string description { get; set; }

        public uint cost { get; set; }

        public string publisherСode { get; set; }

        public uint year { get; set; }

        public int idTopic { get; set; }

        public string imgPath { get; set; }

        public string imgAlter { get; set; }

        public virtual Topic topic { get; set; }
    }
}
