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
            return View(/*put questions model here*/);
        }
        
    }
}












     