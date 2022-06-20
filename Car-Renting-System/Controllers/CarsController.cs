using Car_Renting_System.Models.Cars;
using Microsoft.AspNetCore.Mvc;

namespace Car_Renting_System.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddCarFormModel car)
        {
            return View(car);
        }
    }
}
