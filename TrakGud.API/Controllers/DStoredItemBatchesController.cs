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
    public class DStoredItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DStoredItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DStoredItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DStoredItemBatch>>> GetDStoredItemBatches()
        {
            return await _context.DStoredItemBatches.ToListAsync();
        }

        // GET: api/DStoredItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DStoredItemBatch>> GetDStoredItemBatch(int id)
        {
            var dStoredItemBatch = await _context.DStoredItemBatches.FindAsync(id);

            if (dStoredItemBatch == null)
            {
                return NotFound();
            }

            return dStoredItemBatch;
        }

        // PUT: api/DStoredItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDStoredItemBatch(int id, DStoredItemBatch dStoredItemBatch)
        {
            if (id != dStoredItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(dStoredItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DStoredItemBatchExists(id))
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

        // POST: api/DStoredItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DStoredItemBatch>> PostDStoredItemBatch(DStoredItemBatch dStoredItemBatch)
        {
            _context.DStoredItemBatches.Add(dStoredItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDStoredItemBatch", new { id = dStoredItemBatch.Id }, dStoredItemBatch);
        }

        // DELETE: api/DStoredItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DStoredItemBatch>> DeleteDStoredItemBatch(int id)
        {
            var dStoredItemBatch = await _context.DStoredItemBatches.FindAsync(id);
            if (dStoredItemBatch == null)
            {
                return NotFound();
            }

            _context.DStoredItemBatches.Remove(dStoredItemBatch);
            await _context.SaveChangesAsync();

            return dStoredItemBatch;
        }

        private bool DStoredItemBatchExists(int id)
        {
            return _context.DStoredItemBatches.Any(e => e.Id == id);
        }
    }
}
