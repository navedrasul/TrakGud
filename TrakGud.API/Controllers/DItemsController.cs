using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrakGud.DAL.Models;
using TrakGud.DAL.Repos;

namespace TrakGud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DItemsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DItemsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DItem>>> GetDItems()
        {
            return await _context.DItems.ToListAsync();
        }

        // GET: api/DItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DItem>> GetDItem(int id)
        {
            var dItem = await _context.DItems.FindAsync(id);

            if (dItem == null)
            {
                return NotFound();
            }

            return dItem;
        }

        // PUT: api/DItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDItem(int id, DItem dItem)
        {
            if (id != dItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(dItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DItem>> PostDItem(DItem dItem)
        {
            _context.DItems.Add(dItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDItem", new { id = dItem.Id }, dItem);
        }

        // DELETE: api/DItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DItem>> DeleteDItem(int id)
        {
            var dItem = await _context.DItems.FindAsync(id);
            if (dItem == null)
            {
                return NotFound();
            }

            _context.DItems.Remove(dItem);
            await _context.SaveChangesAsync();

            return dItem;
        }

        private bool DItemExists(int id)
        {
            return _context.DItems.Any(e => e.Id == id);
        }
    }
}
