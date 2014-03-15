using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<ActionResult> ApplicationFinished()
        {
            bool signatureStored = false;
            using (var client = new AppServiceClient())
            {
                client.Open();
                var sig = new ElectronicSig();
                sig.date = new DateTime();
                sig.signature = (string)this.Session["ApplicantId"];
                signatureStored = await client.storeElectronicSigAsync(sig);
                client.Close();
            } 
            if (signatureStored/**true**/)
                return RedirectToAction("Index", "PhoneScreen");
            else
            {
                //error in storing signature
            }
        }
	}
}