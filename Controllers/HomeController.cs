using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Interfaces;
using сoursework.Data.Models;
using сoursework.Data.Models.Menu;
using сoursework.Data.Repository;
using сoursework.View_Models;

namespace сoursework.Controllers
{
    public class HomeController : Controller
    {
        private IMenu _menu;
        private BookRep _bookRep;
        private HomeViewModel _obj;

        public HomeController(IMenu menu, BookRep bookRep)
        {
            _menu = menu;
            _bookRep = bookRep;
            _obj = new()
            {
                menu = _menu,
                bookRep = _bookRep
            };
        }

        public ViewResult Home()
        {
            return View(_obj);
        }

        public ViewResult ViewBooks()
        {
            return View(_obj);
        }
    }
}
