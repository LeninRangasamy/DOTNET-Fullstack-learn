using Microsoft.AspNetCore.Mvc;
namespace ASPEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}