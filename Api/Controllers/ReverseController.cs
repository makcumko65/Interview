using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {
        private readonly IReverseResolver reverseResolver;

        public ReverseController(IReverseResolver reverseResolver)
        {
            this.reverseResolver = reverseResolver;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string data) =>
            Ok(reverseResolver.Reverse(data));
        
    }
}
