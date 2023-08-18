using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;
using Task_1708.Models;

namespace Task_1708.Controllers
{
    public class TraineeController : Controller
    {
        static IList<Training> traineeList = new List<Training> {
        new Training() { Id = 101, Name = "Arun Joseph", Domain=".NET"},
        new Training() { Id = 102, Name = "Darshan", Domain="NODE"},
        new Training() { Id = 103, Name = "Harita", Domain = ".NET"},
        new Training() { Id = 104, Name = "Harshan", Domain = "FRONT END"},
        new Training() { Id = 105, Name = "Hemanth", Domain = ".NET"},
        new Training() { Id = 106, Name = "Harishmitha", Domain = "PHP"},
        new Training() { Id = 107, Name = "Karthikeyan", Domain = "NODE"},
        new Training() { Id = 108, Name = "Sharon", Domain = "PHP"},
        new Training() { Id = 109, Name = "Siva Bharat", Domain = ".NET"},
        new Training() { Id = 110, Name = "Srikanth", Domain = ".NET"},
        new Training() { Id = 111, Name = "Vignesh", Domain = ".NET"},
        new Training() { Id = 112, Name = "Yamini", Domain = ".NET"},
        };

        static IList<Training> trainerList = new List<Training>
        {
        new Training() { Id = 1, Name = "Pallavi Katari", Domain=".NET"},
        new Training() { Id = 2, Name = "Thangam Arulseeli", Domain="PHP"},
        };

        // GET: Trainee
        public ActionResult Index(int? id)
        {
            if(id == 1)
            {
                return View(traineeList);
            }
            else if (id == 2)
            {
                return View(trainerList);
            }
            else
            return Content("<h1>No Data to Display!<h1>", "text/html", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public JsonResult JSONView1()
        {
            var result = Json(trainerList, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            result.MaxJsonLength = int.MaxValue;
            return result;
        }
        public ActionResult JSONView2()
        {
            var result1 = Json(traineeList, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            result1.MaxJsonLength = int.MaxValue;
            return result1;
        }

        public FileResult FileView()
        {
            return File(Url.Content("~/Files/File1.docx"), "text/plain");
        }

        public ActionResult View3(AgeCalculator a)
        { 
            return View(a);
        }
    }
}