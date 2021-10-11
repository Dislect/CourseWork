using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;

namespace сoursework.Data.Models.Menu
{
    public class HierarchicalMenuItem : MenuItem, IMenuItem
    {
        private List<MenuItem> _menuItems;

        public HierarchicalMenuItem(string title, string href) : base(title, href)
        {
            _menuItems = new();
        }

        public HierarchicalMenuItem(string title, string href, params MenuItem[] menuItems) : base(title, href)
        {
            _menuItems = new();
            foreach (var item in menuItems)
            {
                _menuItems.Add(item);
            }
        }

        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }
    }
}
