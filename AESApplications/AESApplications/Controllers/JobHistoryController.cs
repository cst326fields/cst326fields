using AESApplications.AppServiceReference;
using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class JobHistoryController : Controller
    {
        //
        // GET: /JobHistory/
        public ActionResult Index()
        {
            var model = new List<JobHistoryModel>();
            for (int i = 0; i < 3; i++)
            {
                model.Add(new JobHistoryModel());
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Index(List<JobHistoryModel> model)
        {
            if (ModelState.IsValid)
            {
                bool historyStored = false;
                using (var client = new AppServiceClient())
                {
                    client.Open();
                    var history = new List<JobHistory>();
                    foreach (var jobHistory in model)
                    {
                        int tempYear;
                        int tempMonth;
                        var jobHist = new JobHistory();
                        jobHist.address = new StringBuilder(jobHistory.street + " " + jobHistory.city + ", " + jobHistory.state + " " + jobHistory.zip).ToString();
                        jobHist.applicantId = Convert.ToInt32(this.Session["ApplicantId"]);
                        jobHist.duties = jobHistory.responsibilities;
                        jobHist.employer = jobHistory.employer;
                        jobHist.endSalary = jobHistory.salary_end;
                        if (jobHistory.from_year != null && jobHistory.from_month != null)
                        {
                            tempYear = Convert.ToInt32(jobHistory.from_year);  //add validation for valid year
                            tempMonth = Convert.ToInt32(jobHistory.from_month); //add validation for valid month
                            jobHist.from = new DateTime(tempYear, tempMonth, 1);
                            tempYear = Convert.ToInt32(jobHistory.to_year);  //add validation for valid year
                            tempMonth = Convert.ToInt32(jobHistory.to_month); //add validation for valid month
                            jobHist.to = new DateTime(tempYear, tempMonth, 1);
                        }
                        else
                        {
                            jobHist.to = null;
                            jobHist.from = null;
                        }
                        jobHist.phone = jobHistory.phone;
                        jobHist.position = jobHistory.position;
                        jobHist.reasonLeave = jobHistory.reason_for_leaving;
                        jobHist.startSalary = jobHistory.salary_start;
                        jobHist.supervisor = jobHistory.supervisor;
                        history.Add(jobHist);
                    }
                    historyStored = await client.storeJobHistoryAsync(history.ToArray());
                    client.Close();
                }
                if (historyStored/**true**/)
                    return RedirectToAction("Index", "Education");
                else
                {
                    //error in storing history... add error view or determine action??
                }
            }
            return View(model);
        }
	}
}