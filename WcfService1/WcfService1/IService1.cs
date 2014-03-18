using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IAppService
    {
        //Job is defined below in DataContract
        //input: int storeId
        //output: List<Job>
        [OperationContract]
        List<Job> getJobs(int storeId);

        //Store is defined in AESentity.tt->Store.cs
        //input: int storeId
        //output: Store
        [OperationContract]
        Store getStoreInfo(int storeId);

        //Question is defined in AESentity.tt->Question.tt
        //input: List<int> positionIds
        //output: List<Questions>
        [OperationContract]
        List<Question> getQuestions(List<int> positionIds);

        //PersonInfo is defined in AESentity.tt->PersonalInfo.tt
        //Will return int appId
        //input: PersonalInfo object
        //output: int appId used for linking Sections
        //if the operation fails, -1 will be returned
        [OperationContract]
        int storePersonalInfo(PersonalInfo personalInfo);

        //Education is defined in AESentity.tt->Education.tt
        //Will return int appId
        //input: List<Education> objects
        //output: boolean
        //false if operation fails, true if successful
        [OperationContract]
        bool storeEducations(List<Education> educations);

        //JobHistory is defined in AESentity.tt->JobHistory.tt
        //Will return int appId
        //input: List<JobHistory> objects
        //output: boolean
        //false if operation fails, true if successful
        [OperationContract]
        bool storeJobHistory(List<JobHistory> jobHistory);

        //Reference is defined in AESentity.tt->Reference.tt
        //Will return int appId
        //input: List<Reference> objects
        //output: boolean
        //false if operation fails, true if successful
        [OperationContract]
        bool storeReferences(List<Reference> reference);

        //ElectronicSig is defined in AESentity.tt->ElectronicSig.tt
        //Will return int appId
        //input: ElectronicSig object
        //output: boolean
        //false if operation fails, true if successful
        [OperationContract]
        bool storeElectronicSig(ElectronicSig electronicSig);

        [OperationContract]
        ApplicantApp getApplication(int appId);
    }

    //Defined to combine entities Position/AvailablePositions into Job entity
    [DataContract]
    public class Job
    {
        [DataMember]
        public string jLocation { get; set; }
        [DataMember]
        public string jTitle { get; set; }
        [DataMember]
        public string jDescription { get; set; }
        [DataMember]
        public string jPay { get; set; }
        [DataMember]
        public string jDays { get; set; }
        [DataMember]
        public int jAvailPosId { get; set; }
    }

    //Future need to retrieve an application for a person
    //Combines all the sections of the application into entity ApplicantApp
    [DataContract]
    public class ApplicantApp
    {
        [DataMember]
        public PersonalInfo personalInfo { get; set; }
        [DataMember]
        public Education education { get; set; }
        [DataMember]
        public JobHistory jobHistory { get; set; }
        [DataMember]
        public Reference reference { get; set; }
        [DataMember]
        public ElectronicSig electronicSig { get; set; }
    }

    //[DataContract]
    //public partial class JobHistory
    //{
    //    [DataMember]
    //    public string jemployer { get; set; }
    //    [DataMember]
    //    public DateTime jfrom { get; set; }
    //    [DataMember]
    //    public DateTime jto { get; set; }
    //    [DataMember]
    //    public string jstreet { get; set; }
    //    [DataMember]
    //    public string jcity { get; set; }
    //    [DataMember]
    //    public string jstate { get; set; }
    //    [DataMember]
    //    public string jzip { get; set; }
    //    [DataMember]
    //    public string jphone { get; set; }
    //    [DataMember]
    //    public string jsupervisor { get; set; }
    //    [DataMember]
    //    public string jposition { get; set; }
    //    [DataMember]
    //    public int japplicantId { get; set; }
    //    [DataMember]
    //    public string jduties { get; set; }
    //    [DataMember]
    //    public string jstartSalary { get; set; }
    //    [DataMember]
    //    public string jendSalary { get; set; }
    //    [DataMember]
    //    public string jreasonLeave { get; set; }
    //}
        
    //For all the other DataContracts, look inside 'applicant.tt' under 'Applicant.edmx'
    //They were auto generated from entity framework.
}
