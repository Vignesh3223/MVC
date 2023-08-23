using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2208.Models;

namespace Task_2208.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
       
        public ActionResult StudentView()
        {
            IList<Student> stud = new List<Student>()
        {
            new Student(){ SId = 1, SName = "Arun Joseph", Department = "B.Sc CS" },
            new Student(){ SId = 2, SName = "Hemanth", Department = "B.Sc IT" },
            new Student(){ SId = 3, SName = "Yamini", Department = "BCA" },
            new Student(){ SId = 4, SName = "Harita", Department = "B.Sc IT" }
        };
            TempData["Studentdata"] = stud;
            return View(stud);
        }
    }
}