using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{
    internal class RegMNG
    {

        public static void RegKeyUpdater(
            string _4iServerAddr,
            string _4iServerUser,
            string _4iServerPass,
            string _4iServerPort
        )
        {
            if (RegKeyCheck())
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Abdal4iProtoSocksBridge");
            }

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Abdal4iProtoSocksBridge");
            key.SetValue("_4iServerAddr", _4iServerAddr);
            key.SetValue("_4iServerUser", _4iServerUser);
            key.SetValue("_4iServerPass", _4iServerPass);
            key.SetValue("_4iServerPort", _4iServerPort);
            key.Close();
        }


        public static void RegKeyCreator(
            string _4iServerAddr,
            string _4iServerUser,
            string _4iServerPass,
            string _4iServerPort
        )
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Abdal4iProtoSocksBridge");
            key.SetValue("_4iServerAddr", _4iServerAddr);
            key.SetValue("_4iServerUser", _4iServerUser);
            key.SetValue("_4iServerPass", _4iServerPass);
            key.SetValue("_4iServerPort", _4iServerPort);
            key.Close();
        }

        public static Dictionary<string, string> RegReadKey()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Abdal4iProtoSocksBridge");
            var _4iserver_info = new Dictionary<string, string>();


            if (key != null)
            {
                _4iserver_info["_4iServerAddr"] = key.GetValue("_4iServerAddr").ToString();
                _4iserver_info["_4iServerUser"] = key.GetValue("_4iServerUser").ToString();
                _4iserver_info["_4iServerPass"] = key.GetValue("_4iServerPass").ToString();
                _4iserver_info["_4iServerPort"] = key.GetValue("_4iServerPort").ToString();
                key.Close();
                
            }

            return _4iserver_info;
        }


        public static bool RegKeyCheck()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Abdal4iProtoSocksBridge");
            if (key == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void RegKeyDelete()
        {
            if (RegKeyCheck())
            {
                Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Abdal4iProtoSocksBridge");
            }
        }
    }
}