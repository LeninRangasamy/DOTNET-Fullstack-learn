using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;
namespace MyMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Show()
        {
            var users = new List<UserModel>
            {
                new UserModel{userid=10,username="pelvin",emailid="sam1@gmail.com" },
                new UserModel{userid=11,username="Mervin",emailid="mervin@gmail.com" },
                new UserModel{userid=12,username="Jhon",emailid="jhon@gmail.com" },
                new UserModel{userid=13,username="Doe",emailid="doe@gmail.com"}
            };
            return View(users);
        }
    }
}