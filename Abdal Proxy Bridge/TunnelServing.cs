using Chilkat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{

    internal class TunnelServing
    {
        private static SshTunnel tunnel = new SshTunnel();
        public static void  Connector()
        {

            if (tunnel.IsSshConnected() == false)
            {
              #region  Connect 4i Proto Tunnel
                var sshHostname = "45.92.93.215";
                var sshHostusername = "ebrasha";
                var sshHostpassword = "ebrasha";
                var sshPort = 64530;
                var ssh_tunnel_user = "abdal";
                var ssh_tunnel_pass = "abdal";
                var local_socks_port = 52905;
                var current_exe_dir = System.Environment.CurrentDirectory;

                // ConfigMng.ConfigFileWriter("4iServerAddress", sshHostname);
                // ConfigMng.ConfigFileWriter("4iServerPort", sshPort.ToString());
                // ConfigMng.ConfigFileWriter("LocalSocksUser", ssh_tunnel_user);
                // ConfigMng.ConfigFileWriter("LocalSocksPass", ssh_tunnel_pass);
                // ConfigMng.ConfigFileWriter("LocalSocksPort", local_socks_port.ToString());



                var chilkatGlob = new Global();
                var success = chilkatGlob.UnlockBundle("nahaan.CBX1125_FUiiNrsmOG2G");
                if (success != true)
                    MessageManagements.DangerMessage("Your license is not valid");
                else
                    MessageManagements.SuccessMessage("License is Valid\n");


                // This example requires Chilkat version 9.5.0.50 or greater.

                  //Enable Tls3
                //tunnel.UncommonOptions = "EnableTls13";
                //tunnel.UncommonOptions = "ProtectFromVpn";
                //tunnel.UncommonOptions = "NoKeepAliveIgnoreMsg";
                tunnel.ConnectTimeoutMs = 10000;

                tunnel.SocksVersion = 5;
                tunnel.TcpNoDelay = false;
                tunnel.DynamicPortForwarding = true;
                tunnel.InboundSocksUsername = ssh_tunnel_user;
                tunnel.InboundSocksPassword = ssh_tunnel_pass;



                // Connect to an 4i Protocol server and establish the 4i tunnel:
                success = tunnel.Connect(sshHostname, sshPort);
                if (success != true)
                    MessageManagements.DangerMessage("There is a problem connecting to the 4i server");
                // tunnel.CloseTunnel(true);
                else
                    MessageManagements.SuccessMessage("Connect to an 4i server with ip:" + sshHostname + "\n");

                success = tunnel.AuthenticatePw(sshHostusername, sshHostpassword);
                if (success != true)
                    MessageManagements.DangerMessage("your 4i password or username is wrong !!!");
                // tunnel.CloseTunnel(true);
                else
                    MessageManagements.SuccessMessage("Authenticate with the 4i server via a login/password\n");

              


               

                // Start the listen/accept thread to begin accepting SOCKS proxy client connections.
                // Listen on port 1080.
                success = tunnel.BeginAccepting(local_socks_port);
                if (success != true)
                {
                    MessageManagements.DangerMessage("There is a problem start local Socks server");
                    tunnel.CloseTunnel(true);
                }
                else
                {
                    MessageManagements.SuccessMessage(
                        "Start the listen/accept thread to begin accepting SOCKS proxy on port: 52905\n");
                }
                #endregion
            }
             
        }

        public static bool TunnelCheck()
        {
            if (tunnel.IsSshConnected() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static SshTunnel TunnelReturn()
        {
            return tunnel;
        }
    }
}
