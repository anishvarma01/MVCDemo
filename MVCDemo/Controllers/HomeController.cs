using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        StudentEntities1 SE1 = new StudentEntities1();
        StudentEntities SE = new StudentEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDetails(int ID)
        {

            var Name = SE.StudentInfoes.Where(x => x.Id == ID).FirstOrDefault().Name;
            var Gender = SE.StudentInfoes.Where(x => x.Id == ID).FirstOrDefault().Gender;
            var Address = SE.StudentInfoes.Where(x => x.Id == ID).FirstOrDefault().Address;
            //ViewData["Name1"] = Name;
            //ViewData["Gender1"] = Gender;
            //ViewData["Address"] = Address;
            ViewBag.Name1 = Name;
            ViewBag.Gender1 = Gender;
            ViewBag.Address1 = Address;
            return View("Index");

        }

    }
}