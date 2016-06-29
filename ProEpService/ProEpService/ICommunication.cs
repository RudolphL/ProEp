using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProEpService
{
    [ServiceContract]
    interface ICommunication
    {
        [OperationContract]
        bool SendMsg(Message msg);
    }
}
