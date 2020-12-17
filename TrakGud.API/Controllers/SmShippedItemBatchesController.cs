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
    public class SmShippedItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public SmShippedItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SmShippedItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmShippedItemBatch>>> GetSmShippedItemBatches()
        {
            return await _context.SmShippedItemBatches.ToListAsync();
        }

        // GET: api/SmShippedItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SmShippedItemBatch>> GetSmShippedItemBatch(int id)
        {
            var smShippedItemBatch = await _context.SmShippedItemBatches.FindAsync(id);

            if (smShippedItemBatch == null)
            {
                return NotFound();
            }

            return smShippedItemBatch;
        }

        // PUT: api/SmShippedItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmShippedItemBatch(int id, SmShippedItemBatch smShippedItemBatch)
        {
            if (id != smShippedItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(smShippedItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmShippedItemBatchExists(id))
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

        // POST: api/SmShippedItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SmShippedItemBatch>> PostSmShippedItemBatch(SmShippedItemBatch smShippedItemBatch)
        {
            _context.SmShippedItemBatches.Add(smShippedItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSmShippedItemBatch", new { id = smShippedItemBatch.Id }, smShippedItemBatch);
        }

        // DELETE: api/SmShippedItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SmShippedItemBatch>> DeleteSmShippedItemBatch(int id)
        {
            var smShippedItemBatch = await _context.SmShippedItemBatches.FindAsync(id);
            if (smShippedItemBatch == null)
            {
                return NotFound();
            }

            _context.SmShippedItemBatches.Remove(smShippedItemBatch);
            await _context.SaveChangesAsync();

            return smShippedItemBatch;
        }

        private bool SmShippedItemBatchExists(int id)
        {
            return _context.SmShippedItemBatches.Any(e => e.Id == id);
        }
    }
}
