using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartLibrary2.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            var loginStatus = "";
            var login = Request.QueryString["login"];
            var password = Request.QueryString["pass"];
            if ((login =="admin") && (password=="abc123!"))
            {
                loginStatus = "OK";
            }
            else
            {
                loginStatus = "Invalid login name or password";
            }
            ViewBag.Status = loginStatus;

            return View();
        }
        [HttpPost]
        public ActionResult Register(string loginid,string password)
        {
            var loginStatus = "";
            if ((loginid == "admin") && (password == "abc123!"))
            {
                loginStatus = "OK";
            }
            else
            {
                loginStatus = "Invalid login name or password";
            }
            ViewBag.Status = loginStatus;

            return View();
        }
        public ActionResult Hi(int id)
        {

            return Content("Say hi from controller - " + id.ToString());
        }
        public ActionResult SayHello()
        {
            return View();
        }
        public ActionResult GoodBye()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}