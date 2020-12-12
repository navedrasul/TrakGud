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
    public class GsUserSettingsController : ControllerBase
    {
        private readonly TGEContext _context;

        public GsUserSettingsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/GsUserSettings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GsUserSetting>>> GetGsUserSettings()
        {
            return await _context.GsUserSettings.ToListAsync();
        }

        // GET: api/GsUserSettings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GsUserSetting>> GetGsUserSetting(int id)
        {
            var gsUserSetting = await _context.GsUserSettings.FindAsync(id);

            if (gsUserSetting == null)
            {
                return NotFound();
            }

            return gsUserSetting;
        }

        // PUT: api/GsUserSettings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGsUserSetting(int id, GsUserSetting gsUserSetting)
        {
            if (id != gsUserSetting.UserId)
            {
                return BadRequest();
            }

            _context.Entry(gsUserSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GsUserSettingExists(id))
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

        // POST: api/GsUserSettings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GsUserSetting>> PostGsUserSetting(GsUserSetting gsUserSetting)
        {
            _context.GsUserSettings.Add(gsUserSetting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GsUserSettingExists(gsUserSetting.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGsUserSetting", new { id = gsUserSetting.UserId }, gsUserSetting);
        }

        // DELETE: api/GsUserSettings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GsUserSetting>> DeleteGsUserSetting(int id)
        {
            var gsUserSetting = await _context.GsUserSettings.FindAsync(id);
            if (gsUserSetting == null)
            {
                return NotFound();
            }

            _context.GsUserSettings.Remove(gsUserSetting);
            await _context.SaveChangesAsync();

            return gsUserSetting;
        }

        private bool GsUserSettingExists(int id)
        {
            return _context.GsUserSettings.Any(e => e.UserId == id);
        }
    }
}
