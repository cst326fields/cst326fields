using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(List<JobHistoryModel> model)
        {
            if (ModelState.IsValid)
            {
                //save the form here
                return RedirectToAction("Index", "Education");
            }
            return View(model);
        }
	}
}