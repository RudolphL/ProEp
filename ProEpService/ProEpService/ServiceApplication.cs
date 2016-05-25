using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProEpService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceApplication : ILogin, IRegister
    {
        public int Login(string playername, string password)
        {
            throw new NotImplementedException();
        }

        public string RecoverPassword(string email)
        {
            throw new NotImplementedException();
        }

        public int CreateAccount(string firstname, string lastname, string playername, string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string username, string password, string name, string city)
        {
            throw new NotImplementedException();
        }
    }
}
