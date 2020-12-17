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
    public class DCommentsThreadsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DCommentsThreadsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DCommentsThreads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DCommentsThread>>> GetDCommentsThreads()
        {
            return await _context.DCommentsThreads.ToListAsync();
        }

        // GET: api/DCommentsThreads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DCommentsThread>> GetDCommentsThread(int id)
        {
            var dCommentsThread = await _context.DCommentsThreads.FindAsync(id);

            if (dCommentsThread == null)
            {
                return NotFound();
            }

            return dCommentsThread;
        }

        // PUT: api/DCommentsThreads/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDCommentsThread(int id, DCommentsThread dCommentsThread)
        {
            if (id != dCommentsThread.Id)
            {
                return BadRequest();
            }

            _context.Entry(dCommentsThread).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DCommentsThreadExists(id))
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

        // POST: api/DCommentsThreads
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DCommentsThread>> PostDCommentsThread(DCommentsThread dCommentsThread)
        {
            _context.DCommentsThreads.Add(dCommentsThread);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDCommentsThread", new { id = dCommentsThread.Id }, dCommentsThread);
        }

        // DELETE: api/DCommentsThreads/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DCommentsThread>> DeleteDCommentsThread(int id)
        {
            var dCommentsThread = await _context.DCommentsThreads.FindAsync(id);
            if (dCommentsThread == null)
            {
                return NotFound();
            }

            _context.DCommentsThreads.Remove(dCommentsThread);
            await _context.SaveChangesAsync();

            return dCommentsThread;
        }

        private bool DCommentsThreadExists(int id)
        {
            return _context.DCommentsThreads.Any(e => e.Id == id);
        }
    }
}
