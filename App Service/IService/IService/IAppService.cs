using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IService
{
    [ServiceContract(Namespace = "http://localhost:8000")]  //Set up and change the XML Namespace
    public interface IAppService
    {
        /// <summary>
        /// Get all the job openings for a particular store.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of jobs available for that store ID, never NULL, may be empty list</returns>
        [OperationContract]
        List<object /*replace with formal type "JobEntity?"*/> GetLocalJobs(int storeId);

        /// <summary>
        /// Compiles a set of pre-screen questions based on the job id numbers passed,  Each question must be unique.
        /// </summary>
        /// <param name="composite"></param>
        /// <returns>A List of Question objects, must not return NULL, list can be empty</returns>
        [OperationContract]
        List<object/*replace with formal type "QuestionEntity?"*/> GetQuestions(List<int> jobIds);

        /// <summary>
        /// Stores the personal infomation object sent in the database / must be the first section stored, the others require the id
        /// </summary>
        /// <param name="info">Must match the pattern for PersonalInfo table</param>
        /// <returns>aplicant id number returns 0 if fails to add record</returns>
        [OperationContract]
        int StorePersonalInfo(object/*replace with formal type "PersonalInfoEntity?*/ personalInfo);

        /// <summary>
        /// Stores the job historys sent in list form into the database
        /// </summary>
        /// <param name="info">Each jobHistory must match the pattern for JobHistory table / idNum must match an existion applicant id</param>
        /// <returns>true if successful or false</returns>
        [OperationContract]
        Boolean StoreJobHistory(List<object>/*replace with formal type "JobHistoryEntity?*/histories, int idNum );

        /// <summary>
        /// Stores the list of education items in the database using the applicants id number;
        /// </summary>
        /// <param name="info">Each item must match the pattern for Education table / idNum is the applicants idNum</param>
        /// <returns>true if successful or false</returns>
        [OperationContract]
        Boolean StoreEducation(List<object>/*replace with formal type "EducationEntity?*/ education, int idNum);

        /// <summary>
        /// Stores the list of reference items in the database using the applicants id number;
        /// </summary>
        /// <param name="info">Each item must match the pattern for Reference table / idNum is the applicants idNum</param>
        /// <returns>true if successful or false</returns>
        [OperationContract]
        Boolean StoreReferences(List<object>/*replace with formal type "EducationEntity?*/ references, int idNum);

        /// <summary>
        /// Stores the job history object sent in the database
        /// </summary>
        /// <param name="info">Must match the pattern for JobHistory table</param>
        /// <returns></returns>
        [OperationContract]
        Boolean StoreReferences(List<object>/*replace with formal type "ReferenceEntity?*/ references);

        /// <summary>
        /// Gets the items needed for a personal information form (full form)
        /// </summary>
        /// <returns>A list of attributes and data types in the PersonalInfo table, must not return NULL or empty list</returns>
        [OperationContract]
        List<KeyValuePair<String, Type>> GetPersonalInfoForm();

        /// <summary>
        /// Gets the items needed for a job history form (single past job)
        /// </summary>
        /// <returns>A list of attributes and data types in the JobHistory table, never NULL, never Empty List</returns>
        [OperationContract]
        List<KeyValuePair<String, Type>> GetJobHistoryForm();

        /// <summary>
        /// Gets the items needed for a education form.  (Single school)
        /// </summary>
        /// <returns>A list of attributes and data types in the Education table, never NULL, never Empty List</returns>
        [OperationContract]
        List<KeyValuePair<String, Type>> GetEducationForm();

        /// <summary>
        /// Gets the items needed for a references form (single reference)
        /// </summary>
        /// <returns>A list of attributes and data types in the Reference table, never NULL, never Empty List</returns>
        [OperationContract]
        List<KeyValuePair<String, Type>> GetReferencesForm();
    }
}
