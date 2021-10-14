using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Models.ObjectsDB;

namespace сoursework.Data.Models
{
    [Table("Stores")]
    public class Store
    {
        public int id { get; set; }
        public string address { get; set; }
        public uint? area { get; set; }
        public virtual List<Book> books { get; set; } = new();
        public virtual List<Employee> employees { get; set; } = new();
    }
}
