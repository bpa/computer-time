using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ComputerTime
{
    public class BroadcastListener
    {
        private const int port = 55512;
        private UdpClient listener;
        private Thread listenThread;
        private Socket s;

        internal void Start()
        {
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.Start();
        }

        internal void Stop()
        {
            listener.Close();
            listenThread.Join();
        }

        internal void Listen()
        {
            IPEndPoint recieveEP = new IPEndPoint(IPAddress.Any, port);
            IPEndPoint sendEP = new IPEndPoint(BroadcastAddress(), 23244);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listener = new UdpClient(port);

            try
            {
                while (true)
                {
                    byte[] bytes = listener.Receive(ref recieveEP);
                    s.SendTo(bytes, sendEP);
                }
            }
            catch (SocketException)
            {
                //This is what happens when Stop() is called
            }
            finally
            {
                s.Close();
                listener.Close();
            }
        }

        public IPAddress BroadcastAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            IPAddress addr = host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

            byte[] bytes = addr.GetAddressBytes();
            bytes[3] = 255;
            return new IPAddress(bytes);
        }
    }
}
