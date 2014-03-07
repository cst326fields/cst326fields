using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            //ViewBag.RightButtonLink = "/LocalJobs/Index";
            return View();
        }
    }
}