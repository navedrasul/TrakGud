using System.Collections.Generic;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItem
    {
        public DItem Item { get; set; }
        public List<DProduct> Products { get; set; }
        public List<DProductUnit> ProductUnits { get; set; }
    }
}
