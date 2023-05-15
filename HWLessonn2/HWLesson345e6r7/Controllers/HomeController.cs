using HWLesson345e6r7.Models;
using Microsoft.AspNetCore.Mvc;

namespace HWLesson345e6r7.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetProduct()
		{
			Products products = new Products(1, "Ferari", 5000, "Red") { PathToImage = "gl-4-960x540" };
			return View(products);
		}
	}
}
