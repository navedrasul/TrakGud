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
    public class DCommentsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DCommentsController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DComment>>> GetDComments()
        {
            return await _context.DComments.ToListAsync();
        }

        // GET: api/DComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DComment>> GetDComment(int id)
        {
            var dComment = await _context.DComments.FindAsync(id);

            if (dComment == null)
            {
                return NotFound();
            }

            return dComment;
        }

        // PUT: api/DComments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDComment(int id, DComment dComment)
        {
            if (id != dComment.Id)
            {
                return BadRequest();
            }

            _context.Entry(dComment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DCommentExists(id))
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

        // POST: api/DComments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DComment>> PostDComment(DComment dComment)
        {
            _context.DComments.Add(dComment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDComment", new { id = dComment.Id }, dComment);
        }

        // DELETE: api/DComments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DComment>> DeleteDComment(int id)
        {
            var dComment = await _context.DComments.FindAsync(id);
            if (dComment == null)
            {
                return NotFound();
            }

            _context.DComments.Remove(dComment);
            await _context.SaveChangesAsync();

            return dComment;
        }

        private bool DCommentExists(int id)
        {
            return _context.DComments.Any(e => e.Id == id);
        }
    }
}
