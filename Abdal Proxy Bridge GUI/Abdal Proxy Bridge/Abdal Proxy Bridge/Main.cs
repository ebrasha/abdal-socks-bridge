using Chilkat;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Abdal_Proxy_Bridge
{
    public partial class Main : Form
    {
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        public static Int32 abdal_socks_bridge_pid;
        private static string getCurrentLocation = System.Environment.CurrentDirectory;

        private static string abdalSocksBridgeDir = System.Environment.CurrentDirectory + "\\apbcli\\";

        private static string abdalSocksBridgeExeDir =
            System.Environment.CurrentDirectory + "\\apbcli\\Abdal Socks Bridge.exe";

        // Abdal Socks bridge close tunnel sign file
        private static string abdalSBCTS = System.Environment.CurrentDirectory + "\\apbcli\\4inotc";
        private static string abdal_socks_connector_dir = System.Environment.CurrentDirectory + "\\asc\\";
        private static string abdal_socks_connector_exe_dir = System.Environment.CurrentDirectory + "\\asc\\ASC.exe";

        public Main()
        {
            InitializeComponent();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            pkiller.Enabled = true;
            if (bw_4i_server.IsBusy == false)
            {
                bw_4i_server.RunWorkerAsync();
            }
        }

        private void bw_4i_server_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            #region Connect 4i Proto Tunnel

            c_lock.Visible = false;
            bw_lock.Visible = true;
            bool processExist = PTerminator.ProcessExists("Abdal Socks Bridge");
            if (processExist)
            {
                PTerminator.ProcessKiller("Abdal Socks Bridge");
                logBox.Items.Add("kill Abdal Socks Bridge Process");

                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }

            if (File.Exists(abdalSBCTS))
            {
                try
                {
                    File.Delete(abdalSBCTS);
                }
                catch (Exception exception)
                {
                    logBox.Items.Add(exception);
                    // throw;
                }

                logBox.Items.Add("abdalSBCTS Clean");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }


            if (RegMNG.RegKeyCheck())
            {
                // start process
                if (ck_hidecliwindow.Checked)
                {
                    PTerminator.ProcessStarter(
                        abdalSocksBridgeExeDir,
                        abdalSocksBridgeDir,
                        true);
                }
                else
                {
                    PTerminator.ProcessStarter(
                        abdalSocksBridgeExeDir,
                        abdalSocksBridgeDir,
                        false);
                }

                logBox.Items.Add("Abdal Socks Bridge Starting...");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;

                RegMNG.RegKeyUpdater(tb_4iaddr.Text,
                    tb_4i_username.Text,
                    tb_4i_password.Text,
                    tb_4i_port.Text);
            }
            else
            {
                bool connectionInfoIsEmpty = false;

                if (tb_4iaddr.Text == "")
                {
                    tb_4iaddr.BackColor = Color.Tomato;
                    connectionInfoIsEmpty = true;
                    logBox.Items.Add("Please Enter the 4i Server Address");
                    // Scroll Listbox
                    logBox.SelectedIndex = logBox.Items.Count - 1;
                    logBox.SelectedIndex = -1;
                }

                if (tb_4i_username.Text == "")
                {
                    tb_4i_username.BackColor = Color.Tomato;
                    connectionInfoIsEmpty = true;
                    logBox.Items.Add("Please Enter the 4i Server UserName");
                    // Scroll Listbox
                    logBox.SelectedIndex = logBox.Items.Count - 1;
                    logBox.SelectedIndex = -1;
                }

                if (tb_4i_password.Text == "")
                {
                    tb_4i_password.BackColor = Color.Tomato;
                    connectionInfoIsEmpty = true;
                    logBox.Items.Add("Please Enter the 4i Server Password");
                    // Scroll Listbox
                    logBox.SelectedIndex = logBox.Items.Count - 1;
                    logBox.SelectedIndex = -1;
                }

                if (tb_4i_port.Text == "")
                {
                    tb_4i_port.BackColor = Color.Tomato;
                    connectionInfoIsEmpty = true;
                    logBox.Items.Add("Please Enter the 4i Server Port");
                    // Scroll Listbox
                    logBox.SelectedIndex = logBox.Items.Count - 1;
                    logBox.SelectedIndex = -1;
                }


                if (connectionInfoIsEmpty != true)
                {
                    RegMNG.RegKeyCreator(
                        tb_4iaddr.Text,
                        tb_4i_username.Text,
                        tb_4i_password.Text,
                        tb_4i_port.Text);

                    // start process
                    if (ck_hidecliwindow.Checked)
                    {
                        PTerminator.ProcessStarter(
                            abdalSocksBridgeExeDir,
                            abdalSocksBridgeDir,
                            true);
                    }
                    else
                    {
                        PTerminator.ProcessStarter(
                            abdalSocksBridgeExeDir,
                            abdalSocksBridgeDir,
                            false);
                    }

                    logBox.Items.Add("Abdal Socks Bridge Starting...");
                    // Scroll Listbox
                    logBox.SelectedIndex = logBox.Items.Count - 1;
                    logBox.SelectedIndex = -1;
                }
            }


            // This example requires Chilkat version 9.5.0.50 or greater.

            pkiller.Interval = Convert.ToInt32(tb_timeTimeoutMs.Text);
            //Enable Tls3
            pkiller.Enabled = true;

            #endregion
        }

        private void Main_Load(object sender, EventArgs e)
        {

           


            var chilkatGlob = new Global();
            var success = chilkatGlob.UnlockBundle("nahaan.CBX1125_FUiiNrsmOG2G");
            if (success != true)
            {
                logBox.Items.Add("License is not Valid");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }
            else
            {
                logBox.Items.Add("License is Valid");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }

            c_lock.Visible = false;
            bw_lock.Visible = true;
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            bool processExist = PTerminator.ProcessExists("Abdal Socks Bridge");
            if (processExist)
            {
                PTerminator.ProcessKiller("Abdal Socks Bridge");
                logBox.Items.Add("kill Abdal Socks Bridge Process");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }

            if (File.Exists(abdalSBCTS))
            {
                try
                {
                    File.Delete(abdalSBCTS);
                }
                catch (Exception exception)
                {
                    logBox.Items.Add(exception);
                    // throw;
                }

                logBox.Items.Add("abdalSBCTS Clean");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }

            pkiller.Interval = Convert.ToInt32(tb_timeTimeoutMs.Text);
            if (RegMNG.RegKeyCheck())
            {
                tb_4iaddr.Text = RegMNG.RegReadKey()["_4iServerAddr"];
                tb_4i_username.Text = RegMNG.RegReadKey()["_4iServerUser"];
                tb_4i_password.Text = RegMNG.RegReadKey()["_4iServerPass"];
                tb_4i_port.Text = RegMNG.RegReadKey()["_4iServerPort"];
            }
        }

        private void bt_disconnect_Click(object sender, EventArgs e)
        {
            if (bw_pkiller.IsBusy)
            {
                bw_pkiller.CancelAsync();
            }


            if (bw_4i_server_dis.IsBusy != true)
            {
                bw_4i_server_dis.RunWorkerAsync();
            }
        }

        private void bw_4i_server_dis_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            #region dis

            pkiller.Enabled = false;
            logBox.Items.Add("Close the 4i tunnel");
            // Scroll Listbox
            logBox.SelectedIndex = logBox.Items.Count - 1;
            logBox.SelectedIndex = -1;

            bool processExist = PTerminator.ProcessExists("Abdal Socks Bridge");
            if (processExist)
            {
                PTerminator.ProcessKiller("Abdal Socks Bridge");
                logBox.Items.Add("kill Abdal Socks Bridge Process");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }

            if (File.Exists(abdalSBCTS))
            {
                try
                {
                    File.Delete(abdalSBCTS);
                }
                catch (Exception exception)
                {
                    logBox.Items.Add(exception);
                    // throw;
                }

                logBox.Items.Add("abdalSBCTS Clean");
                // Scroll Listbox
                logBox.SelectedIndex = logBox.Items.Count - 1;
                logBox.SelectedIndex = -1;
            }

            c_lock.Visible = false;
            bw_lock.Visible = true;

            #endregion
        }

        private void pkiller_Tick(object sender, EventArgs e)
        {
            if (bw_pkiller.IsBusy == false)
            {
                bw_pkiller.RunWorkerAsync();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool processExist = PTerminator.ProcessExists("Abdal Socks Bridge");
            if (processExist)
            {
                PTerminator.ProcessKiller("Abdal Socks Bridge");
            }

            if (File.Exists(abdalSBCTS))
            {
                try
                {
                    File.Delete(abdalSBCTS);
                }
                catch (Exception exception)
                {
                    logBox.Items.Add(exception);
                    // throw;
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void bw_pkiller_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            pkiller.Interval = Convert.ToInt32(tb_timeTimeoutMs.Text);
            if (ch_autoReconnect.Checked)
            {
                #region Check Is Connect to Youtube

                try
                {
                    PTerminator.ProcessStarter(
                        abdal_socks_connector_exe_dir,
                        abdal_socks_connector_dir,
                        true
                    );


                    if (File.Exists(abdal_socks_connector_dir + "error_asc"))
                    {
                        c_lock.Visible = false;
                        bw_lock.Visible = true;
                        bool processExistcCheck = PTerminator.ProcessExists("Abdal Socks Bridge");
                        if (processExistcCheck)
                        {
                            PTerminator.ProcessKiller("Abdal Socks Bridge");
                            try
                            {
                                File.Delete(abdalSBCTS);
                            }
                            catch (Exception exception)
                            {
                                logBox.Items.Add(exception);
                                // throw;
                            }

                            // start process
                            if (ck_hidecliwindow.Checked)
                            {
                                PTerminator.ProcessStarter(
                                    abdalSocksBridgeExeDir,
                                    abdalSocksBridgeDir,
                                    true);
                            }
                            else
                            {
                                PTerminator.ProcessStarter(
                                    abdalSocksBridgeExeDir,
                                    abdalSocksBridgeDir,
                                    false);
                            }

                            logBox.Items.Add("4i Tunnel is not Connected, start Reconnecting");
                            // Scroll Listbox
                            logBox.SelectedIndex = logBox.Items.Count - 1;
                            logBox.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        c_lock.Visible = true;
                        bw_lock.Visible = false;
                    }
                }
                catch (Exception exception)
                {
                    logBox.Items.Add(exception);
                }

                #endregion

                bool processExist = PTerminator.ProcessExists("Abdal Socks Bridge");
                if (processExist && File.Exists(abdalSBCTS))
                {
                    c_lock.Visible = false;
                    bw_lock.Visible = true;
                    PTerminator.ProcessKiller("Abdal Socks Bridge");
                    try
                    {
                        File.Delete(abdalSBCTS);
                    }
                    catch (Exception exception)
                    {
                        logBox.Items.Add(exception);
                        // throw;
                    }

                    // start process
                    if (ck_hidecliwindow.Checked)
                    {
                        PTerminator.ProcessStarter(
                            abdalSocksBridgeExeDir,
                            abdalSocksBridgeDir,
                            true);
                    }
                    else
                    {
                        PTerminator.ProcessStarter(
                            abdalSocksBridgeExeDir,
                            abdalSocksBridgeDir,
                            false);
                    }

                    logBox.Items.Add("4i Tunnel is not Connected, start Reconnecting");
                    // Scroll Listbox
                    logBox.SelectedIndex = logBox.Items.Count - 1;
                    logBox.SelectedIndex = -1;
                }
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.ShowBalloonTip(2000);
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool processExist = PTerminator.ProcessExists("Abdal Socks Bridge");
            if (processExist)
            {
                PTerminator.ProcessKiller("Abdal Socks Bridge");
            }

            if (File.Exists(abdalSBCTS))
            {
                try
                {
                    File.Delete(abdalSBCTS);
                }
                catch (Exception exception)
                {
                    logBox.Items.Add(exception);
                    // throw;
                }
            }

            Environment.Exit(0);
            Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pkiller.Enabled = true;
            if (bw_4i_server.IsBusy == false)
            {
                bw_4i_server.RunWorkerAsync();
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bw_pkiller.IsBusy)
            {
                bw_pkiller.CancelAsync();
            }


            if (bw_4i_server_dis.IsBusy != true)
            {
                bw_4i_server_dis.RunWorkerAsync();
            }
        }
    }
}