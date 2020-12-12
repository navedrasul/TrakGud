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
    public class NmNotificationsController : ControllerBase
    {
        private readonly TGEContext _context;

        public NmNotificationsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/NmNotifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NmNotification>>> GetNmNotifications()
        {
            return await _context.NmNotifications.ToListAsync();
        }

        // GET: api/NmNotifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NmNotification>> GetNmNotification(int id)
        {
            var nmNotification = await _context.NmNotifications.FindAsync(id);

            if (nmNotification == null)
            {
                return NotFound();
            }

            return nmNotification;
        }

        // PUT: api/NmNotifications/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNmNotification(int id, NmNotification nmNotification)
        {
            if (id != nmNotification.Id)
            {
                return BadRequest();
            }

            _context.Entry(nmNotification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NmNotificationExists(id))
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

        // POST: api/NmNotifications
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NmNotification>> PostNmNotification(NmNotification nmNotification)
        {
            _context.NmNotifications.Add(nmNotification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNmNotification", new { id = nmNotification.Id }, nmNotification);
        }

        // DELETE: api/NmNotifications/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NmNotification>> DeleteNmNotification(int id)
        {
            var nmNotification = await _context.NmNotifications.FindAsync(id);
            if (nmNotification == null)
            {
                return NotFound();
            }

            _context.NmNotifications.Remove(nmNotification);
            await _context.SaveChangesAsync();

            return nmNotification;
        }

        private bool NmNotificationExists(int id)
        {
            return _context.NmNotifications.Any(e => e.Id == id);
        }
    }
}
