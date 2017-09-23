namespace EvalServiceHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.ServiceModel.Web;
    using System.Text;
    using EvalServiceLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(EvalService));

            try
            {
                host.Open();
                PrintServiceInfo(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                host.Abort();
            }

        }

        private static void PrintServiceInfo(ServiceHost host)
        {
            Console.WriteLine("{0} is up and running with these endpoints: ",
                host.Description.ServiceType);
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine(se.Address.ToString());
            }
        }
    }
}
