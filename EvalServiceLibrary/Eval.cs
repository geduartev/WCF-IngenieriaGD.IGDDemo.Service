//-----------------------------------------------------------------------
// <copyright file="Eval.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/20/2017 11:27:03 AM</date>
//-----------------------------------------------------------------------

namespace EvalServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// Contrato para las evaluaciones.
    /// </summary>
    [DataContract(Namespace = "http://www.ingenieriagd.net/WebServiceWCF")]
    public class Eval
    {
        [DataMember]
        public string Id;
        [DataMember]
        public string Submitter;
        [DataMember]
        public string Comments;
        [DataMember]
        public DateTime TimeSubmitted;
    }
}