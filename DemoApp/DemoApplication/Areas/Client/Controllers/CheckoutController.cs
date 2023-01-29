using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Areas.Client.Controllers
{
    [Area("client")]
    [Route("checkout")]
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
