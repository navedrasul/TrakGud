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
    public class FimCreditPaymentsController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimCreditPaymentsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimCreditPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimCreditPayment>>> GetFimCreditPayments()
        {
            return await _context.FimCreditPayments.ToListAsync();
        }

        // GET: api/FimCreditPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimCreditPayment>> GetFimCreditPayment(int id)
        {
            var fimCreditPayment = await _context.FimCreditPayments.FindAsync(id);

            if (fimCreditPayment == null)
            {
                return NotFound();
            }

            return fimCreditPayment;
        }

        // PUT: api/FimCreditPayments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimCreditPayment(int id, FimCreditPayment fimCreditPayment)
        {
            if (id != fimCreditPayment.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimCreditPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimCreditPaymentExists(id))
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

        // POST: api/FimCreditPayments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimCreditPayment>> PostFimCreditPayment(FimCreditPayment fimCreditPayment)
        {
            _context.FimCreditPayments.Add(fimCreditPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimCreditPayment", new { id = fimCreditPayment.Id }, fimCreditPayment);
        }

        // DELETE: api/FimCreditPayments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimCreditPayment>> DeleteFimCreditPayment(int id)
        {
            var fimCreditPayment = await _context.FimCreditPayments.FindAsync(id);
            if (fimCreditPayment == null)
            {
                return NotFound();
            }

            _context.FimCreditPayments.Remove(fimCreditPayment);
            await _context.SaveChangesAsync();

            return fimCreditPayment;
        }

        private bool FimCreditPaymentExists(int id)
        {
            return _context.FimCreditPayments.Any(e => e.Id == id);
        }
    }
}
