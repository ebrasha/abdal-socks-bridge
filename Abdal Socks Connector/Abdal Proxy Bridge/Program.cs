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
    private static string abdal_socks_connector_error_file = System.Environment.CurrentDirectory + "\\error_asc";


    private static void Main(string[] args)
    {
        File.Delete(abdal_socks_connector_error_file);

        Version version = Assembly.GetExecutingAssembly().GetName().Version;

        Console.Title = "Abdal Socks Bridge " + version.Major + "." + version.Minor;
        ;
        AbdalBanners.StartBanner01();


        String thisprocessname = Process.GetCurrentProcess().ProcessName;

        if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            return;


        #region Check Is Connect to Youtube

        try
        {
            string url = "https://www.youtube.com/";

            Http http = new Http();

            // Indicate that the HTTP object is to use our portable SOCKS proxy/SSH tunnel running in our background thread.
            http.SocksHostname = "localhost";
            http.SocksPort = 52905;
            http.SocksVersion = 5;
            http.SocksUsername = "abdal";
            http.SocksPassword = "abdal";

            http.SendCookies = true;
            http.SaveCookies = true;
            http.CookieDir = "memory";

            // Do the HTTPS page fetch (through the SSH tunnel)
            string html = http.QuickGetStr(url);
            if (http.LastMethodSuccess != true)
            {

                File.Create(abdal_socks_connector_error_file);
 
            }
            
        }
        catch (Exception exception)
        {
            File.Create(abdal_socks_connector_error_file);
        }

        #endregion



    } // End Main




}