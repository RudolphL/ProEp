using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ProEpService
{
    [ServiceContract(Namespace = "ProEpService", CallbackContract = typeof(IPortalCallback))]
    public interface IPortal
    {
        [OperationContract]
        List<Post> GetPosts();

        [OperationContract(IsOneWay = true)]
        void AddPost(string name, string author, double price, string isbn, string publisher, string bookCondition, string description, string title, string place, string username);

        [OperationContract]
        void SignIn(string username);

        [OperationContract]
        void SignOut(string username);
    }

    public interface IPortalCallback
    {
        [OperationContract]
        void NewPostAdded(List<Post> updatedList);
    }
}
