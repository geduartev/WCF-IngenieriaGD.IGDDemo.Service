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
        [OperationContract]
        void SubmitEval(Eval eval);

        /// <summary>
        /// Gets the evals.
        /// </summary>
        /// <returns>Retorna una lista de evaluaciones.</returns>
        [OperationContract]
        List<Eval> GetEvals();

        /// <summary>
        /// Removes the eval.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [OperationContract]
        void RemoveEval(String id);
    }
}
