using System;
using System.Linq;
using System.Collections.Generic;
using System.Management;

namespace ComputerTime
{
    internal class Users
    {
        internal List<String> List()
        {
            List<String> usernames = new List<String>();
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
                        usernames.Add(user["Name"].ToString());
                    }
                }
            }
            return usernames;
        }
    }
}