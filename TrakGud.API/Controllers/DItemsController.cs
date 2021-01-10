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

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="count"></param>
        /// <param name="mode">values: txt, edit</param>
        /// <returns>
        ///     <para>An array of Items with each item fulfilling the following conditions.</para>
        ///     <para>if mode is null, entire item is initialised.</para>
        ///     <para>if mode is txt, entire item, and single element arrays of Products and ProductUnits are initialised with Id and Name values.\</para>
        /// </returns>
        // GET: api/DItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiDItem>>> GetDItems(
            int? count = null,
            string mode = null
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
            List<DItem> itemsList = await items.ToListAsync<DItem>();

            // Add associated objects by converting to ExpandoObject.

            List<ApiDItem> res = new List<ApiDItem>();

            foreach (DItem item in itemsList)
            {
                ApiDItem resItem = new ApiDItem()
                {
                    Item = item
                };

                const string withText = "txt";

                switch (mode)
                {
                    case withText:
                        // Add associated text fields.

                        var product = new DProduct
                        {
                            Name = _context.DProducts.First(p => p.Id == item.ProdId).Name
                        };
                        resItem.Products = new List<DProduct>
                        {
                            product
                        };

                        var productUnit = new DProductUnit
                        {
                            Name = _context.DProductUnits.First(pu => pu.Id == item.UnitId).Name
                        };
                        resItem.ProductUnits = new List<DProductUnit>
                        {
                            productUnit
                        };
                        break;
                }

                res.Add(resItem);
            }

            return res;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="id">Item-ID</param>
        /// <param name="mode">values: txt, edit</param>
        /// <returns>
        ///     <para>if mode is null, entire item is initialised.</para>
        ///     <para>if mode is txt, entire item, and single element arrays of Products and ProductUnits are initialised with Id and Name values.\</para>
        ///     <para>if mode is edit, entire item, and entire array of Products and selective array of ProductUnits (for the given prodId) are initialised with Id and Name values.</para>
        /// </returns>
        // GET: api/DItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiDItem>> GetDItem(
            int id,
            string mode = null
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
            ApiDItem resItem = new ApiDItem()
            {
                Item = item
            };

            const string withText = "txt";
            const string forEdit = "edit";

            switch (mode)
            {
                case withText:
                    // Add associated text fields.

                    var product = new DProduct
                    {
                        Name = _context.DProducts.First(p => p.Id == item.ProdId).Name
                    };
                    resItem.Products = new List<DProduct>
                        {
                            product
                        };

                    var productUnit = new DProductUnit
                    {
                        Name = _context.DProductUnits.First(pu => pu.Id == item.UnitId).Name
                    };
                    resItem.ProductUnits = new List<DProductUnit>
                        {
                            productUnit
                        };
                    break;

                case forEdit:
                    // Add fields for Item editing.

                    resItem.Products = _context.DProducts.Select(p => new DProduct
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();

                    resItem.ProductUnits = _context.DProductUnits
                        .Where(pu => pu.ProductId == resItem.Item.ProdId)
                        .Select(pu => new DProductUnit
                        {
                            Id = pu.Id,
                            Name = pu.Name
                        }).ToList();
                    break;
            }

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

            // Todo: Replace the dummy values with the real ones.
            dItem.ModderId = 1;
            dItem.ModTs = new DateTime();

            _context.Entry(dItem).State = EntityState.Modified;
            _context.Entry(dItem).Property(x => x.AdderId).IsModified = false;
            _context.Entry(dItem).Property(x => x.AddTs).IsModified = false;

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
            // Todo: Replace the dummy values with the real ones.
            dItem.AdderId = 1;
            dItem.AddTs = new DateTime();

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

            // Todo: Copy the dItem to the Archive DB.

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
