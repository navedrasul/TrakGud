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
    public class HrmOrganisationsController : ControllerBase
    {
        private readonly TGEContext _context;

        public HrmOrganisationsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/HrmOrganisations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrmOrganisation>>> GetHrmOrganisations()
        {
            return await _context.HrmOrganisations.ToListAsync();
        }

        // GET: api/HrmOrganisations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HrmOrganisation>> GetHrmOrganisation(int id)
        {
            var hrmOrganisation = await _context.HrmOrganisations.FindAsync(id);

            if (hrmOrganisation == null)
            {
                return NotFound();
            }

            return hrmOrganisation;
        }

        // PUT: api/HrmOrganisations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrmOrganisation(int id, HrmOrganisation hrmOrganisation)
        {
            if (id != hrmOrganisation.Id)
            {
                return BadRequest();
            }

            _context.Entry(hrmOrganisation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrmOrganisationExists(id))
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

        // POST: api/HrmOrganisations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HrmOrganisation>> PostHrmOrganisation(HrmOrganisation hrmOrganisation)
        {
            _context.HrmOrganisations.Add(hrmOrganisation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrmOrganisation", new { id = hrmOrganisation.Id }, hrmOrganisation);
        }

        // DELETE: api/HrmOrganisations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HrmOrganisation>> DeleteHrmOrganisation(int id)
        {
            var hrmOrganisation = await _context.HrmOrganisations.FindAsync(id);
            if (hrmOrganisation == null)
            {
                return NotFound();
            }

            _context.HrmOrganisations.Remove(hrmOrganisation);
            await _context.SaveChangesAsync();

            return hrmOrganisation;
        }

        private bool HrmOrganisationExists(int id)
        {
            return _context.HrmOrganisations.Any(e => e.Id == id);
        }
    }
}
