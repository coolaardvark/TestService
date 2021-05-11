using System.ServiceProcess;

namespace TestService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            TextGenerator.WriteMessage("Running as Service!");
        }

        protected override void OnStop()
        {
        }
    }
}
