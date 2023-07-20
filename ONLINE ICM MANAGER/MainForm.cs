using ONLINE_ICM_MANAGER;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Stream_Writer
{
    public partial class MainForm : Form
    {
        public TcpListener server;
        private bool isServerRunning = false;
        public TcpClient client;
        public byte[] bytes = new byte[1024];
        public byte[] data = new byte[1024];
        public string data_streaming;
        public NetworkStream stream;
        private string myconn = "DRIVER={MySQL ODBC 3.51 Driver};Database=meter;Server=localhost;Port=2142;UID=root;PWD=TRANSFOPOWER@123@321;";
        static uint MSN;
        private byte[] buffer1 = new byte[1024];

        public MainForm()
        {
            this.InitializeComponent();
        }

        public async void btnServer_Click(object sender, EventArgs e)
        {
            try
            {
                IP1.Text = "";
                if (Port.Text != "")
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        IP1.Text = GetLocalIPAddress();
                    }));
                    this.server = new TcpListener(((IEnumerable<IPAddress>)Dns.GetHostEntry(Dns.GetHostName()).AddressList).Last<IPAddress>((Func<IPAddress, bool>)(ip => ip.AddressFamily == AddressFamily.InterNetwork)), Int32.Parse((Port.Text)));
                    this.server.Start();
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    isServerRunning = true;
                    this.BeginInvoke(new Action(() =>
                    {

                        this.Label_Notification_From_Server.Text = "Server Started";
                        this.btnStopServer.Enabled = true;
                        this.Label_Notification_From_Server.Show();
                    }));
                    this.btnServer.Enabled = false;
                    this.BeginInvoke(new Action(() =>
                    {
                        this.listBox1.Items.Add((object)"Waiting for a connection... ");
                    }));

                    // Accept a single client connection
                    this.client = await this.server.AcceptTcpClientAsync();
                    stopwatch.Stop();
                   
                    TimeSpan elapsedTime = stopwatch.Elapsed;


                    TimeBox.Text = $"{elapsedTime.TotalMilliseconds}";
                    string Client_IP_Presence = ((IPEndPoint)this.client.Client.RemoteEndPoint).Address.ToString();


                    this.BeginInvoke(new Action(() =>
                    {
                        this.listBox1.Items.Add((object)("Client Connected IP: " + Client_IP_Presence + "\t Client Connection Time : " + DateTime.Now.ToString()));

                        if (Client_IP_Presence != null)
                        {
                            if (this.bw1 == null)
                            {
                                this.bw1 = new BackgroundWorker();
                                this.bw1.DoWork += bw1_DoWork;
                                this.bw1.RunWorkerCompleted += bw1_RunWorkerCompleted;
                                this.bw1.WorkerSupportsCancellation = true;
                                this.bw1.RunWorkerAsync();
                            }

                            else
                            {
                                if (this.bw1.IsBusy == false)
                                {
                                    this.bw1.RunWorkerAsync();
                                }
                            }
                        }
                    }));

                    this.BeginInvoke(new Action(() =>
                    {
                        this.Client_IP.Text = ((IPEndPoint)this.client.Client.RemoteEndPoint).Address.ToString();
                    }));

                    this.stream = this.client.GetStream();

                    if (this.stream == null)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)("Client Disconnected IP: " + "\t IP ADDREES OF CLIENT : " + Client_IP_Presence + "\t Client Connection Time : " + DateTime.Now.ToString()));
                        }));
                    }
                }
                else
                {
                    string message = "PLEASE ENTER THE PORT NUMBER";
                    Alert(message);


                    this.BeginInvoke(new Action(() =>
                    {

                        this.Label_Notification_From_Server.Hide();
                    }));
                }
            }
            catch (Exception)
            {

            }
        }
        public void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (server != null && isServerRunning)
                {
                    TimeBox.Text = "";
                    if (bw1 != null && bw1.IsBusy)
                    {
                        bw1.CancelAsync();
                        bw1.Dispose();
                        bw1 = null;
                    }

                    if (client != null && client.Connected)
                    {
                        string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                        client.Close();
                        client = null;
                        stream = null;

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.Items.Add($"Client Disconnected IP: {clientIP} Client Disconnected Date and Time: {DateTime.Now}");
                        }));
                    }

                    server.Stop();
                    isServerRunning = false;
                    btnServer.Enabled = true;

                    BeginInvoke(new Action(() =>
                    {
                        Label_Notification_From_Server.Text = "Server Stopped";
                    }));
                }
                else if (server != null)
                {
                    server.Stop();
                    isServerRunning = false;
                    btnServer.Enabled = true;

                    BeginInvoke(new Action(() =>
                    {
                        Label_Notification_From_Server.Text = "Server Stopped";
                    }));
                }
            }
            catch
            {
                String message = "Server Stopped In an abnormal Condition";
                Alert(message);
            }
        }



        public void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                byte[] array = ((IEnumerable<string>)this.input2.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                this.stream.Write(array, 0, array.Length);

                string str = "";
                for (int index = 0; index < array.Length; ++index)
                    str = str + array[index].ToString("X2") + " ";

                this.BeginInvoke(new Action(() => {
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

        public void bw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error == null)
            { }
        }

        public void bw2_ProgressChanged(object sender, ProgressChangedEventArgs e) { }



        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String message = "Client disconnected abnormally";
                bool aarq = false;
                bool flag = true;
                bool flagger = true;

                while (client != null && client.Connected)
                {
                    if (!IsConnected(client))
                    {
                        string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.Items.Add($"---Client Disconnected--  IP ADDRESS OF CLIENT: {clientIP} Client Connection Time: {DateTime.Now}");
                        }));
                        Warning(message);
                        break;
                    }

                    byte[] bytes = new byte[1024];
                    int count = stream.Read(bytes, 0, bytes.Length);

                    if (count == 0)
                    {
                        break;
                    }

                    string str1 = BitConverter.ToString(bytes, 0, count);
                    string data = Encoding.ASCII.GetString(bytes, 0, count);
                    DateTime now = DateTime.Now;

                    if (data[count - 1] == 0x07 && data[count - 2] == 0x00 && data[count - 3] == 0x2C)
                    {
                        aarq = true;
                    }
                    else if (!aarq)
                    {
                       
                    }

                    if (flag)
                    {
                        MSN = BitConverter.ToUInt32(bytes, count - 4);
                        flag = false;
                    }

                    BeginInvoke(new Action(() =>
                    {
                        this.listBox2.Items.Add((object)(DateTime.Now.ToString() + "\tReceived:  " + str1 + "\tMeter Number:  " + MSN));
                    }));

                    BeginInvoke(new Action(() =>
                    {
                        listBox2.Items.Add("");
                    }));

                    BeginInvoke(new Action(() =>
                    {
                        listBox2.SelectedIndex = listBox2.Items.Count - 1;
                    }));

                    BeginInvoke(new Action(() =>
                    {
                        listBox2.SelectedIndex = -1;
                    }));

                    if (data[count - 1] == char.MinValue && data[count - 2] == '\t')
                    {
                        byte[] eventAck = { 0, 1, 0, 16, 0, 1, 0, 1, 219 };
                        stream.Write(eventAck, 0, eventAck.Length);
                        string myStr = BitConverter.ToString(eventAck);
                        string serial = Encoding.ASCII.GetString(bytes, count - 28, 10);

                        if (flagger)
                        {
                            MSN = UInt32.Parse(serial);
                            flagger = false;
                        }

                        BeginInvoke(new Action(() =>
                        {

                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tEvent Ack:  " + myStr + "\tMeter Number:  " + MSN));
                        }));

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.Items.Add("");
                        }));

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        }));

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.SelectedIndex = -1;
                        }));
                    }

                    if (bytes[1] == 4)
                    {
                        MSN = BitConverter.ToUInt32(bytes, count - 4);
                        byte[] keepAliveAck = { 218 };
                        string myStr = BitConverter.ToString(keepAliveAck);
                        stream.Write(keepAliveAck, 0, keepAliveAck.Length);

                        BeginInvoke(new Action(() =>
                        {

                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tKeep Alive Ack:  " + myStr + "\tMeter Number:  " + MSN));
                        }));

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.Items.Add("");
                        }));

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        }));

                        BeginInvoke(new Action(() =>
                        {
                            listBox1.SelectedIndex = -1;
                        }));
                    }
                }
            }
            catch
            {

                String message = "Connection Break";
                Alert(message);
            }
        }
        public void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error == null)
                ;
        }

        public void bw_ProgressChanged(object sender, ProgressChangedEventArgs e) { }

        public static string GetLocalIPAddress()
        {
            foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return address.ToString();
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            this.LocalIP.Text = ((IEnumerable<IPAddress>)Dns.GetHostEntry(Dns.GetHostName()).AddressList).Last<IPAddress>((Func<IPAddress, bool>)(ip => ip.AddressFamily == AddressFamily.InterNetwork)).ToString();
            string localIpAddress = MainForm.GetLocalIPAddress();
            this.Label_Notification_From_Server.Hide();
        }



        



        /// <summary>
        ///Running parrallel thread for commands execution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSend_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {

                    if (this.bw2.IsBusy)
                    {
                        return;
                    }
                    else
                    {
                        this.bw2.RunWorkerAsync();
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

        public void btnClear_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
        }
        public void AARQ_Click(object sender, EventArgs e)
        {
            if (this.bw3.IsBusy)
            {
                return;
            }
            else
            {
                this.bw3.RunWorkerAsync();
            }
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

        public void btnSend2_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input1.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
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

        public void butInput3_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input3.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);
                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));

                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                        //////////////////////////////////////
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

        public void btnInput4_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input4.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                       
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = -1;
                        }));
                        /////-----------------///

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
        public void btnInput5_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input5.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;

                        /////-----------------///
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


        private void Send_RLRQ_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = { 0, 1, 0, 48, 0, 1, 0, 5, 98, 3, 128, 1, 0 };
                        this.stream.Write(array, 0, array.Length);

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                       this.BeginInvoke(new Action(() =>
                        {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                        /////-----------------///        
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


        private bool IsConnected(TcpClient tcpClient)
        {
            try
            {
                // Perform a non-blocking read to check the client's status
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
        private void bw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error == null)
                ;
        }

        private void bw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.listBox1.Items.Add((object)
                  "Thread State\t" + (string)e.UserState);

            }));
        }



        private void bw3_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {

                if (Port.Text != "" && IP1.Text != "")
                {
                    if (client != null)
                    {
                        try
                        {
                            byte[] buffer = { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
                            string str = "";
                            this.stream.Write(buffer, 0, buffer.Length);
                            for (int index = 0; index < buffer.Length; ++index)
                            {
                                str = str + buffer[index].ToString("X2") + " ";
                            }
                          
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                            }));
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                            this.listBox1.SelectedIndex = -1;                        //////////////////////////////////////
                                                                                     //////////////////////////////////
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
            }));
        }




        private string convertr(byte[] ndata)
        {
            string str2 = "";
            for (int index = 0; index < ndata.Length; ++index)
            {
                str2 = str2 + ndata[index].ToString("X2") + " ";
            }
            return str2;

        }


        private void Sim_Write_button_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        //Sim Write Buffer//
                        byte[] Sim1Byte = { 0, 1, 0, 48, 0, 1, 0, 26, 193, 1, 129, 0, 1, 0, 0, 96, 12, 128, 255, 2, 0, 9, 11 };
                        byte[] Sim2Byte = { 0, 1, 0, 48, 0, 1, 0, 26, 193, 1, 129, 0, 1, 0, 0, 96, 12, 129, 255, 2, 0, 9, 11 };
                        byte[] Sim3Byte = { 0, 1, 0, 48, 0, 1, 0, 26, 193, 1, 129, 0, 1, 0, 0, 96, 12, 130, 255, 2, 0, 9, 11 };

                        byte[] buffer2 = { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
                        byte[] release = { 0, 1, 0, 48, 0, 1, 0, 5, 98, 3, 128, 1, 0 };
                        int count = 0;
                        stream.Write(buffer2, 0, buffer2.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);
                        if (count != 0)
                        {
                            Console.Write("Reading....");
                            count = 0;
                        }
                        ////////////////SIM1////////////////
                        byte[] ba1 = Encoding.Default.GetBytes(Sim1_Number_Box1.Text);
                        var hexString1 = BitConverter.ToString(ba1);
                        hexString1 = hexString1.Replace("-", " ");
                        hexString1 = hexString1.Replace("  ", " ");
                        byte[] Sim1Byte1 = hexString1.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        byte[] combined1 = concat(Sim1Byte, Sim1Byte1);
                        stream.Write(combined1, 0, combined1.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        /////////////////////
                        debugger(buffer1, count);


                        ////////////////SIM2////////////////
                        byte[] ba2 = Encoding.Default.GetBytes(Sim1_Number_Box2.Text);
                        var hexString2 = BitConverter.ToString(ba2);
                        hexString2 = hexString2.Replace("-", " ");
                        hexString2 = hexString2.Replace("  ", " ");
                        byte[] Sim2Byte1 = hexString2.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        byte[] combined2 = concat(Sim2Byte, Sim2Byte1);
                        stream.Write(combined2, 0, combined2.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        /////////////////////
                        debugger(buffer1, count);
                        ////////////////SIM3////////////////
                        byte[] ba3 = Encoding.Default.GetBytes(Sim1_Number_Box2.Text);
                        var hexString3 = BitConverter.ToString(ba3);
                        hexString3 = hexString3.Replace("-", " ");
                        hexString3 = hexString3.Replace("  ", " ");
                        byte[] Sim3Byte1 = hexString2.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        byte[] combined3 = concat(Sim3Byte, Sim3Byte1);
                        stream.Write(combined3, 0, combined3.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        /////////////////////

                        debugger(buffer1, count);



                        stream.Write(release, 0, release.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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


        public static byte[] concat(byte[] a, byte[] b)
        {
            byte[] combined = new byte[a.Length + b.Length];

            for (int i = 0; i < combined.Length; ++i)
            {
                combined[i] = i < a.Length ? a[i] : b[i - a.Length];
            }
            return combined;
        }
        void debugger(byte[] data, int size)
        {
            string my_str = " ";
            for (int i = 0; i < size; i++)
            {
                my_str += data[i].ToString("X2") + " ";
            }
            Console.Write("\n" + my_str + "\n");
        }




        private void DebugData(byte[] data)
        {
            int size = 0;
            size = this.stream.Read(data, 0, data.Length);
            string my_str = DateTime.Now.ToString() + ": ";
            for (int i = 0; i < size; i++)
            {
                my_str += data[i].ToString("X2") + " ";
            }
         
            this.BeginInvoke(new Action(() => {

                this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "  IP:  Received:" + my_str));
            }));
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            this.listBox1.SelectedIndex = -1;
            ((IList)data).Clear();

        }


        private void relayOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] RelayON = "00 01 00 30 00 01 00 0F C3 01 C1 00 46 00 00 60 03 0A FF 02 01 0F 00".Split().Select(s => Convert.ToByte(s, 16)).ToArray();


                        this.stream.Write(RelayON, 0, RelayON.Length);

                        string str = "";
                        for (int index = 0; index < RelayON.Length; ++index)
                            str = str + RelayON[index].ToString("X2") + " ";
                      

                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));

                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                        //////////////////////////////////////
                        //relayon_click.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string message = "Client Is Not Connected";
                    Warning(message);
                }
            }
            else
            {
                String message = "Start The Server First";
                Warning(message);
            }
        }

        private void Warning(string str)
        {
            MessageBox.Show(str, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Alert(string str)
        {
            MessageBox.Show(str, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        private void relayOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] RelayOff = "00 01 00 30 00 01 00 0F C3 01 C1 00 46 00 00 60 03 0A FF 01 01 0F 00".Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        this.stream.Write(RelayOff, 0, RelayOff.Length);

                        string str = "";
                        for (int index = 0; index < RelayOff.Length; ++index)
                            str = str + RelayOff[index].ToString("X2") + " ";
                       
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    PB1.Minimum = 0;
                    PB1.Maximum = 1005;
                    string[] firmwarepackets = new string[1005];
                    byte[] datas = new byte[1005];
                    int totalsteps = 0;
                    using (OdbcConnection connection = new OdbcConnection(myconn))
                    {
                        connection.Open();
                        using (OdbcCommand command = new OdbcCommand("SELECT commands FROM firmware;", connection))
                        using (OdbcDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                firmwarepackets[totalsteps] = (string)(dr["commands"]);
                                totalsteps++;
                            }
                            dr.Close();
                        }
                        connection.Close();
                    }
                    //*************** Check 1************************//
                    Console.Write("\nP1 Reach\n");
                    for (int o = 0; o < totalsteps; o++)
                    {
                        byte[] configcomm = firmwarepackets[o].Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        string tu = "";
                        for (int r = 0; r < configcomm.Length; r++)
                        {
                            tu += configcomm[r].ToString("X2") + " ";
                        }
                        stream.Write(configcomm, 0, configcomm.Length);
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + tu));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                        int roch = stream.Read(datas, 0, datas.Length);

                        if (datas[roch - 1] == 0 && datas[roch - 2] == 9)

                        {
                            byte[] eventAck = { 0, 1, 0, 16, 0, 1, 0, 1, 219 };
                            this.stream.Write(eventAck, 0, eventAck.Length);
                            string my_str = this.convertr(eventAck);
                            string Serial = (datas[roch - 28] - 48).ToString() + (datas[roch - 27] - 48).ToString() + (datas[roch - 26] - 48).ToString() + (datas[roch - 25] - 48).ToString() + (datas[roch - 24] - 48).ToString() + (datas[roch - 23] - 48).ToString() + (datas[roch - 22] - 48).ToString()
                                + (datas[roch - 21] - 48).ToString() + (datas[roch - 20] - 48).ToString()
                                + (datas[roch - 19] - 48).ToString();
                            MSN = UInt32.Parse(Serial);
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.Items.Add((object)("Sent:" + DateTime.Now.ToLongTimeString() + " Event Ack sent:" + MSN + "\t Packet Sended:" + my_str));
                            }));
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.Items.Add((object)" ");
                            }));
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                            }));
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.SelectedIndex = -1;
                            }));
                        }
                        if (datas[1] == 4)
                        {
                            MSN = (UInt32)((datas[roch - 1] << 24) | (datas[roch - 2] << 16) | (datas[roch - 3] << 8) | (datas[roch - 4] << 0));
                            byte[] keepAliveAck = { 218, 4, datas[roch - 4], datas[roch - 3], datas[roch - 2], datas[roch - 1] };
                            string my_str = this.convertr(keepAliveAck);
                            this.stream.Write(keepAliveAck, 0, keepAliveAck.Length);
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.Items.Add((object)("Sent:" + DateTime.Now.ToLongTimeString() + " Keep Alive Ack sent to meter:" + MSN + "\t Packet Sended:" + my_str));
                            }));
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.Items.Add((object)" ");
                            }));
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                            }));
                            this.BeginInvoke(new Action(() =>
                            {
                                this.listBox1.SelectedIndex = -1;
                            }));
                        }

                        tu = "";
                        for (int r = 0; r < roch; r++)
                        {
                            tu += datas[r].ToString("X2") + " ";
                        }
                        Array.Clear(datas, 0, datas.Length);
                        this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "  IP:  Recieved:  " + tu));
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        this.listBox1.SelectedIndex = -1;
                        PB1.Value = PB1.Value + 1;
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

        private void clearOpenFlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] Clear_Open_Flag = "00 01 00 30 00 01 00 10 C3 01 81 00 09 00 00 0A 00 00 FF 01 01 12 00 06".Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        this.stream.Write(Clear_Open_Flag, 0, Clear_Open_Flag.Length);

                        string str = "";
                        for (int index = 0; index < Clear_Open_Flag.Length; ++index)
                            str = str + Clear_Open_Flag[index].ToString("X2") + " ";
                     
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

        private void clearAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] clear_all_events = "00 01 00 30 00 01 00 10 C3 01 81 00 09 00 00 0A 00 00 FF 01 01 12 00 03".Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        this.stream.Write(clear_all_events, 0, clear_all_events.Length);

                        string str = "";
                        for (int index = 0; index < clear_all_events.Length; ++index)
                            str = str + clear_all_events[index].ToString("X2") + " ";
                       
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

        private void btnInput2_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {

                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input2.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = -1;
                        }));
                        /////-----------------///

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
        private void SimsRead_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {

                        byte[] buffer2 = { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
                        byte[] release = { 0, 1, 0, 48, 0, 1, 0, 5, 98, 3, 128, 1, 0 };
                        int count = 0;
                        Sim1_Number_Read_Box1.Text = "Reading...";
                        Sim2_Number_Read_Box2.Text = "Reading...";
                        Sim3_Number_Read_Box3.Text = "Reading...";


                        stream.Write(buffer2, 0, buffer2.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);
                        if (count != 0)
                        {
                            Console.Write("Reading....");
                        }
                        string sm1 = "";
                        string sm2 = "";
                        string sm3 = "";

                        string Sim1_Read = "00 01 00 30 00 01 00 0D C0 01 81 00 01 00 00 60 0C 80 FF 02 00";
                        byte[] Sim1Byte = Sim1_Read.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        stream.Write(Sim1Byte, 0, Sim1Byte.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);
                        for (int i = 14; i < 14 + buffer1[13]; i++)
                        {
                            sm1 += Convert.ToChar(buffer1[i]);
                        }

                        string Sim2_Read = "00 01 00 30 00 01 00 0D C0 01 81 00 01 00 00 60 0C 81 FF 02 00";
                        byte[] Sim2Byte = Sim2_Read.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        stream.Write(Sim2Byte, 0, Sim2Byte.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);
                        for (int i = 14; i < 14 + buffer1[13]; i++)
                        {
                            sm2 += Convert.ToChar(buffer1[i]);
                        }


                        string Sim3_Read = "00 01 00 30 00 01 00 0D C0 01 81 00 01 00 00 60 0C 82 FF 02 00";
                        byte[] Sim3Byte = Sim3_Read.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                        stream.Write(Sim3Byte, 0, Sim3Byte.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);

                        for (int i = 14; i < 14 + buffer1[13]; i++)
                        {
                            sm3 += Convert.ToChar(buffer1[i]);
                        }

                        Sim1_Number_Read_Box1.Text = sm1;
                        Sim2_Number_Read_Box2.Text = sm2;
                        Sim3_Number_Read_Box3.Text = sm3;


                        stream.Write(release, 0, release.Length);
                        count = stream.Read(buffer1, 0, buffer1.Length);
                        debugger(buffer1, count);
                        ((IList)buffer1).Clear();
                        count = 0;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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




        private void btnInput_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input1.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = -1;
                        }));
                        /////-----------------///

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


        private void btnInput1_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    try
                    {
                        byte[] array = ((IEnumerable<string>)this.input2.Text.Split()).Select<string, byte>((Func<string, byte>)(s => Convert.ToByte(s, 16))).ToArray<byte>();
                        this.stream.Write(array, 0, array.Length);

                        string str = "";
                        for (int index = 0; index < array.Length; ++index)
                            str = str + array[index].ToString("X2") + " ";
                        
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.Items.Add((object)(DateTime.Now.ToString() + "\tSend:  " + str));
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        }));
                        this.BeginInvoke(new Action(() => {
                            this.listBox1.SelectedIndex = -1;
                        }));
                        /////-----------------///

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
        private void RID_Click(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    int count = 0;
                    ((IList)buffer1).Clear();
                    byte[] sig = { };
                    byte[] buffer2 = { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
                    byte[] release = { 0, 1, 0, 48, 0, 1, 0, 5, 98, 3, 128, 1, 0 };

                    stream.Write(buffer2, 0, buffer2.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);

                    if (count != 0)
                    {
                        Console.Write("Reading....");
                        count = 0;
                    }
                    string rssiCommand = "00 01 00 30 00 01 00 0D C0 01 81 00 01 00 00 60 0C 05 FF 02 00";
                    byte[] rssi = rssiCommand.Split().Select(s => Convert.ToByte(s, 16)).ToArray();


                    stream.Write(rssi, 0, rssi.Length);
                    count = stream.Read(sig, 0, sig.Length);

                    currentTarrrr_Box.Text = "Reading...";
                    signal.Text = "Reading...";
                    meterserialnumber.Text = "Reading...";
                    meterdatetime.Text = "Reading...";
                    currenta.Text = "Reading...";
                    currb.Text = "Reading...";
                    currentc.Text = "Reading...";
                    voltagea.Text = "Reading...";
                    voltageb.Text = "Reading...";
                    voltagec.Text = "Reading...";
                    AggReactivePowerExport_Box.Text = "Reading...";
                    AggregatePowerImportbox.Text = "Reading...";
                    AggActivePowerExportbox.Text = "Reading...";
                    AggActivePowerImportbox.Text = "Reading...";
                    freqbox.Text = "Reading...";
                    PowerFactorbox.Text = "Reading...";
                    string a = (sig[count - 1].ToString("X2"));
                    Console.Write(a + "\n");
                    int intAgain = int.Parse(a, System.Globalization.NumberStyles.HexNumber);
                    int b = 256;


                    Console.Write(intAgain + "\n");

                    int c = b - intAgain;
                    c = c * -1;
                    Console.Write(c + "\n");


                    signal.Text = c.ToString() + " dbm";

                    string str = "";
                    for (int index = 0; index < sig.Length; ++index)
                        str = str + sig[index].ToString("X2") + " ";
                    Console.Write("\n" + "Recieved Signal Reply" + str);




                    string Instant = "00 01 00 30 00 01 00 0D C0 01 81 00 07 01 00 5E 5C 0A FF 02 00";
                    byte[] InstantByte = Instant.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                    stream.Write(InstantByte, 0, InstantByte.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);

                    string currentTarrrr = buffer1[count - 1].ToString();
                    currentTarrrr_Box.Text = currentTarrrr;

                    meterserialnumber.Text = MSN.ToString();
                    float TotalReactivePowerExport = (UInt32)((buffer1[count - 6] << 24) | (buffer1[count - 5] << 16) | (buffer1[count - 4] << 8) | (buffer1[count - 3] << 0));
                    TotalReactivePowerExport = TotalReactivePowerExport / 1000;
                    AggReactivePowerExport_Box.Text = TotalReactivePowerExport.ToString();

                    float TotalRactivePowerImport = (UInt32)((buffer1[count - 11] << 24) | (buffer1[count - 10] << 16) | (buffer1[count - 9] << 8) | (buffer1[count - 8] << 0));
                    TotalRactivePowerImport = TotalRactivePowerImport / 1000;
                    AggregatePowerImportbox.Text = TotalRactivePowerImport.ToString();

                    float TotalActivePowerExport = (UInt32)((buffer1[count - 16] << 24) | (buffer1[count - 15] << 16) | (buffer1[count - 14] << 8) | (buffer1[count - 13] << 0));
                    TotalActivePowerExport = TotalActivePowerExport / 1000;
                    AggActivePowerExportbox.Text = TotalActivePowerExport.ToString();


                    float TotalActivePowerImport = (UInt32)((buffer1[count - 21] << 24) | (buffer1[count - 20] << 16) | (buffer1[count - 19] << 8) | (buffer1[count - 18] << 0));
                    TotalActivePowerImport = TotalActivePowerImport / 1000;
                    AggActivePowerImportbox.Text = TotalActivePowerImport.ToString();

                    float FrequencyInstantaneous = (UInt16)((buffer1[count - 24] << 8) | (buffer1[count - 23] << 0));
                    FrequencyInstantaneous = FrequencyInstantaneous / 100;
                    freqbox.Text = FrequencyInstantaneous.ToString();


                    float PowerFactor = (UInt16)((buffer1[count - 27] << 8) | (buffer1[count - 26] << 0));
                    PowerFactor = PowerFactor / 1000;
                    PowerFactorbox.Text = PowerFactor.ToString();


                    float VoltageC = (UInt16)((buffer1[count - 39] << 8) | (buffer1[count - 38] << 0));
                    VoltageC = VoltageC / 100;
                    voltagec.Text = VoltageC.ToString();



                    float VoltageB = (UInt16)((buffer1[count - 42] << 8) | (buffer1[count - 41] << 0));
                    VoltageB = VoltageB / 100;
                    voltageb.Text = VoltageB.ToString();



                    float VoltageA = (UInt16)((buffer1[count - 45] << 8) | (buffer1[count - 44] << 0));
                    VoltageA = VoltageA / 100;
                    voltagea.Text = VoltageA.ToString();


                    float CurrentC = (UInt32)((buffer1[count - 50] << 24) | (buffer1[count - 49] << 16) | (buffer1[count - 48] << 8) | (buffer1[count - 47] << 0));
                    CurrentC = CurrentC / 1000;
                    currentc.Text = CurrentC.ToString();


                    float CurrentB = (UInt32)((buffer1[count - 55] << 24) | (buffer1[count - 54] << 16) | (buffer1[count - 53] << 8) | (buffer1[count - 52] << 0));
                    CurrentB = CurrentB / 1000;
                    currb.Text = CurrentB.ToString();


                    float CurrentA = (UInt32)((buffer1[count - 60] << 24) | (buffer1[count - 59] << 16) | (buffer1[count - 58] << 8) | (buffer1[count - 57] << 0));
                    CurrentA = CurrentA / 1000;
                    currenta.Text = CurrentA.ToString();


                    string DateTimeInstantaneous = ((UInt16)((buffer1[count - 73] << 8) | (buffer1[count - 72] << 0))).ToString() + "/" + buffer1[count - 71] + "/" + buffer1[count - 70] + " " + buffer1[count - 68] + ":" + buffer1[count - 67] + ":" + buffer1[count - 66];
                    DateTime DTInst = DateTime.Parse(DateTimeInstantaneous);
                    meterdatetime.Text = DTInst.ToString();

                    stream.Write(release, 0, release.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);
                    if (buffer1[count - 2] == 216)
                    {
                        MessageBox.Show("READING SUCCESSFUL");
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
        private void Sim_Write_button_Click_1(object sender, EventArgs e)
        {
            if (Port.Text != "" && IP1.Text != "")
            {
                if (client != null)
                {
                    byte[] Sim1Byte = { 0, 1, 0, 48, 0, 1, 0, 26, 193, 1, 129, 0, 1, 0, 0, 96, 12, 128, 255, 2, 0, 9, 11 };
                    byte[] Sim2Byte = { 0, 1, 0, 48, 0, 1, 0, 26, 193, 1, 129, 0, 1, 0, 0, 96, 12, 129, 255, 2, 0, 9, 11 };
                    byte[] Sim3Byte = { 0, 1, 0, 48, 0, 1, 0, 26, 193, 1, 129, 0, 1, 0, 0, 96, 12, 130, 255, 2, 0, 9, 11 };

                    byte[] release = { 0, 1, 0, 48, 0, 1, 0, 5, 98, 3, 128, 1, 0 };
                    int count = 0;
                    byte[] buffer2 = { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
                    stream.Write(buffer2, 0, buffer2.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);
                    debugger(buffer1, count);
                    if (count != 0)
                    {
                        Console.Write("Reading....");
                        count = 0;
                    }
                    ////////////////SIM1////////////////
                    byte[] ba1 = Encoding.Default.GetBytes(Sim1_Number_Box1.Text);
                    var hexString1 = BitConverter.ToString(ba1);
                    hexString1 = hexString1.Replace("-", " ");
                    hexString1 = hexString1.Replace("  ", " ");
                    byte[] Sim1Byte1 = hexString1.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                    byte[] combined1 = concat(Sim1Byte, Sim1Byte1);
                    stream.Write(combined1, 0, combined1.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);
                    /////////////////////
                    debugger(buffer1, count);


                    ////////////////SIM2////////////////
                    byte[] ba2 = Encoding.Default.GetBytes(Sim1_Number_Box2.Text);
                    var hexString2 = BitConverter.ToString(ba2);
                    hexString2 = hexString2.Replace("-", " ");
                    hexString2 = hexString2.Replace("  ", " ");
                    byte[] Sim2Byte1 = hexString2.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                    byte[] combined2 = concat(Sim2Byte, Sim2Byte1);
                    stream.Write(combined2, 0, combined2.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);
                    /////////////////////
                    debugger(buffer1, count);
                    ////////////////SIM3////////////////
                    byte[] ba3 = Encoding.Default.GetBytes(Sim1_Number_Box2.Text);
                    var hexString3 = BitConverter.ToString(ba3);
                    hexString3 = hexString3.Replace("-", " ");
                    hexString3 = hexString3.Replace("  ", " ");
                    byte[] Sim3Byte1 = hexString2.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
                    byte[] combined3 = concat(Sim3Byte, Sim3Byte1);
                    stream.Write(combined3, 0, combined3.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);
                    /////////////////////

                    debugger(buffer1, count);



                    stream.Write(release, 0, release.Length);
                    count = stream.Read(buffer1, 0, buffer1.Length);
                    debugger(buffer1, count);
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            About ab = new About();
            ab.Show();
            

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.Show();

        }

        private void Load_Data_Click(object sender, EventArgs e)
        {
            int count = 0;
            DateTime startDateTime = dateTimePicker1.Value;
            DateTime endDateTime = dateTimePicker2.Value;
            int startyearInt = int.Parse(startDateTime.ToString("yyyy"));
            string startDateHex = startyearInt.ToString("X2");
            int startmonthInt = int.Parse(startDateTime.ToString("MM"));
            string startDateHex1 = startmonthInt.ToString("X2");
            int startdayhInt = int.Parse(startDateTime.ToString("dd"));
            string startDateHex2 = startdayhInt.ToString("X2");
            string date = "0" + startDateHex + startDateHex1 + startDateHex2;
            date = string.Join(" ", Regex.Matches(date, ".{2}").Cast<Match>().Select(m => m.Value));

            int startTimeHex = int.Parse(startDateTime.ToString("HH"));
            int startTimeHex1 = int.Parse(startDateTime.ToString("mm"));
            int startSecondInt = startDateTime.Second;
            string startTimeHex2 = startSecondInt.ToString("X2");


            string s_hh = startTimeHex.ToString("X2");
            string s_mm = startTimeHex1.ToString("X2");
            string startingtime = s_hh + " " + s_mm + " " + startTimeHex2;


            int endyearInt = int.Parse(endDateTime.ToString("yyyy"));
            string endDateHex = endyearInt.ToString("X2");
            int endmonthInt = int.Parse(endDateTime.ToString("MM"));
            string endDateHex1 = endmonthInt.ToString("X2");
            int enddayhInt = int.Parse(endDateTime.ToString("dd"));
            string endDateHex2 = enddayhInt.ToString("X2");
            string end_date = "0" + endDateHex + endDateHex1 + endDateHex2;
            end_date = string.Join(" ", Regex.Matches(end_date, ".{2}").Cast<Match>().Select(m => m.Value));

            int endSecondInt = endDateTime.Second;
            string endTimeHex2 = endSecondInt.ToString("X2");

            int endTimeHex = int.Parse(endDateTime.ToString("HH"));
            int endTimeHex1 = int.Parse(endDateTime.ToString("mm"));


            string ehh = endTimeHex.ToString("X2");
            string emm = endTimeHex1.ToString("X2");
            string endingtime = ehh + " " + emm + " " + endTimeHex2;

          //  byte[] buffer2 = { 0, 1, 0, 48, 0, 1, 0, 56, 96, 54, 161, 9, 6, 7, 96, 133, 116, 5, 8, 1, 1, 138, 2, 7, 128, 139, 7, 96, 133, 116, 5, 8, 2, 1, 172, 10, 128, 8, 49, 50, 51, 52, 53, 54, 55, 56, 190, 16, 4, 14, 1, 0, 0, 0, 6, 95, 31, 4, 0, 0, 126, 31, 4, 176 };
            //stream.Write(buffer2, 0, buffer2.Length);
            //count = stream.Read(buffer1, 0, buffer1.Length);
            //if (count != 0)
            //{
              //  count = 0;
            //}
            string selectedValue = UtilitiesBox.Text;

             if (selectedValue == "Load Profile Data")
            {
                dataGridView1.Columns.Add("msn", "MSN");
                dataGridView1.Columns.Add("meter Datetime", "Meter Datetime");
                dataGridView1.Columns.Add("Interval", "Interval");
                dataGridView1.Columns.Add("active_energy_pos_t1", "Active Energy T1");
                dataGridView1.Columns.Add("active_energy_pos_t2", "Active Energy T2");
                dataGridView1.Columns.Add("active_energy_pos_tl", "Active Energy TL");
                dataGridView1.Columns.Add("active_energy_neg_t1", "Active Energy Negative T1");
                dataGridView1.Columns.Add("active_energy_neg_t2", "Active Energy Negative T2");
                dataGridView1.Columns.Add("active_energy_neg_tl", "Active Energy Negative TL");
                dataGridView1.Columns.Add("active_energy_abs_t1", "Active Energy Absolute T1");
                dataGridView1.Columns.Add("active_energy_abs_t2", "Active Energy Absolute T2");
                dataGridView1.Columns.Add("active_energy_abs_tl", "Active Energy Absolute TL");
                dataGridView1.Columns.Add("reactive_energy_pos_t1", "Reactive Energy T1");
                dataGridView1.Columns.Add("reactive_energy_pos_t2", "Reactive Energy T2");
                dataGridView1.Columns.Add("reactive_energy_pos_tl", "Reactive Energy TL");
                dataGridView1.Columns.Add("reactive_energy_neg_t1", "Reactive Energy Negative T1");
                dataGridView1.Columns.Add("reactive_energy_neg_t2", "Reactive Energy Negative T2");
                dataGridView1.Columns.Add("reactive_energy_neg_tl", "Reactive Energy Negative TL");
                dataGridView1.Columns.Add("reactive_energy_abs_t1", "Reactive Energy Absolute T1");
                dataGridView1.Columns.Add("reactive_energy_abs_t2", "Reactive Energy Absolute T2");
                dataGridView1.Columns.Add("reactive_energy_abs_tl", "Reactive Energy Absolute TL");
                dataGridView1.Columns.Add("active_MDl_pos_t1", "Active MDL T1");
                dataGridView1.Columns.Add("active_MDl_pos_t2", "Active MDL T2");
                dataGridView1.Columns.Add("active_MDl_pos_tl", "Active MDL TL");
                dataGridView1.Columns.Add("active_MDl_neg_t1", "Active MDL Negative T1");
                dataGridView1.Columns.Add("active_MDI_neg_t2", "Active MDL Negative T2");
                dataGridView1.Columns.Add("active_MDI_neg_tl", "Active MDL Negative TL");
                dataGridView1.Columns.Add("active_MDI_abs_t1", "Active MDL Absolute T1");
                dataGridView1.Columns.Add("active_MDI_abs_t2", "Active MDL Absolute T2");
                dataGridView1.Columns.Add("active_MDI_abs_tl", "Active MDL Absolute TL");
                dataGridView1.Columns.Add("aggregate_active_pwr_pos", "Aggregate Active Power Positive");
                dataGridView1.Columns.Add("aggregate_active_pwr_neg", "Aggregate Active Power Negative");
                dataGridView1.Columns.Add("aggregate_active_pwr_abs", "Aggregate Active Power Absolute");
                dataGridView1.Columns.Add("aggregate_reactive_pwr_pos", "Aggregate Reactive Power Positive");
                dataGridView1.Columns.Add("aggregate_reactive_pwr_neg", "Aggregate Reactive Power Negative");
                dataGridView1.Columns.Add("aggregate_reactive_pwr_abs", "Aggregate Reactive Power Absolute");
                dataGridView1.Columns.Add("frequency", "Frequency");
                dataGridView1.Columns.Add("average_pf", "Average Power Factor");


                // Load data into the DataGridView
             
            }

            

            
        
            else if (selectedValue == "Instantaneous Data")
            {
                // Do something when "Instantaneous Data" is selected
                // Example: performInstantaneousDataOperation();
            }
            else if (selectedValue == "Daily billing Data")
            {
                // Do something when "Daily billing Data" is selected
                // Example: performDailyBillingDataOperation();
            }
            else
            {
                string message = "PLEASE SELECT THE OPERATION FROM THE LIST";
                Alert(message);
            }
        }
    }
}






















