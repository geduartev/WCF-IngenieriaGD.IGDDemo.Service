namespace EvalWindowsService
{
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceProcess;
    using EvalServiceLibrary;

    public partial class EvalWindowsService : ServiceBase
    {
        private WebServiceHost host = new WebServiceHost(typeof(EvalService));

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