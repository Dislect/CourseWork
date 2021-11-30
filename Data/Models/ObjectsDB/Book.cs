using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace сoursework.Data.Models
{
    [Table("Books")]
    public class Book
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "Название")]
        public string title { get; set; }

        [Display(Name = "Автор")]
        public virtual Author author { get; set; }

        [Display(Name = "Описание")]
        public string description { get; set; }

        [Display(Name = "Цена")]
        public uint? cost { get; set; }

        [Display(Name = "Количество")]
        public uint? quantity { get; set; }

        [Display(Name = "Издатель")]
        public virtual Publisher publisher { get; set; }

        [Display(Name = "Год выпуска")]
        public uint? year { get; set; }

        [Display(Name = "Путь к картинке")]
        public string imgPath { get; set; }

        [Display(Name = "Альтернативный текст")]
        public string imgAlterText { get; set; }

        public virtual List<Genre> genres { get; set; } = new();
        public virtual List<Store> stores { get; set; } = new();
    }
}
