using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Areas.Client.Controllers
{
    [Area("client")]
    public class HomeController : Controller
    {
        [HttpGet("~/", Name = "client-home-index")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
