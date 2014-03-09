using AESApplications.Test;
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
            var fakeServ = new FakeService();
            List<Job> jobs = fakeServ.getLocalJobs(Convert.ToInt32(this.Session["storeId"]));

            return View(jobs);
        }
    }
}