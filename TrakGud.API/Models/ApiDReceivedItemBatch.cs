using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDReceivedItemBatch: ApiDItemBatchBase
    {
        public DReceivedItemBatch receivedItemBatch { get; set; }
        public DSeller seller { get; set; }
        public FimTransaction transaction { get; set; }
    }
}
