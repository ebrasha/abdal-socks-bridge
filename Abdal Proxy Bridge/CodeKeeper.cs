using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{
    internal class CodeKeeper
    {
        public CodeKeeper()
        {




            // #region Check SSh Tunnel health
            //
            //
            //
            // bool success;
            // string command = "";
            // if (tunnel.IsSshConnected() == false)
            // {
            //
            //
            //
            //     if (warning_counter <= 5)
            //     {
            //         MessageManagements.DangerMessage("4i Tunnel is not Connected... Check your network or server");
            //         warning_counter += 1;
            //     }
            //
            //
            //
            //
            //
            // }
            // else
            // {
            //     if (warning_counter >= 5)
            //     {
            //         MessageManagements.SuccessMessage("4i Tunnel is Connected");
            //         warning_counter = 0;
            //     }
            // }
            //
            // string exit_command_str = "";
            // bool exit_command = Reader.TryReadLine(out exit_command_str, 3000);
            // if (!exit_command)
            // {
            //     if (exit_command_str == "stop")
            //     {
            //         #region StopTunnel
            //
            //         // Stop the background listen/accept thread:
            //         var waitForThreadExit = true;
            //         success = tunnel.StopAccepting(waitForThreadExit);
            //         if (success != true)
            //         {
            //             MessageManagements.DangerMessage("Error in StopAccepting");
            //             tunnel.CloseTunnel(waitForThreadExit);
            //         }
            //         else
            //         {
            //             MessageManagements.SuccessMessage("Stop the background listen/accept thread");
            //         }
            //
            //         // Close the 4i tunnel (would also kick any remaining connected clients).
            //         success = tunnel.CloseTunnel(waitForThreadExit);
            //         if (success != true)
            //         {
            //             MessageManagements.DangerMessage("Error in CloseTunnel");
            //             tunnel.CloseTunnel(waitForThreadExit);
            //             tunnel.DisconnectAllClients(waitForThreadExit);
            //         }
            //         else
            //         {
            //             MessageManagements.SuccessMessage("Close the 4i tunnel");
            //         }
            //
            //         #endregion
            //         Environment.Exit(0);
            //     }
            // }
            //
            //
            // #endregion


        }
    }
}
