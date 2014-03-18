using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class AppService : IAppService
    {
        public List<Job> getJobs(int storeId)
        {
            List<Job> jobs = new List<Job>();

            using (AESDatabaseEntities context = new AESDatabaseEntities())
            {
                var location = (from l in context.Stores where storeId == l.storeId select l).First<Store>();   //To get the store city related to the storeID passed in.

                string cityState = new StringBuilder(location.city + ", " + location.stateAbbreviation).ToString();
                
                var city = (from c in context.AvailablePositions where storeId == c.storeId select c);

                foreach (var p in city)
                {
                    var temp = new Job();
                    temp.jLocation = cityState;     //Added this for store city
                    temp.jTitle = p.Position.title;
                    temp.jDescription = p.Position.description;
                    temp.jPay = p.Position.pay;
                    temp.jDays = p.workingDays;
                    temp.jAvailPosId = p.availablePosId;
                    jobs.Add(temp);
                }
                return jobs;
            }
        }

        public Store getStoreInfo(int storeId)
        {
            Store aStore = new Store();
            using (AESDatabaseEntities context = new AESDatabaseEntities())
            {
                var store = (from p in context.Stores where storeId == p.storeId select p);

                foreach (var x in store)
                {
                    aStore.name = x.name;
                    aStore.address = x.address;
                    aStore.city = x.city;
                    aStore.stateAbbreviation = x.stateAbbreviation;
                }
                return aStore;
            }
        }

        public List<Question> getQuestions(List<int> positionIds)
        {
            if (positionIds == null)
                return null;

            List<Question> questions = new List<Question>();

            using (AESDatabaseEntities context = new AESDatabaseEntities())
            {
                foreach(int id in positionIds)
                {
                    var question = (from q in context.Questionaires where q.positionId == id group q by new { q.Question } into g select g).ToList();

                    foreach(var x in question)
                    {
                        bool addme = true;
                        Question temp = new Question();
                        temp.theQuestion = x.Key.Question.theQuestion;
                        temp.theAnswer = x.Key.Question.theAnswer;
                        foreach (var ques in questions)
                        {
                            if (temp.theQuestion.CompareTo(ques.theQuestion) == 0)
                            {
                                addme = false;
                            }
                        }
                        if (addme)
                            questions.Add(temp);
                    }
                }
            }
                return questions;
        }

        public int storePersonalInfo(PersonalInfo personalInfo)
        {
            int appId;
            PersonalInfo temp = new PersonalInfo();
            temp.address = personalInfo.address;
            temp.alias = personalInfo.alias;
            temp.firstName = personalInfo.firstName;
            temp.lastName = personalInfo.lastName;
            temp.middleName = personalInfo.middleName;
            temp.Phone = personalInfo.Phone;
            temp.socialNum = personalInfo.socialNum;

            //temp.address = "address";
            //temp.alias = "john boy";
            //temp.firstName = "Dustin";
            //temp.lastName = "falgsomething";
            //temp.middleName = "no idea";
            //temp.Phone = "1800suckit";
            //temp.socialNum = "123456789";
            try
            {
                using (AESDatabaseEntities context = new AESDatabaseEntities())
                {
                    context.PersonalInfoes.Add(temp);
                    context.SaveChanges();
                    appId = (from p in context.PersonalInfoes select p.applicantId).First();
                    
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return appId;
        }

        public bool storeEducations(List<Education> educations)
        {
            bool result = true;

            if (educations == null)
                return false;

            foreach (var education in educations)
            {
                if (education.nameAddress != null)
                {
                    Education temp = new Education();
                    temp.applicantId = education.applicantId;
                    temp.degreeMajor = education.degreeMajor;
                    temp.yearsAttended = education.yearsAttended;   //Added this to add the years attended
                    temp.graduated = education.graduated;
                    temp.nameAddress = education.nameAddress;

                    try
                    {
                        using (AESDatabaseEntities context = new AESDatabaseEntities())
                        {
                            context.Educations.Add(temp);
                            context.SaveChanges();

                        }
                    }
                    catch (Exception)
                    {
                        result = false;
                    }
                    temp = null;
                }
            }
            return result;
        }

        public bool storeJobHistory(List<JobHistory> jobHistorys)
        {
            bool result = true;

            if (jobHistorys == null)
                return false;

            foreach (var jobHistory in jobHistorys)
            {
                if (jobHistory.employer != null)
                {
                    JobHistory temp = new JobHistory();
                    temp.applicantId = jobHistory.applicantId;
                    temp.address = jobHistory.address;
                    temp.duties = jobHistory.duties;
                    temp.employer = jobHistory.employer;
                    temp.endSalary = jobHistory.endSalary;
                    temp.from = jobHistory.from;
                    temp.to = jobHistory.to;
                    temp.phone = jobHistory.phone;
                    temp.supervisor = jobHistory.supervisor;
                    temp.reasonLeave = jobHistory.reasonLeave;
                    temp.startSalary = jobHistory.startSalary;
                    temp.position = jobHistory.position;

                    try
                    {
                        using (AESDatabaseEntities context = new AESDatabaseEntities())
                        {
                            context.JobHistories.Add(temp);
                            context.SaveChanges();

                        }
                    }
                    catch (Exception)
                    {
                        result = false;
                    }
                    temp = null;
                }
            }
            return result;
        }

        public bool storeReferences(List<Reference> references)
        {
            bool result = true;

            if (references == null)
                return false;

            foreach(var reference in references)
            {
                if (reference.name != null)
                {
                    Reference temp = new Reference();
                    temp.applicantId = reference.applicantId;
                    temp.company = reference.company;
                    temp.name = reference.name;
                    temp.phone = reference.phone;
                    temp.title = reference.title;


                    try
                    {
                        using (AESDatabaseEntities context = new AESDatabaseEntities())
                        {
                            context.References.Add(temp);
                            context.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        result = false;
                    }

                    temp = null;
                }
            }
            return result;
        }

        public bool storeElectronicSig(ElectronicSig electronicSig)
        {
            bool result = true;

            if (electronicSig == null)
                return false;

            ElectronicSig temp = new ElectronicSig();
            temp.applicantId = electronicSig.applicantId;
            temp.date = electronicSig.date;
            temp.signature = electronicSig.signature;

            try
            {
                using (AESDatabaseEntities context = new AESDatabaseEntities())
                {
                    context.ElectronicSigs.Add(temp);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public ApplicantApp getApplication(int appId)
        {
            ApplicantApp a = new ApplicantApp();

            PersonalInfo p = new PersonalInfo();
            JobHistory j = new JobHistory();
            Education e = new Education();
            Reference r = new Reference();

            using (AESDatabaseEntities context = new AESDatabaseEntities())
            {
                p = (from per in context.PersonalInfoes where per.applicantId == appId select per).First();
                j = (from jo in context.JobHistories where jo.applicantId == appId select jo).First();
                e = (from ed in context.Educations where ed.applicantId == appId select ed).First();
                r = (from re in context.References where re.applicantId == appId select re).First();
            }
            a.personalInfo = p;
            a.jobHistory = j;
            a.education = e;
            a.reference = r;

            return a;
        }

    }    
}
