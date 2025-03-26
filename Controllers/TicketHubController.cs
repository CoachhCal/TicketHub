using Azure.Storage.Queues;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

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
        public async Task<IActionResult> Post(Customer customer)
        {

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            string queueName = "tickethub";

            // Get connection string from secrets.json
            string? connectionString = _configuration["AzureStorageConnectionString"];

            if (string.IsNullOrEmpty(connectionString))
            {
                return BadRequest("An error was encountered");
            }

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            // serialize an object to json
            string message = JsonSerializer.Serialize(customer);

            // send string message to queue
            await queueClient.SendMessageAsync(message);

            return Ok("Hello " + customer.Name + ". Customer Information sent to storage queue");
        }
    }
}
