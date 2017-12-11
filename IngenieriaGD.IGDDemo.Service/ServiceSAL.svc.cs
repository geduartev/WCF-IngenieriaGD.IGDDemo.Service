using System.Collections.Generic;
using System.ServiceModel;
using IngenieriaGD.IGDDemo.Library.DAL.Data;
using IngenieriaGD.IGDDemo.Library.DAL.Entities;

namespace IngenieriaGD.IGDDemo.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceSAL : IServiceSAL
    {
        public List<ClientInfo> GetAllClients()
        {
            var clients = ClientsRepository.GetInstance().SelectAll();
            return clients;
        }

        public ClientInfo GetClient(int ClientId)
        {
            var result = ClientsRepository.GetInstance().SelectById(ClientId);
            return result;
        }

        public bool UpdateClientReading(int ClientId, int NewReading)
        {
            var client = ClientsRepository.GetInstance().SelectById(ClientId);
            client.LastReading = NewReading;
            bool result = ClientsRepository.GetInstance().Update(client);
            return result;
        }

        public bool ValidateUser(string User, string Password)
        {
            return true;
        }
    }
}
