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
    public class FmVehiclesController : ControllerBase
    {
        private readonly TGEContext _context;

        public FmVehiclesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FmVehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FmVehicle>>> GetFmVehicles()
        {
            return await _context.FmVehicles.ToListAsync();
        }

        // GET: api/FmVehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FmVehicle>> GetFmVehicle(int id)
        {
            var fmVehicle = await _context.FmVehicles.FindAsync(id);

            if (fmVehicle == null)
            {
                return NotFound();
            }

            return fmVehicle;
        }

        // PUT: api/FmVehicles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFmVehicle(int id, FmVehicle fmVehicle)
        {
            if (id != fmVehicle.Id)
            {
                return BadRequest();
            }

            _context.Entry(fmVehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FmVehicleExists(id))
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

        // POST: api/FmVehicles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FmVehicle>> PostFmVehicle(FmVehicle fmVehicle)
        {
            _context.FmVehicles.Add(fmVehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFmVehicle", new { id = fmVehicle.Id }, fmVehicle);
        }

        // DELETE: api/FmVehicles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FmVehicle>> DeleteFmVehicle(int id)
        {
            var fmVehicle = await _context.FmVehicles.FindAsync(id);
            if (fmVehicle == null)
            {
                return NotFound();
            }

            _context.FmVehicles.Remove(fmVehicle);
            await _context.SaveChangesAsync();

            return fmVehicle;
        }

        private bool FmVehicleExists(int id)
        {
            return _context.FmVehicles.Any(e => e.Id == id);
        }
    }
}
