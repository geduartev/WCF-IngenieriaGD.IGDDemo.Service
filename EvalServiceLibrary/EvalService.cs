//-----------------------------------------------------------------------
// <copyright file="EvalService.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/20/2017 11:41:09 AM</date>
//-----------------------------------------------------------------------
namespace EvalServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;

    /// <summary>
    /// Exponer el servicio para realizar evaluaciones.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        List<Eval> evals = new List<Eval>();

        #region IEvalService Members

        /// <summary>
        /// Gets the evals.
        /// </summary>
        /// <returns>
        /// Retorna una lista de evaluaciones.
        /// </returns>
        public List<Eval> GetEvals()
        {
            return evals;

        }

        /// <summary>
        /// Removes the eval.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void RemoveEval(string id)
        {
            evals.Remove(evals.Find(e => e.Id.Equals(id)));
        }

        /// <summary>
        /// Submits the eval.
        /// </summary>
        /// <param name="eval">The eval.</param>
        public void SubmitEval(Eval eval)
        {
            eval.Id = Guid.NewGuid().ToString();
            evals.Add(eval);
        }

        #endregion
    }
}