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

        /// <summary>
        /// This method will unsubscribe the client from getting notify by the callback of IUpdateMessage
        /// </summary>
        [OperationContract]
        void UpdateMessageUnsubcribe();

        /// <summary>
        /// This method will subcribe the client to receiver a trigger from the client( a call back) with IUpdateMessage 
        /// </summary>
        [OperationContract]
        void UpdateMessageSubscribe();

        /// <summary>
        /// This method will send the message text to the database and then notify the client (refresh)
        /// The message will be send as a Message type object which contain : sender, receiver, id and text.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        [OperationContract]
        bool SendMessage(Message message);

        /// <summary>
        /// This method will get the ListOfPerson that the user have chated with before.
        /// </summary>
        /// <param name="user"> the username of the current user</param>
        /// <returns></returns>
        [OperationContract]
        List<String> GetListOfPerson(String username);

        /// <summary>
        /// This method will get the ListOfMessage( return a List of type Message) 
        /// by searching through the database and then find the message 
        /// with sender and user like parameters had declared
        /// </summary>
        /// <param name="sender_username">user name of sender</param>
        /// <param name="receiver_username">user name of receiver</param>
        /// <returns></returns>
        [OperationContract]
        List<Message> GetListOfMessage(String sender_username, String receiver_username);

      

    }

    public interface IUpdateMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void UpdateMessage(List<string> messages);
    }
}

