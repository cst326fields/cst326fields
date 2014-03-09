using AESApplications.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AESApplications.Controllers
{
    public class QuestionnaireController : Controller
    {
         //
        // GET: /Questionnaire/
        [HttpPost]
        public ActionResult Index(FormCollection fc )
        {
            List<Question> questions;
            var fakeServ = new FakeService();

            List<int> ids = new List<int>();
            for (int i = 1; i < fc.Count; i++ )
            {
                 ids.Add(Convert.ToInt32(fc.Keys.Get(i)));
            }
            questions = fakeServ.getQuestions(ids);

            return View(questions);
        }

        [HttpPost]
        public ActionResult CheckQuestions(List<Question> questionnair)
        {
            bool questionFailed = false;
            if (questionFailed) {
                //fail questionnair response
            }
            return RedirectToAction("Index","PersonalInfo");
        }
        
    }
}












     