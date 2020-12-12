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
    public class FimCashPaymentsController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimCashPaymentsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimCashPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimCashPayment>>> GetFimCashPayments()
        {
            return await _context.FimCashPayments.ToListAsync();
        }

        // GET: api/FimCashPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimCashPayment>> GetFimCashPayment(int id)
        {
            var fimCashPayment = await _context.FimCashPayments.FindAsync(id);

            if (fimCashPayment == null)
            {
                return NotFound();
            }

            return fimCashPayment;
        }

        // PUT: api/FimCashPayments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimCashPayment(int id, FimCashPayment fimCashPayment)
        {
            if (id != fimCashPayment.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimCashPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimCashPaymentExists(id))
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

        // POST: api/FimCashPayments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimCashPayment>> PostFimCashPayment(FimCashPayment fimCashPayment)
        {
            _context.FimCashPayments.Add(fimCashPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimCashPayment", new { id = fimCashPayment.Id }, fimCashPayment);
        }

        // DELETE: api/FimCashPayments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimCashPayment>> DeleteFimCashPayment(int id)
        {
            var fimCashPayment = await _context.FimCashPayments.FindAsync(id);
            if (fimCashPayment == null)
            {
                return NotFound();
            }

            _context.FimCashPayments.Remove(fimCashPayment);
            await _context.SaveChangesAsync();

            return fimCashPayment;
        }

        private bool FimCashPaymentExists(int id)
        {
            return _context.FimCashPayments.Any(e => e.Id == id);
        }
    }
}
