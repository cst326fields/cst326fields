using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IService
{
    // Implement the IService interface here
    public class AppService : IAppService
    {
        public List<object> GetLocalJobs(int storeId)
        {
            throw new NotImplementedException();
        }

        public List<object> GetQuestions(List<int> jobIds)
        {
            throw new NotImplementedException();
        }

        public int StorePersonalInfo(object personalInfo)
        {
            throw new NotImplementedException();
        }

        public bool StoreJobHistory(List<object> histories, int idNum)
        {
            throw new NotImplementedException();
        }

        public bool StoreEducation(List<object> education, int idNum)
        {
            throw new NotImplementedException();
        }

        public bool StoreReferences(List<object> references, int idNum)
        {
            throw new NotImplementedException();
        }

        public bool StoreReferences(List<object> references)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<string, Type>> GetPersonalInfoForm()
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<string, Type>> GetJobHistoryForm()
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<string, Type>> GetEducationForm()
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<string, Type>> GetReferencesForm()
        {
            throw new NotImplementedException();
        }
    }
}
