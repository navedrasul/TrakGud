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
    public class DWarehousesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DWarehousesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DWarehouses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DWarehouse>>> GetDWarehouses()
        {
            return await _context.DWarehouses.ToListAsync();
        }

        // GET: api/DWarehouses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DWarehouse>> GetDWarehouse(int id)
        {
            var dWarehouse = await _context.DWarehouses.FindAsync(id);

            if (dWarehouse == null)
            {
                return NotFound();
            }

            return dWarehouse;
        }

        // PUT: api/DWarehouses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDWarehouse(int id, DWarehouse dWarehouse)
        {
            if (id != dWarehouse.Id)
            {
                return BadRequest();
            }

            _context.Entry(dWarehouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DWarehouseExists(id))
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

        // POST: api/DWarehouses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DWarehouse>> PostDWarehouse(DWarehouse dWarehouse)
        {
            _context.DWarehouses.Add(dWarehouse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDWarehouse", new { id = dWarehouse.Id }, dWarehouse);
        }

        // DELETE: api/DWarehouses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DWarehouse>> DeleteDWarehouse(int id)
        {
            var dWarehouse = await _context.DWarehouses.FindAsync(id);
            if (dWarehouse == null)
            {
                return NotFound();
            }

            _context.DWarehouses.Remove(dWarehouse);
            await _context.SaveChangesAsync();

            return dWarehouse;
        }

        private bool DWarehouseExists(int id)
        {
            return _context.DWarehouses.Any(e => e.Id == id);
        }
    }
}
