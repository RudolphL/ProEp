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
     
        [OperationContract]
        void SendMessage(Message message);
    
        [OperationContract]
        List<String> GetListOfPersonOnMessage(String username);

        [OperationContract]
        List<Message> GetListOfMessage(String sender_username, String receiver_username);  
    }

    public interface IUpdateMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void UpdateMessage();
    }
}

