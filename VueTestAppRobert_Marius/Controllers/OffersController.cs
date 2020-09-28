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
    public class OffersController : ControllerBase
    {
        private static List<Offer> Offers = new List<Offer>();
        private static int id = 1;

        private readonly ILogger<LicitationsController> _logger;

        public OffersController(ILogger<LicitationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Offer> Get([FromHeader] Offer offer)
        {
            return Offers.Where(o => o.LicitationId == offer.LicitationId);
        }
        
        [HttpPost]
        public void Post([FromBody] Offer offer)
        {
            var newLicitation = new Offer
            {
                Id = id,
                Date = DateTime.UtcNow,
                Summary = offer.Summary,
                LicitationId = offer.LicitationId
            };
            Offers.Add(newLicitation);
            id++;
        }
    }
}
