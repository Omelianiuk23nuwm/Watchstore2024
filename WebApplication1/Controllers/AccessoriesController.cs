using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccessoriesController : Controller
    {
        public AccessoriesController()
        {
        }
        public IActionResult Index(int accessoriesId)
        {
            AccessoriesModel[] accessory = new AccessoriesModel[3];
            accessory[0] = new AccessoriesModel();
            accessory[0].Id = 1;
            accessory[0].Name = "Скринька для прикрас від торгової марки Wooden Organizer";
            accessory[0].Price = 1433;
            accessory[1] = new AccessoriesModel();
            accessory[1].Id = 2;
            accessory[1].Name = "Скринька для прикрас tm wooden organizer emerald lock біла jb010";
            accessory[1].Price = 123;
            accessory[2] = new AccessoriesModel();
            accessory[2].Id = 3;
            accessory[2].Name = "Організатор настільний vlando для косметики, прикрас";
            accessory[2].Price = 123;
            return View(accessory);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
