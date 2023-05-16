namespace Abdal_Proxy_Bridge
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.logBox = new System.Windows.Forms.ListBox();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_hidecliwindow = new System.Windows.Forms.CheckBox();
            this.tb_4i_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_4iaddr = new System.Windows.Forms.TextBox();
            this.tb_4i_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_4i_username = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_timeTimeoutMs = new System.Windows.Forms.TextBox();
            this.ch_autoReconnect = new System.Windows.Forms.CheckBox();
            this.tb_socks_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_socks_address = new System.Windows.Forms.TextBox();
            this.tb_socks_port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_socks_username = new System.Windows.Forms.TextBox();
            this.bw_4i_server = new System.ComponentModel.BackgroundWorker();
            this.c_lock = new System.Windows.Forms.PictureBox();
            this.bw_4i_server_dis = new System.ComponentModel.BackgroundWorker();
            this.pkiller = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.bw_pkiller = new System.ComponentModel.BackgroundWorker();
            this.bw_lock = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_lock)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bw_lock)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Location = new System.Drawing.Point(12, 292);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(551, 152);
            this.logBox.TabIndex = 0;
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(12, 253);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(83, 23);
            this.bt_connect.TabIndex = 1;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.Location = new System.Drawing.Point(101, 253);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(85, 23);
            this.bt_disconnect.TabIndex = 2;
            this.bt_disconnect.Text = "Disconnect";
            this.bt_disconnect.UseVisualStyleBackColor = true;
            this.bt_disconnect.Click += new System.EventHandler(this.bt_disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "4i Server Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ck_hidecliwindow);
            this.groupBox1.Controls.Add(this.tb_4i_password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_4iaddr);
            this.groupBox1.Controls.Add(this.tb_4i_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_4i_username);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4i Server Setting";
            // 
            // ck_hidecliwindow
            // 
            this.ck_hidecliwindow.AutoSize = true;
            this.ck_hidecliwindow.Checked = true;
            this.ck_hidecliwindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_hidecliwindow.Location = new System.Drawing.Point(21, 150);
            this.ck_hidecliwindow.Name = "ck_hidecliwindow";
            this.ck_hidecliwindow.Size = new System.Drawing.Size(222, 19);
            this.ck_hidecliwindow.TabIndex = 12;
            this.ck_hidecliwindow.Text = "Hide Abdal Socks Bridge CLI Window";
            this.ck_hidecliwindow.UseVisualStyleBackColor = true;
            // 
            // tb_4i_password
            // 
            this.tb_4i_password.Location = new System.Drawing.Point(179, 99);
            this.tb_4i_password.Name = "tb_4i_password";
            this.tb_4i_password.Size = new System.Drawing.Size(150, 23);
            this.tb_4i_password.TabIndex = 11;
            this.tb_4i_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "4i Server Password";
            // 
            // tb_4iaddr
            // 
            this.tb_4iaddr.Location = new System.Drawing.Point(18, 55);
            this.tb_4iaddr.Name = "tb_4iaddr";
            this.tb_4iaddr.Size = new System.Drawing.Size(207, 23);
            this.tb_4iaddr.TabIndex = 5;
            // 
            // tb_4i_port
            // 
            this.tb_4i_port.Location = new System.Drawing.Point(231, 55);
            this.tb_4i_port.Name = "tb_4i_port";
            this.tb_4i_port.Size = new System.Drawing.Size(98, 23);
            this.tb_4i_port.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "4i Server UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "4i Server Port";
            // 
            // tb_4i_username
            // 
            this.tb_4i_username.Location = new System.Drawing.Point(18, 99);
            this.tb_4i_username.Name = "tb_4i_username";
            this.tb_4i_username.Size = new System.Drawing.Size(155, 23);
            this.tb_4i_username.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_timeTimeoutMs);
            this.groupBox2.Controls.Add(this.ch_autoReconnect);
            this.groupBox2.Controls.Add(this.tb_socks_password);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_socks_address);
            this.groupBox2.Controls.Add(this.tb_socks_port);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_socks_username);
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 186);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Socks Server Setting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tunnel ConnectTimeoutMs";
            // 
            // tb_timeTimeoutMs
            // 
            this.tb_timeTimeoutMs.Location = new System.Drawing.Point(18, 143);
            this.tb_timeTimeoutMs.Name = "tb_timeTimeoutMs";
            this.tb_timeTimeoutMs.Size = new System.Drawing.Size(156, 23);
            this.tb_timeTimeoutMs.TabIndex = 5;
            this.tb_timeTimeoutMs.Text = "5000";
            // 
            // ch_autoReconnect
            // 
            this.ch_autoReconnect.AutoSize = true;
            this.ch_autoReconnect.Checked = true;
            this.ch_autoReconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_autoReconnect.Location = new System.Drawing.Point(190, 147);
            this.ch_autoReconnect.Name = "ch_autoReconnect";
            this.ch_autoReconnect.Size = new System.Drawing.Size(111, 19);
            this.ch_autoReconnect.TabIndex = 6;
            this.ch_autoReconnect.Text = "Auto Reconnect";
            this.ch_autoReconnect.UseVisualStyleBackColor = true;
            // 
            // tb_socks_password
            // 
            this.tb_socks_password.Location = new System.Drawing.Point(179, 99);
            this.tb_socks_password.Name = "tb_socks_password";
            this.tb_socks_password.ReadOnly = true;
            this.tb_socks_password.Size = new System.Drawing.Size(150, 23);
            this.tb_socks_password.TabIndex = 11;
            this.tb_socks_password.Text = "abdal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Socks Server Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Socks Server Password";
            // 
            // tb_socks_address
            // 
            this.tb_socks_address.Location = new System.Drawing.Point(18, 55);
            this.tb_socks_address.Name = "tb_socks_address";
            this.tb_socks_address.ReadOnly = true;
            this.tb_socks_address.Size = new System.Drawing.Size(207, 23);
            this.tb_socks_address.TabIndex = 5;
            this.tb_socks_address.Text = "127.0.0.1";
            // 
            // tb_socks_port
            // 
            this.tb_socks_port.Location = new System.Drawing.Point(231, 55);
            this.tb_socks_port.Name = "tb_socks_port";
            this.tb_socks_port.ReadOnly = true;
            this.tb_socks_port.Size = new System.Drawing.Size(98, 23);
            this.tb_socks_port.TabIndex = 9;
            this.tb_socks_port.Text = "52905";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Socks Server UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Socks Server Port";
            // 
            // tb_socks_username
            // 
            this.tb_socks_username.Location = new System.Drawing.Point(18, 99);
            this.tb_socks_username.Name = "tb_socks_username";
            this.tb_socks_username.ReadOnly = true;
            this.tb_socks_username.Size = new System.Drawing.Size(155, 23);
            this.tb_socks_username.TabIndex = 7;
            this.tb_socks_username.Text = "abdal";
            // 
            // bw_4i_server
            // 
            this.bw_4i_server.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_4i_server_DoWork);
            // 
            // c_lock
            // 
            this.c_lock.Image = global::ASBL.Properties.Resources._053;
            this.c_lock.Location = new System.Drawing.Point(595, 301);
            this.c_lock.Name = "c_lock";
            this.c_lock.Size = new System.Drawing.Size(143, 143);
            this.c_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c_lock.TabIndex = 13;
            this.c_lock.TabStop = false;
            // 
            // bw_4i_server_dis
            // 
            this.bw_4i_server_dis.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_4i_server_dis_DoWork);
            // 
            // pkiller
            // 
            this.pkiller.Enabled = true;
            this.pkiller.Interval = 5000;
            this.pkiller.Tick += new System.EventHandler(this.pkiller_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 455);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(215, 22);
            this.toolStripLabel1.Text = "Programmer: Ebrahim Shafiei (EbraSha)";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel2.Text = "Phone: 09022223301";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(171, 22);
            this.toolStripLabel3.Text = "Email: Prof.Shafiei@Gmail.com";
            // 
            // bw_pkiller
            // 
            this.bw_pkiller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_pkiller_DoWork);
            // 
            // bw_lock
            // 
            this.bw_lock.Image = global::ASBL.Properties.Resources.wb4;
            this.bw_lock.Location = new System.Drawing.Point(595, 301);
            this.bw_lock.Name = "bw_lock";
            this.bw_lock.Size = new System.Drawing.Size(143, 143);
            this.bw_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bw_lock.TabIndex = 15;
            this.bw_lock.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "I am Here!";
            this.notifyIcon1.BalloonTipTitle = "Abdal Socks Bridge";
            this.notifyIcon1.ContextMenuStrip = this.Menu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Abdal Socks Bridge";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.Menu.Name = "Exit";
            this.Menu.Size = new System.Drawing.Size(134, 76);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 480);
            this.Controls.Add(this.bw_lock);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.c_lock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_disconnect);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.logBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abdal Socks Bridge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_lock)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bw_lock)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox logBox;
        private Button bt_connect;
        private Button bt_disconnect;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_4iaddr;
        private TextBox tb_4i_username;
        private Label label2;
        private TextBox tb_4i_port;
        private Label label3;
        private TextBox tb_4i_password;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox tb_socks_password;
        private Label label5;
        private Label label6;
        private TextBox tb_socks_address;
        private TextBox tb_socks_port;
        private Label label7;
        private Label label8;
        private TextBox tb_socks_username;
        private System.ComponentModel.BackgroundWorker bw_4i_server;
        private PictureBox c_lock;
        private Label label9;
        private TextBox tb_timeTimeoutMs;
        private System.ComponentModel.BackgroundWorker bw_4i_server_dis;
        private CheckBox ch_autoReconnect;
        private System.Windows.Forms.Timer pkiller;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel3;
        private System.ComponentModel.BackgroundWorker bw_pkiller;
        public CheckBox ck_hidecliwindow;
        private PictureBox bw_lock;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip Menu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem connectToolStripMenuItem;
    }
}