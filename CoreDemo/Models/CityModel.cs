using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreDemo.Models
{
    public class CityModel
    {
        public string City { get; set; }

        public List<SelectListItem> Cities { get; set; }

    }
}
