namespace ClientEvalService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ClientEvalService.EvalServiceReference;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press <Enter> to run the client...");
            Console.ReadLine();

            // BasicHttpBinding_IEvalService es el nombre del punto de entrada que se obtiene del archivo de configuración.
            EvalServiceClient client = new EvalServiceClient("BasicHttpBinding_IEvalService");
            
            Eval eval = new Eval();
            eval.Comments = "This came from code!";
            eval.Submitter = "GabrielDua";
            eval.TimeSubmitted = DateTime.Now;

            client.SubmitEval(eval);

            Eval[] evals = client.GetEvals();
            foreach (Eval ev in evals)
            {
                Console.WriteLine(ev.Comments);
            }

            Console.WriteLine("Number of evals: {0}", client.GetEvals().Length);

            Console.ReadLine();
        }
    }
}
