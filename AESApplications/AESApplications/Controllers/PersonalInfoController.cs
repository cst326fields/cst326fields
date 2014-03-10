using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(PersonalInfoModel model)
        {
            if (ModelState.IsValid)
            {
                //call the service to save the info here.
                return RedirectToAction("Index", "JobHistory");
            }

            return View(model);
        }
	}
}