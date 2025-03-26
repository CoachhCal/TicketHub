using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketHubController : ControllerBase
    {

        private readonly ILogger<TicketHubController> _logger;

        private readonly IConfiguration _configuration;

        public TicketHubController(ILogger<TicketHubController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello GET from Ticket Hub Controller");
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            if (customer.CreditCard.Length != 16 || !customer.CreditCard.All(char.IsDigit))
            {
                return BadRequest("Invalid credit card number.");
            }

            return Ok("Hello " + customer.Name + " from Ticket Hub Controller");
        }

    }
}
