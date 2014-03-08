using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}