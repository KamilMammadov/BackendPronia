using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
