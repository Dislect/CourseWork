using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;

namespace сoursework.Data.Models.Menu
{
    public class MenuItem : IMenuItem
    {
        protected string _title;
        protected string _href;

        public MenuItem(string title, string href)
        {
            _title = title;
            _href = href;
        }

        public string GetHref()
        {
            return _href;
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}
