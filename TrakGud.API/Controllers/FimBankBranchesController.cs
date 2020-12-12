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
    public class FimBankBranchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimBankBranchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimBankBranches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimBankBranch>>> GetFimBankBranches()
        {
            return await _context.FimBankBranches.ToListAsync();
        }

        // GET: api/FimBankBranches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimBankBranch>> GetFimBankBranch(int id)
        {
            var fimBankBranch = await _context.FimBankBranches.FindAsync(id);

            if (fimBankBranch == null)
            {
                return NotFound();
            }

            return fimBankBranch;
        }

        // PUT: api/FimBankBranches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimBankBranch(int id, FimBankBranch fimBankBranch)
        {
            if (id != fimBankBranch.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimBankBranch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimBankBranchExists(id))
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

        // POST: api/FimBankBranches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimBankBranch>> PostFimBankBranch(FimBankBranch fimBankBranch)
        {
            _context.FimBankBranches.Add(fimBankBranch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimBankBranch", new { id = fimBankBranch.Id }, fimBankBranch);
        }

        // DELETE: api/FimBankBranches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimBankBranch>> DeleteFimBankBranch(int id)
        {
            var fimBankBranch = await _context.FimBankBranches.FindAsync(id);
            if (fimBankBranch == null)
            {
                return NotFound();
            }

            _context.FimBankBranches.Remove(fimBankBranch);
            await _context.SaveChangesAsync();

            return fimBankBranch;
        }

        private bool FimBankBranchExists(int id)
        {
            return _context.FimBankBranches.Any(e => e.Id == id);
        }
    }
}
