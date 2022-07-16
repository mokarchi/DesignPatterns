using Decorator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IDataService _dataService;

        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.GetData());
        }
    }
}
