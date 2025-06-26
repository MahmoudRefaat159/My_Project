using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using My_Project.Models;

namespace My_Project.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public ViewResult Data()
        {
            var data = Stor.ReturnData();
            return View(data);
        }
        [HttpGet]
        public ViewResult Stored_Data()
        {
            
            return View();
        }

        [HttpPost]
        public ViewResult Stored_Data(Employee employee) {

            Stor.InsertInto(employee);
            return View("Confirmation",employee);
        }
      
    }
}
