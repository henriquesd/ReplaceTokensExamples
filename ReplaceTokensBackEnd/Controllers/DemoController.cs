using Microsoft.AspNetCore.Mvc;

namespace ReplaceTokensBackEnd.Controllers
{

    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DemoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ServiceAExample")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ServiceAExample()
        {
            return Ok(_configuration.GetValue<string>("ServiceA:BaseUrl"));
        }

        [HttpGet("ServiceBExample")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ServiceBExample()
        {
            return Ok(_configuration.GetValue<string>("ServiceB:BaseUrl"));
        }
    }
}
