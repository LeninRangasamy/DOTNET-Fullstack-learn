using Microsoft.AspNetCore.Mvc;
using ASPEmpty.Models;
using System.Collections.Generic;
using System.Linq;
namespace ASPEmpty.Controllers{
  public class EmployeeController : Controller{
    private static List<EmployeeModel>  employees=new List<EmployeeModel>{
      new EmployeeModel{eid=1,name="Pelvin",salary=15000}
      new EmployeeModel{eid=2,name="Boopathi",salary=17000}
    };

    //Read(Display employees)
    public IActionResult Index(){
      return View(employees);
    }

    //Create (Form)
    [HttpGet]
    public IActionResult Create(){
      return View();
    }

    //Add received data to the employees list
    [HttpPost]
    public IActionResult Create(EmployeeModel emp){
      employees.Add(emp);
      return RedirectToAction("Index");
    }

  }
}
