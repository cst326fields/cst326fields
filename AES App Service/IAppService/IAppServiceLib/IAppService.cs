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
        string GetData(int value);
    }
}
