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
    public class DItemRemovalHistoriesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DItemRemovalHistoriesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DItemRemovalHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DItemRemovalHistory>>> GetDItemRemovalHistories()
        {
            return await _context.DItemRemovalHistories.ToListAsync();
        }

        // GET: api/DItemRemovalHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DItemRemovalHistory>> GetDItemRemovalHistory(int id)
        {
            var dItemRemovalHistory = await _context.DItemRemovalHistories.FindAsync(id);

            if (dItemRemovalHistory == null)
            {
                return NotFound();
            }

            return dItemRemovalHistory;
        }

        // PUT: api/DItemRemovalHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDItemRemovalHistory(int id, DItemRemovalHistory dItemRemovalHistory)
        {
            if (id != dItemRemovalHistory.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(dItemRemovalHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DItemRemovalHistoryExists(id))
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

        // POST: api/DItemRemovalHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DItemRemovalHistory>> PostDItemRemovalHistory(DItemRemovalHistory dItemRemovalHistory)
        {
            _context.DItemRemovalHistories.Add(dItemRemovalHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DItemRemovalHistoryExists(dItemRemovalHistory.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDItemRemovalHistory", new { id = dItemRemovalHistory.ItemId }, dItemRemovalHistory);
        }

        // DELETE: api/DItemRemovalHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DItemRemovalHistory>> DeleteDItemRemovalHistory(int id)
        {
            var dItemRemovalHistory = await _context.DItemRemovalHistories.FindAsync(id);
            if (dItemRemovalHistory == null)
            {
                return NotFound();
            }

            _context.DItemRemovalHistories.Remove(dItemRemovalHistory);
            await _context.SaveChangesAsync();

            return dItemRemovalHistory;
        }

        private bool DItemRemovalHistoryExists(int id)
        {
            return _context.DItemRemovalHistories.Any(e => e.ItemId == id);
        }
    }
}
