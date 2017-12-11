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
                Console.WriteLine("Press ENTER to exit.");
                Console.ReadLine();
                host.Close();
            } catch(CommunicationException ce) {
                Console.WriteLine("There is a CommunicationException: {0}", ce.Message);
                Console.WriteLine("Press ENTER to continue and abort this service.");
                Console.ReadLine();
                host.Abort();
            }
            catch (Exception e)
            {
                Console.WriteLine("There is a Exception: {0}", e.Message);
                Console.WriteLine("Press ENTER to continue and abort this service.");
                Console.ReadLine();
                host.Abort();
            }

            //ServiceHost hospedaje = new ServiceHost(typeof(Mensaje),
            //    new Uri("http://localhost/EjemploWCFConfig"));
            //try
            //{
            //    hospedaje.Open();
            //    Console.WriteLine("Dirección: {0} \nEnlace: {1}", hospedaje.BaseAddresses[0], hospedaje.Description.Endpoints[0].Binding.Name);
            //    Console.WriteLine("El servicio está en ejecución, presione ENTER para salir.");
            //    Console.ReadLine();
            //    hospedaje.Close();
            //}
            //catch (CommunicationException ce)
            //{
            //    Console.WriteLine("Hubo derrumbe de la comunicación, por lo tanto se abortará.");
            //    Console.WriteLine("El problema fue: {0}", ce.Message);
            //    Console.ReadLine();
            //    hospedaje.Abort();
            //}

        }

        private static void PrintServiceInfo(ServiceHost host)
        {
            Console.WriteLine("{0} is up and running with these endpoints: ", host.Description.ServiceType);

            foreach (ServiceEndpoint se in host.Description.Endpoints) {
                Console.WriteLine(se.Address.ToString());
            }
        }
    }
}
