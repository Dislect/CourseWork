using System.Collections.Generic;

namespace сoursework.Data.Models.Menu
{
    public class Menu
    {
        private Menu _menu;
        private List<HierarchicalMenuItem> _menuItems;

        public Menu()
        {
            _menuItems = CreateDefaultMenuItems();
            _menu = this;
        }

        public Menu(params HierarchicalMenuItem[] menuItems)
        {
            _menuItems = new();
            foreach (var item in menuItems)
            {
                _menuItems.Add(item);
            }
            _menu = this;
        }

        private List<HierarchicalMenuItem> CreateDefaultMenuItems()
        {
            var list = new List<HierarchicalMenuItem>();
            var hMenu1 = new HierarchicalMenuItem("Первый пункт меню", "ссылка 1",
                new MenuItem("первый подпункт", "ссылка 11"),
                new MenuItem("второй подпункт", "ссылка 12")
                );
            var hMenu2 = new HierarchicalMenuItem("Второй пункт меню", "ссылка 2");
            var hMenu3 = new HierarchicalMenuItem("Третий пункт меню", "ссылка 3");
            list.Add(hMenu1);
            list.Add(hMenu2);
            list.Add(hMenu3);
            return list;
        }

        public List<HierarchicalMenuItem> GetHMenuItems()
        {
            return _menuItems;
        }

        public Menu GetMenuObject()
        {
            return _menu;
        }
    }
}
