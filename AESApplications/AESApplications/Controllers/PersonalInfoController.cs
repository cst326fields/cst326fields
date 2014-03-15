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
    public class PersonalInfoController : Controller
    {
        //
        // GET: /PersonalInfo/
        public ActionResult Index()
        {
            return View(new PersonalInfoModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(PersonalInfoModel model)
        {
            if (ModelState.IsValid)
            {  
                using (var client = new AppServiceClient())
                {
                    client.Open();
                    var personalInfo = new PersonalInfo();
                    personalInfo.firstName = model.name_first;
                    personalInfo.middleName = model.name_middle;
                    personalInfo.lastName = model.name_last;
                    personalInfo.alias = model.name_alt;
                    personalInfo.address = new StringBuilder(model.street + " " + model.city + ", " + model.state + " " + model.zip).ToString();
                    personalInfo.Phone = model.phone_num;
                    personalInfo.socialNum = model.ssn;
                    this.Session["ApplicantID"] = await client.storePersonalInfoAsync(personalInfo);
                    client.Close();
                } 
                if (this.Session["ApplicantId"] != null/** true**/)
                {
                    return RedirectToAction("Index", "JobHistory");
                }
                else
                {
                    //error has occured storing personal info-- add error page ??? currently will go back to personalInfo view
                }
            }

            return View(model);
        }
	}
}