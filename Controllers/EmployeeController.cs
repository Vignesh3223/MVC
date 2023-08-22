using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2108.Models;
using Task_2108.ViewModel;

namespace Task_2108.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeView()
        {
            Trainer Trainers = new Trainer()
            {
                TrName = "Pallavi Katari",
                TrDomain = "Angular JS, React JS, DOTNET",
                TrExperience = 5
            };
            Trainee Trainees = new Trainee()
            {
                Tid= 1,
                Tname = "Arun Joseph",
                Tage = 21,
                TDomain = "Angular, DOTNET",
                TrName = "Pallavi Katari"
            };
            Employee employee = new Employee()
            {
                Trainers = Trainers,
                Trainees = Trainees
            };
            return View(employee);
        }
    }
}