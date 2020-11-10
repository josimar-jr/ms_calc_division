using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using division.Services;

namespace division.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class HealthcheckController : ControllerBase
    {
        private readonly ILogger<HealthcheckController> _logger;

        public HealthcheckController(ILogger<HealthcheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/healthcheck")]
        [HttpGet("/")]
        public string Get()
        {
            // return "ok";
            return HealthcheckService.Status();
        }
    }
}
