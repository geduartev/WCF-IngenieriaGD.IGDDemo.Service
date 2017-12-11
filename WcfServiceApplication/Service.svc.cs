using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EvalServiceLibrary;

namespace WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        EvalService evalService = new EvalService();
        List<Eval> listEval = new List<Eval>();

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Eval> GetAll()
        {
            return listEval;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// News the submit.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="comments">The comments.</param>
        public void NewSubmit(string name, string comments)
        {
            Eval eval = new Eval();
            eval.TimeSubmitted = DateTime.Now;
            eval.Submitter = name;
            eval.Comments = comments;
            listEval.Add(eval);
        }
    }
}
