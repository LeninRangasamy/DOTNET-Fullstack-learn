using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;
namespace HelloMVC.Controllers
{
    public class EmployeeController : Controller
    {
    public IActionResult Details()
        {
            var emp = new EmployeeViewModel
            {
                id = 1,
                name = "Lenin",
                department = "Development"
            };
            return View(emp);
        }
    }
}