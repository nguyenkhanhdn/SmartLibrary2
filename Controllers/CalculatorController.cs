using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartLibrary2.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calculate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(double a, char op, double b)
        {
            if (op == '+')
            {
                ViewBag.Ketqua = a + b;
            }else if (op == '-')
            {
                ViewBag.Ketqua = a - b;
            }else if (op == '*')
            {
                ViewBag.Ketqua = a * b;
            }
            else
            {
                ViewBag.Ketqua = a / b;
            }    
            return View("Index");
        }
    }
}