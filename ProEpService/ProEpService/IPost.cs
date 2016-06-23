using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProEpService
{
    [ServiceContract]
    public interface IPost
    {
        [OperationContract]
        bool AddPost(string name, string author, double price, string isbn, string publisher, string bookCondition, string description, string title, string place, string username);
    }
}
