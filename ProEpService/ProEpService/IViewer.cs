using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ProEpService
{
    [ServiceContract(Namespace = "ProEpService", CallbackContract = typeof(IViewerCallback))]
    public interface IViewer
    {
        [OperationContract]
        List<Post> ViewPosts();

        [OperationContract]
        void ViewerSignIn(string username);

        [OperationContract]
        void ViewerSignOut(string username);
    }

    public interface IViewerCallback
    {
        [OperationContract]
        void UpdatePosts(List<Post> updatedList);
    }
}
