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
    public class SProductOffersController : ControllerBase
    {
        private readonly TGEContext _context;

        public SProductOffersController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/SProductOffers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SProductOffer>>> GetSProductOffers()
        {
            return await _context.SProductOffers.ToListAsync();
        }

        // GET: api/SProductOffers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SProductOffer>> GetSProductOffer(int id)
        {
            var sProductOffer = await _context.SProductOffers.FindAsync(id);

            if (sProductOffer == null)
            {
                return NotFound();
            }

            return sProductOffer;
        }

        // PUT: api/SProductOffers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSProductOffer(int id, SProductOffer sProductOffer)
        {
            if (id != sProductOffer.Id)
            {
                return BadRequest();
            }

            _context.Entry(sProductOffer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SProductOfferExists(id))
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

        // POST: api/SProductOffers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SProductOffer>> PostSProductOffer(SProductOffer sProductOffer)
        {
            _context.SProductOffers.Add(sProductOffer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSProductOffer", new { id = sProductOffer.Id }, sProductOffer);
        }

        // DELETE: api/SProductOffers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SProductOffer>> DeleteSProductOffer(int id)
        {
            var sProductOffer = await _context.SProductOffers.FindAsync(id);
            if (sProductOffer == null)
            {
                return NotFound();
            }

            _context.SProductOffers.Remove(sProductOffer);
            await _context.SaveChangesAsync();

            return sProductOffer;
        }

        private bool SProductOfferExists(int id)
        {
            return _context.SProductOffers.Any(e => e.Id == id);
        }
    }
}
