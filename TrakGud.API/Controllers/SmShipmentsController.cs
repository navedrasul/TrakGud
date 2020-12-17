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
    public class SmShipmentsController : ControllerBase
    {
        private readonly TGEContext _context;

        public SmShipmentsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SmShipments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SmShipment>>> GetSmShipments()
        {
            return await _context.SmShipments.ToListAsync();
        }

        // GET: api/SmShipments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SmShipment>> GetSmShipment(int id)
        {
            var smShipment = await _context.SmShipments.FindAsync(id);

            if (smShipment == null)
            {
                return NotFound();
            }

            return smShipment;
        }

        // PUT: api/SmShipments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmShipment(int id, SmShipment smShipment)
        {
            if (id != smShipment.Id)
            {
                return BadRequest();
            }

            _context.Entry(smShipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmShipmentExists(id))
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

        // POST: api/SmShipments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SmShipment>> PostSmShipment(SmShipment smShipment)
        {
            _context.SmShipments.Add(smShipment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSmShipment", new { id = smShipment.Id }, smShipment);
        }

        // DELETE: api/SmShipments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SmShipment>> DeleteSmShipment(int id)
        {
            var smShipment = await _context.SmShipments.FindAsync(id);
            if (smShipment == null)
            {
                return NotFound();
            }

            _context.SmShipments.Remove(smShipment);
            await _context.SaveChangesAsync();

            return smShipment;
        }

        private bool SmShipmentExists(int id)
        {
            return _context.SmShipments.Any(e => e.Id == id);
        }
    }
}
