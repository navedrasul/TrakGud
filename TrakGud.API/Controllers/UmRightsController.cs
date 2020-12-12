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
    public class UmRightsController : ControllerBase
    {
        private readonly TGEContext _context;

        public UmRightsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/UmRights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmRight>>> GetUmRights()
        {
            return await _context.UmRights.ToListAsync();
        }

        // GET: api/UmRights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmRight>> GetUmRight(int id)
        {
            var umRight = await _context.UmRights.FindAsync(id);

            if (umRight == null)
            {
                return NotFound();
            }

            return umRight;
        }

        // PUT: api/UmRights/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmRight(int id, UmRight umRight)
        {
            if (id != umRight.Id)
            {
                return BadRequest();
            }

            _context.Entry(umRight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmRightExists(id))
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

        // POST: api/UmRights
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UmRight>> PostUmRight(UmRight umRight)
        {
            _context.UmRights.Add(umRight);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUmRight", new { id = umRight.Id }, umRight);
        }

        // DELETE: api/UmRights/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UmRight>> DeleteUmRight(int id)
        {
            var umRight = await _context.UmRights.FindAsync(id);
            if (umRight == null)
            {
                return NotFound();
            }

            _context.UmRights.Remove(umRight);
            await _context.SaveChangesAsync();

            return umRight;
        }

        private bool UmRightExists(int id)
        {
            return _context.UmRights.Any(e => e.Id == id);
        }
    }
}
