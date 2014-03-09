using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(List<EducationModel> model)
        {
            if (ModelState.IsValid)
            {
                //save the form here
                return RedirectToAction("Index", "References");
            }
            return View(model);
        }
	}
}