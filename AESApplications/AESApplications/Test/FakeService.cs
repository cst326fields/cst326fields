using AESApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AESApplications.Test
{
    public class FakeService
    {
        public List<JobModel> getLocalJobsTest(int storeid)
        {
            var allJobs = new List<JobModel>();
            var job1 = new JobModel();
            var job2 = new JobModel();
            var job3 = new JobModel();

            job1.jobId = 1;
            job1.title = "Cashier";
            job1.location = "Portland, OR";
            job1.description = "Department store cashiers perform a wide range of job duties. Key responsibilities include completing customer transactions and handling money. Cashiers at large department stores may work exclusively on the cash register. At other stores, cashiers may perform a number of additional responsibilities, including processing returns, answering phones, wrapping gifts, assisting customer on the sales floor, bagging purchases, and signing members up for rewards cards. Department store cashiers should demonstrate knowledge of store sales and promotions. Additionally, department stores require cashiers to understand and follow all loss prevention policies. Most department stores offer paid training in order to acquaint new-hire cashiers with job duties and company polices.";
            job1.hours = "Mon - Fri, 6:00am to 5:00pm";
            job1.education = "High School Diploma";
            job1.requirements = "In jobs centered on interacting with customers, department store cashiers must display a friendly, helpful attitude. During stressful situations and busy shopping seasons, cashiers must remain calm and professional. Additional qualities cashiers should possess include basic mathematic, communication, and computer skills. Most department stores set the minimum age requirements for cahiers at 16 years old. For entry-level cashier jobs, employers generally do not require previous retail or other work experience.";

            job2.jobId = 2;
            job2.title = "Stock Clerk";
            job2.location = "Hillsbor, OR";
            job2.description = "As the name implies, a stock clerk, sometimes called a stocker or stock associate, fills or properly displays merchandise on the department store sales floor. Stockers usually need to put out merchandise in accordance with a specific design. Stock associates may also interact with customers on a regular basis and help store patrons find a particular product or a suitable alternative. Stock clerks often complete a variety of tasks, including display setup, inventory tracking, and general product upkeep.";
            job2.hours = "Mon - Sat, 2:00am to 8:00am";
            job2.education = "High School Diploma";
            job2.requirements = "To be an effective stock associate, a worker must be able to strive under minimal supervision. Most stores give stockers a general outline of what needs to be done and leave stock employees to fill in the blanks. Because of the physical nature of stock clerk positions, employees should be able to move and lift a certain amount of weight with relative ease. Many department stores use various tools and equipment for stockers to do jobs more effectively. Most importantly, a stock clerk must possess good customer service skills, since customer interaction also represents a part of the job. Most department stores set the minimum age requirement for stocking or receiving jobs at 18 years old. Typically, stores require no educational qualifications or work experience for stocking positions.";

            job3.jobId = 3;
            job3.title = "Sales Assosiate";
            job3.location = "Beaverton, OR";
            job3.description = "Responsible for maintaining excellent customer relations, sales associates generate sales, organize merchandise, and provide an overall friendly environment for both customers and employees. Typically, sales associates keep track of the sales floor and decide whether to stock shelves, check inventory, or assist customers in finding a particular product. Sales employees must be aware of any promotional deals or other marketing strategies that may increase profitability for the store. Completing the whole customer transaction, sales associates often ring up customers with final sales.";
            job3.hours = "Mon - Fri, 9:00am to 5:00pm";
            job3.education = "Assosiates Degree";
            job3.requirements = "Sales associate jobs require only a few main skills. Above all, a sales associate must possess excellent customer service skills and be capable of fully satisfying customer needs. Salespersons must also effectively communicate with fellow store associates. In general, sales associate must also be able to read, write, and count accurately to complete orders and other documentation. Beyond these meager requirements, most department stores reserve no educational or work-related qualifications for sales associate positions. Some department stores may require sales associates to meet certain physical needs, such as the ability to lift equipment and merchandise of various weights.";

            switch (storeid)
            {
                case 1:
                    allJobs.Add(job1);
                    break;
                case 2:
                    allJobs.Add(job2);
                    allJobs.Add(job3);
                    break;
                case 3:
                    allJobs.Add(job3);
                    allJobs.Add(job2);
                    allJobs.Add(job1);
                    break;
                default:
                    break;
            }
            return allJobs;
        }

        public List<FakeQuestion> getQuestionsTest(List<int> jobIds)
        {
            var allQuestions = new List<FakeQuestion>();
            var q1 = new FakeQuestion();
            var q2 = new FakeQuestion();

            q1.question = "Can you lift over 25 pounds on a regular basis?";
            q1.correctAnswer = "Yes";
            q2.question = "Can you work on weekends?";
            q2.correctAnswer = "Yes";

            allQuestions.Add(q1);
            allQuestions.Add(q2);

            return allQuestions;
        }

        public int storePersonalInfoTest(object personalInfo)
        {
            return 321;
        }

        public bool storeJobHistoryTest(object jobHistory)
        {
            return true;
        }

        public bool storeEducationTest(object education) 
        {
            return true;
        }

        public bool storeReferencesTest(object references)
        {
            return true;
        }

        public bool finalizeApplicationTest(object eSignature)
        {
            return true;
        }

        public string getPhoneScreenInstructionsTest(int applicantId)
        {
            return "please dial 1-800-1TO-HIRE";
        }
    }
}