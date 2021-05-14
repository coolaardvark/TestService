using System.ServiceProcess;

namespace Attempt2
{
    public class TestService : ServiceBase
    {
        public TestService()
        {
            
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
