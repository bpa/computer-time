using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Threading;

namespace ComputerTime
{
    public partial class Service : ServiceBase
    {
        BroadcastListener listener = new BroadcastListener(new Users());

        public Service()
        {
                InitializeComponent();

                eventLog = new EventLog();
                if (!EventLog.SourceExists("ComputerTime"))
                {
                    EventLog.CreateEventSource("ComputerTime", "Application");
                }
                eventLog.Source = "ComputerTime";
                eventLog.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            listener.Start();
        }

        protected override void OnStop()
        {
            listener.Stop();
        }
    }
}
