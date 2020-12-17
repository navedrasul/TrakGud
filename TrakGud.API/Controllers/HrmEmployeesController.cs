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
    public class HrmEmployeesController : ControllerBase
    {
        private readonly TGEContext _context;

        public HrmEmployeesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/HrmEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrmEmployee>>> GetHrmEmployees()
        {
            return await _context.HrmEmployees.ToListAsync();
        }

        // GET: api/HrmEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HrmEmployee>> GetHrmEmployee(int id)
        {
            var hrmEmployee = await _context.HrmEmployees.FindAsync(id);

            if (hrmEmployee == null)
            {
                return NotFound();
            }

            return hrmEmployee;
        }

        // PUT: api/HrmEmployees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrmEmployee(int id, HrmEmployee hrmEmployee)
        {
            if (id != hrmEmployee.Id)
            {
                return BadRequest();
            }

            _context.Entry(hrmEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrmEmployeeExists(id))
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

        // POST: api/HrmEmployees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HrmEmployee>> PostHrmEmployee(HrmEmployee hrmEmployee)
        {
            _context.HrmEmployees.Add(hrmEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrmEmployee", new { id = hrmEmployee.Id }, hrmEmployee);
        }

        // DELETE: api/HrmEmployees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HrmEmployee>> DeleteHrmEmployee(int id)
        {
            var hrmEmployee = await _context.HrmEmployees.FindAsync(id);
            if (hrmEmployee == null)
            {
                return NotFound();
            }

            _context.HrmEmployees.Remove(hrmEmployee);
            await _context.SaveChangesAsync();

            return hrmEmployee;
        }

        private bool HrmEmployeeExists(int id)
        {
            return _context.HrmEmployees.Any(e => e.Id == id);
        }
    }
}
