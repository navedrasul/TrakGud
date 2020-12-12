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
    public class DProductWarehouseStocksController : ControllerBase
    {
        private readonly TGEContext _context;

        public DProductWarehouseStocksController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DProductWarehouseStocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DProductWarehouseStock>>> GetDProductWarehouseStocks()
        {
            return await _context.DProductWarehouseStocks.ToListAsync();
        }

        // GET: api/DProductWarehouseStocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DProductWarehouseStock>> GetDProductWarehouseStock(int id)
        {
            var dProductWarehouseStock = await _context.DProductWarehouseStocks.FindAsync(id);

            if (dProductWarehouseStock == null)
            {
                return NotFound();
            }

            return dProductWarehouseStock;
        }

        // PUT: api/DProductWarehouseStocks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDProductWarehouseStock(int id, DProductWarehouseStock dProductWarehouseStock)
        {
            if (id != dProductWarehouseStock.Id)
            {
                return BadRequest();
            }

            _context.Entry(dProductWarehouseStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DProductWarehouseStockExists(id))
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

        // POST: api/DProductWarehouseStocks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DProductWarehouseStock>> PostDProductWarehouseStock(DProductWarehouseStock dProductWarehouseStock)
        {
            _context.DProductWarehouseStocks.Add(dProductWarehouseStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDProductWarehouseStock", new { id = dProductWarehouseStock.Id }, dProductWarehouseStock);
        }

        // DELETE: api/DProductWarehouseStocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DProductWarehouseStock>> DeleteDProductWarehouseStock(int id)
        {
            var dProductWarehouseStock = await _context.DProductWarehouseStocks.FindAsync(id);
            if (dProductWarehouseStock == null)
            {
                return NotFound();
            }

            _context.DProductWarehouseStocks.Remove(dProductWarehouseStock);
            await _context.SaveChangesAsync();

            return dProductWarehouseStock;
        }

        private bool DProductWarehouseStockExists(int id)
        {
            return _context.DProductWarehouseStocks.Any(e => e.Id == id);
        }
    }
}
