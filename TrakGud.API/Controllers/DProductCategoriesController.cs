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
    public class DProductCategoriesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DProductCategoriesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DProductCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DProductCategory>>> GetDProductCategories()
        {
            return await _context.DProductCategories.ToListAsync();
        }

        // GET: api/DProductCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DProductCategory>> GetDProductCategory(int id)
        {
            var dProductCategory = await _context.DProductCategories.FindAsync(id);

            if (dProductCategory == null)
            {
                return NotFound();
            }

            return dProductCategory;
        }

        // PUT: api/DProductCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDProductCategory(int id, DProductCategory dProductCategory)
        {
            if (id != dProductCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(dProductCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DProductCategoryExists(id))
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

        // POST: api/DProductCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DProductCategory>> PostDProductCategory(DProductCategory dProductCategory)
        {
            _context.DProductCategories.Add(dProductCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDProductCategory", new { id = dProductCategory.Id }, dProductCategory);
        }

        // DELETE: api/DProductCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DProductCategory>> DeleteDProductCategory(int id)
        {
            var dProductCategory = await _context.DProductCategories.FindAsync(id);
            if (dProductCategory == null)
            {
                return NotFound();
            }

            _context.DProductCategories.Remove(dProductCategory);
            await _context.SaveChangesAsync();

            return dProductCategory;
        }

        private bool DProductCategoryExists(int id)
        {
            return _context.DProductCategories.Any(e => e.Id == id);
        }
    }
}
