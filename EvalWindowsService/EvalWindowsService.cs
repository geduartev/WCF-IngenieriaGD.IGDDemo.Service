namespace EvalWindowsService
{
    using System.ServiceModel;
    using System.ServiceProcess;
    using EvalServiceLibrary;

    public partial class EvalWindowsService : ServiceBase
    {
        private ServiceHost host = new ServiceHost(typeof(EvalService));

        public EvalWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}