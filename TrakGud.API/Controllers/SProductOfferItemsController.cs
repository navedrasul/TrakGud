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
    public class SProductOfferItemsController : ControllerBase
    {
        private readonly TGEContext _context;

        public SProductOfferItemsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SProductOfferItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SProductOfferItem>>> GetSProductOfferItems()
        {
            return await _context.SProductOfferItems.ToListAsync();
        }

        // GET: api/SProductOfferItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SProductOfferItem>> GetSProductOfferItem(int id)
        {
            var sProductOfferItem = await _context.SProductOfferItems.FindAsync(id);

            if (sProductOfferItem == null)
            {
                return NotFound();
            }

            return sProductOfferItem;
        }

        // PUT: api/SProductOfferItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSProductOfferItem(int id, SProductOfferItem sProductOfferItem)
        {
            if (id != sProductOfferItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(sProductOfferItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SProductOfferItemExists(id))
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

        // POST: api/SProductOfferItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SProductOfferItem>> PostSProductOfferItem(SProductOfferItem sProductOfferItem)
        {
            _context.SProductOfferItems.Add(sProductOfferItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSProductOfferItem", new { id = sProductOfferItem.Id }, sProductOfferItem);
        }

        // DELETE: api/SProductOfferItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SProductOfferItem>> DeleteSProductOfferItem(int id)
        {
            var sProductOfferItem = await _context.SProductOfferItems.FindAsync(id);
            if (sProductOfferItem == null)
            {
                return NotFound();
            }

            _context.SProductOfferItems.Remove(sProductOfferItem);
            await _context.SaveChangesAsync();

            return sProductOfferItem;
        }

        private bool SProductOfferItemExists(int id)
        {
            return _context.SProductOfferItems.Any(e => e.Id == id);
        }
    }
}
