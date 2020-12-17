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
    public class SShopsController : ControllerBase
    {
        private readonly TGEContext _context;

        public SShopsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SShops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SShop>>> GetSShops()
        {
            return await _context.SShops.ToListAsync();
        }

        // GET: api/SShops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SShop>> GetSShop(int id)
        {
            var sShop = await _context.SShops.FindAsync(id);

            if (sShop == null)
            {
                return NotFound();
            }

            return sShop;
        }

        // PUT: api/SShops/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSShop(int id, SShop sShop)
        {
            if (id != sShop.Id)
            {
                return BadRequest();
            }

            _context.Entry(sShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SShopExists(id))
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

        // POST: api/SShops
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SShop>> PostSShop(SShop sShop)
        {
            _context.SShops.Add(sShop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSShop", new { id = sShop.Id }, sShop);
        }

        // DELETE: api/SShops/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SShop>> DeleteSShop(int id)
        {
            var sShop = await _context.SShops.FindAsync(id);
            if (sShop == null)
            {
                return NotFound();
            }

            _context.SShops.Remove(sShop);
            await _context.SaveChangesAsync();

            return sShop;
        }

        private bool SShopExists(int id)
        {
            return _context.SShops.Any(e => e.Id == id);
        }
    }
}
