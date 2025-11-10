using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;
namespace HelloMVC.Controllers
{
    public class WorkerController : Controller
    {
        //[HttpGet]
        public IActionResult Display()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Display(WorkerViewModel wvm)
        {
            ViewData["Message"] = $"Worker {wvm.wname} added succesfully";
            return View(wvm);
        }
    }
}