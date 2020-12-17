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
    public class DProductsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DProductsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DProduct>>> GetDProducts()
        {
            return await _context.DProducts.ToListAsync();
        }

        // GET: api/DProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DProduct>> GetDProduct(int id)
        {
            var dProduct = await _context.DProducts.FindAsync(id);

            if (dProduct == null)
            {
                return NotFound();
            }

            return dProduct;
        }

        // PUT: api/DProducts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDProduct(int id, DProduct dProduct)
        {
            if (id != dProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(dProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DProductExists(id))
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

        // POST: api/DProducts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DProduct>> PostDProduct(DProduct dProduct)
        {
            _context.DProducts.Add(dProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDProduct", new { id = dProduct.Id }, dProduct);
        }

        // DELETE: api/DProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DProduct>> DeleteDProduct(int id)
        {
            var dProduct = await _context.DProducts.FindAsync(id);
            if (dProduct == null)
            {
                return NotFound();
            }

            _context.DProducts.Remove(dProduct);
            await _context.SaveChangesAsync();

            return dProduct;
        }

        private bool DProductExists(int id)
        {
            return _context.DProducts.Any(e => e.Id == id);
        }
    }
}
