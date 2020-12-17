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
    public class DProductStocksController : ControllerBase
    {
        private readonly TGEContext _context;

        public DProductStocksController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DProductStocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DProductStock>>> GetDProductStocks()
        {
            return await _context.DProductStocks.ToListAsync();
        }

        // GET: api/DProductStocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DProductStock>> GetDProductStock(int id)
        {
            var dProductStock = await _context.DProductStocks.FindAsync(id);

            if (dProductStock == null)
            {
                return NotFound();
            }

            return dProductStock;
        }

        // PUT: api/DProductStocks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDProductStock(int id, DProductStock dProductStock)
        {
            if (id != dProductStock.Id)
            {
                return BadRequest();
            }

            _context.Entry(dProductStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DProductStockExists(id))
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

        // POST: api/DProductStocks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DProductStock>> PostDProductStock(DProductStock dProductStock)
        {
            _context.DProductStocks.Add(dProductStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDProductStock", new { id = dProductStock.Id }, dProductStock);
        }

        // DELETE: api/DProductStocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DProductStock>> DeleteDProductStock(int id)
        {
            var dProductStock = await _context.DProductStocks.FindAsync(id);
            if (dProductStock == null)
            {
                return NotFound();
            }

            _context.DProductStocks.Remove(dProductStock);
            await _context.SaveChangesAsync();

            return dProductStock;
        }

        private bool DProductStockExists(int id)
        {
            return _context.DProductStocks.Any(e => e.Id == id);
        }
    }
}
