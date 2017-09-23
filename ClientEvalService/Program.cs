namespace ClientEvalService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.Web;
    using System.Text;
    using EvalServiceLibrary;
    using ServiceReferenceEval;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Evaluation Cliente Application ***\n");

            // BasicHttpBinding_IEvalService es el nombre del punto de entrada que se obtiene del archivo de configuración.

            // La línea comentada reemplaza las siguientes dos líneas.
            // Al usar la línea comentada es necesario crear un Service References al servicio.
            // EvalServiceClient client = new EvalServiceClient("BasicHttpBinding_IEvalService");

            WebChannelFactory<EvalServiceLibrary.IEvalService> cf =
                new WebChannelFactory<EvalServiceLibrary.IEvalService>(
                    new Uri("http://localhost:8080/evalservicehost"));

            EvalServiceLibrary.IEvalService client = cf.CreateChannel();

            Console.WriteLine("Please enter a command: ");
            string command = Console.ReadLine();

            while (!command.Equals("exit"))
            {
                switch (command)
                {
                    case "submit":
                        Console.WriteLine("Please enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter your comments: ");
                        string comments = Console.ReadLine();

                        Eval eval = new Eval();
                        eval.TimeSubmitted = DateTime.Now;
                        eval.Submitter = name;
                        eval.Comments = comments;

                        client.SubmitEval(eval);

                        Console.WriteLine("Evaluation submitted!\n");
                        break;

                    case "get":
                        Console.WriteLine("Please enter the eval id: ");
                        string id = Console.ReadLine();

                        Eval e = client.GetEval(id);
                        Console.WriteLine("{0} -- {1} said: {2} (id {3})\n", e.TimeSubmitted, e.Submitter, e.Comments);
                        break;
                    case "list":
                        Console.WriteLine("Please enter the submitter name: ");
                        name = Console.ReadLine();

                        List<Eval> evals = client.GetEvalsBySubmitter(name);

                        evals.ForEach(ev => Console.WriteLine("{0} -- {1} said: {2}", ev.TimeSubmitted, ev.Submitter, ev.Comments));
                        Console.WriteLine();
                        break;
                    case "remove":
                        Console.WriteLine("Please enter the eval id: ");
                        id = Console.ReadLine();

                        client.RemoveEval(id);

                        Console.WriteLine("Evaluation {0} removed!\n", id);
                        break;
                    case "listasync":
                        EvalServiceClient clientasync = new EvalServiceClient("WSHttpBinding_IEvalService");

                        clientasync.GetAllEvalsCompleted += new EventHandler<GetAllEvalsCompletedEventArgs>(Clientasync_GetAllEvalsCompleted);

                        Console.WriteLine("Calling GetEvals...");

                        //TODO: Verificar por que no carga en pantalla las evaluaciones o si estamos haciendo más el delegado.

                        clientasync.GetAllEvalsAsync();

                        Console.WriteLine("GetEvals called.\n");
                        
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Please enter a command.");
                        break;
                }

                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine();
            }

            Console.WriteLine("Number of evals: {0}", client.GetAllEvals().Count);

            Console.ReadLine();
        }

        private static void Clientasync_GetAllEvalsCompleted(object sender, GetAllEvalsCompletedEventArgs e)
        {
            foreach (Eval ev in e.Result)
            {
                Console.WriteLine("{0} -- {1} said: {2}", ev.TimeSubmitted, ev.Submitter, ev.Comments);
            }
        }
    }
}
