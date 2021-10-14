using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace сoursework.Data.Models.ObjectsDB
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string imgPath { get; set; }
        public string imgAlterText { get; set; }
        public string phoneNumber { get; set; }
        public virtual Store idStore { get; set; }
    }
}
