//-----------------------------------------------------------------------
// <copyright file="IEvalService.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/20/2017 11:36:15 AM</date>
//-----------------------------------------------------------------------
namespace EvalServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;

    /// <summary>
    /// Interface pública para las evaluaciones.
    /// </summary>
    [ServiceContract]
    public interface IEvalService
    {
        /// <summary>
        /// Submits the eval.
        /// </summary>
        /// <param name="eval">The eval.</param>
        [WebInvoke(Method ="POST", UriTemplate ="evals")]
        [OperationContract]
        void SubmitEval(Eval eval);

        /// <summary>
        /// Gets the eval.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Retorna una evaluación.</returns>
        [WebGet(UriTemplate="eval/{id}")]
        [OperationContract]
        Eval GetEval(string id);

        /// <summary>
        /// Gets the evals.
        /// </summary>
        /// <returns>Retorna una lista de evaluaciones.</returns>
        [WebGet(UriTemplate = "evals", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Eval> GetAllEvals();

        /// <summary>
        /// Gets the evals by submitter.
        /// </summary>
        /// <param name="submitter">The submitter.</param>
        /// <returns>Retorna una evaluación.</returns>
        [WebGet(UriTemplate = "evals/{submitter}")]
        [OperationContract]
        List<Eval> GetEvalsBySubmitter(string submitter);

        /// <summary>
        /// Removes the eval.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [WebInvoke(Method = "DELETE", UriTemplate = "eval/{id}")]
        [OperationContract]
        void RemoveEval(String id);
    }
}
