using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrakGud.DAL.Models;
using TrakGud.DAL.Repos;

namespace TrakGud.MVC.Controllers
{
    public class DItemsController : Controller
    {
        private readonly TGEContext _context;

        public DItemsController(TGEContext context)
        {
            _context = context;
        }

        // GET: DItems
        public async Task<IActionResult> Index()
        {
            var tGEContext = _context.DItems.Include(d => d.Adder).Include(d => d.Modder).Include(d => d.Prod).Include(d => d.Unit);
            return View(await tGEContext.ToListAsync());
        }

        // GET: DItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dItem = await _context.DItems
                .Include(d => d.Adder)
                .Include(d => d.Modder)
                .Include(d => d.Prod)
                .Include(d => d.Unit)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dItem == null)
            {
                return NotFound();
            }

            return View(dItem);
        }

        // GET: DItems/Create
        public IActionResult Create()
        {
            ViewData["AdderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash");
            ViewData["ModderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash");
            ViewData["ProdId"] = new SelectList(_context.DProducts, "Id", "Name");
            ViewData["UnitId"] = new SelectList(_context.DProductUnits, "Id", "Name");
            return View();
        }

        // POST: DItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProdId,Price,AddTs,AdderId,ModderId,IsRemoved,Qty,UnitId,ExpireTs,ExpireMargin,IsFixed,IsExpired,ModTs")] DItem dItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash", dItem.AdderId);
            ViewData["ModderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash", dItem.ModderId);
            ViewData["ProdId"] = new SelectList(_context.DProducts, "Id", "Name", dItem.ProdId);
            ViewData["UnitId"] = new SelectList(_context.DProductUnits, "Id", "Name", dItem.UnitId);
            return View(dItem);
        }

        // GET: DItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dItem = await _context.DItems.FindAsync(id);
            if (dItem == null)
            {
                return NotFound();
            }
            ViewData["AdderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash", dItem.AdderId);
            ViewData["ModderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash", dItem.ModderId);
            ViewData["ProdId"] = new SelectList(_context.DProducts, "Id", "Name", dItem.ProdId);
            ViewData["UnitId"] = new SelectList(_context.DProductUnits, "Id", "Name", dItem.UnitId);
            return View(dItem);
        }

        // POST: DItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProdId,Price,AddTs,AdderId,ModderId,IsRemoved,Qty,UnitId,ExpireTs,ExpireMargin,IsFixed,IsExpired,ModTs")] DItem dItem)
        {
            if (id != dItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DItemExists(dItem.Id))
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
            ViewData["AdderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash", dItem.AdderId);
            ViewData["ModderId"] = new SelectList(_context.UmUsers, "Id", "PasswordHash", dItem.ModderId);
            ViewData["ProdId"] = new SelectList(_context.DProducts, "Id", "Name", dItem.ProdId);
            ViewData["UnitId"] = new SelectList(_context.DProductUnits, "Id", "Name", dItem.UnitId);
            return View(dItem);
        }

        // GET: DItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dItem = await _context.DItems
                .Include(d => d.Adder)
                .Include(d => d.Modder)
                .Include(d => d.Prod)
                .Include(d => d.Unit)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dItem == null)
            {
                return NotFound();
            }

            return View(dItem);
        }

        // POST: DItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dItem = await _context.DItems.FindAsync(id);
            _context.DItems.Remove(dItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DItemExists(int id)
        {
            return _context.DItems.Any(e => e.Id == id);
        }
    }
}
