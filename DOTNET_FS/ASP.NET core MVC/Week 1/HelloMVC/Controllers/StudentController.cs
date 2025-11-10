using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;
namespace HelloMVC.Controllers
{
    //[Route("Lenin")]
    public class StudentController : Controller
    {
        //[Route("Data")]
        public IActionResult Show()
        {
            StudentViewModel svm = new StudentViewModel();
            svm.rollno = 22053;
            svm.name = "Lenin";
            svm.course = "B.Tech";
            svm.department = "Information Technology";
            return View(svm);
        }
    }
}