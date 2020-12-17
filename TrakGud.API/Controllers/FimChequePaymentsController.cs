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
    public class FimChequePaymentsController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimChequePaymentsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimChequePayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimChequePayment>>> GetFimChequePayments()
        {
            return await _context.FimChequePayments.ToListAsync();
        }

        // GET: api/FimChequePayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimChequePayment>> GetFimChequePayment(int id)
        {
            var fimChequePayment = await _context.FimChequePayments.FindAsync(id);

            if (fimChequePayment == null)
            {
                return NotFound();
            }

            return fimChequePayment;
        }

        // PUT: api/FimChequePayments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimChequePayment(int id, FimChequePayment fimChequePayment)
        {
            if (id != fimChequePayment.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimChequePayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimChequePaymentExists(id))
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

        // POST: api/FimChequePayments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimChequePayment>> PostFimChequePayment(FimChequePayment fimChequePayment)
        {
            _context.FimChequePayments.Add(fimChequePayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimChequePayment", new { id = fimChequePayment.Id }, fimChequePayment);
        }

        // DELETE: api/FimChequePayments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimChequePayment>> DeleteFimChequePayment(int id)
        {
            var fimChequePayment = await _context.FimChequePayments.FindAsync(id);
            if (fimChequePayment == null)
            {
                return NotFound();
            }

            _context.FimChequePayments.Remove(fimChequePayment);
            await _context.SaveChangesAsync();

            return fimChequePayment;
        }

        private bool FimChequePaymentExists(int id)
        {
            return _context.FimChequePayments.Any(e => e.Id == id);
        }
    }
}
