using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
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
    //[EnableCorsAttribute("_myAllowSpecificOrigins")]
    public class DItemsController : ControllerBase
    {
        private readonly TGEContext _context;

        public DItemsController(TGEContext context)
        {
            _context = context;
        }

        // -----------------> Implementation with API Model.

        // GET: api/DItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiDItem>>> GetDItems(
            int? count = null,
            bool? withTxt = null
            )
        {
            IQueryable<DItem> items;

            items = _context.DItems;

            if (items == null)
            {
                return NotFound();
            }

            // Only take the first count records.
            items = items.Take(count ?? int.MaxValue);

            // Convert to List.
            List<DItem> sellersList = await items.ToListAsync<DItem>();

            // Add associated objects by converting to ExpandoObject.

            List<ApiDItem> res = new List<ApiDItem>();

            foreach (DItem item in sellersList)
            {
                ApiDItem resItem = new ApiDItem()
                {
                    item = item
                };

                // Add associated text fields.

                if (withTxt ?? false)
                {
                    resItem.product = new DProduct();
                    resItem.product.Name = _context.DProducts.First(p => p.Id == item.ProdId).Name;

                    resItem.productUnit = new DProductUnit();
                    resItem.productUnit.Name = _context.DProductUnits.First(pu => pu.Id == item.UnitId).Name;
                }

                res.Add(resItem);
            }

            return res;
        }

        // -----------------> Implementation without params

        //// GET: api/DItems
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<DItem>>> GetDItems()
        //{
        //    return await _context.DItems.ToListAsync();
        //}

        // GET: api/DItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiDItem>> GetDItem(
            int id,
            bool? withProduct = false
            )
        {
            // TODO: !!! Following is test-code and should be removed after testing
            //await Task.Delay(3000); // Wait 2 seconds without blocking

            var item = await _context.DItems.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            // Create the response object.
            ApiDItem resItem = new ApiDItem
            {
                // Add associated objects.
                item = item,
                product = _context.DProducts.First(p => p.Id == item.ProdId)
            };

            return resItem;
        }

        // PUT: api/DItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDItem(int id, DItem dItem)
        {
            if (id != dItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(dItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DItemExists(id))
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

        // POST: api/DItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DItem>> PostDItem(DItem dItem)
        {
            _context.DItems.Add(dItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDItem", new { id = dItem.Id }, dItem);
        }

        // DELETE: api/DItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DItem>> DeleteDItem(int id)
        {
            var dItem = await _context.DItems.FindAsync(id);
            if (dItem == null)
            {
                return NotFound();
            }

            _context.DItems.Remove(dItem);
            await _context.SaveChangesAsync();

            return dItem;
        }

        private bool DItemExists(int id)
        {
            return _context.DItems.Any(e => e.Id == id);
        }
    }
}
