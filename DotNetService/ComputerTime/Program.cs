using System;
using System.ServiceProcess;

namespace ComputerTime
{
    static class Program
    {
        /// <summary>
        /// Administrative api
        /// </summary>
        static void Main()
        {
#if DEBUG
            new BroadcastListener(new Users()).Listen();
            //Console.WriteLine(String.Join(", ", new Users().List().ToArray()));
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
