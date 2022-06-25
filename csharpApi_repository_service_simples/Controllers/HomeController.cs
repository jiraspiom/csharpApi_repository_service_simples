using Microsoft.AspNetCore.Mvc;

namespace csharpApi_repository_service_simples.Controllers
{
    [ApiController]
    [Route("V1")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
