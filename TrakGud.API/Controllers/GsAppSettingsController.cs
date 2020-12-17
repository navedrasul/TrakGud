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
    public class GsAppSettingsController : ControllerBase
    {
        private readonly TGEContext _context;

        public GsAppSettingsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/GsAppSettings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GsAppSetting>>> GetGsAppSettings()
        {
            return await _context.GsAppSettings.ToListAsync();
        }

        // GET: api/GsAppSettings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GsAppSetting>> GetGsAppSetting(int id)
        {
            var gsAppSetting = await _context.GsAppSettings.FindAsync(id);

            if (gsAppSetting == null)
            {
                return NotFound();
            }

            return gsAppSetting;
        }

        // PUT: api/GsAppSettings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGsAppSetting(int id, GsAppSetting gsAppSetting)
        {
            if (id != gsAppSetting.AppId)
            {
                return BadRequest();
            }

            _context.Entry(gsAppSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GsAppSettingExists(id))
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

        // POST: api/GsAppSettings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GsAppSetting>> PostGsAppSetting(GsAppSetting gsAppSetting)
        {
            _context.GsAppSettings.Add(gsAppSetting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GsAppSettingExists(gsAppSetting.AppId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGsAppSetting", new { id = gsAppSetting.AppId }, gsAppSetting);
        }

        // DELETE: api/GsAppSettings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GsAppSetting>> DeleteGsAppSetting(int id)
        {
            var gsAppSetting = await _context.GsAppSettings.FindAsync(id);
            if (gsAppSetting == null)
            {
                return NotFound();
            }

            _context.GsAppSettings.Remove(gsAppSetting);
            await _context.SaveChangesAsync();

            return gsAppSetting;
        }

        private bool GsAppSettingExists(int id)
        {
            return _context.GsAppSettings.Any(e => e.AppId == id);
        }
    }
}
