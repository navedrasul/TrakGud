using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrakGud.API.Models;
using TrakGud.DAL.Models;
using TrakGud.DAL.Repos;

namespace TrakGud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DItemBatchesController : ControllerBase
    {
        private readonly TGEContext _context;

        public DItemBatchesController(TGEContext context)
        {
            _context = context;
        }

        // GET: api/DItemBatches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DItemBatch>>> GetDItemBatches()
        {
            return await _context.DItemBatches.ToListAsync();
        }

        // GET: api/DItemBatches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiDItemBatch>> GetDItemBatch(
            int id,
            string mode = null
        )
        {
            try
            {
                DItemBatch dItemBatch = null;
                if (mode != "add")
                {
                    dItemBatch = await _context.DItemBatches.FindAsync(id);

                    if (dItemBatch == null)
                    {
                        return NotFound();
                    }
                }

                ApiDItemBatch resItemB = new ApiDItemBatch
                {
                    ItemBatch = dItemBatch
                };

                const string withText = "txt";
                const string forEdit = "edit";
                const string forAdd = "add";

                switch (mode)
                {
                    case withText:
                        // Add associated text fields.

                        // Todo: Implement!

                        break;

                    case forEdit:
                        // Add fields for Item-batch editing.

                        resItemB.Products = _context.DProducts.Select(p => new DProduct
                        {
                            Id = p.Id,
                            Name = p.Name
                        }).ToList();

                        resItemB.ItemBatchSourceTypes = _context.DItemBatchSourceTypes.Select(t => new DItemBatchSourceType
                        {
                            Value = t.Value,
                            Text = t.Text
                        }).ToList();

                        break;
                    case forAdd:
                        resItemB.Products = _context.DProducts.Select(p => new DProduct
                        {
                            Id = p.Id,
                            Name = p.Name
                        }).ToList();

                        resItemB.ItemBatchSourceTypes = _context.DItemBatchSourceTypes.Select(t => new DItemBatchSourceType
                        {
                            Value = t.Value,
                            Text = t.Text
                        }).ToList();

                        break;
                }

                return resItemB;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return NoContent();
        }

        // PUT: api/DItemBatches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDItemBatch(int id, DItemBatch dItemBatch)
        {
            if (id != dItemBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(dItemBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DItemBatchExists(id))
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

        // POST: api/DItemBatches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DItemBatch>> PostDItemBatch(DItemBatch dItemBatch)
        {
            _context.DItemBatches.Add(dItemBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDItemBatch", new { id = dItemBatch.Id }, dItemBatch);
        }

        // DELETE: api/DItemBatches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DItemBatch>> DeleteDItemBatch(int id)
        {
            var dItemBatch = await _context.DItemBatches.FindAsync(id);
            if (dItemBatch == null)
            {
                return NotFound();
            }

            _context.DItemBatches.Remove(dItemBatch);
            await _context.SaveChangesAsync();

            return dItemBatch;
        }

        private bool DItemBatchExists(int id)
        {
            return _context.DItemBatches.Any(e => e.Id == id);
        }
    }
}
