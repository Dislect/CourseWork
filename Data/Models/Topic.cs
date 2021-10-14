using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models
{
    [Table("Topics")]
    public class Topic
    {
        public Guid id { get; set; }

        public string topic { get; set; }

        public virtual List<Book> books { get; set; }
    }
}
