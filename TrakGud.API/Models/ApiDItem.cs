using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDItem
    {
        public DItem item { get; set; }
        public DProduct product { get; set; }
        public DProductUnit productUnit { get; set; }
    }
}
