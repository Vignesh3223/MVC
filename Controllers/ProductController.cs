using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_1708.Models;

namespace Task_1708.Controllers
{
    public class ProductController : Controller
    {
        static IList<Product> items = new List<Product>
        {
            //new Product() { PId = 1, PName = "FootBall", PQty = 2, PPrice = 3000, ManDate = new DateTime(2022,10,23) },
            //new Product() { PId = 2, PName = "HandBall", PQty = 3, PPrice = 4800, ManDate = new DateTime(2020,07,15) },
            //new Product() { PId = 3, PName = "ThrowBall", PQty = 2, PPrice = 2800, ManDate = new DateTime(2021,12,04) }
        };
        // GET: Product
        public ActionResult Index()
        {
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p)
        {
            if(ModelState.IsValid)
            {
                items.Add(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var p = items.Where(a => a.PId == Id).FirstOrDefault();
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            var product = items.Where(a => a.PId == p.PId).FirstOrDefault();
            items.Remove(product);
            items.Add(p);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            var p = items.Where(a => a.PId == Id).FirstOrDefault();
            return View(p);
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var p = items.Where(a => a.PId == Id).FirstOrDefault();
            items.Remove(p);

            return RedirectToAction("Index");
        }
    }
}