using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;

namespace сoursework.Data.Models.Menu
{
    public class HierarchicalMenuItem : MenuItem, IHierarchicalMenuItem
    {
        public List<IMenuItem> _menuItems;

        public HierarchicalMenuItem(string title, string href) : base(title, href)
        {
            _menuItems = new();
        }

        public HierarchicalMenuItem(string title, string href, params IMenuItem[] menuItems) : base(title, href)
        {
            this._menuItems = new();
            foreach (var item in menuItems)
            {
                this._menuItems.Add(item);
            }
        }

        public List<IMenuItem> GetMenuItems()
        {
            return _menuItems;
        }
    }
}
