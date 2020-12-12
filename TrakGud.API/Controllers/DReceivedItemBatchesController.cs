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
    public class DReceivedItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DReceivedItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DReceivedItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DReceivedItemBatch>>> GetDReceivedItemBatches()
        {
            return await _context.DReceivedItemBatches.ToListAsync();
        }

        // GET: api/DReceivedItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DReceivedItemBatch>> GetDReceivedItemBatch(int id)
        {
            var dReceivedItemBatch = await _context.DReceivedItemBatches.FindAsync(id);

            if (dReceivedItemBatch == null)
            {
                return NotFound();
            }

            return dReceivedItemBatch;
        }

        // PUT: api/DReceivedItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDReceivedItemBatch(int id, DReceivedItemBatch dReceivedItemBatch)
        {
            if (id != dReceivedItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(dReceivedItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DReceivedItemBatchExists(id))
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

        // POST: api/DReceivedItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DReceivedItemBatch>> PostDReceivedItemBatch(DReceivedItemBatch dReceivedItemBatch)
        {
            _context.DReceivedItemBatches.Add(dReceivedItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDReceivedItemBatch", new { id = dReceivedItemBatch.Id }, dReceivedItemBatch);
        }

        // DELETE: api/DReceivedItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DReceivedItemBatch>> DeleteDReceivedItemBatch(int id)
        {
            var dReceivedItemBatch = await _context.DReceivedItemBatches.FindAsync(id);
            if (dReceivedItemBatch == null)
            {
                return NotFound();
            }

            _context.DReceivedItemBatches.Remove(dReceivedItemBatch);
            await _context.SaveChangesAsync();

            return dReceivedItemBatch;
        }

        private bool DReceivedItemBatchExists(int id)
        {
            return _context.DReceivedItemBatches.Any(e => e.Id == id);
        }
    }
}
