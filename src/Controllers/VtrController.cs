using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VtrController
    {
        private readonly ILogger<VtrController> _logger;
        
        public VtrController(ILogger<VtrController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return null;
        }

    }
}
