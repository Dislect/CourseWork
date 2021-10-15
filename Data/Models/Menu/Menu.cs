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
                new HierarchicalMenuItem("Просмотр", "#")
                {
                    _menuItems = new()
                    {
                        new MenuItem("Авторы ", "/Home/ViewAuthors"),
                        new MenuItem("Книги ", "/Home/ViewBooks"),
                        new MenuItem("Сотрудники ", "ссылка 12"),
                        new MenuItem("Жанры ", "ссылка 12"),
                        new MenuItem("Должности ", "ссылка 12"),
                        new MenuItem("Издатели ", "ссылка 12"),
                        new MenuItem("Магазины ", "ссылка 12")
                    }
                },
                new HierarchicalMenuItem("Создание  ", "ссылка 2"),
                new HierarchicalMenuItem("Изменение  ", "ссылка 3"),
                new HierarchicalMenuItem("Удаление  ", "ссылка 3")
            });
            return list;
        }

        public List<IHierarchicalMenuItem> GetHierarchicalMenuItems()
        {
            return _menuItems;
        }
    }
}
