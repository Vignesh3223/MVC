using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2208.Models;

namespace Task_2208.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            string name = "James";
            string password = "James@123";
            TempData["name"] = name;
            TempData["password"] = password;

            if (TempData.ContainsKey("name") && TempData.ContainsKey("password"))
            {
                ViewBag.Name = TempData["name"];
                ViewBag.Password = TempData["password"];
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}