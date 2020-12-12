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
    public class FimTransactionItemsController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimTransactionItemsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimTransactionItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimTransactionItem>>> GetFimTransactionItems()
        {
            return await _context.FimTransactionItems.ToListAsync();
        }

        // GET: api/FimTransactionItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimTransactionItem>> GetFimTransactionItem(int id)
        {
            var fimTransactionItem = await _context.FimTransactionItems.FindAsync(id);

            if (fimTransactionItem == null)
            {
                return NotFound();
            }

            return fimTransactionItem;
        }

        // PUT: api/FimTransactionItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimTransactionItem(int id, FimTransactionItem fimTransactionItem)
        {
            if (id != fimTransactionItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimTransactionItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimTransactionItemExists(id))
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

        // POST: api/FimTransactionItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimTransactionItem>> PostFimTransactionItem(FimTransactionItem fimTransactionItem)
        {
            _context.FimTransactionItems.Add(fimTransactionItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimTransactionItem", new { id = fimTransactionItem.Id }, fimTransactionItem);
        }

        // DELETE: api/FimTransactionItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimTransactionItem>> DeleteFimTransactionItem(int id)
        {
            var fimTransactionItem = await _context.FimTransactionItems.FindAsync(id);
            if (fimTransactionItem == null)
            {
                return NotFound();
            }

            _context.FimTransactionItems.Remove(fimTransactionItem);
            await _context.SaveChangesAsync();

            return fimTransactionItem;
        }

        private bool FimTransactionItemExists(int id)
        {
            return _context.FimTransactionItems.Any(e => e.Id == id);
        }
    }
}
