using AESApplications.Models;
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
        public async Task<ActionResult> Index()
        {
            //var fakeServ = new FakeService();  // test code
            //List<JobModel> jobs = fakeServ.getLocalJobsTest(Convert.ToInt32(this.Session["storeId"])); //test code

            using (var client = new AppServiceClient())
            {
                client.Open();
                var loadedJobs = await client.getJobsAsync(Convert.ToInt32(this.Session["storeId"]));
                var jobs = new List<JobModel>();
                foreach (var job in loadedJobs)
                {
                    var tempJob = new JobModel();
                    tempJob.jobId = job.jAvailPosId;
                    tempJob.hours = job.jDays;
                    tempJob.description = job.jDescription;
                    tempJob.title = job.jTitle;
                    tempJob.requirements = job.jPay; //change field to pay???
                    //Service is mising store location as a field.. theres no way to retrieve it with current methods / lack of store id for job
                    jobs.Add(tempJob);
                }
                client.Close();
            }
          
            return View(jobs);
        }
    }

}