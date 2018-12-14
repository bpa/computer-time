using System;
using System.Runtime.InteropServices;

namespace ComputerTime
{
    public static class Native
    {
        public const uint UF_ACCOUNTDISABLE = 2;

        public static T NetUserGetInfo<T>(string username, Func<USER_INFO_2, T> f)
        {
            try
            {
                T ret = default(T);
                USER_INFO_2 userInfo = new USER_INFO_2();
                IntPtr data;
                int err = Native.NetUserGetInfo(null, username, 2, out data);
                if (err == 0)
                {
                    userInfo = (USER_INFO_2)Marshal.PtrToStructure(data, typeof(USER_INFO_2));
                    ret = f(userInfo);
                }
                NetApiBufferFree(data);
                data = IntPtr.Zero;
                return ret;
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        [DllImport("Netapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int NetUserGetInfo([MarshalAs(UnmanagedType.LPWStr)] string ServerName, [MarshalAs(UnmanagedType.LPWStr)] string UserName, int level, out IntPtr BufPtr);

        [DllImport("Netapi32.dll", SetLastError = true)]
        private static extern int NetApiBufferFree(IntPtr Buffer);

        public struct USER_INFO_2
        {
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_name;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_password;
            public uint usri2_password_age;
            public uint usri2_priv;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_home_dir;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_comment;
            public uint usri2_flags;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_script_path;
            public uint usri2_auth_flags;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_full_name;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_usr_comment;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_parms;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_workstations;
            public uint usri2_last_logon;
            public uint usri2_last_logoff;
            public uint usri2_acct_expires;
            public uint usri2_max_storage;
            public uint usri2_units_per_week;
            public IntPtr usri2_logon_hours;
            public uint usri2_bad_pw_count;
            public uint usri2_num_logons;
            [MarshalAs(UnmanagedType.LPWStr)] public string usri2_logon_server;
            public uint usri2_country_code;
            public uint usri2_code_page;
        }
    }
}
