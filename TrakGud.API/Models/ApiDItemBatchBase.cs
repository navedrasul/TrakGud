using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItemBatchBase
    {
        public DItemBatchType ItemBatchType { get; set; }
        public DItemBatchSourceType ItemBatchSourceType { get; set; }
        public DProduct Product { get; set; }
        public DProductUnit ProductUnit { get; set; }
    }
}
