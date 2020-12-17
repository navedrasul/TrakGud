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
    public class UmUserGroupsController : ControllerBase
    {
        private readonly TGEContext _context;

        public UmUserGroupsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/UmUserGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmUserGroup>>> GetUmUserGroups()
        {
            return await _context.UmUserGroups.ToListAsync();
        }

        // GET: api/UmUserGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmUserGroup>> GetUmUserGroup(int id)
        {
            var umUserGroup = await _context.UmUserGroups.FindAsync(id);

            if (umUserGroup == null)
            {
                return NotFound();
            }

            return umUserGroup;
        }

        // PUT: api/UmUserGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmUserGroup(int id, UmUserGroup umUserGroup)
        {
            if (id != umUserGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(umUserGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmUserGroupExists(id))
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

        // POST: api/UmUserGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UmUserGroup>> PostUmUserGroup(UmUserGroup umUserGroup)
        {
            _context.UmUserGroups.Add(umUserGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUmUserGroup", new { id = umUserGroup.Id }, umUserGroup);
        }

        // DELETE: api/UmUserGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UmUserGroup>> DeleteUmUserGroup(int id)
        {
            var umUserGroup = await _context.UmUserGroups.FindAsync(id);
            if (umUserGroup == null)
            {
                return NotFound();
            }

            _context.UmUserGroups.Remove(umUserGroup);
            await _context.SaveChangesAsync();

            return umUserGroup;
        }

        private bool UmUserGroupExists(int id)
        {
            return _context.UmUserGroups.Any(e => e.Id == id);
        }
    }
}
