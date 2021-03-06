﻿using System;
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
    public class FimBanksController : ControllerBase
    {
        private readonly TGEContext _context;

        public FimBanksController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/FimBanks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FimBank>>> GetFimBanks()
        {
            return await _context.FimBanks.ToListAsync();
        }

        // GET: api/FimBanks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FimBank>> GetFimBank(int id)
        {
            var fimBank = await _context.FimBanks.FindAsync(id);

            if (fimBank == null)
            {
                return NotFound();
            }

            return fimBank;
        }

        // PUT: api/FimBanks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFimBank(int id, FimBank fimBank)
        {
            if (id != fimBank.Id)
            {
                return BadRequest();
            }

            _context.Entry(fimBank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FimBankExists(id))
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

        // POST: api/FimBanks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FimBank>> PostFimBank(FimBank fimBank)
        {
            _context.FimBanks.Add(fimBank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFimBank", new { id = fimBank.Id }, fimBank);
        }

        // DELETE: api/FimBanks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FimBank>> DeleteFimBank(int id)
        {
            var fimBank = await _context.FimBanks.FindAsync(id);
            if (fimBank == null)
            {
                return NotFound();
            }

            _context.FimBanks.Remove(fimBank);
            await _context.SaveChangesAsync();

            return fimBank;
        }

        private bool FimBankExists(int id)
        {
            return _context.FimBanks.Any(e => e.Id == id);
        }
    }
}
