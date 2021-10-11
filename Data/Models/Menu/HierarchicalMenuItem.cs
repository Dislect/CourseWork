using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;

namespace сoursework.Data.Models.Menu
{
    public class HierarchicalMenuItem : MenuItem, IMenuItem
    {
        public List<MenuItem> menuItems;

        public HierarchicalMenuItem(string title, string href) : base(title, href)
        {
            menuItems = new();
        }

        public HierarchicalMenuItem(string title, string href, params MenuItem[] menuItems) : base(title, href)
        {
            this.menuItems = new();
            foreach (var item in menuItems)
            {
                this.menuItems.Add(item);
            }
        }
    }
}
