using Google.Protobuf;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using static Message.Types.Type;

namespace ComputerTime
{
    public class BroadcastListener
    {
        private const int port = 55512;
        private UdpClient listener;
        private Thread listenThread;
        private Users users;

        internal BroadcastListener(Users users)
        {
            this.users = users;
        }

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
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            listener = new UdpClient(port);

            try
            {
                while (true)
                {
                    try
                    {
                        byte[] bytes = listener.Receive(ref recieveEP);
                        s.SendTo(HandleMessage(bytes).ToByteArray(), recieveEP);
                    }
                    catch (Exception) { }
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

        private Message HandleMessage(byte[] bytes)
        {
            Message message = Message.Parser.ParseFrom(bytes);
            switch (message.Type)
            {
                case ListAccountRequest:
                    return users.ListAccounts().ToListAccountResponse();
                case AccountSettingsRequest:
                    return users.GetAccountSettings(message.User).ToAccountSettingsResponse();
                case DisableRequest:
                    Native.SetEnabled(message.User, false);
                    return users.GetAccountSettings(message.User).ToAccountSettingsResponse();
                case EnableRequest:
                    Native.SetEnabled(message.User, true);
                    return users.GetAccountSettings(message.User).ToAccountSettingsResponse();
                case SetLogonHoursRequest:
                    SetHours set = message.SetHours;
                    Native.SetLogonHours(set.Name, set.LogonHours.ToByteArray().ToGMT());
                    return users.GetAccountSettings(set.Name).ToAccountSettingsResponse();
            }
            throw new Exception();
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
