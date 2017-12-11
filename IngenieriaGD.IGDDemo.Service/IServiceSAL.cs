using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using IngenieriaGD.IGDDemo.Library.DAL.Entities;

namespace IngenieriaGD.IGDDemo.Service
{
    [ServiceContract]
    public interface IServiceSAL
    {
        [OperationContract]
        [WebGet]
        List<ClientInfo> GetAllClients();

        [OperationContract]
        [WebInvoke]
        ClientInfo GetClient(int ClientId);

        [OperationContract]
        [WebInvoke]
        bool UpdateClientReading(int ClientId, int NewReading);

        [OperationContract]
        [WebInvoke]
        bool ValidateUser(string User, string Password);
    }
}
