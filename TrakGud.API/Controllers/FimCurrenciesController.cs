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
    public class FimCurrenciesController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimCurrenciesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimCurrencies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimCurrency>>> GetFimCurrencies()
        {
            return await _context.FimCurrencies.ToListAsync();
        }

        // GET: api/FimCurrencies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimCurrency>> GetFimCurrency(string id)
        {
            var fimCurrency = await _context.FimCurrencies.FindAsync(id);

            if (fimCurrency == null)
            {
                return NotFound();
            }

            return fimCurrency;
        }

        // PUT: api/FimCurrencies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimCurrency(string id, FimCurrency fimCurrency)
        {
            if (id != fimCurrency.Value)
            {
                return BadRequest();
            }

            _context.Entry(fimCurrency).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimCurrencyExists(id))
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

        // POST: api/FimCurrencies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimCurrency>> PostFimCurrency(FimCurrency fimCurrency)
        {
            _context.FimCurrencies.Add(fimCurrency);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FimCurrencyExists(fimCurrency.Value))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFimCurrency", new { id = fimCurrency.Value }, fimCurrency);
        }

        // DELETE: api/FimCurrencies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimCurrency>> DeleteFimCurrency(string id)
        {
            var fimCurrency = await _context.FimCurrencies.FindAsync(id);
            if (fimCurrency == null)
            {
                return NotFound();
            }

            _context.FimCurrencies.Remove(fimCurrency);
            await _context.SaveChangesAsync();

            return fimCurrency;
        }

        private bool FimCurrencyExists(string id)
        {
            return _context.FimCurrencies.Any(e => e.Value == id);
        }
    }
}
