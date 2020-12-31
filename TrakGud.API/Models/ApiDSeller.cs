using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrakGud.API.UItils;
using TrakGud.DAL.Models;

namespace TrakGud.API.Models
{
    public class ApiDSeller
    {
        public DSeller seller { get; set; }
        public CmCompanyInfo companyInfo { get; set; }
    }
}
