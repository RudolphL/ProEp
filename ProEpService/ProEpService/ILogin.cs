using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProEpService
{
    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        int Register(string username, string password, string name, string city, string email);

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        bool RecoverPassword(string email);
    }
}
