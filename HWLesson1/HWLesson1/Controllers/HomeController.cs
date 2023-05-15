using Microsoft.AspNetCore.Mvc;

namespace HWLesson1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var osname = Environment.OSVersion.Version.ToString();
            ViewBag.osname = osname;
            return View();
        }
    }
}
