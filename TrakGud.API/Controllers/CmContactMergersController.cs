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
    public class CmContactMergersController : ControllerBase
    {
        private readonly TGEContext _context;

        public CmContactMergersController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/CmContactMergers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CmContactMerger>>> GetCmContactMergers()
        {
            return await _context.CmContactMergers.ToListAsync();
        }

        // GET: api/CmContactMergers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CmContactMerger>> GetCmContactMerger(int id)
        {
            var cmContactMerger = await _context.CmContactMergers.FindAsync(id);

            if (cmContactMerger == null)
            {
                return NotFound();
            }

            return cmContactMerger;
        }

        // PUT: api/CmContactMergers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCmContactMerger(int id, CmContactMerger cmContactMerger)
        {
            if (id != cmContactMerger.MainContactId)
            {
                return BadRequest();
            }

            _context.Entry(cmContactMerger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CmContactMergerExists(id))
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

        // POST: api/CmContactMergers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CmContactMerger>> PostCmContactMerger(CmContactMerger cmContactMerger)
        {
            _context.CmContactMergers.Add(cmContactMerger);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CmContactMergerExists(cmContactMerger.MainContactId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCmContactMerger", new { id = cmContactMerger.MainContactId }, cmContactMerger);
        }

        // DELETE: api/CmContactMergers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CmContactMerger>> DeleteCmContactMerger(int id)
        {
            var cmContactMerger = await _context.CmContactMergers.FindAsync(id);
            if (cmContactMerger == null)
            {
                return NotFound();
            }

            _context.CmContactMergers.Remove(cmContactMerger);
            await _context.SaveChangesAsync();

            return cmContactMerger;
        }

        private bool CmContactMergerExists(int id)
        {
            return _context.CmContactMergers.Any(e => e.MainContactId == id);
        }
    }
}
