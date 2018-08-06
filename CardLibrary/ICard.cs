using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace CardLibrary
{
    [ServiceContract]
    public interface ICard
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        bool Authenticate(int CardNo, int cvv);


        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        bool DateCheck(int CardNo, DateTime dt);

        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        double Trans(int CardNo, double amount);
    }
}
