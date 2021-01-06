using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDReceivedItemBatch: ApiDItemBatchBase
    {
        public DReceivedItemBatch ReceivedItemBatch { get; set; }
        public DSeller Seller { get; set; }
        public FimTransaction Transaction { get; set; }
    }
}
