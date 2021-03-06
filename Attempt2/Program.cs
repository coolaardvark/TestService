using System;
using System.ServiceProcess;
using System.Configuration.Install;

namespace Attempt2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                if (args.Length > 0)
                {
                    if (args[0].ToLower() == "install")
                    {
                        InstallService();
                    }
                    else if (args[0].ToLower() == "uninstall")
                    {
                        UninstallService();
                    }
                    else
                    {
                        RunExe();
                    }
                }
                else
                {
                    RunExe();
                }
            }
            else
            {
                RunService();
            }
        }

        static void InstallService()
        {
            ManagedInstallerClass.InstallHelper(
                new string[] { typeof(Program).Assembly.Location });
        }

        static void UninstallService()
        {
            ManagedInstallerClass.InstallHelper(
                new string[] { "/u", typeof(Program).Assembly.Location });
        }

        static void RunService()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                    new TestService()
            };

            ServiceBase.Run(ServicesToRun);
        }

        static void RunExe()
        {
            Console.WriteLine("Running as exe");

            Console.WriteLine("Press return to exit");
            Console.ReadLine();
        }
    }
}