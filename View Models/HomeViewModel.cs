using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;
using сoursework.Data.Models.Menu;
using сoursework.Data.Repository;

namespace сoursework.View_Models
{
    public class HomeViewModel
    {
        public IMenu menu { get; set; }

        public BookRep bookRep { get; set; }
    }
}
