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
    public class DBuyersController : ControllerBase
    {
        private readonly TGEContext _context;

        public DBuyersController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DBuyers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DBuyer>>> GetDBuyers()
        {
            return await _context.DBuyers.ToListAsync();
        }

        // GET: api/DBuyers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DBuyer>> GetDBuyer(int id)
        {
            var dBuyer = await _context.DBuyers.FindAsync(id);

            if (dBuyer == null)
            {
                return NotFound();
            }

            return dBuyer;
        }

        // PUT: api/DBuyers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDBuyer(int id, DBuyer dBuyer)
        {
            if (id != dBuyer.Id)
            {
                return BadRequest();
            }

            _context.Entry(dBuyer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DBuyerExists(id))
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

        // POST: api/DBuyers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DBuyer>> PostDBuyer(DBuyer dBuyer)
        {
            _context.DBuyers.Add(dBuyer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDBuyer", new { id = dBuyer.Id }, dBuyer);
        }

        // DELETE: api/DBuyers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DBuyer>> DeleteDBuyer(int id)
        {
            var dBuyer = await _context.DBuyers.FindAsync(id);
            if (dBuyer == null)
            {
                return NotFound();
            }

            _context.DBuyers.Remove(dBuyer);
            await _context.SaveChangesAsync();

            return dBuyer;
        }

        private bool DBuyerExists(int id)
        {
            return _context.DBuyers.Any(e => e.Id == id);
        }
    }
}
