using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using сoursework.Data.Models;

namespace сoursework.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookStoreDBContext _context;

        public HomeController(BookStoreDBContext context)
        {
            _context = context;
        }

        public ViewResult Home()
        {
            return View();
        }

        public async Task<IActionResult> ViewAuthors()
        {
            return View(await _context.authors.Include(x => x.books).ToListAsync());
        }

        public async Task<IActionResult> ViewBooks()
        {
            return View(await _context.books.ToListAsync());
        }

        public async Task<IActionResult> ViewEmployees()
        {
            return View(await _context.employees.Include(x => x.idStore).ToListAsync());
        }

        public async Task<IActionResult> ViewGenres()
        {
            return View(await _context.genres.Include(x => x.books).ToListAsync());
        }

        public async Task<IActionResult> ViewPositions()
        {
            return View(await _context.positions.Include(x => x.employees).ToListAsync());
        }

        public async Task<IActionResult> ViewPublishers()
        {
            return View(await _context.publishers.Include(x => x.books).ToListAsync());
        }

        public async Task<IActionResult> ViewStores()
        {
            return View(await _context.stores.Include(x => x.books).Include(x => x.employees).ToListAsync());
        }
    }
}
