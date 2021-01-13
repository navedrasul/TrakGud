using System.Collections.Generic;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItemBatch: ApiDItemBatchBase
    {
        public DItemBatch ItemBatch { get; set; }
        public List<DProduct> Products { get; set; }
        public List<DItemBatchSourceType> SourceTypes { get; set; }
    }
}
