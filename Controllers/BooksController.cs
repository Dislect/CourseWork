using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using сoursework.Data.Models;

namespace сoursework.Controllers
{
    [Authorize(Roles = "employee")]
    public class BooksController : Controller
    {
        private readonly BookStoreDBContext _context;

        public BooksController(BookStoreDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.books.Include(x => x.author).Include(x => x.publisher).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,title,description,cost,quantity,year,imgPath,imgAlterText,author")] Book book, int authorId, int publisherId, int genreId)
        {
            if (ModelState.IsValid)
            {
                book.author = await _context.authors.FirstOrDefaultAsync(x => x.id == authorId);
                book.publisher = await _context.publishers.FirstOrDefaultAsync(x => x.id == publisherId);
                book.genres.Add(await _context.genres.FirstOrDefaultAsync(x => x.id == genreId));

                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            book = await _context.books.FirstOrDefaultAsync(x => x == book);
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,title,description,cost,quantity,year,imgPath,imgAlterText")] Book book, int authorId, int publisherId, string addGenreId, string delGenreId)
        {
            if (id != book.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldbook = await _context.books.Include(x => x.genres).FirstOrDefaultAsync(x => x.id == id);
                    oldbook.title = book.title;
                    oldbook.description = book.description;
                    oldbook.cost = book.cost;
                    oldbook.quantity = book.quantity;
                    oldbook.year = book.year;
                    oldbook.imgPath = book.imgPath;
                    oldbook.imgAlterText = book.imgAlterText;
                    oldbook.author = await _context.authors.FirstOrDefaultAsync(x => x.id == authorId);
                    oldbook.publisher = await _context.publishers.FirstOrDefaultAsync(x => x.id == publisherId);
                    if (int.TryParse(addGenreId, out int res1))
                    {
                        oldbook.genres.Add(await _context.genres.FirstOrDefaultAsync(x => x.id == int.Parse(addGenreId)));
                    }
                    if (int.TryParse(delGenreId, out int res))
                    {
                        oldbook.genres.Remove(await _context.genres.FirstOrDefaultAsync(x => x.id == int.Parse(delGenreId)));
                    }
                    _context.Update(oldbook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.books
                .FirstOrDefaultAsync(m => m.id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.books.FindAsync(id);
            _context.books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.books.Any(e => e.id == id);
        }
    }
}
