using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ProEpService
{
    [ServiceContract]
    interface IProfile
    {
        [OperationContract]
        string GetPassword(string username);

        [OperationContract]
        bool ChangePassword(string username, string password);
    }
}
