using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ProEpService
{
    [ServiceContract]
    public interface IRegister
    {
        [OperationContract]
        int Register(string username, string password, string name, string city, string email);
    }
}
