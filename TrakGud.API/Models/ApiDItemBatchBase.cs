using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItemBatchBase
    {
        public DItemBatchType itemBatchType { get; set; }
        public DItemBatchSourceType itemBatchSourceType { get; set; }
        public DProduct product { get; set; }
        public DProductUnit productUnit { get; set; }
    }
}
