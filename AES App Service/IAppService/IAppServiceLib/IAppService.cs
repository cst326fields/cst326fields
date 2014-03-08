using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IAppServiceLib
{
    [ServiceContract]
    public interface IAppService
    {
        [OperationContract]
        List<Job> getJobs(int storeId);
        [OperationContract]
        Store getStoreInfo(int storeId);
    }

    [DataContract]
    public class Job
    {
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
}
