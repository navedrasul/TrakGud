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
    public class FimChequesController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimChequesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimCheques
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimCheque>>> GetFimCheques()
        {
            return await _context.FimCheques.ToListAsync();
        }

        // GET: api/FimCheques/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimCheque>> GetFimCheque(int id)
        {
            var fimCheque = await _context.FimCheques.FindAsync(id);

            if (fimCheque == null)
            {
                return NotFound();
            }

            return fimCheque;
        }

        // PUT: api/FimCheques/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimCheque(int id, FimCheque fimCheque)
        {
            if (id != fimCheque.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimCheque).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimChequeExists(id))
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

        // POST: api/FimCheques
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimCheque>> PostFimCheque(FimCheque fimCheque)
        {
            _context.FimCheques.Add(fimCheque);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimCheque", new { id = fimCheque.Id }, fimCheque);
        }

        // DELETE: api/FimCheques/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimCheque>> DeleteFimCheque(int id)
        {
            var fimCheque = await _context.FimCheques.FindAsync(id);
            if (fimCheque == null)
            {
                return NotFound();
            }

            _context.FimCheques.Remove(fimCheque);
            await _context.SaveChangesAsync();

            return fimCheque;
        }

        private bool FimChequeExists(int id)
        {
            return _context.FimCheques.Any(e => e.Id == id);
        }
    }
}
