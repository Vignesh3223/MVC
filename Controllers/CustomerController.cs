using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Task_2208.Models;

namespace Task_2208.Controllers
{
    //Route Prefix
    [RoutePrefix("route")]
    public class CustomerController : Controller
    {
        static IList<Customer> customer = new List<Customer>()
        {
            new Customer() { Id = 1, Name = "Arun", City = "Gudalur"},
            new Customer() { Id = 2, Name = "Sharon", City = "Coimbatore"}
        };
       
        [HttpGet]
        [Route("~/route/{id}")] 
        //https://localhost:44370/route
        public ActionResult Index(int id)
        {
            if (id == 1)
            {
                return View(customer);
            }
            else
            {
                return Content("I am a CustomerController");
            }
        }
        
        [Route("controller/{id}/details")]
        //https://localhost:44370/Customer/Index
        public ActionResult Index1(int id)
        {
            return Content("Routing Parameter id : " + id);
        }

        [Route("~/Customer/Index2/{Name:alpha:length(4,16)}")]
        public ActionResult Index2(string Name)
        {
            return Content("<h1> Entered Name : " + Name.ToString() + "</h1>");
        }

        [Route("~/Customer/Index3/{value:bool}")]
        public ActionResult Index3( Boolean value)
        {
            return Content("<h1> Result : " + value + "</h1>");
        }

        [Route("~/Customer/Index4/{dob:datetime}")]
        public ActionResult Index4(DateTime dob)
        {
            return Content("<h1> Your Date of Birth : " + dob + "</h1>");
        }

        [Route("~/Customer/Index5/{x:regex(^[A-Za-z0-9]+$)}")]
        public ActionResult Index5(string x)
        {
            return Content("<h1> Regular Expression Field : " + x + "</h1>");
        }
    }
}