﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class ESignatureController : Controller
    {
        //
        // GET: /ESignature/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ApplicationFinished()
        {
            //save the responce to esignature
            return RedirectToAction("Index", "PhoneScreen");
        }
	}
}