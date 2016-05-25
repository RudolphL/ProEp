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
        int Login(string playername, string password);

        [OperationContract]
        String RecoverPassword(string email);

        [OperationContract]
        int CreateAccount(string firstname, string lastname, string playername, string email, string password);
    }
}
