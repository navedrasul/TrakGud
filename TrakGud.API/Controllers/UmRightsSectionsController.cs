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
    public class UmRightsSectionsController : ControllerBase
    {
        private readonly TGEContext _context;

        public UmRightsSectionsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/UmRightsSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmRightsSection>>> GetUmRightsSections()
        {
            return await _context.UmRightsSections.ToListAsync();
        }

        // GET: api/UmRightsSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmRightsSection>> GetUmRightsSection(int id)
        {
            var umRightsSection = await _context.UmRightsSections.FindAsync(id);

            if (umRightsSection == null)
            {
                return NotFound();
            }

            return umRightsSection;
        }

        // PUT: api/UmRightsSections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmRightsSection(int id, UmRightsSection umRightsSection)
        {
            if (id != umRightsSection.Id)
            {
                return BadRequest();
            }

            _context.Entry(umRightsSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmRightsSectionExists(id))
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

        // POST: api/UmRightsSections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UmRightsSection>> PostUmRightsSection(UmRightsSection umRightsSection)
        {
            _context.UmRightsSections.Add(umRightsSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUmRightsSection", new { id = umRightsSection.Id }, umRightsSection);
        }

        // DELETE: api/UmRightsSections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UmRightsSection>> DeleteUmRightsSection(int id)
        {
            var umRightsSection = await _context.UmRightsSections.FindAsync(id);
            if (umRightsSection == null)
            {
                return NotFound();
            }

            _context.UmRightsSections.Remove(umRightsSection);
            await _context.SaveChangesAsync();

            return umRightsSection;
        }

        private bool UmRightsSectionExists(int id)
        {
            return _context.UmRightsSections.Any(e => e.Id == id);
        }
    }
}
