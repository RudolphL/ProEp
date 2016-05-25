using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace ProEpService
{
    [ServiceContract(Namespace = "ProEpService", CallbackContract = typeof(IUpdateMessageCallback))]
    public interface IMessage
    {        
        [OperationContract]
        void UpdateMessageUnsubcribe();

        [OperationContract]
        void UpdateMessageSubscribe();
    }

    public interface IUpdateMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void UpdateMessage(List<string> messages);
    }
}

