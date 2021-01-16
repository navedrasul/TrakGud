using System.Collections.Generic;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItemBatchBase
    {
        public DItem ItemInfo { get; set; }
        public DItemBatchType ItemBatchTypes { get; set; }
        public List<DItemBatchSourceType> ItemBatchSourceTypes { get; set; }
        public List<DProduct> Products { get; set; }
        public List<DProductUnit> ProductUnits { get; set; }
    }
}
