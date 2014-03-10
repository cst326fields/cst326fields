using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(List<ReferenceModel> model)
        {
            if (ModelState.IsValid)
            {
                //save the form here
                return RedirectToAction("Index", "ESignature");
            }
            return View(model);
        }
	}
}