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
    public class SmMovingItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public SmMovingItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SmMovingItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmMovingItemBatch>>> GetSmMovingItemBatches()
        {
            return await _context.SmMovingItemBatches.ToListAsync();
        }

        // GET: api/SmMovingItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SmMovingItemBatch>> GetSmMovingItemBatch(int id)
        {
            var smMovingItemBatch = await _context.SmMovingItemBatches.FindAsync(id);

            if (smMovingItemBatch == null)
            {
                return NotFound();
            }

            return smMovingItemBatch;
        }

        // PUT: api/SmMovingItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmMovingItemBatch(int id, SmMovingItemBatch smMovingItemBatch)
        {
            if (id != smMovingItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(smMovingItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmMovingItemBatchExists(id))
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

        // POST: api/SmMovingItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SmMovingItemBatch>> PostSmMovingItemBatch(SmMovingItemBatch smMovingItemBatch)
        {
            _context.SmMovingItemBatches.Add(smMovingItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSmMovingItemBatch", new { id = smMovingItemBatch.Id }, smMovingItemBatch);
        }

        // DELETE: api/SmMovingItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SmMovingItemBatch>> DeleteSmMovingItemBatch(int id)
        {
            var smMovingItemBatch = await _context.SmMovingItemBatches.FindAsync(id);
            if (smMovingItemBatch == null)
            {
                return NotFound();
            }

            _context.SmMovingItemBatches.Remove(smMovingItemBatch);
            await _context.SaveChangesAsync();

            return smMovingItemBatch;
        }

        private bool SmMovingItemBatchExists(int id)
        {
            return _context.SmMovingItemBatches.Any(e => e.Id == id);
        }
    }
}
