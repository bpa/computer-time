using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

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
    }
}
