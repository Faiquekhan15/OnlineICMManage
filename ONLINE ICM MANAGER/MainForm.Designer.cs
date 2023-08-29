

namespace ONLINE_ICM_MANAGER
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;
       

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.EssencialInfo = new System.Windows.Forms.Panel();
            this.Setting = new System.Windows.Forms.Panel();
            this.label_Text = new System.Windows.Forms.Label();
            this.killSwitch = new System.Windows.Forms.Button();
            this.autoconfig = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PanelForAssociations = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Send_RLRQ = new System.Windows.Forms.Button();
            this.Copy_Sending_Data = new System.Windows.Forms.Button();
            this.Copyreceiving = new System.Windows.Forms.Button();
            this.Send_AARQ = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Sendingsize_Label = new System.Windows.Forms.Label();
            this.SendBufferSizeBox = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.Client_labelIP = new System.Windows.Forms.Label();
            this.LinkSpeed = new System.Windows.Forms.TextBox();
            this.Recieving_Buffer_Size = new System.Windows.Forms.Label();
            this.Client_IP = new System.Windows.Forms.Label();
            this.DNSHOSTLABEL = new System.Windows.Forms.Label();
            this.LocalIP = new System.Windows.Forms.Label();
            this.ConnectionTimeLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.IPBOX = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Label_Host_IP = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Port = new System.Windows.Forms.ComboBox();
            this.Label_port_Box = new System.Windows.Forms.Label();
            this.Label_Notification_From_Server = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relayOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relayOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOpenFlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend5 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend4 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.ToggleContentButton = new System.Windows.Forms.Button();
            this.MainPage.SuspendLayout();
            this.EssencialInfo.SuspendLayout();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.PanelForAssociations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bw1
            // 
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            this.bw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw1_ProgressChanged);
            this.bw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw1_RunWorkerCompleted);
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPage.BackgroundImage")));
            this.MainPage.Controls.Add(this.ToggleContentButton);
            this.MainPage.Controls.Add(this.input2);
            this.MainPage.Controls.Add(this.input1);
            this.MainPage.Controls.Add(this.input4);
            this.MainPage.Controls.Add(this.input3);
            this.MainPage.Controls.Add(this.input5);
            this.MainPage.Controls.Add(this.btnSend1);
            this.MainPage.Controls.Add(this.btnSend5);
            this.MainPage.Controls.Add(this.btnSend2);
            this.MainPage.Controls.Add(this.btnSend4);
            this.MainPage.Controls.Add(this.btnSend3);
            this.MainPage.Controls.Add(this.EssencialInfo);
            this.MainPage.Controls.Add(this.IPBOX);
            this.MainPage.Controls.Add(this.listBox2);
            this.MainPage.Controls.Add(this.Label_Host_IP);
            this.MainPage.Controls.Add(this.listBox1);
            this.MainPage.Controls.Add(this.Port);
            this.MainPage.Controls.Add(this.Label_port_Box);
            this.MainPage.Controls.Add(this.Label_Notification_From_Server);
            this.MainPage.Controls.Add(this.menuStrip1);
            this.MainPage.Location = new System.Drawing.Point(4, 29);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1525, 664);
            this.MainPage.TabIndex = 0;
            // 
            // EssencialInfo
            // 
            this.EssencialInfo.BackColor = System.Drawing.Color.Navy;
            this.EssencialInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EssencialInfo.Controls.Add(this.Setting);
            this.EssencialInfo.Controls.Add(this.PanelForAssociations);
            this.EssencialInfo.Controls.Add(this.Sendingsize_Label);
            this.EssencialInfo.Controls.Add(this.SendBufferSizeBox);
            this.EssencialInfo.Controls.Add(this.btnServer);
            this.EssencialInfo.Controls.Add(this.Client_labelIP);
            this.EssencialInfo.Controls.Add(this.LinkSpeed);
            this.EssencialInfo.Controls.Add(this.Recieving_Buffer_Size);
            this.EssencialInfo.Controls.Add(this.Client_IP);
            this.EssencialInfo.Controls.Add(this.DNSHOSTLABEL);
            this.EssencialInfo.Controls.Add(this.LocalIP);
            this.EssencialInfo.Controls.Add(this.ConnectionTimeLabel);
            this.EssencialInfo.Controls.Add(this.TimeBox);
            this.EssencialInfo.Controls.Add(this.btnStopServer);
            this.EssencialInfo.Location = new System.Drawing.Point(10, 227);
            this.EssencialInfo.Name = "EssencialInfo";
            this.EssencialInfo.Padding = new System.Windows.Forms.Padding(15);
            this.EssencialInfo.Size = new System.Drawing.Size(1503, 141);
            this.EssencialInfo.TabIndex = 78;
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Setting.Controls.Add(this.label_Text);
            this.Setting.Controls.Add(this.killSwitch);
            this.Setting.Controls.Add(this.autoconfig);
            this.Setting.Controls.Add(this.numericUpDown);
            this.Setting.Location = new System.Drawing.Point(752, 12);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(378, 109);
            this.Setting.TabIndex = 80;
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Font = new System.Drawing.Font("Vivaldi", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text.Location = new System.Drawing.Point(3, 6);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(122, 38);
            this.label_Text.TabIndex = 82;
            this.label_Text.Text = "Settings";
            // 
            // killSwitch
            // 
            this.killSwitch.Location = new System.Drawing.Point(21, 72);
            this.killSwitch.Name = "killSwitch";
            this.killSwitch.Size = new System.Drawing.Size(189, 21);
            this.killSwitch.TabIndex = 81;
            this.killSwitch.Text = "Stop Auto Configuration";
            this.killSwitch.UseVisualStyleBackColor = true;
            this.killSwitch.Click += new System.EventHandler(this.killSwitch_Click);
            // 
            // autoconfig
            // 
            this.autoconfig.Location = new System.Drawing.Point(21, 46);
            this.autoconfig.Name = "autoconfig";
            this.autoconfig.Size = new System.Drawing.Size(153, 23);
            this.autoconfig.TabIndex = 79;
            this.autoconfig.Text = "Auto Configuration";
            this.autoconfig.UseVisualStyleBackColor = true;
            this.autoconfig.Click += new System.EventHandler(this.autoconfig_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(213, 45);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(60, 26);
            this.numericUpDown.TabIndex = 80;
            // 
            // PanelForAssociations
            // 
            this.PanelForAssociations.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.PanelForAssociations.AllowDrop = true;
            this.PanelForAssociations.BackColor = System.Drawing.Color.Azure;
            this.PanelForAssociations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelForAssociations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelForAssociations.Controls.Add(this.label2);
            this.PanelForAssociations.Controls.Add(this.label1);
            this.PanelForAssociations.Controls.Add(this.Send_RLRQ);
            this.PanelForAssociations.Controls.Add(this.Copy_Sending_Data);
            this.PanelForAssociations.Controls.Add(this.Copyreceiving);
            this.PanelForAssociations.Controls.Add(this.Send_AARQ);
            this.PanelForAssociations.Controls.Add(this.btnClear);
            this.PanelForAssociations.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.PanelForAssociations.Location = new System.Drawing.Point(224, 12);
            this.PanelForAssociations.Name = "PanelForAssociations";
            this.PanelForAssociations.Size = new System.Drawing.Size(525, 108);
            this.PanelForAssociations.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 84;
            this.label2.Text = "Operations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 83;
            this.label1.Text = "Commands";
            // 
            // Send_RLRQ
            // 
            this.Send_RLRQ.Location = new System.Drawing.Point(261, 10);
            this.Send_RLRQ.Name = "Send_RLRQ";
            this.Send_RLRQ.Size = new System.Drawing.Size(107, 22);
            this.Send_RLRQ.TabIndex = 63;
            this.Send_RLRQ.Text = "Send RLRQ";
            this.Send_RLRQ.UseVisualStyleBackColor = true;
            this.Send_RLRQ.Click += new System.EventHandler(this.Send_RLRQ_Click);
            // 
            // Copy_Sending_Data
            // 
            this.Copy_Sending_Data.Location = new System.Drawing.Point(325, 49);
            this.Copy_Sending_Data.Name = "Copy_Sending_Data";
            this.Copy_Sending_Data.Size = new System.Drawing.Size(171, 23);
            this.Copy_Sending_Data.TabIndex = 81;
            this.Copy_Sending_Data.Text = "Copy Sending Data";
            this.Copy_Sending_Data.UseVisualStyleBackColor = true;
            this.Copy_Sending_Data.Click += new System.EventHandler(this.Copy_Sending_Data_Click);
            // 
            // Copyreceiving
            // 
            this.Copyreceiving.Location = new System.Drawing.Point(148, 49);
            this.Copyreceiving.Name = "Copyreceiving";
            this.Copyreceiving.Size = new System.Drawing.Size(171, 23);
            this.Copyreceiving.TabIndex = 80;
            this.Copyreceiving.Text = "Copy Receiving Data";
            this.Copyreceiving.UseVisualStyleBackColor = true;
            this.Copyreceiving.Click += new System.EventHandler(this.Copyreceiving_Click);
            // 
            // Send_AARQ
            // 
            this.Send_AARQ.Location = new System.Drawing.Point(148, 10);
            this.Send_AARQ.Name = "Send_AARQ";
            this.Send_AARQ.Size = new System.Drawing.Size(107, 22);
            this.Send_AARQ.TabIndex = 19;
            this.Send_AARQ.Text = "Send AARQ";
            this.Send_AARQ.UseVisualStyleBackColor = true;
            this.Send_AARQ.Click += new System.EventHandler(this.AARQ_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(411, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Sendingsize_Label
            // 
            this.Sendingsize_Label.AutoSize = true;
            this.Sendingsize_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendingsize_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sendingsize_Label.Location = new System.Drawing.Point(1135, 45);
            this.Sendingsize_Label.Name = "Sendingsize_Label";
            this.Sendingsize_Label.Size = new System.Drawing.Size(171, 20);
            this.Sendingsize_Label.TabIndex = 79;
            this.Sendingsize_Label.Text = "Sending Frame Size";
            // 
            // SendBufferSizeBox
            // 
            this.SendBufferSizeBox.Location = new System.Drawing.Point(1385, 45);
            this.SendBufferSizeBox.Name = "SendBufferSizeBox";
            this.SendBufferSizeBox.Size = new System.Drawing.Size(75, 26);
            this.SendBufferSizeBox.TabIndex = 78;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(10, 82);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(85, 23);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Start Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Client_labelIP
            // 
            this.Client_labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_labelIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Client_labelIP.Location = new System.Drawing.Point(6, 15);
            this.Client_labelIP.Name = "Client_labelIP";
            this.Client_labelIP.Size = new System.Drawing.Size(75, 20);
            this.Client_labelIP.TabIndex = 20;
            this.Client_labelIP.Text = "ClientIP";
            // 
            // LinkSpeed
            // 
            this.LinkSpeed.Location = new System.Drawing.Point(1385, 75);
            this.LinkSpeed.Name = "LinkSpeed";
            this.LinkSpeed.Size = new System.Drawing.Size(75, 26);
            this.LinkSpeed.TabIndex = 76;
            // 
            // Recieving_Buffer_Size
            // 
            this.Recieving_Buffer_Size.AutoSize = true;
            this.Recieving_Buffer_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieving_Buffer_Size.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recieving_Buffer_Size.Location = new System.Drawing.Point(1135, 75);
            this.Recieving_Buffer_Size.Name = "Recieving_Buffer_Size";
            this.Recieving_Buffer_Size.Size = new System.Drawing.Size(183, 20);
            this.Recieving_Buffer_Size.TabIndex = 77;
            this.Recieving_Buffer_Size.Text = "Receiving Frame Size";
            // 
            // Client_IP
            // 
            this.Client_IP.AutoSize = true;
            this.Client_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_IP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Client_IP.Location = new System.Drawing.Point(87, 15);
            this.Client_IP.Name = "Client_IP";
            this.Client_IP.Size = new System.Drawing.Size(21, 20);
            this.Client_IP.TabIndex = 17;
            this.Client_IP.Text = "--";
            // 
            // DNSHOSTLABEL
            // 
            this.DNSHOSTLABEL.AutoSize = true;
            this.DNSHOSTLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNSHOSTLABEL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DNSHOSTLABEL.Location = new System.Drawing.Point(6, 47);
            this.DNSHOSTLABEL.Name = "DNSHOSTLABEL";
            this.DNSHOSTLABEL.Size = new System.Drawing.Size(74, 20);
            this.DNSHOSTLABEL.TabIndex = 1;
            this.DNSHOSTLABEL.Text = "Local IP";
            // 
            // LocalIP
            // 
            this.LocalIP.AutoSize = true;
            this.LocalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LocalIP.Location = new System.Drawing.Point(89, 47);
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(21, 20);
            this.LocalIP.TabIndex = 18;
            this.LocalIP.Text = "--";
            // 
            // ConnectionTimeLabel
            // 
            this.ConnectionTimeLabel.AutoSize = true;
            this.ConnectionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionTimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectionTimeLabel.Location = new System.Drawing.Point(1135, 15);
            this.ConnectionTimeLabel.Name = "ConnectionTimeLabel";
            this.ConnectionTimeLabel.Size = new System.Drawing.Size(242, 20);
            this.ConnectionTimeLabel.TabIndex = 73;
            this.ConnectionTimeLabel.Text = "Connection Established Time";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(1385, 15);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(75, 26);
            this.TimeBox.TabIndex = 71;
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(101, 81);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(85, 23);
            this.btnStopServer.TabIndex = 20;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // IPBOX
            // 
            this.IPBOX.FormattingEnabled = true;
            this.IPBOX.Location = new System.Drawing.Point(80, 92);
            this.IPBOX.Name = "IPBOX";
            this.IPBOX.Size = new System.Drawing.Size(135, 28);
            this.IPBOX.TabIndex = 75;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(704, 374);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(807, 284);
            this.listBox2.TabIndex = 70;
            // 
            // Label_Host_IP
            // 
            this.Label_Host_IP.AutoSize = true;
            this.Label_Host_IP.BackColor = System.Drawing.Color.Transparent;
            this.Label_Host_IP.Location = new System.Drawing.Point(12, 95);
            this.Label_Host_IP.Name = "Label_Host_IP";
            this.Label_Host_IP.Size = new System.Drawing.Size(62, 20);
            this.Label_Host_IP.TabIndex = 14;
            this.Label_Host_IP.Text = "Host IP";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(10, 374);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(676, 284);
            this.listBox1.TabIndex = 64;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // Port
            // 
            this.Port.FormattingEnabled = true;
            this.Port.Items.AddRange(new object[] {
            "9001",
            "9002",
            "9003",
            "9004",
            "9005",
            "9006",
            "9007",
            "9008",
            "9009",
            "9010"});
            this.Port.Location = new System.Drawing.Point(80, 122);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(75, 28);
            this.Port.TabIndex = 13;
            // 
            // Label_port_Box
            // 
            this.Label_port_Box.AutoSize = true;
            this.Label_port_Box.BackColor = System.Drawing.Color.Transparent;
            this.Label_port_Box.Location = new System.Drawing.Point(12, 130);
            this.Label_port_Box.Name = "Label_port_Box";
            this.Label_port_Box.Size = new System.Drawing.Size(38, 20);
            this.Label_port_Box.TabIndex = 15;
            this.Label_port_Box.Text = "Port";
            // 
            // Label_Notification_From_Server
            // 
            this.Label_Notification_From_Server.AutoSize = true;
            this.Label_Notification_From_Server.BackColor = System.Drawing.Color.Transparent;
            this.Label_Notification_From_Server.ForeColor = System.Drawing.Color.Red;
            this.Label_Notification_From_Server.Location = new System.Drawing.Point(27, 159);
            this.Label_Notification_From_Server.Name = "Label_Notification_From_Server";
            this.Label_Notification_From_Server.Size = new System.Drawing.Size(128, 20);
            this.Label_Notification_From_Server.TabIndex = 16;
            this.Label_Notification_From_Server.Text = "Server Started....";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1519, 33);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "Main Menu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relayOnToolStripMenuItem,
            this.relayOffToolStripMenuItem,
            this.clearOpenFlagToolStripMenuItem,
            this.clearAllEventsToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // relayOnToolStripMenuItem
            // 
            this.relayOnToolStripMenuItem.Name = "relayOnToolStripMenuItem";
            this.relayOnToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.relayOnToolStripMenuItem.Text = "Relay On";
            this.relayOnToolStripMenuItem.Click += new System.EventHandler(this.relayOnToolStripMenuItem_Click);
            // 
            // relayOffToolStripMenuItem
            // 
            this.relayOffToolStripMenuItem.Name = "relayOffToolStripMenuItem";
            this.relayOffToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.relayOffToolStripMenuItem.Text = "Relay Off";
            this.relayOffToolStripMenuItem.Click += new System.EventHandler(this.relayOffToolStripMenuItem_Click);
            // 
            // clearOpenFlagToolStripMenuItem
            // 
            this.clearOpenFlagToolStripMenuItem.Name = "clearOpenFlagToolStripMenuItem";
            this.clearOpenFlagToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.clearOpenFlagToolStripMenuItem.Text = "Clear Open Flag";
            this.clearOpenFlagToolStripMenuItem.Click += new System.EventHandler(this.clearOpenFlagToolStripMenuItem_Click);
            // 
            // clearAllEventsToolStripMenuItem
            // 
            this.clearAllEventsToolStripMenuItem.Name = "clearAllEventsToolStripMenuItem";
            this.clearAllEventsToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.clearAllEventsToolStripMenuItem.Text = "Clear All Events";
            this.clearAllEventsToolStripMenuItem.Click += new System.EventHandler(this.clearAllEventsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1533, 697);
            this.tabControl1.TabIndex = 72;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(235, 100);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(1143, 26);
            this.input2.TabIndex = 85;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(235, 70);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(1143, 26);
            this.input1.TabIndex = 84;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(235, 160);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(1143, 26);
            this.input4.TabIndex = 82;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(235, 130);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(1143, 26);
            this.input3.TabIndex = 81;
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(235, 190);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(1143, 26);
            this.input5.TabIndex = 80;
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(1393, 70);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(114, 20);
            this.btnSend1.TabIndex = 86;
            this.btnSend1.Text = "Send Request";
            this.btnSend1.UseVisualStyleBackColor = true;
            // 
            // btnSend5
            // 
            this.btnSend5.Location = new System.Drawing.Point(1393, 190);
            this.btnSend5.Name = "btnSend5";
            this.btnSend5.Size = new System.Drawing.Size(114, 20);
            this.btnSend5.TabIndex = 79;
            this.btnSend5.Text = "Send Request";
            this.btnSend5.UseVisualStyleBackColor = true;
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(1393, 100);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(114, 20);
            this.btnSend2.TabIndex = 87;
            this.btnSend2.Text = "Send Request";
            this.btnSend2.UseVisualStyleBackColor = true;
            // 
            // btnSend4
            // 
            this.btnSend4.Location = new System.Drawing.Point(1393, 160);
            this.btnSend4.Name = "btnSend4";
            this.btnSend4.Size = new System.Drawing.Size(114, 20);
            this.btnSend4.TabIndex = 83;
            this.btnSend4.Text = "Send Request";
            this.btnSend4.UseVisualStyleBackColor = true;
            // 
            // btnSend3
            // 
            this.btnSend3.Location = new System.Drawing.Point(1393, 130);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(114, 20);
            this.btnSend3.TabIndex = 88;
            this.btnSend3.Text = "Send Request";
            this.btnSend3.UseVisualStyleBackColor = true;
            // 
            // ToggleContentButton
            // 
            this.ToggleContentButton.Location = new System.Drawing.Point(10, 198);
            this.ToggleContentButton.Name = "ToggleContentButton";
            this.ToggleContentButton.Size = new System.Drawing.Size(23, 23);
            this.ToggleContentButton.TabIndex = 89;
            this.ToggleContentButton.Text = "+";
            this.ToggleContentButton.UseVisualStyleBackColor = true;
            this.ToggleContentButton.Click += new System.EventHandler(this.ToggleContentButton_Click);
            // 
            // MainForm
            // 
            this.AccessibleName = "ICM Online Manager";
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1548, 733);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ICM Online Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.EssencialInfo.ResumeLayout(false);
            this.EssencialInfo.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.PanelForAssociations.ResumeLayout(false);
            this.PanelForAssociations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.Panel EssencialInfo;
        private System.Windows.Forms.Panel Setting;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.Button killSwitch;
        private System.Windows.Forms.Button autoconfig;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Panel PanelForAssociations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Send_RLRQ;
        private System.Windows.Forms.Button Copy_Sending_Data;
        private System.Windows.Forms.Button Copyreceiving;
        public System.Windows.Forms.Button Send_AARQ;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Sendingsize_Label;
        private System.Windows.Forms.TextBox SendBufferSizeBox;
        public System.Windows.Forms.Button btnServer;
        public System.Windows.Forms.Label Client_labelIP;
        private System.Windows.Forms.TextBox LinkSpeed;
        private System.Windows.Forms.Label Recieving_Buffer_Size;
        public System.Windows.Forms.Label Client_IP;
        public System.Windows.Forms.Label DNSHOSTLABEL;
        public System.Windows.Forms.Label LocalIP;
        private System.Windows.Forms.Label ConnectionTimeLabel;
        private System.Windows.Forms.TextBox TimeBox;
        public System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.ComboBox IPBOX;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.Label Label_Host_IP;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Port;
        public System.Windows.Forms.Label Label_port_Box;
        public System.Windows.Forms.Label Label_Notification_From_Server;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relayOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relayOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOpenFlagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox input2;
        public System.Windows.Forms.TextBox input1;
        public System.Windows.Forms.TextBox input4;
        public System.Windows.Forms.TextBox input3;
        public System.Windows.Forms.TextBox input5;
        public System.Windows.Forms.Button btnSend1;
        public System.Windows.Forms.Button btnSend5;
        public System.Windows.Forms.Button btnSend2;
        public System.Windows.Forms.Button btnSend4;
        public System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Button ToggleContentButton;
    }
}
