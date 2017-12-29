using System;
using System.Collections.Generic;
using System.IO;
using IngenieriaGD.IGDDemo.Library.DAL.Data;
using IngenieriaGD.IGDDemo.Library.DAL.Entities;
using IngenieriaGD.IGDLogWriter.Library.Contracts;
using IngenieriaGD.IGDLogWriter.Library.DAL.Serilog;

namespace IngenieriaGD.IGDDemo.Service
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceSAL : IServiceSAL
    {
        #region Clients

        public List<ClientInfo> GetAllClients()
        {
            var clients = ClientsRepository.GetInstance().SelectAll();
            return clients;
        }

        public ClientInfo GetClient(int clientId)
        {
            var result = ClientsRepository.GetInstance().SelectById(clientId);
            return result;
        }

        public ClientInfo GetClientByDocument(int documentType, string documentNumber)
        {
            var result = ClientsRepository.GetInstance().SelectByDocument(documentType, documentNumber);
            return result;
        }

        public bool InsertClient(ClientInfo clientInfo)
        {
            var result = ClientsRepository.GetInstance().Insert(clientInfo);
            return result;
        }

        public bool UpdateClientReading(int clientId, int newReading)
        {
            var client = ClientsRepository.GetInstance().SelectById(clientId);

            if (client == null)
            {
                return false;
            }

            client.LastReading = newReading;
            bool result = ClientsRepository.GetInstance().Update(client);
            return result;
        }

        public bool ValidateUser(string user, string password)
        {
            return true;
        }

        #endregion

        #region DocumentTypes
        
        public List<DocumentTypeInfo> GetAllDocumentTypes()
        {
            var documentTypes = DocumentTypesRepository.GetInstance().SelectAll();
            return documentTypes;
        }

        #endregion

        #region Logs

        public void WriteOperationTracking(OperationTracking operationTracking)
        {
            SerilogWriter.WriteOperationTrackingToMongoDb(operationTracking);
        }

        public void WriteExceptionTracking(ExceptionTracking exceptionTracking)
        {
            SerilogWriter.WriteExceptionTrackingToMongoDb(exceptionTracking);
        }

        #endregion
    }
}
