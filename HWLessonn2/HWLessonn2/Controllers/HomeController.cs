using HWLessonn2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HWLessonn2.Controllers
{
    public class HomeController : Controller
    {
        List<Products> products = new List<Products>();
        public HomeController()
        {
            products.Add(new Products(1, "Ferari", 5000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(2, "Lamborghini", 6000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(3, "Mers", 7000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(4, "BMW", 8000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(5, "Lexus", 9000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(6, "Toyota", 10000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(7, "Lada", 11000, "Red") { PathToImage = "gl-4-960x540" });
            products.Add(new Products(8, "Samocat", 12000, "Red") { PathToImage = "gl-4-960x540" });
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View(products);
        }
        public IActionResult Images()
        {
            return View(products.Where(w=>w.Price > 1500).ToList());
        }
    }
}
