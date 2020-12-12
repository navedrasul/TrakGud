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
    public class UmRolesController : ControllerBase
    {
        private readonly TGEContext _context;

        public UmRolesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/UmRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmRole>>> GetUmRoles()
        {
            return await _context.UmRoles.ToListAsync();
        }

        // GET: api/UmRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmRole>> GetUmRole(int id)
        {
            var umRole = await _context.UmRoles.FindAsync(id);

            if (umRole == null)
            {
                return NotFound();
            }

            return umRole;
        }

        // PUT: api/UmRoles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmRole(int id, UmRole umRole)
        {
            if (id != umRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(umRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmRoleExists(id))
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

        // POST: api/UmRoles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UmRole>> PostUmRole(UmRole umRole)
        {
            _context.UmRoles.Add(umRole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUmRole", new { id = umRole.Id }, umRole);
        }

        // DELETE: api/UmRoles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UmRole>> DeleteUmRole(int id)
        {
            var umRole = await _context.UmRoles.FindAsync(id);
            if (umRole == null)
            {
                return NotFound();
            }

            _context.UmRoles.Remove(umRole);
            await _context.SaveChangesAsync();

            return umRole;
        }

        private bool UmRoleExists(int id)
        {
            return _context.UmRoles.Any(e => e.Id == id);
        }
    }
}
