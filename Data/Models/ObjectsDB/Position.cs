using System.Collections.Generic;

namespace сoursework.Data.Models.ObjectsDB
{
    public class Position
    {
        public int id { get; set; }
        public string employeePosition { get; set; }
        public uint? salary { get; set; }
        public virtual List<Employee> employees { get; set; } = new();
    }
}
