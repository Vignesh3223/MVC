using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2108.Models;

namespace Task_2108.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee
        static IList<Trainee> trainees = new List<Trainee>()
        {
            new Trainee() {Tid=1,Tname="Arun Joseph",Tage=21,TDomain="Angular, DOTNET", TrName="Pallavi Katari"},
            new Trainee() {Tid=2,Tname="Harita",Tage=20,TDomain="React, DOTNET",TrName="Pallavi Katari"},
            new Trainee() {Tid=3,Tname="Darshan",Tage=20,TDomain="React, NODE", TrName = "Pallavi Katari"},
            new Trainee() {Tid=4,Tname="Harishmitha",Tage=20,TDomain="Vue, PHP", TrName = "Thangam Arulseeli" },
            new Trainee() {Tid=5,Tname="Hemanth",Tage=20,TDomain="Angular, DOTNET", TrName = "Pallavi Katari"},
            new Trainee() {Tid=6,Tname="Karthkeyan",Tage=21,TDomain="React, NODE", TrName = "Pallavi Katari"},
            new Trainee() {Tid=7,Tname="Siva Bharat",Tage=22,TDomain="Angular, DOTNET", TrName = "Pallavi Katari"},
            new Trainee() {Tid=8,Tname="Sharon",Tage=20,TDomain="Angular, PHP", TrName = "Thangam Arulseeli"},
            new Trainee() {Tid=9,Tname="Srikanth",Tage=20,TDomain="Angular, DOTNET", TrName = "Pallavi Katari"},
            new Trainee() {Tid=10,Tname="Vignesh",Tage=20,TDomain="Angular, DOTNET", TrName = "Pallavi Katari"},
            new Trainee() {Tid=11,Tname="Yamini",Tage=20,TDomain="React, DOTNET", TrName = "Pallavi Katari"},
        };
        public ActionResult TraineeView()
        {
            return View(trainees);
        }
        [ChildActionOnly]
        public ActionResult RenderSideBar()
        {
            return PartialView("SideBar");
        }
    }
}