using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONLINE_ICM_MANAGER
{
    public partial class MainForm : Form
    {
        public TcpListener server;
        private bool isServerRunning = false;
        private TcpClient client;
        public byte[] bytes = new byte[1024];
        public byte[] data = new byte[1024];
        public string data_streaming;
        public NetworkStream stream;
        private static uint MSN;
        private byte[] buffer1 = new byte[1024];
        private Stopwatch stopwatch = new Stopwatch();
        private bool isAutomaticRunning = false;
        private CancellationTokenSource automaticCancellationTokenSource;
        private bool autoConfigLoopRunning = false;
        private bool isContentVisible = false;
        public MainForm()
        {
            InitializeComponent();
            this.PopulateIPAddressComboBox();
            EssencialInfo.Visible = false;

        }
        private void PopulateIPAddressComboBox()
        {
            foreach (IPAddress hostAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (hostAddress.AddressFamily == AddressFamily.InterNetwork)
                    this.IPBOX.Items.Add((object)hostAddress.ToString());
            }
        }


        private void btnSend1_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IPBOX.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input1.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";

                        this.stream.Write(array, 0, array.Length);
                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";

                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string message = "Client is not connected";
                    Warning(message);
                }
            }
            else
            {
                string message = "Start The Server First";
                Warning(message);
            }
        }
        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IPBOX.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input2.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";

                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string message = "Client is not connected";
                    Warning(message);
                }
            }
            else
            {
                string message = "Start The Server First";
                Warning(message);
            }
        }
        private void btnSend3_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IPBOX.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input3.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";

                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string message = "Client is not connected";
                    Warning(message);
                }
            }
            else
            {
                string message = "Start The Server First";
                Warning(message);
            }

        }
        private void btnSend4_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IPBOX.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input4.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";

                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string message = "Client is not connected";
                    Warning(message);
                }
            }
            else
            {
                string message = "Start The Server First";
                Warning(message);
            }
        }
        private void btnSend5_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IPBOX.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input5.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";

                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string message = "Client is not connected";
                    Warning(message);
                }
            }
            else
            {
                string message = "Start The Server First";
                Warning(message);
            }
        }
        
         private void Copyreceiving_Click(object sender, EventArgs e)
        {
            
            if (this.listBox2.Items.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (object obj in this.listBox2.Items)
                    stringBuilder.AppendLine(obj.ToString());
                this.ShowCopiedTextDialog(stringBuilder.ToString());
            }
            else 
            {
                Warning("No items to copy." + "Copy Failed");
            }
        }

        private void Copy_Sending_Data_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (object obj in this.listBox1.Items)
                    stringBuilder.AppendLine(obj.ToString());
                this.ShowCopiedTextDialog(stringBuilder.ToString());
            }
            else
            {
                Warning("No items to copy."+ "Copy Failed");
            }
        }

        private void ShowCopiedTextDialog(string text)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Copied Text";
                dialog.Size = new Size(400, 300);
                TextBox textBox = new TextBox();
                textBox.Multiline = true;
                textBox.ScrollBars = ScrollBars.Vertical;
                textBox.Dock = DockStyle.Fill;
                textBox.Text = text;
                Button button = new Button();
                button.Text = "Close";
                button.Dock = DockStyle.Bottom;
                button.Click += (EventHandler)((sender, e) => dialog.Close());
                dialog.Controls.Add((Control)textBox);
                dialog.Controls.Add((Control)button);
                int num = (int)dialog.ShowDialog();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
        }

        private void AARQ_Click(object sender, EventArgs e)
        {
            if (this.Port.Text != "" && this.IPBOX.Text != "")
            {
                if (this.client != null)
                {
                    try
                    {
                        byte[] buffer = new byte[64] { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
                        string str = "";
                        this.stream.Write(buffer, 0, buffer.Length);
                        SendBufferSizeBox.Text = buffer.Length.ToString() + " bytes";
                        for (int index = 0; index < buffer.Length; ++index)
                            str = str + buffer[index].ToString("X2") + " ";
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                    this.Warning("Client is not connected");
            }
            else
                this.Warning("Start The Server First");
        }

        private void Send_RLRQ_Click(object sender, EventArgs e)
        {
            if (this.Port.Text != "" && this.IPBOX.Text != "")
            {
                if (this.client != null)
                {
                    try
                    {
                        byte[] buffer = new byte[13]
                        {
              (byte) 0,
              (byte) 1,
              (byte) 0,
              (byte) 48,
              (byte) 0,
              (byte) 1,
              (byte) 0,
              (byte) 5,
              (byte) 98,
              (byte) 3,
              (byte) 128,
              (byte) 1,
              (byte) 0
                        };
                        this.stream.Write(buffer, 0, buffer.Length);
                        SendBufferSizeBox.Text = buffer.Length.ToString() + " bytes";

                        string str = "";
                        for (int index = 0; index < buffer.Length; ++index)
                            str = str + buffer[index].ToString("X2") + " ";
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                    this.Warning("Client is not connected");
            }
            else
                this.Warning("Start The Server First");
        }

        private async Task StartServer()
        {
            try

            {
                if (string.IsNullOrEmpty(this.IPBOX.Text))
                    this.Alert("PLEASE ENTER THE IP ADDRESS");
                else if (string.IsNullOrEmpty(this.Port.Text))
                {
                    this.Alert("PLEASE ENTER THE PORT NUMBER");
                }
                else
                {
                    this.server = new TcpListener(((IEnumerable<IPAddress>)Dns.GetHostAddresses(Dns.GetHostName())).Last<IPAddress>((Func<IPAddress, bool>)(ip => ip.AddressFamily == AddressFamily.InterNetwork)), int.Parse(this.Port.Text));
                    this.server.Start();
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    this.isServerRunning = true;
                    this.BeginInvoke(new Action(() =>
                    {
                        this.Label_Notification_From_Server.Text = "Server Started";
                        this.btnStopServer.Enabled = true;
                        this.Label_Notification_From_Server.Show();
                    }));
                    this.btnServer.Enabled = false;
                    this.BeginInvoke(new Action(() =>
                    {
                        this.listBox1.Items.Add((object)"Waiting for a connection...");
                    }));
                    MainForm mainForm = this;
                    TcpClient client = mainForm.client;
                    TcpClient tcpClient = await this.server.AcceptTcpClientAsync();
                    mainForm.client = tcpClient;
                    mainForm = (MainForm)null;
                    tcpClient = (TcpClient)null;
                    stopwatch.Stop();
                    TimeSpan elapsedTime = stopwatch.Elapsed;
                    this.TimeBox.Text = string.Format("{0}", (object)elapsedTime.TotalMilliseconds);
                    string Client_IP_Presence = ((IPEndPoint)this.client.Client.RemoteEndPoint).Address.ToString();
                    this.BeginInvoke(new Action(() =>
                    {
                        this.listBox1.Items.Add((object)string.Format("Client Connected IP: {0}\t Client Connection Time: {1}", (object)Client_IP_Presence, (object)DateTime.Now));
                        if (this.bw1 != null && this.bw1.IsBusy)
                            return;
                        this.bw1 = new BackgroundWorker();
                        this.bw1.DoWork += new DoWorkEventHandler(this.bw1_DoWork);
                        this.bw1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bw1_RunWorkerCompleted);
                        this.bw1.WorkerSupportsCancellation = true;
                        this.bw1.RunWorkerAsync();
                    }));
                    this.BeginInvoke(new Action(() =>
                    {
                        this.Client_IP.Text = Client_IP_Presence;
                    }));
                    this.stream = this.client.GetStream();
                    if (this.stream == null)
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)string.Format("Client Disconnected IP: {0}\t IP ADDRESS OF CLIENT: {1}\t Client Connection Time: {2}", (object)Client_IP_Presence, (object)Client_IP_Presence, (object)DateTime.Now));
                        }));
                    stopwatch = (Stopwatch)null;
                    elapsedTime = new TimeSpan();
                }
            }
            catch
            {
                //string message = "Client Disconnected In an abnormal Condition";
              //  this.Warning(message);
                //message = (string)null;
            }


        }

        public async void btnServer_Click(object sender, EventArgs e)
        {
            await StartServer();

        }
        private void StopServer()
        {
            try
            {
                // If the automatic process is running, don't stop the server here
                if (isAutomaticRunning)
                    return;

                if (this.server != null && this.isServerRunning)
                {
                    this.TimeBox.Text = "";
                    LinkSpeed.Text = "";
                    SendBufferSizeBox.Text = "";
                    if (this.bw1 != null && this.bw1.IsBusy)
                    {
                        this.bw1.CancelAsync();
                        this.bw1.Dispose();
                        this.bw1 = null;
                    }
                    if (this.client != null && this.client.Connected)
                    {
                        string clientIP = ((IPEndPoint)this.client.Client.RemoteEndPoint).Address.ToString();
                        this.client.Close();
                        this.client = null;
                        this.stream = null;
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)string.Format("Client Disconnected IP: {0} Client Disconnected Date and Time: {1}", (object)clientIP, (object)DateTime.Now));
                        }));
                    }
                    this.server.Stop();
                    this.isServerRunning = false;
                    this.btnServer.Enabled = true;
                    this.BeginInvoke(new Action(() =>
                    {
                        this.Label_Notification_From_Server.Text = "Server Stopped";
                    }));
                }
                else
                {
                    if (this.server != null)
                    {
                        this.server.Stop();
                        this.isServerRunning = false;
                        this.btnServer.Enabled = true;
                        this.BeginInvoke(new Action(() =>
                        {
                            this.Label_Notification_From_Server.Text = "Server Stopped";
                        }));
                    }
                }
            }
            catch
            {
                this.Alert("Server Stopped!");
            }
        }



        private void btnStopServer_Click(object sender, EventArgs e)
        {
            StopServer();
       }
        private bool IsConnected(TcpClient tcpClient)
        {
            try
            {
                if (tcpClient.Client.Poll(0, SelectMode.SelectRead))
                {
                    byte[] buffer = new byte[1];
                    if (tcpClient.Client.Receive(buffer, SocketFlags.Peek) == 0)
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void relayOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Port.Text != "" && this.IPBOX.Text != "")
            {
                if (this.client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)"00 01 00 30 00 01 00 0F C3 01 C1 00 46 00 00 60 03 0A FF 02 01 0F 00".Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";
                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                    this.Warning("Client Is Not Connected");
            }
            else
                this.Warning("Start The Server First");
        }

        private void relayOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Port.Text != "" && this.IPBOX.Text != "")
            {
                if (this.client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)"00 01 00 30 00 01 00 0F C3 01 C1 00 46 00 00 60 03 0A FF 01 01 0F 00".Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";
                        this.stream.Write(array, 0, array.Length);
                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                    this.Warning("Client is not connected");
            }
            else
                this.Warning("Start The Server First");
        }

        private void clearOpenFlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Port.Text != "" && this.IPBOX.Text != "")
            {
                if (this.client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)"00 01 00 30 00 01 00 10 C3 01 81 00 09 00 00 0A 00 00 FF 01 01 12 00 06".Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";
                        this.stream.Write(array, 0, array.Length);
                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                    this.Warning("Client is not connected");
            }
            else
                this.Warning("Start The Server First");
        }
        private void Warning(string str)
        {
            int num = (int)MessageBox.Show(str, nameof(Warning), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Alert(string str)
        {
            int num = (int)MessageBox.Show(str, nameof(Alert), MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void clearAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Port.Text != "" && this.IPBOX.Text != "")
            {
                if (this.client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)"00 01 00 30 00 01 00 10 C3 01 81 00 09 00 00 0A 00 00 FF 01 01 12 00 03".Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        SendBufferSizeBox.Text = array.Length.ToString() + " bytes";
                        this.stream.Write(array, 0, array.Length);
                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                    this.Warning("Client is not connected");
            }
            else
                this.Warning("Start The Server First");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LocalIP.Text = ((IEnumerable<IPAddress>)Dns.GetHostEntry(Dns.GetHostName()).AddressList).Last<IPAddress>((Func<IPAddress, bool>)(ip => ip.AddressFamily == AddressFamily.InterNetwork)).ToString();
            MainForm.GetLocalIPAddress();
            this.Label_Notification_From_Server.Hide();
        }
        public static string GetLocalIPAddress()
        {
            foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return address.ToString();
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bool flag1 = false;
                bool flag2 = true;
                bool flag3 = true;

                while (this.client != null && this.client.Connected)
                {
                    if (!this.IsConnected(this.client))
                    {
                        string clientIP = ((IPEndPoint)this.client.Client.RemoteEndPoint).Address.ToString();
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)string.Format("---Client Disconnected--  IP ADDRESS OF CLIENT: {0} Client Connection Time: {1}", (object)clientIP, (object)DateTime.Now));
                        }));
                        break;
                    }

                    byte[] numArray = new byte[1024];
                    int num = this.stream.Read(numArray, 0, numArray.Length);

                    if (num == 0)
                        break;

                    LinkSpeed.Text = num.ToString() + " bytes";
                    string str1 = BitConverter.ToString(numArray, 0, num);
                    string str3 = Encoding.ASCII.GetString(numArray, 0, num);
                    DateTime now = DateTime.Now;

                    if (str3[num - 1] == '\a' && str3[num - 2] == char.MinValue && str3[num - 3] == ',')
                        flag1 = true;
                    else if (flag1)
                    {
                        // You might want to add some logic here.
                    }

                    if (flag2)
                    {
                        MainForm.MSN = BitConverter.ToUInt32(numArray, num - 4);
                        flag2 = false;
                    }

                    if (str1.StartsWith("DD") && str1.Length >= 8)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox2.Items.Add((object)string.Format("{0}\tReceived: Meter Heart Beat ❤️\tMeter Number:  {1}", (object)DateTime.Now.ToString(), (object)MainForm.MSN));
                        }));
                    }
                    else
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox2.Items.Add((object)(DateTime.Now.ToString() + "\tReceived:  " + str1 + "\tMeter Number:  " + (object)MainForm.MSN));
                            this.listBox2.Items.Add((object)"");
                            this.listBox2.SelectedIndex = this.listBox2.Items.Count - 1;
                            this.listBox2.SelectedIndex = -1;
                        }));
                    }

                    if (str3[num - 1] == char.MinValue && str3[num - 2] == '\t')
                    {
                        byte[] buffer = new byte[9] { 0, 1, 0, 16, 0, 1, 0, 1, 219 };
                        this.stream.Write(buffer, 0, buffer.Length);
                        string myStr = BitConverter.ToString(buffer);
                        string s = Encoding.ASCII.GetString(numArray, num - 28, 10);

                        if (flag3)
                        {
                            MainForm.MSN = uint.Parse(s);
                            flag3 = false;
                        }

                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tEvent Ack:  " + myStr + "\tMeter Number:  " + (object)MainForm.MSN));
                            this.listBox1.Items.Add((object)"");
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                            this.listBox1.SelectedIndex = -1;
                        }));
                    }

                    if (numArray[1] == (byte)4)
                    {
                        MainForm.MSN = BitConverter.ToUInt32(numArray, num - 4);
                        byte[] buffer = new byte[1] { (byte)218 };
                        string myStr = BitConverter.ToString(buffer);
                        this.stream.Write(buffer, 0, buffer.Length);

                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tKeep Alive Ack:  " + myStr + "\tMeter Number:  " + (object)MainForm.MSN));
                            this.listBox1.Items.Add((object)"");
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                            this.listBox1.SelectedIndex = -1;
                        }));
                    }
                }
            }
            catch
            {

            }

        }


        private void bw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.listBox1.Items.Add((object)("Thread State\t" + (string)e.UserState));
            }));

        }

        private void bw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error != null)
                ;
        }

        public void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Control) == Keys.None || e.KeyCode != Keys.C)
                return;
            Clipboard.SetText(this.listBox1.SelectedItem.ToString());
        }

        public void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            Clipboard.SetText(this.listBox1.Items[this.listBox1.SelectedIndex].ToString());
        }


        public void listBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Control) == Keys.None || e.KeyCode != Keys.C)
                return;
            Clipboard.SetText(this.listBox2.SelectedItem.ToString());
        }

        public void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            Clipboard.SetText(this.listBox2.Items[this.listBox2.SelectedIndex].ToString());
        }

        private async void autoconfig_Click(object sender, EventArgs e)
        {
            if (!autoConfigLoopRunning)
            {
                autoConfigLoopRunning = true;

                while (autoConfigLoopRunning)
                {
                    int selectedMinutes = (int)numericUpDown.Value;

                    if (selectedMinutes == 0)
                    {
                        Warning("Time Must be Greater Than 0 minutes");
                    }
                    else if (selectedMinutes > 0)
                    {
                        while (autoConfigLoopRunning)
                        {
                            await StartServer();

                            automaticCancellationTokenSource = new CancellationTokenSource();

                            try
                            {
                                await Task.Delay(TimeSpan.FromMinutes(selectedMinutes), automaticCancellationTokenSource.Token);

                                StopServer();
                            }
                            catch (TaskCanceledException)
                            {
                            }
                        }
                    }
                }
            }
        }






        private void killSwitch_Click(object sender, EventArgs e)
        {
            autoConfigLoopRunning = false;
        }

        private void ToggleContentButton_Click(object sender, EventArgs e)
        {
            if (isContentVisible)
            {
                EssencialInfo.Visible = false;
                ToggleContentButton.Text = "+";
            }
            else
            {
                EssencialInfo.Visible = true;
                ToggleContentButton.Text = "-";
            }

            isContentVisible = !isContentVisible;
        }
    }
}
