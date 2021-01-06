using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItemBatch: ApiDItemBatchBase
    {
        public DItemBatch ItemBatch { get; set; }
    }
}
