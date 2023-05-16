using System.Timers;
using Abdal_Proxy_Bridge;
using Chilkat;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;

namespace AbdalProxyBridge;

internal class Program
{
    private static string sshHostname;
    private static string sshHostusername;
    private static string sshHostpassword;
    private static string sshPort;
    private static System.Timers.Timer aTimer;
    private static SshTunnel tunnel = new SshTunnel();
    private static int warning_counter = 0;


    private static void Main(string[] args)
    {
        Version version = Assembly.GetExecutingAssembly().GetName().Version;

        Console.Title = "Abdal Socks Bridge " + version.Major + "." + version.Minor;
        ;
        AbdalBanners.StartBanner01();


        String thisprocessname = Process.GetCurrentProcess().ProcessName;

        if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            return;

        if (CheckForInternetConnection.InternetCheck() == false)
        {
            MessageManagements.DangerMessage("Internet not Connected");
        }
        else
        {
            MessageManagements.SuccessMessageCW(" OK!\n");

            #region Connect 4i Proto Tunnel

            var ssh_tunnel_user = "abdal";
            var ssh_tunnel_pass = "abdal";
            var local_socks_port = 52905;
            var current_exe_dir = System.Environment.CurrentDirectory;

            // ConfigMng.ConfigFileWriter("4iServerAddress", sshHostname);
            // ConfigMng.ConfigFileWriter("4iServerPort", sshPort.ToString());
            // ConfigMng.ConfigFileWriter("LocalSocksUser", ssh_tunnel_user);
            // ConfigMng.ConfigFileWriter("LocalSocksPass", ssh_tunnel_pass);
            // ConfigMng.ConfigFileWriter("LocalSocksPort", local_socks_port.ToString());

            #region Change Data

            // if (args == null || args.Length == 0)
            // {
            //     if (RegMNG.RegKeyCheck() == true)
            //     {
            //         Console.Write("Do you want to change the 4i Proto Server (y/n):  ");
            //         var userVhangedata = Console.ReadLine();
            //
            //         if (userVhangedata.ToString() == "y")
            //         {
            //             RegMNG.RegKeyDelete();
            //             Console.Write("Please Enter the 4i Proto Server Address:  ");
            //             sshHostname =  Console.ReadLine();
            //             Console.Write("Please Enter the 4i Proto Server Username:  ");
            //             sshHostusername = Console.ReadLine();
            //             Console.Write("Please Enter the 4i Proto Server Password:  ");
            //             sshHostpassword = Console.ReadLine();
            //             Console.Write("Please Enter the 4i Proto Server Port:  ");
            //             sshPort = Console.ReadLine();
            //
            //             
            //             RegMNG.RegKeyCreator(
            //                 sshHostname,
            //                 sshHostusername,
            //                 sshHostpassword,
            //                 sshPort.ToString()
            //             );
            //         }
            //     }
            // }

            #endregion

            #region RegDB

            if (RegMNG.RegKeyCheck())
            {
                var _4iserver_info = RegMNG.RegReadKey();
                sshHostname = _4iserver_info["_4iServerAddr"];
                sshHostusername = _4iserver_info["_4iServerUser"];
                sshHostpassword = _4iserver_info["_4iServerPass"];
                sshPort = _4iserver_info["_4iServerPort"];
            }
            else
            {
                Console.Write("Please Enter the 4i Proto Server Address:  ");
                sshHostname = Console.ReadLine();
                Console.Write("Please Enter the 4i Proto Server Username:  ");
                sshHostusername = Console.ReadLine();
                Console.Write("Please Enter the 4i Proto Server Password:  ");
                sshHostpassword = Console.ReadLine();
                Console.Write("Please Enter the 4i Proto Server Port:  ");
                sshPort = Console.ReadLine();


                RegMNG.RegKeyCreator(
                    sshHostname,
                    sshHostusername,
                    sshHostpassword,
                    sshPort.ToString()
                );
            }

            #endregion


            var chilkatGlob = new Global();
            var success = chilkatGlob.UnlockBundle("nahaan.CBX1125_FUiiNrsmOG2G");
            if (success != true)
            {
                MessageManagements.DangerMessage("Your license is not valid");
            }
            else
            {
                Console.Write("-> License is Valid ");
                MessageManagements.SuccessMessageCW(" OK!\n");
            }


            // This example requires Chilkat version 9.5.0.50 or greater.

            tunnel.ConnectTimeoutMs = 10000;


            // Connect to an 4i Protocol server and establish the 4i tunnel:
            success = tunnel.Connect(sshHostname, Convert.ToUInt16(sshPort));
            if (success != true)
            {
                MessageManagements.DangerMessage("There is a problem connecting to the 4i server");
                // tunnel.CloseTunnel(true);
            }
            else
            {
                Console.Write("-> Connect to an 4i server with ip:" + sshHostname + " ");
                MessageManagements.SuccessMessageCW(" OK!\n");
            }


            success = tunnel.AuthenticatePw(sshHostusername, sshHostpassword);
            if (success != true)
            {
                MessageManagements.DangerMessage("your 4i password or username is wrong !!!");
                // tunnel.CloseTunnel(true);
            }
            else
            {
                Console.Write("-> Authenticate with the 4i server via a login/password ");
                MessageManagements.SuccessMessageCW(" OK!\n");
            }


            //Enable Tls3
            tunnel.UncommonOptions = "EnableTls13";
            tunnel.UncommonOptions = "ProtectFromVpn";
            tunnel.UncommonOptions = "NoKeepAliveIgnoreMsg";

            //tunnel.PreferIpv6 = true;
            tunnel.SocksVersion = 5;
            tunnel.TcpNoDelay = true;
            tunnel.DynamicPortForwarding = true;
            tunnel.InboundSocksUsername = ssh_tunnel_user;
            tunnel.InboundSocksPassword = ssh_tunnel_pass;

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
                Console.Write("-> Local SOCKS proxy Start ");
                MessageManagements.SuccessMessageCW(" OK!\n");

                var socks_info = @"
                    

                         -Local SOCKS5 proxy-
                        | IP : 127.0.0.1     |
                        | Port : 52905       |
                        | UserName : abdal   |
                        | Password : abdal   |
                         --------------------

                    ";
                MessageManagements.WarningMessage(socks_info);
            }

            #endregion
        }


