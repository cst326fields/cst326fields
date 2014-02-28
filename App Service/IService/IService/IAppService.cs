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
        //Example of how to interface service methods "operations"
        [OperationContract]
        string GetData(int value);

        //Look into CompositeType operations
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "IService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
