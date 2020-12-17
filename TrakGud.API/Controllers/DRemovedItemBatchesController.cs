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
    public class DRemovedItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DRemovedItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DRemovedItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DRemovedItemBatch>>> GetDRemovedItemBatches()
        {
            return await _context.DRemovedItemBatches.ToListAsync();
        }

        // GET: api/DRemovedItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DRemovedItemBatch>> GetDRemovedItemBatch(int id)
        {
            var dRemovedItemBatch = await _context.DRemovedItemBatches.FindAsync(id);

            if (dRemovedItemBatch == null)
            {
                return NotFound();
            }

            return dRemovedItemBatch;
        }

        // PUT: api/DRemovedItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDRemovedItemBatch(int id, DRemovedItemBatch dRemovedItemBatch)
        {
            if (id != dRemovedItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(dRemovedItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DRemovedItemBatchExists(id))
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

        // POST: api/DRemovedItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DRemovedItemBatch>> PostDRemovedItemBatch(DRemovedItemBatch dRemovedItemBatch)
        {
            _context.DRemovedItemBatches.Add(dRemovedItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDRemovedItemBatch", new { id = dRemovedItemBatch.Id }, dRemovedItemBatch);
        }

        // DELETE: api/DRemovedItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DRemovedItemBatch>> DeleteDRemovedItemBatch(int id)
        {
            var dRemovedItemBatch = await _context.DRemovedItemBatches.FindAsync(id);
            if (dRemovedItemBatch == null)
            {
                return NotFound();
            }

            _context.DRemovedItemBatches.Remove(dRemovedItemBatch);
            await _context.SaveChangesAsync();

            return dRemovedItemBatch;
        }

        private bool DRemovedItemBatchExists(int id)
        {
            return _context.DRemovedItemBatches.Any(e => e.Id == id);
        }
    }
}
