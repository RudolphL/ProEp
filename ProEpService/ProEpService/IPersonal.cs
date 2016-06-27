using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ProEpService
{
    [ServiceContract]
    interface IPersonal
    {
        [OperationContract]
        List<Post> GetUserPosts(string username);

        [OperationContract(IsOneWay = true)]
        void DeleteUserPost(string username, int postId);
    }
}
