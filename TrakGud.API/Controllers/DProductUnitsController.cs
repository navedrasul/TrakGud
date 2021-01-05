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
    public class DProductUnitsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DProductUnitsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DProductUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DProductUnit>>> GetDProductUnits(
            int? prodId = null
            )
        {
            if (prodId.HasValue)
            {
                return await _context.DProductUnits.Where(pu => pu.ProductId == prodId).ToListAsync();
            }
            else
            {
                return await _context.DProductUnits.ToListAsync();
            }
        }

        // GET: api/DProductUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DProductUnit>> GetDProductUnit(int id)
        {
            var dProductUnit = await _context.DProductUnits.FindAsync(id);

            if (dProductUnit == null)
            {
                return NotFound();
            }

            return dProductUnit;
        }

        // PUT: api/DProductUnits/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDProductUnit(int id, DProductUnit dProductUnit)
        {
            if (id != dProductUnit.Id)
            {
                return BadRequest();
            }

            _context.Entry(dProductUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DProductUnitExists(id))
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

        // POST: api/DProductUnits
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DProductUnit>> PostDProductUnit(DProductUnit dProductUnit)
        {
            _context.DProductUnits.Add(dProductUnit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDProductUnit", new { id = dProductUnit.Id }, dProductUnit);
        }

        // DELETE: api/DProductUnits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DProductUnit>> DeleteDProductUnit(int id)
        {
            var dProductUnit = await _context.DProductUnits.FindAsync(id);
            if (dProductUnit == null)
            {
                return NotFound();
            }

            _context.DProductUnits.Remove(dProductUnit);
            await _context.SaveChangesAsync();

            return dProductUnit;
        }

        private bool DProductUnitExists(int id)
        {
            return _context.DProductUnits.Any(e => e.Id == id);
        }
    }
}
