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
    public class CmAddressesController : ControllerBase
    {
        private readonly TGEContext _context;

        public CmAddressesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/CmAddresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CmAddress>>> GetCmAddresses()
        {
            return await _context.CmAddresses.ToListAsync();
        }

        // GET: api/CmAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CmAddress>> GetCmAddress(int id)
        {
            var cmAddress = await _context.CmAddresses.FindAsync(id);

            if (cmAddress == null)
            {
                return NotFound();
            }

            return cmAddress;
        }

        // PUT: api/CmAddresses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCmAddress(int id, CmAddress cmAddress)
        {
            if (id != cmAddress.Id)
            {
                return BadRequest();
            }

            _context.Entry(cmAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CmAddressExists(id))
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

        // POST: api/CmAddresses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CmAddress>> PostCmAddress(CmAddress cmAddress)
        {
            _context.CmAddresses.Add(cmAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCmAddress", new { id = cmAddress.Id }, cmAddress);
        }

        // DELETE: api/CmAddresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CmAddress>> DeleteCmAddress(int id)
        {
            var cmAddress = await _context.CmAddresses.FindAsync(id);
            if (cmAddress == null)
            {
                return NotFound();
            }

            _context.CmAddresses.Remove(cmAddress);
            await _context.SaveChangesAsync();

            return cmAddress;
        }

        private bool CmAddressExists(int id)
        {
            return _context.CmAddresses.Any(e => e.Id == id);
        }
    }
}
