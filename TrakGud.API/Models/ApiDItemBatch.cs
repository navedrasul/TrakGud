using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItemBatch: ApiDItemBatchBase
    {
        public DItemBatch itemBatch { get; set; }
    }
}
