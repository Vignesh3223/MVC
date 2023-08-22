using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2108.Models;

namespace Task_2108.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        static IList<Trainer> trainer = new List<Trainer>()
        {
            new Trainer(){TrName="Pallavi Katari",TrDomain="Angular JS, React JS, DOTNET",TrExperience = 5},
            new Trainer(){TrName="Thangam Arulseeli",TrDomain="Vue JS, PHP, Laravel",TrExperience = 7},
        };
        public ActionResult TrainerView()
        {
            return View(trainer);
        }
        [ChildActionOnly]
        public ActionResult RenderSideBar()
        {
            return PartialView("SideBar");
        }
    }
}