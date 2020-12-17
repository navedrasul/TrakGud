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
    public class CmLocationInfoesController : ControllerBase
    {
        private readonly TGEContext _context;

        public CmLocationInfoesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/CmLocationInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CmLocationInfo>>> GetCmLocationInfos()
        {
            return await _context.CmLocationInfos.ToListAsync();
        }

        // GET: api/CmLocationInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CmLocationInfo>> GetCmLocationInfo(int id)
        {
            var cmLocationInfo = await _context.CmLocationInfos.FindAsync(id);

            if (cmLocationInfo == null)
            {
                return NotFound();
            }

            return cmLocationInfo;
        }

        // PUT: api/CmLocationInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCmLocationInfo(int id, CmLocationInfo cmLocationInfo)
        {
            if (id != cmLocationInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(cmLocationInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CmLocationInfoExists(id))
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

        // POST: api/CmLocationInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CmLocationInfo>> PostCmLocationInfo(CmLocationInfo cmLocationInfo)
        {
            _context.CmLocationInfos.Add(cmLocationInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCmLocationInfo", new { id = cmLocationInfo.Id }, cmLocationInfo);
        }

        // DELETE: api/CmLocationInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CmLocationInfo>> DeleteCmLocationInfo(int id)
        {
            var cmLocationInfo = await _context.CmLocationInfos.FindAsync(id);
            if (cmLocationInfo == null)
            {
                return NotFound();
            }

            _context.CmLocationInfos.Remove(cmLocationInfo);
            await _context.SaveChangesAsync();

            return cmLocationInfo;
        }

        private bool CmLocationInfoExists(int id)
        {
            return _context.CmLocationInfos.Any(e => e.Id == id);
        }
    }
}
