using System.ComponentModel.DataAnnotations;

namespace сoursework.Data.Models.ObjectsDB
{
    public class Employee
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "Имя")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string imgPath { get; set; }
        public string imgAlterText { get; set; }
        public string phoneNumber { get; set; }
        public virtual Store idStore { get; set; }
        public virtual Position idPosition { get; set; }
    }
}
