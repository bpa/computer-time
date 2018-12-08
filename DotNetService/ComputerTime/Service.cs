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
        BroadcastListener listener = new BroadcastListener();

        public Service()
        {
                InitializeComponent();

                eventLog = new EventLog();
                if (!EventLog.SourceExists("MySource"))
                {
                    EventLog.CreateEventSource(
                        "MySource", "MyNewLog");
                }
                eventLog.Source = "MySource";
                eventLog.Log = "MyNewLog";
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
