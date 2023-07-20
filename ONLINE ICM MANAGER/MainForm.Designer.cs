using System.Windows.Forms;

namespace TCP_Stream_Writer
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
            this.LocalIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Host_IP = new System.Windows.Forms.Label();
            this.Label_port_Box = new System.Windows.Forms.Label();
            this.Label_Notification_From_Server = new System.Windows.Forms.Label();
            this.Client_IP = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.IP1 = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.TextBox();
            this.AARQ = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.btnInput1 = new System.Windows.Forms.Button();
            this.btnInput3 = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.btnInput4 = new System.Windows.Forms.Button();
            this.input5 = new System.Windows.Forms.TextBox();
            this.btnInput5 = new System.Windows.Forms.Button();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.Send_RLRQ = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.ComboBox();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.bw3 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relayOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relayOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOpenFlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.PB1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Min = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Sim_ReadtabPage2 = new System.Windows.Forms.TabPage();
            this.simsreadbutton1 = new System.Windows.Forms.Button();
            this.Sim3Numberlabel3 = new System.Windows.Forms.Label();
            this.Sim2Numberlabel2 = new System.Windows.Forms.Label();
            this.Sim1Numberlabel1 = new System.Windows.Forms.Label();
            this.Sim3_Number_Read_Box3 = new System.Windows.Forms.TextBox();
            this.Sim2_Number_Read_Box2 = new System.Windows.Forms.TextBox();
            this.Sim1_Number_Read_Box1 = new System.Windows.Forms.TextBox();
            this.Sim_WritetabPage3 = new System.Windows.Forms.TabPage();
            this.Sim_Write_button = new System.Windows.Forms.Button();
            this.Sim3Number_lb3_wrt = new System.Windows.Forms.Label();
            this.Sim2Number_lb1_wrt = new System.Windows.Forms.Label();
            this.Sim1Number_lb1_wrt = new System.Windows.Forms.Label();
            this.Sim1_Number_Box3 = new System.Windows.Forms.TextBox();
            this.Sim1_Number_Box2 = new System.Windows.Forms.TextBox();
            this.Sim1_Number_Box1 = new System.Windows.Forms.TextBox();
            this.InstantaneousData_tabPage4 = new System.Windows.Forms.TabPage();
            this.freqbox = new System.Windows.Forms.TextBox();
            this.freqboxlabel6 = new System.Windows.Forms.Label();
            this.meterserialnumber = new System.Windows.Forms.TextBox();
            this.currenta = new System.Windows.Forms.TextBox();
            this.AggregatePowerImportbox = new System.Windows.Forms.TextBox();
            this.AggReactivePowerExport_Box = new System.Windows.Forms.TextBox();
            this.PowerFactorbox = new System.Windows.Forms.TextBox();
            this.AggActivePowerExportbox = new System.Windows.Forms.TextBox();
            this.signal = new System.Windows.Forms.TextBox();
            this.meterdatetime = new System.Windows.Forms.TextBox();
            this.currb = new System.Windows.Forms.TextBox();
            this.currentc = new System.Windows.Forms.TextBox();
            this.voltagea = new System.Windows.Forms.TextBox();
            this.voltageb = new System.Windows.Forms.TextBox();
            this.voltagec = new System.Windows.Forms.TextBox();
            this.AggActivePowerImportbox = new System.Windows.Forms.TextBox();
            this.currentTarrrr_Box = new System.Windows.Forms.TextBox();
            this.PowerFactorboxlabel15 = new System.Windows.Forms.Label();
            this.AggReactivePowerExport_Boxlabel14 = new System.Windows.Forms.Label();
            this.AggregatePowerImportboxlabel13 = new System.Windows.Forms.Label();
            this.AggActivePowerExportboxlabel12 = new System.Windows.Forms.Label();
            this.AggregateActivePowerImport_lbl = new System.Windows.Forms.Label();
            this.voltage_c = new System.Windows.Forms.Label();
            this.voltage_b = new System.Windows.Forms.Label();
            this.voltage_a = new System.Windows.Forms.Label();
            this.currentcphase = new System.Windows.Forms.Label();
            this.currentb = new System.Windows.Forms.Label();
            this.CAlabel5 = new System.Windows.Forms.Label();
            this.Meter_Date_Timelabel = new System.Windows.Forms.Label();
            this.MeterSerialNumberlabel3 = new System.Windows.Forms.Label();
            this.SignalStrengthlabel2 = new System.Windows.Forms.Label();
            this.CurrentTariffRegisterlabel1 = new System.Windows.Forms.Label();
            this.Read_Instantaneous_data = new System.Windows.Forms.Button();
            this.Remote_Upgrade_tabPage5 = new System.Windows.Forms.TabPage();
            this.Utilities_Data = new System.Windows.Forms.TabPage();
            this.UtilitiesBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Load_Data = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SimRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.Sim_ReadtabPage2.SuspendLayout();
            this.Sim_WritetabPage3.SuspendLayout();
            this.InstantaneousData_tabPage4.SuspendLayout();
            this.Remote_Upgrade_tabPage5.SuspendLayout();
            this.Utilities_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalIP
            // 
            this.LocalIP.AutoSize = true;
            this.LocalIP.Location = new System.Drawing.Point(593, 264);
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(19, 20);
            this.LocalIP.TabIndex = 18;
            this.LocalIP.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local IP";
            // 
            // Label_Host_IP
            // 
            this.Label_Host_IP.AutoSize = true;
            this.Label_Host_IP.Location = new System.Drawing.Point(19, 40);
            this.Label_Host_IP.Name = "Label_Host_IP";
            this.Label_Host_IP.Size = new System.Drawing.Size(62, 20);
            this.Label_Host_IP.TabIndex = 14;
            this.Label_Host_IP.Text = "Host IP";
            // 
            // Label_port_Box
            // 
            this.Label_port_Box.AutoSize = true;
            this.Label_port_Box.Location = new System.Drawing.Point(19, 69);
            this.Label_port_Box.Name = "Label_port_Box";
            this.Label_port_Box.Size = new System.Drawing.Size(38, 20);
            this.Label_port_Box.TabIndex = 15;
            this.Label_port_Box.Text = "Port";
            // 
            // Label_Notification_From_Server
            // 
            this.Label_Notification_From_Server.AutoSize = true;
            this.Label_Notification_From_Server.ForeColor = System.Drawing.Color.Red;
            this.Label_Notification_From_Server.Location = new System.Drawing.Point(19, 125);
            this.Label_Notification_From_Server.Name = "Label_Notification_From_Server";
            this.Label_Notification_From_Server.Size = new System.Drawing.Size(128, 20);
            this.Label_Notification_From_Server.TabIndex = 16;
            this.Label_Notification_From_Server.Text = "Server Started....";
            // 
            // Client_IP
            // 
            this.Client_IP.AutoSize = true;
            this.Client_IP.Location = new System.Drawing.Point(593, 241);
            this.Client_IP.Name = "Client_IP";
            this.Client_IP.Size = new System.Drawing.Size(19, 20);
            this.Client_IP.TabIndex = 17;
            this.Client_IP.Text = "--";
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(6, 162);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(85, 23);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Start Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(92, 37);
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(110, 26);
            this.IP1.TabIndex = 9;
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(92, 162);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(85, 23);
            this.btnStopServer.TabIndex = 20;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.Location = new System.Drawing.Point(1266, 38);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(114, 20);
            this.btnInput.TabIndex = 61;
            this.btnInput.Text = "Send Request";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1285, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // input2
            // 
            this.input2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input2.Location = new System.Drawing.Point(233, 72);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(1027, 26);
            this.input2.TabIndex = 21;
            // 
            // AARQ
            // 
            this.AARQ.Location = new System.Drawing.Point(199, 232);
            this.AARQ.Name = "AARQ";
            this.AARQ.Size = new System.Drawing.Size(107, 38);
            this.AARQ.TabIndex = 19;
            this.AARQ.Text = "Send AARQ";
            this.AARQ.Click += new System.EventHandler(this.AARQ_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(8, 307);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(677, 324);
            this.listBox1.TabIndex = 64;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Location = new System.Drawing.Point(233, 40);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(1027, 26);
            this.input1.TabIndex = 7;
            // 
            // btnInput1
            // 
            this.btnInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput1.Location = new System.Drawing.Point(1266, 72);
            this.btnInput1.Name = "btnInput1";
            this.btnInput1.Size = new System.Drawing.Size(114, 20);
            this.btnInput1.TabIndex = 61;
            this.btnInput1.Text = "Send Request";
            this.btnInput1.UseVisualStyleBackColor = true;
            this.btnInput1.Click += new System.EventHandler(this.btnInput1_Click);
            // 
            // btnInput3
            // 
            this.btnInput3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput3.Location = new System.Drawing.Point(1266, 104);
            this.btnInput3.Name = "btnInput3";
            this.btnInput3.Size = new System.Drawing.Size(114, 20);
            this.btnInput3.TabIndex = 62;
            this.btnInput3.Text = "Send Request";
            this.btnInput3.UseVisualStyleBackColor = true;
            this.btnInput3.Click += new System.EventHandler(this.butInput3_Click);
            // 
            // input3
            // 
            this.input3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input3.Location = new System.Drawing.Point(233, 104);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(1027, 26);
            this.input3.TabIndex = 3;
            // 
            // input4
            // 
            this.input4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input4.Location = new System.Drawing.Point(233, 136);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(1027, 26);
            this.input4.TabIndex = 4;
            // 
            // btnInput4
            // 
            this.btnInput4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput4.Location = new System.Drawing.Point(1266, 136);
            this.btnInput4.Name = "btnInput4";
            this.btnInput4.Size = new System.Drawing.Size(114, 20);
            this.btnInput4.TabIndex = 5;
            this.btnInput4.Text = "Send Request";
            this.btnInput4.UseVisualStyleBackColor = true;
            this.btnInput4.Click += new System.EventHandler(this.btnInput4_Click);
            // 
            // input5
            // 
            this.input5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input5.Location = new System.Drawing.Point(233, 168);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(1027, 26);
            this.input5.TabIndex = 1;
            // 
            // btnInput5
            // 
            this.btnInput5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput5.Location = new System.Drawing.Point(1266, 168);
            this.btnInput5.Name = "btnInput5";
            this.btnInput5.Size = new System.Drawing.Size(114, 20);
            this.btnInput5.TabIndex = 0;
            this.btnInput5.Text = "Send Request";
            this.btnInput5.UseVisualStyleBackColor = true;
            this.btnInput5.Click += new System.EventHandler(this.btnInput5_Click);
            // 
            // bw2
            // 
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw2_DoWork);
            this.bw2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw2_ProgressChanged);
            this.bw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw2_RunWorkerCompleted);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(520, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "ClientIP";
            // 
            // Send_RLRQ
            // 
            this.Send_RLRQ.Location = new System.Drawing.Point(323, 232);
            this.Send_RLRQ.Name = "Send_RLRQ";
            this.Send_RLRQ.Size = new System.Drawing.Size(107, 38);
            this.Send_RLRQ.TabIndex = 63;
            this.Send_RLRQ.Text = "Send RLRQ";
            this.Send_RLRQ.Click += new System.EventHandler(this.Send_RLRQ_Click);
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
            this.Port.Location = new System.Drawing.Point(92, 69);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(75, 28);
            this.Port.TabIndex = 13;
            // 
            // bw1
            // 
            this.bw1.WorkerSupportsCancellation = true;
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            this.bw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw1_ProgressChanged);
            this.bw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw1_RunWorkerCompleted);
            // 
            // bw3
            // 
            this.bw3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw3_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 33);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 20);
            this.button1.TabIndex = 70;
            this.button1.Text = "Update Firmware";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PB1
            // 
            this.PB1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PB1.Location = new System.Drawing.Point(185, 38);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(114, 10);
            this.PB1.TabIndex = 71;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.Sim_ReadtabPage2);
            this.tabControl1.Controls.Add(this.Sim_WritetabPage3);
            this.tabControl1.Controls.Add(this.InstantaneousData_tabPage4);
            this.tabControl1.Controls.Add(this.Remote_Upgrade_tabPage5);
            this.tabControl1.Controls.Add(this.Utilities_Data);
            this.tabControl1.Location = new System.Drawing.Point(0, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1396, 702);
            this.tabControl1.TabIndex = 72;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPage.Controls.Add(this.label2);
            this.MainPage.Controls.Add(this.label_Min);
            this.MainPage.Controls.Add(this.TimeBox);
            this.MainPage.Controls.Add(this.listBox2);
            this.MainPage.Controls.Add(this.Label_Host_IP);
            this.MainPage.Controls.Add(this.LocalIP);
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.Controls.Add(this.btnServer);
            this.MainPage.Controls.Add(this.listBox1);
            this.MainPage.Controls.Add(this.btnInput5);
            this.MainPage.Controls.Add(this.IP1);
            this.MainPage.Controls.Add(this.btnInput4);
            this.MainPage.Controls.Add(this.btnInput3);
            this.MainPage.Controls.Add(this.Port);
            this.MainPage.Controls.Add(this.Label_port_Box);
            this.MainPage.Controls.Add(this.btnInput1);
            this.MainPage.Controls.Add(this.btnInput);
            this.MainPage.Controls.Add(this.Label_Notification_From_Server);
            this.MainPage.Controls.Add(this.Client_IP);
            this.MainPage.Controls.Add(this.Send_RLRQ);
            this.MainPage.Controls.Add(this.btnStopServer);
            this.MainPage.Controls.Add(this.input5);
            this.MainPage.Controls.Add(this.btnClear);
            this.MainPage.Controls.Add(this.input2);
            this.MainPage.Controls.Add(this.input3);
            this.MainPage.Controls.Add(this.label7);
            this.MainPage.Controls.Add(this.input4);
            this.MainPage.Controls.Add(this.AARQ);
            this.MainPage.Controls.Add(this.input1);
            this.MainPage.Controls.Add(this.menuStrip1);
            this.MainPage.Location = new System.Drawing.Point(4, 29);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1388, 669);
            this.MainPage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Connection Established Time";
            // 
            // label_Min
            // 
            this.label_Min.AutoSize = true;
            this.label_Min.Location = new System.Drawing.Point(1025, 220);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(94, 20);
            this.label_Min.TabIndex = 72;
            this.label_Min.Text = "milliseconds";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(944, 217);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(75, 26);
            this.TimeBox.TabIndex = 71;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(706, 307);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(674, 324);
            this.listBox2.TabIndex = 70;
            // 
            // Sim_ReadtabPage2
            // 
            this.Sim_ReadtabPage2.Controls.Add(this.simsreadbutton1);
            this.Sim_ReadtabPage2.Controls.Add(this.Sim3Numberlabel3);
            this.Sim_ReadtabPage2.Controls.Add(this.Sim2Numberlabel2);
            this.Sim_ReadtabPage2.Controls.Add(this.Sim1Numberlabel1);
            this.Sim_ReadtabPage2.Controls.Add(this.Sim3_Number_Read_Box3);
            this.Sim_ReadtabPage2.Controls.Add(this.Sim2_Number_Read_Box2);
            this.Sim_ReadtabPage2.Controls.Add(this.Sim1_Number_Read_Box1);
            this.Sim_ReadtabPage2.Location = new System.Drawing.Point(4, 29);
            this.Sim_ReadtabPage2.Name = "Sim_ReadtabPage2";
            this.Sim_ReadtabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.Sim_ReadtabPage2.Size = new System.Drawing.Size(1388, 669);
            this.Sim_ReadtabPage2.TabIndex = 1;
            this.Sim_ReadtabPage2.Text = "Sim Read";
            this.Sim_ReadtabPage2.UseVisualStyleBackColor = true;
            // 
            // simsreadbutton1
            // 
            this.simsreadbutton1.Location = new System.Drawing.Point(386, 190);
            this.simsreadbutton1.Name = "simsreadbutton1";
            this.simsreadbutton1.Size = new System.Drawing.Size(150, 35);
            this.simsreadbutton1.TabIndex = 6;
            this.simsreadbutton1.Text = "Sims Read";
            this.simsreadbutton1.UseVisualStyleBackColor = true;
            this.simsreadbutton1.Click += new System.EventHandler(this.SimsRead_Click);
            // 
            // Sim3Numberlabel3
            // 
            this.Sim3Numberlabel3.AutoSize = true;
            this.Sim3Numberlabel3.Location = new System.Drawing.Point(36, 120);
            this.Sim3Numberlabel3.Name = "Sim3Numberlabel3";
            this.Sim3Numberlabel3.Size = new System.Drawing.Size(105, 20);
            this.Sim3Numberlabel3.TabIndex = 5;
            this.Sim3Numberlabel3.Text = "Sim3 Number";
            // 
            // Sim2Numberlabel2
            // 
            this.Sim2Numberlabel2.AutoSize = true;
            this.Sim2Numberlabel2.Location = new System.Drawing.Point(36, 77);
            this.Sim2Numberlabel2.Name = "Sim2Numberlabel2";
            this.Sim2Numberlabel2.Size = new System.Drawing.Size(105, 20);
            this.Sim2Numberlabel2.TabIndex = 4;
            this.Sim2Numberlabel2.Text = "Sim2 Number";
            // 
            // Sim1Numberlabel1
            // 
            this.Sim1Numberlabel1.AutoSize = true;
            this.Sim1Numberlabel1.Location = new System.Drawing.Point(36, 39);
            this.Sim1Numberlabel1.Name = "Sim1Numberlabel1";
            this.Sim1Numberlabel1.Size = new System.Drawing.Size(105, 20);
            this.Sim1Numberlabel1.TabIndex = 3;
            this.Sim1Numberlabel1.Text = "Sim1 Number";
            // 
            // Sim3_Number_Read_Box3
            // 
            this.Sim3_Number_Read_Box3.Location = new System.Drawing.Point(186, 120);
            this.Sim3_Number_Read_Box3.Name = "Sim3_Number_Read_Box3";
            this.Sim3_Number_Read_Box3.Size = new System.Drawing.Size(188, 26);
            this.Sim3_Number_Read_Box3.TabIndex = 2;
            // 
            // Sim2_Number_Read_Box2
            // 
            this.Sim2_Number_Read_Box2.Location = new System.Drawing.Point(186, 77);
            this.Sim2_Number_Read_Box2.Name = "Sim2_Number_Read_Box2";
            this.Sim2_Number_Read_Box2.Size = new System.Drawing.Size(188, 26);
            this.Sim2_Number_Read_Box2.TabIndex = 1;
            // 
            // Sim1_Number_Read_Box1
            // 
            this.Sim1_Number_Read_Box1.Location = new System.Drawing.Point(186, 39);
            this.Sim1_Number_Read_Box1.Name = "Sim1_Number_Read_Box1";
            this.Sim1_Number_Read_Box1.Size = new System.Drawing.Size(188, 26);
            this.Sim1_Number_Read_Box1.TabIndex = 0;
            // 
            // Sim_WritetabPage3
            // 
            this.Sim_WritetabPage3.Controls.Add(this.Sim_Write_button);
            this.Sim_WritetabPage3.Controls.Add(this.Sim3Number_lb3_wrt);
            this.Sim_WritetabPage3.Controls.Add(this.Sim2Number_lb1_wrt);
            this.Sim_WritetabPage3.Controls.Add(this.Sim1Number_lb1_wrt);
            this.Sim_WritetabPage3.Controls.Add(this.Sim1_Number_Box3);
            this.Sim_WritetabPage3.Controls.Add(this.Sim1_Number_Box2);
            this.Sim_WritetabPage3.Controls.Add(this.Sim1_Number_Box1);
            this.Sim_WritetabPage3.Location = new System.Drawing.Point(4, 29);
            this.Sim_WritetabPage3.Name = "Sim_WritetabPage3";
            this.Sim_WritetabPage3.Size = new System.Drawing.Size(1388, 669);
            this.Sim_WritetabPage3.TabIndex = 2;
            this.Sim_WritetabPage3.Text = "Sim Write";
            this.Sim_WritetabPage3.UseVisualStyleBackColor = true;
            // 
            // Sim_Write_button
            // 
            this.Sim_Write_button.Location = new System.Drawing.Point(386, 190);
            this.Sim_Write_button.Name = "Sim_Write_button";
            this.Sim_Write_button.Size = new System.Drawing.Size(150, 35);
            this.Sim_Write_button.TabIndex = 0;
            this.Sim_Write_button.Text = "Sim Write";
            this.Sim_Write_button.Click += new System.EventHandler(this.Sim_Write_button_Click);
            // 
            // Sim3Number_lb3_wrt
            // 
            this.Sim3Number_lb3_wrt.Location = new System.Drawing.Point(36, 120);
            this.Sim3Number_lb3_wrt.Name = "Sim3Number_lb3_wrt";
            this.Sim3Number_lb3_wrt.Size = new System.Drawing.Size(105, 20);
            this.Sim3Number_lb3_wrt.TabIndex = 1;
            this.Sim3Number_lb3_wrt.Text = "Sim3 Number";
            // 
            // Sim2Number_lb1_wrt
            // 
            this.Sim2Number_lb1_wrt.Location = new System.Drawing.Point(36, 77);
            this.Sim2Number_lb1_wrt.Name = "Sim2Number_lb1_wrt";
            this.Sim2Number_lb1_wrt.Size = new System.Drawing.Size(105, 20);
            this.Sim2Number_lb1_wrt.TabIndex = 2;
            this.Sim2Number_lb1_wrt.Text = "Sim2 Number";
            // 
            // Sim1Number_lb1_wrt
            // 
            this.Sim1Number_lb1_wrt.Location = new System.Drawing.Point(36, 39);
            this.Sim1Number_lb1_wrt.Name = "Sim1Number_lb1_wrt";
            this.Sim1Number_lb1_wrt.Size = new System.Drawing.Size(105, 20);
            this.Sim1Number_lb1_wrt.TabIndex = 3;
            this.Sim1Number_lb1_wrt.Text = "Sim1 Number";
            // 
            // Sim1_Number_Box3
            // 
            this.Sim1_Number_Box3.Location = new System.Drawing.Point(186, 120);
            this.Sim1_Number_Box3.Name = "Sim1_Number_Box3";
            this.Sim1_Number_Box3.Size = new System.Drawing.Size(188, 26);
            this.Sim1_Number_Box3.TabIndex = 4;
            // 
            // Sim1_Number_Box2
            // 
            this.Sim1_Number_Box2.Location = new System.Drawing.Point(186, 77);
            this.Sim1_Number_Box2.Name = "Sim1_Number_Box2";
            this.Sim1_Number_Box2.Size = new System.Drawing.Size(188, 26);
            this.Sim1_Number_Box2.TabIndex = 5;
            // 
            // Sim1_Number_Box1
            // 
            this.Sim1_Number_Box1.Location = new System.Drawing.Point(186, 39);
            this.Sim1_Number_Box1.Name = "Sim1_Number_Box1";
            this.Sim1_Number_Box1.Size = new System.Drawing.Size(188, 26);
            this.Sim1_Number_Box1.TabIndex = 6;
            // 
            // InstantaneousData_tabPage4
            // 
            this.InstantaneousData_tabPage4.Controls.Add(this.freqbox);
            this.InstantaneousData_tabPage4.Controls.Add(this.freqboxlabel6);
            this.InstantaneousData_tabPage4.Controls.Add(this.meterserialnumber);
            this.InstantaneousData_tabPage4.Controls.Add(this.currenta);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggregatePowerImportbox);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggReactivePowerExport_Box);
            this.InstantaneousData_tabPage4.Controls.Add(this.PowerFactorbox);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggActivePowerExportbox);
            this.InstantaneousData_tabPage4.Controls.Add(this.signal);
            this.InstantaneousData_tabPage4.Controls.Add(this.meterdatetime);
            this.InstantaneousData_tabPage4.Controls.Add(this.currb);
            this.InstantaneousData_tabPage4.Controls.Add(this.currentc);
            this.InstantaneousData_tabPage4.Controls.Add(this.voltagea);
            this.InstantaneousData_tabPage4.Controls.Add(this.voltageb);
            this.InstantaneousData_tabPage4.Controls.Add(this.voltagec);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggActivePowerImportbox);
            this.InstantaneousData_tabPage4.Controls.Add(this.currentTarrrr_Box);
            this.InstantaneousData_tabPage4.Controls.Add(this.PowerFactorboxlabel15);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggReactivePowerExport_Boxlabel14);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggregatePowerImportboxlabel13);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggActivePowerExportboxlabel12);
            this.InstantaneousData_tabPage4.Controls.Add(this.AggregateActivePowerImport_lbl);
            this.InstantaneousData_tabPage4.Controls.Add(this.voltage_c);
            this.InstantaneousData_tabPage4.Controls.Add(this.voltage_b);
            this.InstantaneousData_tabPage4.Controls.Add(this.voltage_a);
            this.InstantaneousData_tabPage4.Controls.Add(this.currentcphase);
            this.InstantaneousData_tabPage4.Controls.Add(this.currentb);
            this.InstantaneousData_tabPage4.Controls.Add(this.CAlabel5);
            this.InstantaneousData_tabPage4.Controls.Add(this.Meter_Date_Timelabel);
            this.InstantaneousData_tabPage4.Controls.Add(this.MeterSerialNumberlabel3);
            this.InstantaneousData_tabPage4.Controls.Add(this.SignalStrengthlabel2);
            this.InstantaneousData_tabPage4.Controls.Add(this.CurrentTariffRegisterlabel1);
            this.InstantaneousData_tabPage4.Controls.Add(this.Read_Instantaneous_data);
            this.InstantaneousData_tabPage4.Location = new System.Drawing.Point(4, 29);
            this.InstantaneousData_tabPage4.Name = "InstantaneousData_tabPage4";
            this.InstantaneousData_tabPage4.Size = new System.Drawing.Size(1388, 669);
            this.InstantaneousData_tabPage4.TabIndex = 3;
            this.InstantaneousData_tabPage4.Text = "Instantaneous Data";
            this.InstantaneousData_tabPage4.UseVisualStyleBackColor = true;
            // 
            // freqbox
            // 
            this.freqbox.Location = new System.Drawing.Point(341, 513);
            this.freqbox.Name = "freqbox";
            this.freqbox.Size = new System.Drawing.Size(170, 26);
            this.freqbox.TabIndex = 34;
            // 
            // freqboxlabel6
            // 
            this.freqboxlabel6.AutoSize = true;
            this.freqboxlabel6.Location = new System.Drawing.Point(70, 500);
            this.freqboxlabel6.Name = "freqboxlabel6";
            this.freqboxlabel6.Size = new System.Drawing.Size(84, 20);
            this.freqboxlabel6.TabIndex = 33;
            this.freqboxlabel6.Text = "Frequency";
            // 
            // meterserialnumber
            // 
            this.meterserialnumber.Location = new System.Drawing.Point(341, 76);
            this.meterserialnumber.Name = "meterserialnumber";
            this.meterserialnumber.Size = new System.Drawing.Size(170, 26);
            this.meterserialnumber.TabIndex = 32;
            // 
            // currenta
            // 
            this.currenta.Location = new System.Drawing.Point(341, 143);
            this.currenta.Name = "currenta";
            this.currenta.Size = new System.Drawing.Size(170, 26);
            this.currenta.TabIndex = 31;
            // 
            // AggregatePowerImportbox
            // 
            this.AggregatePowerImportbox.Location = new System.Drawing.Point(341, 408);
            this.AggregatePowerImportbox.Name = "AggregatePowerImportbox";
            this.AggregatePowerImportbox.Size = new System.Drawing.Size(170, 26);
            this.AggregatePowerImportbox.TabIndex = 30;
            // 
            // AggReactivePowerExport_Box
            // 
            this.AggReactivePowerExport_Box.Location = new System.Drawing.Point(341, 443);
            this.AggReactivePowerExport_Box.Name = "AggReactivePowerExport_Box";
            this.AggReactivePowerExport_Box.Size = new System.Drawing.Size(170, 26);
            this.AggReactivePowerExport_Box.TabIndex = 29;
            // 
            // PowerFactorbox
            // 
            this.PowerFactorbox.Location = new System.Drawing.Point(341, 478);
            this.PowerFactorbox.Name = "PowerFactorbox";
            this.PowerFactorbox.Size = new System.Drawing.Size(170, 26);
            this.PowerFactorbox.TabIndex = 28;
            // 
            // AggActivePowerExportbox
            // 
            this.AggActivePowerExportbox.Location = new System.Drawing.Point(341, 373);
            this.AggActivePowerExportbox.Name = "AggActivePowerExportbox";
            this.AggActivePowerExportbox.Size = new System.Drawing.Size(170, 26);
            this.AggActivePowerExportbox.TabIndex = 27;
            // 
            // signal
            // 
            this.signal.Location = new System.Drawing.Point(341, 44);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(170, 26);
            this.signal.TabIndex = 25;
            // 
            // meterdatetime
            // 
            this.meterdatetime.Location = new System.Drawing.Point(341, 108);
            this.meterdatetime.Name = "meterdatetime";
            this.meterdatetime.Size = new System.Drawing.Size(170, 26);
            this.meterdatetime.TabIndex = 24;
            // 
            // currb
            // 
            this.currb.Location = new System.Drawing.Point(341, 175);
            this.currb.Name = "currb";
            this.currb.Size = new System.Drawing.Size(170, 26);
            this.currb.TabIndex = 23;
            // 
            // currentc
            // 
            this.currentc.Location = new System.Drawing.Point(341, 209);
            this.currentc.Name = "currentc";
            this.currentc.Size = new System.Drawing.Size(170, 26);
            this.currentc.TabIndex = 22;
            // 
            // voltagea
            // 
            this.voltagea.Location = new System.Drawing.Point(341, 241);
            this.voltagea.Name = "voltagea";
            this.voltagea.Size = new System.Drawing.Size(170, 26);
            this.voltagea.TabIndex = 21;
            // 
            // voltageb
            // 
            this.voltageb.Location = new System.Drawing.Point(341, 273);
            this.voltageb.Name = "voltageb";
            this.voltageb.Size = new System.Drawing.Size(170, 26);
            this.voltageb.TabIndex = 20;
            // 
            // voltagec
            // 
            this.voltagec.Location = new System.Drawing.Point(341, 305);
            this.voltagec.Name = "voltagec";
            this.voltagec.Size = new System.Drawing.Size(170, 26);
            this.voltagec.TabIndex = 19;
            // 
            // AggActivePowerImportbox
            // 
            this.AggActivePowerImportbox.Location = new System.Drawing.Point(341, 341);
            this.AggActivePowerImportbox.Name = "AggActivePowerImportbox";
            this.AggActivePowerImportbox.Size = new System.Drawing.Size(170, 26);
            this.AggActivePowerImportbox.TabIndex = 18;
            // 
            // currentTarrrr_Box
            // 
            this.currentTarrrr_Box.Location = new System.Drawing.Point(341, 12);
            this.currentTarrrr_Box.Name = "currentTarrrr_Box";
            this.currentTarrrr_Box.Size = new System.Drawing.Size(170, 26);
            this.currentTarrrr_Box.TabIndex = 17;
            // 
            // PowerFactorboxlabel15
            // 
            this.PowerFactorboxlabel15.AutoSize = true;
            this.PowerFactorboxlabel15.Location = new System.Drawing.Point(70, 468);
            this.PowerFactorboxlabel15.Name = "PowerFactorboxlabel15";
            this.PowerFactorboxlabel15.Size = new System.Drawing.Size(170, 20);
            this.PowerFactorboxlabel15.TabIndex = 16;
            this.PowerFactorboxlabel15.Text = "Average Power Factor ";
            // 
            // AggReactivePowerExport_Boxlabel14
            // 
            this.AggReactivePowerExport_Boxlabel14.AutoSize = true;
            this.AggReactivePowerExport_Boxlabel14.Location = new System.Drawing.Point(70, 436);
            this.AggReactivePowerExport_Boxlabel14.Name = "AggReactivePowerExport_Boxlabel14";
            this.AggReactivePowerExport_Boxlabel14.Size = new System.Drawing.Size(252, 20);
            this.AggReactivePowerExport_Boxlabel14.TabIndex = 15;
            this.AggReactivePowerExport_Boxlabel14.Text = "Aggregate Reactive Power Export ";
            // 
            // AggregatePowerImportboxlabel13
            // 
            this.AggregatePowerImportboxlabel13.AutoSize = true;
            this.AggregatePowerImportboxlabel13.Location = new System.Drawing.Point(70, 404);
            this.AggregatePowerImportboxlabel13.Name = "AggregatePowerImportboxlabel13";
            this.AggregatePowerImportboxlabel13.Size = new System.Drawing.Size(252, 20);
            this.AggregatePowerImportboxlabel13.TabIndex = 14;
            this.AggregatePowerImportboxlabel13.Text = "Aggregate Reactive Power Import ";
            // 
            // AggActivePowerExportboxlabel12
            // 
            this.AggActivePowerExportboxlabel12.AutoSize = true;
            this.AggActivePowerExportboxlabel12.Location = new System.Drawing.Point(70, 372);
            this.AggActivePowerExportboxlabel12.Name = "AggActivePowerExportboxlabel12";
            this.AggActivePowerExportboxlabel12.Size = new System.Drawing.Size(229, 20);
            this.AggActivePowerExportboxlabel12.TabIndex = 13;
            this.AggActivePowerExportboxlabel12.Text = "Aggregate Active Power Export";
            // 
            // AggregateActivePowerImport_lbl
            // 
            this.AggregateActivePowerImport_lbl.AutoSize = true;
            this.AggregateActivePowerImport_lbl.Location = new System.Drawing.Point(70, 340);
            this.AggregateActivePowerImport_lbl.Name = "AggregateActivePowerImport_lbl";
            this.AggregateActivePowerImport_lbl.Size = new System.Drawing.Size(233, 20);
            this.AggregateActivePowerImport_lbl.TabIndex = 12;
            this.AggregateActivePowerImport_lbl.Text = "Aggregate Active Power Import ";
            // 
            // voltage_c
            // 
            this.voltage_c.AutoSize = true;
            this.voltage_c.Location = new System.Drawing.Point(74, 308);
            this.voltage_c.Name = "voltage_c";
            this.voltage_c.Size = new System.Drawing.Size(128, 20);
            this.voltage_c.TabIndex = 11;
            this.voltage_c.Text = "Voltage Phase C";
            // 
            // voltage_b
            // 
            this.voltage_b.AutoSize = true;
            this.voltage_b.Location = new System.Drawing.Point(70, 276);
            this.voltage_b.Name = "voltage_b";
            this.voltage_b.Size = new System.Drawing.Size(128, 20);
            this.voltage_b.TabIndex = 10;
            this.voltage_b.Text = "Voltage Phase B";
            // 
            // voltage_a
            // 
            this.voltage_a.AutoSize = true;
            this.voltage_a.Location = new System.Drawing.Point(70, 244);
            this.voltage_a.Name = "voltage_a";
            this.voltage_a.Size = new System.Drawing.Size(132, 20);
            this.voltage_a.TabIndex = 9;
            this.voltage_a.Text = "Voltage Phase A ";
            // 
            // currentcphase
            // 
            this.currentcphase.AutoSize = true;
            this.currentcphase.Location = new System.Drawing.Point(70, 215);
            this.currentcphase.Name = "currentcphase";
            this.currentcphase.Size = new System.Drawing.Size(130, 20);
            this.currentcphase.TabIndex = 7;
            this.currentcphase.Text = "Current Phase C ";
            // 
            // currentb
            // 
            this.currentb.AutoSize = true;
            this.currentb.Location = new System.Drawing.Point(74, 178);
            this.currentb.Name = "currentb";
            this.currentb.Size = new System.Drawing.Size(126, 20);
            this.currentb.TabIndex = 6;
            this.currentb.Text = "Current Phase B";
            // 
            // CAlabel5
            // 
            this.CAlabel5.AutoSize = true;
            this.CAlabel5.Location = new System.Drawing.Point(70, 146);
            this.CAlabel5.Name = "CAlabel5";
            this.CAlabel5.Size = new System.Drawing.Size(130, 20);
            this.CAlabel5.TabIndex = 5;
            this.CAlabel5.Text = "Current Phase A ";
            // 
            // Meter_Date_Timelabel
            // 
            this.Meter_Date_Timelabel.AutoSize = true;
            this.Meter_Date_Timelabel.Location = new System.Drawing.Point(70, 114);
            this.Meter_Date_Timelabel.Name = "Meter_Date_Timelabel";
            this.Meter_Date_Timelabel.Size = new System.Drawing.Size(135, 20);
            this.Meter_Date_Timelabel.TabIndex = 4;
            this.Meter_Date_Timelabel.Text = "Meter Date & Time ";
            // 
            // MeterSerialNumberlabel3
            // 
            this.MeterSerialNumberlabel3.AutoSize = true;
            this.MeterSerialNumberlabel3.Location = new System.Drawing.Point(68, 84);
            this.MeterSerialNumberlabel3.Name = "MeterSerialNumberlabel3";
            this.MeterSerialNumberlabel3.Size = new System.Drawing.Size(154, 20);
            this.MeterSerialNumberlabel3.TabIndex = 3;
            this.MeterSerialNumberlabel3.Text = "Meter Serial Number";
            // 
            // SignalStrengthlabel2
            // 
            this.SignalStrengthlabel2.AutoSize = true;
            this.SignalStrengthlabel2.Location = new System.Drawing.Point(70, 50);
            this.SignalStrengthlabel2.Name = "SignalStrengthlabel2";
            this.SignalStrengthlabel2.Size = new System.Drawing.Size(123, 20);
            this.SignalStrengthlabel2.TabIndex = 2;
            this.SignalStrengthlabel2.Text = "Signal Strength ";
            // 
            // CurrentTariffRegisterlabel1
            // 
            this.CurrentTariffRegisterlabel1.AutoSize = true;
            this.CurrentTariffRegisterlabel1.Location = new System.Drawing.Point(70, 18);
            this.CurrentTariffRegisterlabel1.Name = "CurrentTariffRegisterlabel1";
            this.CurrentTariffRegisterlabel1.Size = new System.Drawing.Size(170, 20);
            this.CurrentTariffRegisterlabel1.TabIndex = 1;
            this.CurrentTariffRegisterlabel1.Text = "Current Tariff Register ";
            // 
            // Read_Instantaneous_data
            // 
            this.Read_Instantaneous_data.Location = new System.Drawing.Point(630, 551);
            this.Read_Instantaneous_data.Name = "Read_Instantaneous_data";
            this.Read_Instantaneous_data.Size = new System.Drawing.Size(258, 42);
            this.Read_Instantaneous_data.TabIndex = 0;
            this.Read_Instantaneous_data.Text = "Read instantaneous Data";
            this.Read_Instantaneous_data.UseVisualStyleBackColor = true;
            this.Read_Instantaneous_data.Click += new System.EventHandler(this.RID_Click);
            // 
            // Remote_Upgrade_tabPage5
            // 
            this.Remote_Upgrade_tabPage5.Controls.Add(this.button1);
            this.Remote_Upgrade_tabPage5.Controls.Add(this.PB1);
            this.Remote_Upgrade_tabPage5.Location = new System.Drawing.Point(4, 29);
            this.Remote_Upgrade_tabPage5.Name = "Remote_Upgrade_tabPage5";
            this.Remote_Upgrade_tabPage5.Size = new System.Drawing.Size(1388, 669);
            this.Remote_Upgrade_tabPage5.TabIndex = 4;
            this.Remote_Upgrade_tabPage5.Text = "Remote Upgrade";
            this.Remote_Upgrade_tabPage5.UseVisualStyleBackColor = true;
            // 
            // Utilities_Data
            // 
            this.Utilities_Data.Controls.Add(this.dataGridView1);
            this.Utilities_Data.Controls.Add(this.UtilitiesBox);
            this.Utilities_Data.Controls.Add(this.label5);
            this.Utilities_Data.Controls.Add(this.progressBar1);
            this.Utilities_Data.Controls.Add(this.Load_Data);
            this.Utilities_Data.Controls.Add(this.label4);
            this.Utilities_Data.Controls.Add(this.label3);
            this.Utilities_Data.Controls.Add(this.dateTimePicker2);
            this.Utilities_Data.Controls.Add(this.dateTimePicker1);
            this.Utilities_Data.Location = new System.Drawing.Point(4, 29);
            this.Utilities_Data.Name = "Utilities_Data";
            this.Utilities_Data.Size = new System.Drawing.Size(1388, 669);
            this.Utilities_Data.TabIndex = 5;
            this.Utilities_Data.Text = "Utilities";
            this.Utilities_Data.UseVisualStyleBackColor = true;
            // 
            // UtilitiesBox
            // 
            this.UtilitiesBox.FormattingEnabled = true;
            this.UtilitiesBox.Items.AddRange(new object[] {
            "Load Profile Data",
            "Instantaneous Data",
            "Daily billing Data"});
            this.UtilitiesBox.Location = new System.Drawing.Point(993, 63);
            this.UtilitiesBox.Name = "UtilitiesBox";
            this.UtilitiesBox.Size = new System.Drawing.Size(121, 28);
            this.UtilitiesBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Processing";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(148, 128);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 12);
            this.progressBar1.TabIndex = 6;
            // 
            // Load_Data
            // 
            this.Load_Data.Location = new System.Drawing.Point(1137, 63);
            this.Load_Data.Name = "Load_Data";
            this.Load_Data.Size = new System.Drawing.Size(100, 28);
            this.Load_Data.TabIndex = 5;
            this.Load_Data.Text = "Invoke";
            this.Load_Data.UseVisualStyleBackColor = true;
            this.Load_Data.Click += new System.EventHandler(this.Load_Data_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(528, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // SimRead
            // 
            this.SimRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SimRead.Location = new System.Drawing.Point(596, 375);
            this.SimRead.Name = "SimRead";
            this.SimRead.Size = new System.Drawing.Size(114, 20);
            this.SimRead.TabIndex = 68;
            this.SimRead.Text = "SimRead";
            this.SimRead.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 425);
            this.dataGridView1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AccessibleName = "ICM Online Manager";
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1408, 773);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ICM Online Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.Sim_ReadtabPage2.ResumeLayout(false);
            this.Sim_ReadtabPage2.PerformLayout();
            this.Sim_WritetabPage3.ResumeLayout(false);
            this.Sim_WritetabPage3.PerformLayout();
            this.InstantaneousData_tabPage4.ResumeLayout(false);
            this.InstantaneousData_tabPage4.PerformLayout();
            this.Remote_Upgrade_tabPage5.ResumeLayout(false);
            this.Utilities_Data.ResumeLayout(false);
            this.Utilities_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label label1;
        public Label Label_Host_IP;
        public Label Label_port_Box;
        public Label Label_Notification_From_Server;
        public Label Client_IP;
        public Label LocalIP;
        public Button btnServer;
        public Button btnClear;
        public TextBox input4;
        public TextBox input3;
        public TextBox input1;
        public Button btnInput1;
        public Button btnInput4;
        public Button btnInput3;
        public Button btnStopServer;
        public Button btnInput;
        public TextBox IP1;
        public TextBox input2;
        public ListBox listBox1;
        public Button AARQ;
        public TextBox input5;
        public Button btnInput5;
        public System.ComponentModel.BackgroundWorker bw2;
        public Label label7;
        public Button Send_RLRQ;
        private ComboBox Port;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.ComponentModel.BackgroundWorker bw3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem relayOnToolStripMenuItem;
        private ToolStripMenuItem relayOffToolStripMenuItem;
        private Button button1;
        private ProgressBar PB1;
        private ToolStripMenuItem clearOpenFlagToolStripMenuItem;
        private ToolStripMenuItem clearAllEventsToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage MainPage;
        private System.Windows.Forms.TextBox Sim1_Number_Read_Box1;
        private System.Windows.Forms.TextBox Sim2_Number_Read_Box2;
        private System.Windows.Forms.TextBox Sim3_Number_Read_Box3;
        private System.Windows.Forms.Label Sim1Numberlabel1;
        private System.Windows.Forms.Label Sim2Numberlabel2;
        private System.Windows.Forms.Label Sim3Numberlabel3;
        private System.Windows.Forms.Button simsreadbutton1;
        private System.Windows.Forms.TextBox Sim1_Number_Box1;
        private System.Windows.Forms.TextBox Sim1_Number_Box2;
        private System.Windows.Forms.TextBox Sim1_Number_Box3;
        private System.Windows.Forms.Label Sim1Number_lb1_wrt;
        private System.Windows.Forms.Label Sim2Number_lb1_wrt;
        private System.Windows.Forms.Label Sim3Number_lb3_wrt;
        private System.Windows.Forms.Button Sim_Write_button;
        private System.Windows.Forms.Button Read_Instantaneous_data;
        private System.Windows.Forms.Label CurrentTariffRegisterlabel1;
        private System.Windows.Forms.Label SignalStrengthlabel2;
        private System.Windows.Forms.Label MeterSerialNumberlabel3;
        private System.Windows.Forms.Label Meter_Date_Timelabel;
        private System.Windows.Forms.Label CAlabel5;
        private System.Windows.Forms.Label currentb;
        private System.Windows.Forms.Label currentcphase;
        private System.Windows.Forms.Label voltage_a;
        private System.Windows.Forms.Label voltage_b;
        private System.Windows.Forms.Label voltage_c;
        private System.Windows.Forms.Label AggregateActivePowerImport_lbl;
        private System.Windows.Forms.Label AggActivePowerExportboxlabel12;
        private System.Windows.Forms.Label AggregatePowerImportboxlabel13;
        private System.Windows.Forms.Label AggReactivePowerExport_Boxlabel14;
        private System.Windows.Forms.Label PowerFactorboxlabel15;
        private System.Windows.Forms.TextBox currentTarrrr_Box;
        private System.Windows.Forms.TextBox AggActivePowerImportbox;
        private System.Windows.Forms.TextBox voltagec;
        private System.Windows.Forms.TextBox voltageb;
        private System.Windows.Forms.TextBox voltagea;
        private System.Windows.Forms.TextBox currentc;
        private System.Windows.Forms.TextBox currb;
        private System.Windows.Forms.TextBox meterdatetime;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.TextBox AggActivePowerExportbox;
        private System.Windows.Forms.TextBox PowerFactorbox;
        private System.Windows.Forms.TextBox AggReactivePowerExport_Box;
        private System.Windows.Forms.TextBox AggregatePowerImportbox;
        private System.Windows.Forms.TextBox currenta;
        private System.Windows.Forms.TextBox meterserialnumber;
        private System.Windows.Forms.Label freqboxlabel6;
        private System.Windows.Forms.TextBox freqbox;
        private TabPage Sim_ReadtabPage2;
        private Button SimRead;
        private TabPage Sim_WritetabPage3;
        private TabPage InstantaneousData_tabPage4;
        private TabPage Remote_Upgrade_tabPage5;
        public ListBox listBox2;
        private TextBox TimeBox;
        private Label label_Min;
        private Label label2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabPage Utilities_Data;
        private Label label5;
        private ProgressBar progressBar1;
        private Button Load_Data;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox UtilitiesBox;
        private DataGridView dataGridView1;
    }
}