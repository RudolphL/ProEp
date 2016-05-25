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
        // use for register the code will use DatabaseHelper classes and then check and then regis
        [OperationContract]
        bool Register(string username, string password, string name, string city);


    }
}
