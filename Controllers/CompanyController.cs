using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2108.Models;

namespace Task_2108.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Compnay
        static IList<Company> comp = new List<Company>()
        {
            new Company() 
            {
            CompanyName = "CG-VAK Software & Exports Pvt.Ltd",
            CompanyDescription = "CG- VAK is a Solution Provider and a Service based Company.",
            CompanyPhone = "0422-2428487",
            CompanyEmail = "sales@cgvak.com",
            CompanyAddress = "Vellakinar Pirivu,\r\nCoimbatore 641029, India."
            }
        };
        public ActionResult Index()
        {
            return View(comp);
        }
    }
}