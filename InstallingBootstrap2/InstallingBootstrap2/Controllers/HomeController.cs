using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrap2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
