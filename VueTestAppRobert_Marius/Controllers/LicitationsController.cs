using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VueTestAppRobert_Marius.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LicitationsController : ControllerBase
    {
        private static List<Licitation> Licitations = new List<Licitation> { new Licitation { Date = DateTime.UtcNow, Id = 0, Summary = "MARIUS!" } };
        private static int id = 1;

        private readonly ILogger<LicitationsController> _logger;

        public LicitationsController(ILogger<LicitationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Licitation> Get()
        {
            return Licitations;
        }
        
        [HttpPost]
        public Licitation Post([FromBody] Licitation licitation)
        {
            var newLicitation = new Licitation
            {
                Id = id,
                Date = DateTime.UtcNow,
                Summary = licitation.Summary
            };
            Licitations.Add(newLicitation);
            id++;

            return newLicitation;
        }
    }
}
