//-----------------------------------------------------------------------
// <copyright file="IServiceSAL.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>12/28/2017 10:34:10 AM</date>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.ServiceModel;
using IngenieriaGD.IGDDemo.Library.DAL.Entities;
using IngenieriaGD.IGDLogWriter.Library.Contracts;

namespace IngenieriaGD.IGDDemo.Service
{
    [ServiceContract]
    public interface IServiceSAL
    {
        #region Clients

        [OperationContract]
        List<ClientInfo> GetAllClients();

        [OperationContract]
        ClientInfo GetClient(int clientId);

        [OperationContract]
        ClientInfo GetClientByDocument(int documentType, string documentNumber);

        [OperationContract]
        bool InsertClient(ClientInfo clientInfo);

        [OperationContract]
        bool UpdateClientReading(int clientId, int newReading);

        #endregion

        #region Users
                
        [OperationContract]
        bool ValidateUser(string user, string password);

        #endregion

        #region Document Types
                
        [OperationContract]
        List<DocumentTypeInfo> GetAllDocumentTypes();

        #endregion

        #region Sellers

        //[OperationContract]
        //bool ValidateSeller(string User, string Password);

        #endregion

        #region Products

        //[OperationContract]
        //ClientInfo GetProduct(int ProductId);

        #endregion

        #region Orders

        //[OperationContract]
        //int SaveOrder(int SellerId, int ClientId, List<DetailOrder> DetailOrder);

        #endregion

        #region Logs

        [OperationContract]
        void WriteOperationTracking(OperationTracking operationTracking);

        [OperationContract]
        void WriteExceptionTracking(ExceptionTracking exceptionTracking);

        #endregion
    }
}
