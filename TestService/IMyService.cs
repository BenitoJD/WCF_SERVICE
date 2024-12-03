using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();
    }
}
