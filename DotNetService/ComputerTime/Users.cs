using Google.Protobuf;
using System;
using System.Management;
using System.Runtime.InteropServices;
using static ComputerTime.Native;

namespace ComputerTime
{
    internal class Users
    {
        internal HostAccounts ListAccounts()
        {
            HostAccounts host = new HostAccounts { Host = Environment.MachineName };
            SelectQuery query = new SelectQuery("Win32_GroupUser");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject groupUser in searcher.Get())
            {
                ManagementObject group = groupUser.Ref("GroupComponent");
                if ("Users".Equals(group["Name"]))
                {
                    ManagementObject user = groupUser.Ref("PartComponent");
                    if (user["__class"].Equals("Win32_UserAccount"))
                    {
                        host.Accounts.Add(new Account { Name = user["Name"].ToString(), });
                    }
                }
            }
            return host;
        }

        internal AccountSettings GetAccountSettings(string user)
        {
            return NetUserGetInfo(user, info =>
            {
                AccountSettings settings = new AccountSettings();
                settings.Name = user;
                settings.Disabled = (info.usri2_flags & UF_ACCOUNTDISABLE) > 0;
                byte[] hours = new byte[21];
                Marshal.Copy(info.usri2_logon_hours, hours, 0, 21);
                settings.LogonHours = ByteString.CopyFrom(hours.FromGMT());
                return settings;
            });
        }
    }
}