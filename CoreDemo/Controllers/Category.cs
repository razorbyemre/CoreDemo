using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
