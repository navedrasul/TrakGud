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
    public class DSellersController : ControllerBase
    {
        private readonly TGEContext _context;

        public DSellersController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DSellers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DSeller>>> GetDSellers()
        {
            return await _context.DSellers.ToListAsync();
        }

        // GET: api/DSellers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DSeller>> GetDSeller(int id)
        {
            var dSeller = await _context.DSellers.FindAsync(id);

            if (dSeller == null)
            {
                return NotFound();
            }

            return dSeller;
        }

        // PUT: api/DSellers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDSeller(int id, DSeller dSeller)
        {
            if (id != dSeller.Id)
            {
                return BadRequest();
            }

            _context.Entry(dSeller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DSellerExists(id))
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

        // POST: api/DSellers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DSeller>> PostDSeller(DSeller dSeller)
        {
            _context.DSellers.Add(dSeller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDSeller", new { id = dSeller.Id }, dSeller);
        }

        // DELETE: api/DSellers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DSeller>> DeleteDSeller(int id)
        {
            var dSeller = await _context.DSellers.FindAsync(id);
            if (dSeller == null)
            {
                return NotFound();
            }

            _context.DSellers.Remove(dSeller);
            await _context.SaveChangesAsync();

            return dSeller;
        }

        private bool DSellerExists(int id)
        {
            return _context.DSellers.Any(e => e.Id == id);
        }
    }
}
