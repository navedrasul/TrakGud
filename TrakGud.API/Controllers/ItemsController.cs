using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrakGud.DAL.Models.Domain;
using TrakGud.DAL.Repos;

namespace TrakGud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        private DomainContext _domainContext;

        public ItemsController(ILogger<ItemsController> logger, DomainContext domainContext)
        {
            _logger = logger;
            _domainContext = domainContext;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _domainContext.Items.ToArray<Item>();
        }
    }
}
