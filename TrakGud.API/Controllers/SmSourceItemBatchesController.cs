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
    public class SmSourceItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public SmSourceItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SmSourceItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmSourceItemBatch>>> GetSmSourceItemBatches()
        {
            return await _context.SmSourceItemBatches.ToListAsync();
        }

        // GET: api/SmSourceItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SmSourceItemBatch>> GetSmSourceItemBatch(int id)
        {
            var smSourceItemBatch = await _context.SmSourceItemBatches.FindAsync(id);

            if (smSourceItemBatch == null)
            {
                return NotFound();
            }

            return smSourceItemBatch;
        }

        // PUT: api/SmSourceItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmSourceItemBatch(int id, SmSourceItemBatch smSourceItemBatch)
        {
            if (id != smSourceItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(smSourceItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmSourceItemBatchExists(id))
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

        // POST: api/SmSourceItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SmSourceItemBatch>> PostSmSourceItemBatch(SmSourceItemBatch smSourceItemBatch)
        {
            _context.SmSourceItemBatches.Add(smSourceItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSmSourceItemBatch", new { id = smSourceItemBatch.Id }, smSourceItemBatch);
        }

        // DELETE: api/SmSourceItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SmSourceItemBatch>> DeleteSmSourceItemBatch(int id)
        {
            var smSourceItemBatch = await _context.SmSourceItemBatches.FindAsync(id);
            if (smSourceItemBatch == null)
            {
                return NotFound();
            }

            _context.SmSourceItemBatches.Remove(smSourceItemBatch);
            await _context.SaveChangesAsync();

            return smSourceItemBatch;
        }

        private bool SmSourceItemBatchExists(int id)
        {
            return _context.SmSourceItemBatches.Any(e => e.Id == id);
        }
    }
}