        SetTimer();


        //Console.ReadKey(true);

        if (Console.Read() == 'q')
        {
            Environment.Exit(0);
        }
    } // End Main

    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(2000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        // Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
        //     e.SignalTime);


        #region Check SSh Tunnel health

        bool success;
        string command = "";
        if (tunnel.IsSshConnected() == false)
        {
            if (warning_counter <= 2)
            {
                MessageManagements.DangerMessage("4i Tunnel is not Connected... Check your network or server");
                if (!File.Exists(System.Environment.CurrentDirectory + "\\4inotc"))
                {
                    File.Create(System.Environment.CurrentDirectory + "\\4inotc");
                }

                warning_counter += 1;
            }
            else
            {
                string cmd_file = Directory.GetCurrentDirectory() + "\\runner.bat";
                string cmd_file_path = Directory.GetCurrentDirectory();

                if (File.Exists(cmd_file))
                {
                    File.Delete(cmd_file);
                }

                // // Create a new file     
                // using (StreamWriter sw = File.CreateText(cmd_file))
                // {
                //     sw.WriteLine("@echo off");
                //     sw.WriteLine("echo %time%");
                //     sw.WriteLine("timeout 3 > NUL");
                //     sw.WriteLine("echo %time%");
                //     sw.WriteLine("start  \"\" \"" + cmd_file_path + "\\Abdal Socks Bridge.exe\"");
                // }
            }
        }

        #endregion
    }
}