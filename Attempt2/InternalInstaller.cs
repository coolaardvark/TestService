using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;

namespace Attempt2
{
    [RunInstaller(true)]
    public partial class InternalInstaller : Installer
    {
        private ServiceProcessInstaller serviceProcessInstaller1;
        private ServiceInstaller serviceInstaller1;

        public InternalInstaller()
        {
            InitializeComponent();

            serviceProcessInstaller1 = new ServiceProcessInstaller();
            serviceInstaller1 = new ServiceInstaller();

            // Force request for login at install
            serviceProcessInstaller1.Password = null;
            serviceProcessInstaller1.Username = null;

            serviceInstaller1.ServiceName = "TestService";

            Installers.AddRange(new Installer[] {
                serviceProcessInstaller1,
                serviceInstaller1});
        }
    }
}
