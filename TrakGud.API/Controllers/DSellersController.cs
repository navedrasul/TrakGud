using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrakGud.API.Models;
using TrakGud.API.UItils;
using TrakGud.DAL.Models;
using TrakGud.DAL.Repos;

namespace TrakGud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DSellersController : ControllerBase
    {
        private readonly TGEContext _context;

        public DSellersController(TGEContext context)
        {
            _context = context;
        }

        // -----------------> Implementation with API Model.

        // GET: api/DSellers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiDSeller>>> GetDSellers(
            string filter = null,
            int? count = null,
            bool? withContact = null
            )
        {
            IQueryable<DSeller> sellers;

            if (string.IsNullOrWhiteSpace(filter))
            {
                sellers = _context.DSellers;
                //.ToListAsync();
            }
            else
            {
                // Convert the filter-key to the "LOWER CASE".
                filter = filter.ToLower();

                sellers = _context.DSellers
                                .Where(s =>
                                    s.Name.ToLower().Contains(filter) ||
                                    _context.CmCompanyInfos.First(c => c.Id == s.ContactId).Name.ToLower().Contains(filter)
                                    );
                //.ToListAsync<DSeller>();
            }

            if (sellers == null)
            {
                return NotFound();
            }

            // Order by name. Then take the first 'count' number of records.
            sellers = sellers.OrderBy(s => s.Name)
                .Take(count ?? int.MaxValue);

            // Convert to List.
            List<DSeller> sellersList = await sellers.ToListAsync<DSeller>();

            // Create the response objects.
            List<ApiDSeller> res = new List<ApiDSeller>();

            // Add associated objects.

            foreach (DSeller seller in sellersList)
            {
                ApiDSeller resSeller = new ApiDSeller() {
                    Seller = seller
                };

                // Add associated CmCompanyInfo objects.

                if (withContact ?? false)
                {
                    resSeller.CompanyInfo = _context.CmCompanyInfos.First(ci => ci.Id == seller.ContactId);
                }

                res.Add(resSeller);
            }

            return res;
        }

        // -----------------> Implementation without params

        //// GET: api/DSellers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<DSeller>>> GetDSellers()
        //{
        //    return await _context.DSellers.ToListAsync();
        //}

        // -----------------> Implementation with ExpandoObject

        //// GET: api/DSellers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ExpandoObject>>> GetDSellers(
        //    string filter = null,
        //    int? count = null,
        //    bool? withContact = null
        //    )
        //{
        //    IQueryable<DSeller> sellers;

        //    if (string.IsNullOrWhiteSpace(filter))
        //    {
        //        sellers = _context.DSellers;
        //        //.ToListAsync();
        //    }
        //    else
        //    {
        //        // Convert the filter-key to the "LOWER CASE".
        //        filter = filter.ToLower();

        //        sellers = _context.DSellers
        //                        .Where(s =>
        //                            s.Name.ToLower().Contains(filter) ||
        //                            _context.CmCompanyInfos.First(c => c.Id == s.ContactId).Name.ToLower().Contains(filter)
        //                            )
        //                        .Take(count ?? int.MaxValue);
        //                        //.ToListAsync<DSeller>();
        //    }

        //    if (sellers == null)
        //    {
        //        return NotFound();
        //    }

        //    // Order by name.

        //    sellers = sellers.OrderBy(s => s.Name);

        //    // Convert to List.

        //    List<DSeller> sellersList = await sellers.ToListAsync<DSeller>();

        //    // Add associated objects by converting to ExpandoObject.

        //    List<ExpandoObject> res = new List<ExpandoObject>();

        //    foreach (DSeller seller in sellersList)
        //    {
        //        dynamic eo = TypeConverter.dtoToExpando<DSeller>(seller);

        //        // Add associated CmCompanyInfo objects.

        //        if (withContact ?? false)
        //        {
        //            eo.Contact = _context.CmCompanyInfos.First(ci => ci.Id == seller.ContactId);
        //        }

        //        res.Add(eo);
        //    }

        //    return res;
        //}

        // GET: api/DSellers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DSeller>> GetDSeller(int id)
        {
            var dSeller = await _context.DSellers.FindAsync(id);

            if (dSeller == null)
            {
                return NotFound();
            }

            return dSeller;
        }

        // PUT: api/DSellers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDSeller(int id, DSeller dSeller)
        {
            if (id != dSeller.Id)
            {
                return BadRequest();
            }

            _context.Entry(dSeller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DSellerExists(id))
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

        // POST: api/DSellers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DSeller>> PostDSeller(DSeller dSeller)
        {
            _context.DSellers.Add(dSeller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDSeller", new { id = dSeller.Id }, dSeller);
        }

        // DELETE: api/DSellers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DSeller>> DeleteDSeller(int id)
        {
            var dSeller = await _context.DSellers.FindAsync(id);
            if (dSeller == null)
            {
                return NotFound();
            }

            _context.DSellers.Remove(dSeller);
            await _context.SaveChangesAsync();

            return dSeller;
        }

        private bool DSellerExists(int id)
        {
            return _context.DSellers.Any(e => e.Id == id);
        }
    }
}
