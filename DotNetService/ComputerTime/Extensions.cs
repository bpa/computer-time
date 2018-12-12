using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Management;

namespace ComputerTime
{
    public static class Extensions
    {
        public static ManagementObject Ref(this ManagementObject mo, string reference)
        {
            ManagementObject obj = new ManagementObject((String)mo[reference]);
            obj.Get();
            return obj;
        }

        public static byte[] ToListAccountResponse(this HostAccounts accounts)
        {
            Message response = new Message
            {
                Type = Message.Types.Type.ListAccountResponse,
                HostAccounts = accounts
            };
            return response.ToByteArray();
        }
    }
}
