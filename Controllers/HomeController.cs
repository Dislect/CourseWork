using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;
using сoursework.Data.Models.Menu;
using сoursework.View_Models;

namespace сoursework.Controllers
{
    public class HomeController : Controller
    {
        private Menu _menu;

        public HomeController(Menu menu)
        {
            _menu = menu;
        }

        public ViewResult Home()
        {
            //_menu = new Menu(new HierarchicalMenuItem("tittle1", "", new MenuItem("Test", "href")));
            HomeViewModel obj = new()
            {
                menu = _menu
            };
            return View(obj);
        }
    }
}
