using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace ProEpService
{
    [ServiceContract]
    public interface ISearch
    {
        [OperationContract]
        bool SearchByAuthor(string name);

        [OperationContract]
        bool SearchByPrice(int price);

        [OperationContract]
        bool SearchByfitle(string firstname);

        [OperationContract]
        bool SsearchByISBN(string isbn);
    }
}
