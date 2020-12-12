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
    public class CmContactsController : ControllerBase
    {
        private readonly TGEContext _context;

        public CmContactsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/CmContacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CmContact>>> GetCmContacts()
        {
            return await _context.CmContacts.ToListAsync();
        }

        // GET: api/CmContacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CmContact>> GetCmContact(int id)
        {
            var cmContact = await _context.CmContacts.FindAsync(id);

            if (cmContact == null)
            {
                return NotFound();
            }

            return cmContact;
        }

        // PUT: api/CmContacts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCmContact(int id, CmContact cmContact)
        {
            if (id != cmContact.Id)
            {
                return BadRequest();
            }

            _context.Entry(cmContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CmContactExists(id))
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

        // POST: api/CmContacts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CmContact>> PostCmContact(CmContact cmContact)
        {
            _context.CmContacts.Add(cmContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCmContact", new { id = cmContact.Id }, cmContact);
        }

        // DELETE: api/CmContacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CmContact>> DeleteCmContact(int id)
        {
            var cmContact = await _context.CmContacts.FindAsync(id);
            if (cmContact == null)
            {
                return NotFound();
            }

            _context.CmContacts.Remove(cmContact);
            await _context.SaveChangesAsync();

            return cmContact;
        }

        private bool CmContactExists(int id)
        {
            return _context.CmContacts.Any(e => e.Id == id);
        }
    }
}
