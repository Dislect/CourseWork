using System.Collections.Generic;

namespace сoursework.Data.Models.Menu
{
    public class Menu
    {
        private Menu _menu;
        public List<HierarchicalMenuItem> menuItems;

        public Menu()
        {
            menuItems = CreateDefaultMenuItems();
            _menu = this;
        }

        public Menu(params HierarchicalMenuItem[] menuItems)
        {
            this.menuItems = new();
            foreach (var item in menuItems)
            {
                this.menuItems.Add(item);
            }
            _menu = this;
        }

        private List<HierarchicalMenuItem> CreateDefaultMenuItems()
        {
            var list = new List<HierarchicalMenuItem>();

            list.AddRange(new List<HierarchicalMenuItem>() 
            {
                new HierarchicalMenuItem("Первый пункт меню gg", "ссылка 1")
                {
                    menuItems = new()
                    {
                        new MenuItem("первый подпункт 1g", "ссылка 11"),
                        new MenuItem("второй подпункт 2g", "ссылка 12")
                    }
                },
                new HierarchicalMenuItem("Второй пункт меню", "ссылка 2"),
                new HierarchicalMenuItem("Третий пункт меню", "ссылка 3")
            });
            return list;
        }

        public Menu GetMenuObject()
        {
            return _menu;
        }
    }
}
