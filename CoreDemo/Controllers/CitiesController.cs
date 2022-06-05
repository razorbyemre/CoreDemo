using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreDemo.Controllers
{
    public class CitiesController : Controller
    {

        public IActionResult Index()
        {
            var model = new CityModel();

            model.Cities = new List<SelectListItem>();
            model.Cities.Add(new SelectListItem() { Text= "Istanbul",Value="1",Selected=false});
            model.Cities.Add(new SelectListItem() { Text= "Ankara",Value="2",Selected=false});
            model.Cities.Add(new SelectListItem() { Text= "Antalya",Value="3",Selected=false});
            model.Cities.Add(new SelectListItem() { Text= "Izmir",Value="4",Selected=false});
            model.Cities.Add(new SelectListItem() { Text= "Adana",Value="5",Selected=false});

            return View(model);
        }
    }
}
