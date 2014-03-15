using AESApplications.AppServiceReference;
using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class ReferencesController : Controller
    {
        //
        // GET: /References/
        public ActionResult Index()
        {
            var model = new List<ReferenceModel>();
            for (int i = 0; i < 3; i++)
            {
                model.Add(new ReferenceModel());
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Index(List<ReferenceModel> model)
        {
            if (ModelState.IsValid)
            {
                bool referencesStored = false;
                using (var client = new AppServiceClient())
                {
                    client.Open();
                    var references = new List<Reference>();
                    foreach (var refer in model)
                    {
                        var temp = new Reference();
                        temp.applicantId = Convert.ToInt32(this.Session["ApplicantId"]);
                        temp.company = refer.company;
                        temp.name = refer.name;
                        temp.phone = refer.phone;
                        temp.title = refer.title;
                        references.Add(temp);
                    }
                    referencesStored = await client.storeReferencesAsync(references.ToArray());
                    client.Close();
                }
                if (referencesStored/**true**/)
                    return RedirectToAction("Index", "ESignature");
                else
                {
                    //error has occured storing references.
                }
            }
            return View(model);
        }
	}
}