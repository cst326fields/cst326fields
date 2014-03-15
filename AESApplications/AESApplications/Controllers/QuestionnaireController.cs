using AESApplications.Models;
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
        public async Task<ActionResult> Index(FormCollection fc )
        {
            List<QuestionModel> questions;
            List<int> ids = new List<int>();
            for (int i = 1; i < fc.Count; i++ )
            {
                 ids.Add(Convert.ToInt32(fc.Keys.Get(i)));
            }
            if (ids.Count < 1)
                return RedirectToAction("Index", "LocalJobs")
            var fakeServ = new FakeService();  //test code 
            //questions = fakeServ.getQuestionsTest(ids);  //test code

            using (var client = new AppServiceClient())
            {
                var tempQuestions = await client.getQuestionsAsync(ids.ToArray());
                foreach (var question in tempQuestions)
                {
                    var tempQuestion = new QuestionModel();
                    tempQuestion.question = question.theQuestion;
                    tempQuestion.correctAnswer = question.theAnswer;
                    questions.Add(tempQuestion);
                }
            }
            return View(questions);
        }

        [HttpPost]
        public ActionResult CheckQuestions(List<FakeQuestion> questionnair)
        {
            bool questionFailed = false;
            foreach (var question in questionnair)
            {
                if (question.correctAnswer.CompareTo(question.response) != 0)
                    questionFailed = true;
            }
            if (questionFailed) {
                return RedirectToAction("Fail", "Questionnaire"); 
            }
            return RedirectToAction("Index","PersonalInfo");
        }

        public ActionResult Fail() 
        {
            return View();
        }
    }
}












     