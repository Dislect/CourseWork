using System.Collections.Generic;
using сoursework.Data.Interfaces;

namespace сoursework.Data.Models.Menu
{
    public class Menu : IMenu
    {
        private List<IHierarchicalMenuItem> _menuItems;

        public Menu()
        {
            _menuItems = CreateDefaultMenuItems();
        }

        public Menu(params IHierarchicalMenuItem[] menuItems)
        {
            this._menuItems = new();
            foreach (var item in menuItems)
            {
                this._menuItems.Add(item);
            }
        }

        private List<IHierarchicalMenuItem> CreateDefaultMenuItems()
        {
            var list = new List<IHierarchicalMenuItem>();

            list.AddRange(new List<IHierarchicalMenuItem>()
            {
                new HierarchicalMenuItem("Первый", "ссылка 1")
                {
                    _menuItems = new()
                    {
                        new MenuItem("подпункт ", "ссылка 11"),
                        new MenuItem("подпункт ", "ссылка 12")
                    }
                },
                new HierarchicalMenuItem("Второй  ", "ссылка 2"),
                new HierarchicalMenuItem("Третий  ", "ссылка 3")
            });
            return list;
        }

        public List<IHierarchicalMenuItem> GetHierarchicalMenuItems()
        {
            return _menuItems;
        }
    }
}
