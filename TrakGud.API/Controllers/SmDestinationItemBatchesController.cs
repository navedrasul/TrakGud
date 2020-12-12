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
    public class SmDestinationItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public SmDestinationItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SmDestinationItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmDestinationItemBatch>>> GetSmDestinationItemBatches()
        {
            return await _context.SmDestinationItemBatches.ToListAsync();
        }

        // GET: api/SmDestinationItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SmDestinationItemBatch>> GetSmDestinationItemBatch(int id)
        {
            var smDestinationItemBatch = await _context.SmDestinationItemBatches.FindAsync(id);

            if (smDestinationItemBatch == null)
            {
                return NotFound();
            }

            return smDestinationItemBatch;
        }

        // PUT: api/SmDestinationItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmDestinationItemBatch(int id, SmDestinationItemBatch smDestinationItemBatch)
        {
            if (id != smDestinationItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(smDestinationItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmDestinationItemBatchExists(id))
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

        // POST: api/SmDestinationItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SmDestinationItemBatch>> PostSmDestinationItemBatch(SmDestinationItemBatch smDestinationItemBatch)
        {
            _context.SmDestinationItemBatches.Add(smDestinationItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSmDestinationItemBatch", new { id = smDestinationItemBatch.Id }, smDestinationItemBatch);
        }

        // DELETE: api/SmDestinationItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SmDestinationItemBatch>> DeleteSmDestinationItemBatch(int id)
        {
            var smDestinationItemBatch = await _context.SmDestinationItemBatches.FindAsync(id);
            if (smDestinationItemBatch == null)
            {
                return NotFound();
            }

            _context.SmDestinationItemBatches.Remove(smDestinationItemBatch);
            await _context.SaveChangesAsync();

            return smDestinationItemBatch;
        }

        private bool SmDestinationItemBatchExists(int id)
        {
            return _context.SmDestinationItemBatches.Any(e => e.Id == id);
        }
    }
}
