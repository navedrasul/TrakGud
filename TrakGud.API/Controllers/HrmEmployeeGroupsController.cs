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
    public class HrmEmployeeGroupsController : ControllerBase
    {
        private readonly TGEContext _context;

        public HrmEmployeeGroupsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/HrmEmployeeGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrmEmployeeGroup>>> GetHrmEmployeeGroups()
        {
            return await _context.HrmEmployeeGroups.ToListAsync();
        }

        // GET: api/HrmEmployeeGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HrmEmployeeGroup>> GetHrmEmployeeGroup(int id)
        {
            var hrmEmployeeGroup = await _context.HrmEmployeeGroups.FindAsync(id);

            if (hrmEmployeeGroup == null)
            {
                return NotFound();
            }

            return hrmEmployeeGroup;
        }

        // PUT: api/HrmEmployeeGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrmEmployeeGroup(int id, HrmEmployeeGroup hrmEmployeeGroup)
        {
            if (id != hrmEmployeeGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(hrmEmployeeGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrmEmployeeGroupExists(id))
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

        // POST: api/HrmEmployeeGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HrmEmployeeGroup>> PostHrmEmployeeGroup(HrmEmployeeGroup hrmEmployeeGroup)
        {
            _context.HrmEmployeeGroups.Add(hrmEmployeeGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrmEmployeeGroup", new { id = hrmEmployeeGroup.Id }, hrmEmployeeGroup);
        }

        // DELETE: api/HrmEmployeeGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HrmEmployeeGroup>> DeleteHrmEmployeeGroup(int id)
        {
            var hrmEmployeeGroup = await _context.HrmEmployeeGroups.FindAsync(id);
            if (hrmEmployeeGroup == null)
            {
                return NotFound();
            }

            _context.HrmEmployeeGroups.Remove(hrmEmployeeGroup);
            await _context.SaveChangesAsync();

            return hrmEmployeeGroup;
        }

        private bool HrmEmployeeGroupExists(int id)
        {
            return _context.HrmEmployeeGroups.Any(e => e.Id == id);
        }
    }
}
