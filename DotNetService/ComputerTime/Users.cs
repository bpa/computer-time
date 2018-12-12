using System;
using System.Management;

namespace ComputerTime
{
    internal class Users
    {
        internal HostAccounts List()
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
    }
}