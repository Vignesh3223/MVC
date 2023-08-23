using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2308.Models;

namespace Task_2308.Controllers
{
    public class HomeController : Controller
    {
        MVCDatabaseEntities1 mvcdata = new MVCDatabaseEntities1();
        public ActionResult Index()
        {
          
            List<Trainee> trainee = mvcdata.Trainees.ToList();
            return View(trainee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tid,tname,tcity,deptid,domain")] Trainee trainee)
        {
            if(ModelState.IsValid)
            {
                mvcdata.Trainees.Add(trainee);
                mvcdata.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            Trainee trainee = mvcdata.Trainees.Find(id);
            return View(trainee);
        }
        
        public ActionResult Edit(int? id)
        {
            Trainee trainee = mvcdata.Trainees.Find(id);
            return View(trainee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tid,tname,tcity,deptid,domain")]Trainee trainee)
        {
            if(ModelState.IsValid)
            {
                mvcdata.Entry(trainee).State = System.Data.Entity.EntityState.Modified;
                mvcdata.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            Trainee trainee = mvcdata.Trainees.Find(id);
            mvcdata.Trainees.Remove(trainee);
            mvcdata.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}