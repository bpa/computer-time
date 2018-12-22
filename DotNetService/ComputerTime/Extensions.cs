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

        public static byte[] ToAccountSettingsResponse(this AccountSettings accounts)
        {
            Message response = new Message
            {
                Type = Message.Types.Type.AccountSettingsResponse,
                AccountSettings = accounts
            };
            return response.ToByteArray();
        }

        public static byte[] FromGMT(this byte[] hours)
        {
            return hours.RotateBits(-DateTimeOffset.Now.Offset.Hours);
        }

        public static byte[] ToGMT(this byte[] hours)
        {
            return hours.RotateBits(DateTimeOffset.Now.Offset.Hours);
        }

        public static byte[] RotateBits(this byte[] data, int offset)
        {
            byte[] copy = new byte[data.Length];

            offset %= data.Length * 8;
            if (offset < 0) offset += data.Length * 8;

            int byteOffset;
            int nextOffset = offset / 8;
            int bitOffset = offset % 8;

            for(int i=0; i<data.Length; i++)
            {
                byteOffset = nextOffset;
                nextOffset = (byteOffset + 1) % data.Length;
                copy[i] = (byte)((data[byteOffset] >> bitOffset) | (data[nextOffset] << (8 - bitOffset)));
            }
            return copy;
        }
    }
}
