using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class LocalJobsController : Controller
    {
        //
        // GET: /LocalJobs/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getJobs()
        {
           
            return new RedirectResult("/PersonalInfo/Index");
        }
	}
}