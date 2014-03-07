using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //service call to get list of local jobs heres//
            List<string> jobs = new List<string>(); //fake job listings
            for(int i = 0; i < 4; i++) {
                jobs.Add("Job listing " + i.ToString());
            }

            return View(jobs);
        }
    }
}