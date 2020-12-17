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
    public class DProductUnitConvertionsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DProductUnitConvertionsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DProductUnitConvertions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DProductUnitConvertion>>> GetDProductUnitConvertions()
        {
            return await _context.DProductUnitConvertions.ToListAsync();
        }

        // GET: api/DProductUnitConvertions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DProductUnitConvertion>> GetDProductUnitConvertion(int id)
        {
            var dProductUnitConvertion = await _context.DProductUnitConvertions.FindAsync(id);

            if (dProductUnitConvertion == null)
            {
                return NotFound();
            }

            return dProductUnitConvertion;
        }

        // PUT: api/DProductUnitConvertions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDProductUnitConvertion(int id, DProductUnitConvertion dProductUnitConvertion)
        {
            if (id != dProductUnitConvertion.SourceUnitId)
            {
                return BadRequest();
            }

            _context.Entry(dProductUnitConvertion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DProductUnitConvertionExists(id))
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

        // POST: api/DProductUnitConvertions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DProductUnitConvertion>> PostDProductUnitConvertion(DProductUnitConvertion dProductUnitConvertion)
        {
            _context.DProductUnitConvertions.Add(dProductUnitConvertion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DProductUnitConvertionExists(dProductUnitConvertion.SourceUnitId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDProductUnitConvertion", new { id = dProductUnitConvertion.SourceUnitId }, dProductUnitConvertion);
        }

        // DELETE: api/DProductUnitConvertions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DProductUnitConvertion>> DeleteDProductUnitConvertion(int id)
        {
            var dProductUnitConvertion = await _context.DProductUnitConvertions.FindAsync(id);
            if (dProductUnitConvertion == null)
            {
                return NotFound();
            }

            _context.DProductUnitConvertions.Remove(dProductUnitConvertion);
            await _context.SaveChangesAsync();

            return dProductUnitConvertion;
        }

        private bool DProductUnitConvertionExists(int id)
        {
            return _context.DProductUnitConvertions.Any(e => e.SourceUnitId == id);
        }
    }
}
