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
            List<int> ids = new List<int>();
            foreach (string fd in fc)
            {
                //add ids to list
            } 
            //call service and get questions model
            //fake model
            List<string> questions = new List<string>(); //fake job listings
            for (int i = 0; i < 4; i++)
            {
                questions.Add("Question 1 " + i.ToString());
            }

            return View(questions);
        }

        [HttpPost]
        public ActionResult CheckQuestions(FormCollection fc)
        {

            return RedirectToAction("Index","PersonalInfo");
        }
        
    }
}












     