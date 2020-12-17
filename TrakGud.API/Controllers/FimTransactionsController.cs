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
    public class FimTransactionsController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimTransactionsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimTransactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimTransaction>>> GetFimTransactions()
        {
            return await _context.FimTransactions.ToListAsync();
        }

        // GET: api/FimTransactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimTransaction>> GetFimTransaction(int id)
        {
            var fimTransaction = await _context.FimTransactions.FindAsync(id);

            if (fimTransaction == null)
            {
                return NotFound();
            }

            return fimTransaction;
        }

        // PUT: api/FimTransactions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimTransaction(int id, FimTransaction fimTransaction)
        {
            if (id != fimTransaction.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimTransactionExists(id))
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

        // POST: api/FimTransactions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimTransaction>> PostFimTransaction(FimTransaction fimTransaction)
        {
            _context.FimTransactions.Add(fimTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimTransaction", new { id = fimTransaction.Id }, fimTransaction);
        }

        // DELETE: api/FimTransactions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimTransaction>> DeleteFimTransaction(int id)
        {
            var fimTransaction = await _context.FimTransactions.FindAsync(id);
            if (fimTransaction == null)
            {
                return NotFound();
            }

            _context.FimTransactions.Remove(fimTransaction);
            await _context.SaveChangesAsync();

            return fimTransaction;
        }

        private bool FimTransactionExists(int id)
        {
            return _context.FimTransactions.Any(e => e.Id == id);
        }
    }
}
