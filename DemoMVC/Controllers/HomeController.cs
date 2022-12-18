using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Tom";
            int age = 20;
            ViewBag.Name = name;
            ViewData["Age"]=age;
            TempData["Name"] = name;
            return View();
        }
        public IActionResult About()
        {
            int[] nums = { 40, 30, 20, 40, 20 };
            ViewBag.Nums = nums;

            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Name = TempData["Name"];
            return View();
        }
    }
}
