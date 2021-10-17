using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using сoursework.Data.Models;
using сoursework.Data.Repository;
using сoursework.View_Models;

namespace сoursework.Controllers
{
    public class HomeController : Controller
    {
        private BookRep _bookRep;
        private HomeViewModel _obj;

        public HomeController(BookRep bookRep)
        {
            _bookRep = bookRep;
            _obj = new()
            {
                bookRep = _bookRep
            };
        }

        public ViewResult Home()
        {
            return View(_obj);
        }

        public ViewResult ViewAuthors()
        {
            return View(_obj);
        }

        public ViewResult ViewBooks()
        {
            return View(_obj);
        }

        public ViewResult ViewEmployees()
        {
            return View(_obj);
        }

        public ViewResult ViewGenres()
        {
            return View(_obj);
        }

        public ViewResult ViewPositions()
        {
            return View(_obj);
        }

        public ViewResult ViewPublishers()
        {
            return View(_obj);
        }

        public ViewResult ViewStores()
        {
            return View(_obj);
        }
    }
}
