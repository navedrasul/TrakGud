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
    public class UmUsersController : ControllerBase
    {
        private readonly TGEContext _context;

        public UmUsersController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/UmUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UmUser>>> GetUmUsers()
        {
            return await _context.UmUsers.ToListAsync();
        }

        // GET: api/UmUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UmUser>> GetUmUser(int id)
        {
            var umUser = await _context.UmUsers.FindAsync(id);

            if (umUser == null)
            {
                return NotFound();
            }

            return umUser;
        }

        // PUT: api/UmUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUmUser(int id, UmUser umUser)
        {
            if (id != umUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(umUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UmUserExists(id))
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

        // POST: api/UmUsers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UmUser>> PostUmUser(UmUser umUser)
        {
            _context.UmUsers.Add(umUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUmUser", new { id = umUser.Id }, umUser);
        }

        // DELETE: api/UmUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UmUser>> DeleteUmUser(int id)
        {
            var umUser = await _context.UmUsers.FindAsync(id);
            if (umUser == null)
            {
                return NotFound();
            }

            _context.UmUsers.Remove(umUser);
            await _context.SaveChangesAsync();

            return umUser;
        }

        private bool UmUserExists(int id)
        {
            return _context.UmUsers.Any(e => e.Id == id);
        }
    }
}
