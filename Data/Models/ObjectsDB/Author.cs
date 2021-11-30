using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace сoursework.Data.Models
{
    [Table("Authors")]
    public class Author
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "Имя")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        public string surname { get; set; }

        [Display(Name = "Отчество")]
        public string patronymic { get; set; }

        public virtual List<Book> books { get; set; } = new();
    }
}
