using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _manager = new WriterManager(new EFWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        //Burada bir parametree girimeliyiz, cunku funk isimleri ayni ve hata aliriz. 
        public IActionResult Index(Writer w)
        {
            w.WriterStatus = true;
            w.WriterAbout = "Test";
            _manager.WriteAdd(w);
            return RedirectToAction("Index","Blog"); // Burada blog icindeki index aksiyona git dedik. 
        }
    }
}
