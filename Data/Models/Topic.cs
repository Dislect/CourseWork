using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models
{
    public class Topic
    {
        public string id { get; set; }

        public string topic { get; set; }

        public List<Book> books { get; set; }
    }
}
