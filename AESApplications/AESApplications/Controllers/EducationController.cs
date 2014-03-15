using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class EducationController : Controller
    {
        //
        // GET: /Education/
        public ActionResult Index()
        {
            var model = new List<EducationModel>();
            for (int i = 0; i < 3; i++)
            {
                model.Add(new EducationModel());
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Index(List<EducationModel> model)
        {
            if (ModelState.IsValid)
            {
                bool educationStored = false;
                /**
                using (var client = new AppServiceClient())
                {
                    client.Open();
                    var education = new List<Education>();
                    foreach (var ed in model)
                    {
                        var temp = new Education();
                        temp.applicantId = Convert.ToInt32(this.Session["ApplicantId"]);
                        temp.degreeMajor = ed.degree;
                        temp.graduated = ed.graduated;
                        temp.nameAddress = ed.name_address;
                        temp.yearsAttended = ed.years_attended;
                        education.Add(temp);
                    }
                    educationStored = await client.storeEducationsAsync(education.ToArray());
                    client.Close();
                } **/
                if (/**educationStored**/ true)
                    return RedirectToAction("Index", "References");
                else
                {
                    //error occured storing education 
                }
            }
            return View(model);
        }
	}
}