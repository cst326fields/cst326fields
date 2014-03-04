using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class ApplicationController : Controller
    {
        //
        // GET: /Application/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LocalJobs()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PersonalInfo()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult JobHistory()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult References()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ESignature()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
	}
}