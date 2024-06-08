using Microsoft.AspNetCore.Mvc;
using MVC_Virtual_Test_Table.Models;

namespace MVC_Virtual_Test_Table.Controllers
{
    public class CarOrderController : Controller
    {
        private List<Brand> GetBrands()
        {
            return new List<Brand>
            {
                new Brand {Id=1, Name="Ferrari"},
                new Brand {Id=2, Name="Lamborghini"},
                new Brand {Id=3, Name="Alfa Romeo"},
                new Brand {Id=4, Name="Peugeot"},

            };
        }

        private List<Colour> GetColours()
        {
            return new List<Colour>
            {
                new Colour {Id=1, Name="Blue"},
                new Colour {Id=2, Name="Red"},
                new Colour {Id=3, Name="Green"},
                new Colour {Id=4, Name="Black"},

            };
        }

        private List<CarModel> GetCarModels()
        {
            return new List<CarModel>
            {
                new CarModel {Id=1, Name="Enzo"},
                new CarModel {Id=2, Name="Murciélago"},
                new CarModel {Id=3, Name="Reventon"},
                new CarModel {Id=4, Name="Elemento"},

            };
        }

        private List<BodyType> GetBodyTypes()
        {
            return new List<BodyType>
            {
                new BodyType {Id=1, Name="SUV"},
                new BodyType {Id=2, Name="SEDAN"},
                new BodyType {Id=3, Name="Hatchback"},
                new BodyType {Id=4, Name="Coupe"},

            };
        }

        public IActionResult Index()
        {
            var modal = new CarOrderViewModel
            {
                Brands = GetBrands(),
                Colours = GetColours(),
                CarModels = GetCarModels(),
                BodyTypes = GetBodyTypes()
                //Customers = GetCustomers()
            };


            return View(modal);
        }

        [HttpPost]
        public IActionResult Index(CarOrderViewModel modal)
        {
            if (ModelState.IsValid)
            {

                //Bu alanda DB ye insert edeceğim.

                TempData["SuccessMessage"] = "Siparişiniz Başarılı";
                return RedirectToAction("Index");

            }
            modal.Brands = GetBrands();
            modal.Colours = GetColours();
            return View(modal);
        }
    }
}
