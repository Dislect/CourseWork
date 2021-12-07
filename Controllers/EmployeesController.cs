using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using сoursework.Data.Models;
using сoursework.Data.Models.ObjectsDB;

namespace сoursework.Controllers
{
    [Authorize(Roles = "employee")]
    public class EmployeesController : Controller
    {
        private readonly BookStoreDBContext _context;

        public EmployeesController(BookStoreDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.employees.Include(x => x.idPosition).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,surname,patronymic,imgPath,imgAlterText,phoneNumber")] Employee employee, int storeId, int positionId)
        {
            if (ModelState.IsValid)
            {
                employee.idStore = await _context.stores.FirstOrDefaultAsync(x => x.id == storeId);
                employee.idPosition = await _context.positions.FirstOrDefaultAsync(x => x.id == positionId);
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.employees.Include(x => x.idPosition).Include(x => x.idStore)
                .FirstOrDefaultAsync(x => x.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            ViewBag.Store = await _context.stores.ToListAsync();
            ViewBag.Position = await _context.positions.ToListAsync();
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,surname,patronymic,imgPath,imgAlterText,phoneNumber")] Employee employee, int idStore, int idPosition)
        {
            if (id != employee.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    employee.idStore = await _context.stores.FirstOrDefaultAsync(x => x.id == idStore);
                    employee.idPosition = await _context.positions.FirstOrDefaultAsync(x => x.id == idPosition);
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.id))
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
            ViewBag.Store = await _context.stores.ToListAsync();
            ViewBag.Position = await _context.positions.ToListAsync();
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.employees
                .FirstOrDefaultAsync(m => m.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.employees.FindAsync(id);
            _context.employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.employees.Any(e => e.id == id);
        }
    }
}
