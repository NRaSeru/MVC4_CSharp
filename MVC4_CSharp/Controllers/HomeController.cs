using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_CSharp.Controllers
{
    public struct Customer
    {
        public string Name;
        public int Alter;
        public string EMail;
        public string Password;
    }

    public class HomeController : Controller
    {
        public static int Counter = 1;

        // GET: Home
        public ActionResult Index()
        {
            ViewData.Add(new KeyValuePair<string, object>("greetings", "Hallo from Asp.Net :)"));
            ViewData.Add(new KeyValuePair<string, object>("counter", Counter++));

            Customer Fabian = new Customer();
            Fabian.Alter = 32;
            Fabian.EMail = "nraseru@googlemail.com";
            Fabian.Name = "Fabian";
            Fabian.Password = "geheim";

            ViewBag.data = Fabian;

            return View();
        }

        public ActionResult Seite2()
        {
            ViewBag.Title = "Hello world";
            return View();
        }

        public ActionResult Seite3()
        {
            return View();
        }

        public ActionResult Testform()
        {

            return View();
        }
    }
}