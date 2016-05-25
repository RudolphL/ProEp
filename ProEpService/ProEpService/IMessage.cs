using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace ProEpService
{
    public class IMessage
    {
    [ServiceContract(Namespace = "myservice", CallbackContract = typeof(IupdateMessageCallback))]
        [OperationContract]
        void UpateMessageUnsubcribe();

        [OperationContract]
        void UpateMessageSubscribe();
    }


    public interface IupdateMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void updateMessage(List<string> messages);
    }
}

