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
    public class NmNotificationCategoriesController : ControllerBase
    {
        private readonly TGEContext _context;

        public NmNotificationCategoriesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/NmNotificationCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NmNotificationCategory>>> GetNmNotificationCategories()
        {
            return await _context.NmNotificationCategories.ToListAsync();
        }

        // GET: api/NmNotificationCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NmNotificationCategory>> GetNmNotificationCategory(int id)
        {
            var nmNotificationCategory = await _context.NmNotificationCategories.FindAsync(id);

            if (nmNotificationCategory == null)
            {
                return NotFound();
            }

            return nmNotificationCategory;
        }

        // PUT: api/NmNotificationCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNmNotificationCategory(int id, NmNotificationCategory nmNotificationCategory)
        {
            if (id != nmNotificationCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(nmNotificationCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NmNotificationCategoryExists(id))
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

        // POST: api/NmNotificationCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NmNotificationCategory>> PostNmNotificationCategory(NmNotificationCategory nmNotificationCategory)
        {
            _context.NmNotificationCategories.Add(nmNotificationCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNmNotificationCategory", new { id = nmNotificationCategory.Id }, nmNotificationCategory);
        }

        // DELETE: api/NmNotificationCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NmNotificationCategory>> DeleteNmNotificationCategory(int id)
        {
            var nmNotificationCategory = await _context.NmNotificationCategories.FindAsync(id);
            if (nmNotificationCategory == null)
            {
                return NotFound();
            }

            _context.NmNotificationCategories.Remove(nmNotificationCategory);
            await _context.SaveChangesAsync();

            return nmNotificationCategory;
        }

        private bool NmNotificationCategoryExists(int id)
        {
            return _context.NmNotificationCategories.Any(e => e.Id == id);
        }
    }
}
