using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int bufferSize = 255;
        static byte[] buffer = new byte[bufferSize];
        static Form1 F;
        const String host = "192.168.88.1";
        static IPAddress ipAddr = new IPAddress(new byte[4] { 192, 168, 88, 1 });
        static IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 80);
        Socket client;

        delegate void HandleMessageDelegate(string message);
        delegate void ConnectedDelegate();

        HandleMessageDelegate MessageHandler;

        int nextCommand;
        string[] sketch;
        List<string[]> sketches;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               if (SendMessage(textBox1.Text))
                {
                    textBox1.Text = "";
                }
            }
        }

        bool SendMessage(string msg)
        {
            try
            {
                client.Send(Encoding.UTF8.GetBytes(msg + "\n"));
                return true;
            }
            catch
            {
                Disconnected();
                return false;
            }
        }

        private void Connect()
        {
            richTextBox1.AppendText($"Wait for connect to {host} ...\n");
            client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            client.BeginConnect(ipEndPoint, ConnectCallBack, client);
        }

        static void ConnectCallBack(IAsyncResult state)
        {
            Socket client = (Socket)state.AsyncState;
            try
            {
                client.EndConnect(state);
                F.Invoke(new ConnectedDelegate(F.Connected), new object[] {});
                client.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceiveCallBack, client);
            }
            catch (SocketException)
            {
               client.BeginConnect(ipEndPoint, ConnectCallBack, client);
            }
        }

        const int deviation = 12;
        const int delta = 40;
        int angle;
        void RotateHandler(string msg)
        {
            if (msg == "Recieved" && angle <= 180)
            {
                SendMessage($"sp{deviation} {angle}");
                angle += delta;
            }
            else
            {
                MessageHandler = PrintMessage;
                SendMessage("sp0 0");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageHandler = RotateHandler;
            angle = -180;
            SendMessage($"sp{deviation} {angle}");
            angle += delta;
        }

        void LoadSketches()
        {
            StreamReader file = new StreamReader("Sketches.txt");
            sketches = new List<string[]>();
            sketchBox.Items.Clear();
            sketchBox.SelectedIndex = -1;
            while (!file.EndOfStream)
            {
                sketch = file.ReadLine().Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (sketch.Length > 1)
                {
                    if (sketch[0] == "*")
                    {
                        sketchBox.Items.Add(sketch[1]);
                        sketchBox.SelectedIndex = sketchBox.Items.Count - 1;
                        sketches.Add(sketch.Skip(2).ToArray());
                    }
                    else
                    {
                        sketchBox.Items.Add(sketch[0]);
                        sketches.Add(sketch.Skip(1).ToArray());
                    }
                }
            }
            file.Close();
            if (sketchBox.SelectedIndex == -1)
            {
                sketchBox.SelectedIndex = sketchBox.Items.Count - 1;
            }
        }

        void SketchHandler(string msg)
        {
            if (msg == "Recieved" && nextCommand != sketch.Length)
            {
                if (sketch[nextCommand].StartsWith("sleep"))
                {
                    Thread.Sleep(int.Parse(sketch[nextCommand++].Substring(5)));
                    if (nextCommand != sketch.Length)
                    {
                        SendMessage(sketch[nextCommand++]);
                    }
                    else
                    {
                        MessageHandler = PrintMessage;
                    }
                }
                else
                {
                    SendMessage(sketch[nextCommand++]);
                }
            }
            else
            {
                MessageHandler = PrintMessage;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageHandler = SketchHandler;
            sketch = sketches[sketchBox.SelectedIndex];
            nextCommand = 0;
            SendMessage(sketch[nextCommand++]);
        }

        void PrintMessage(string message)
        {
            richTextBox1.AppendText(message + "\n");
            richTextBox1.ScrollToCaret();
        }

        void Connected()
        {
            richTextBox1.AppendText("Connected\n");
            textBox1.Enabled = legsBox.Enabled = button4.Enabled = button5.Enabled = button7.Enabled = true;
            textBox1.Focus();
        }

        void Disconnected()
        {
            richTextBox1.AppendText("Disconnected\n");
            textBox1.Enabled = legsBox.Enabled = button4.Enabled = button3.Enabled = 
            heightBar.Enabled = radiusBar.Enabled = turnBar.Enabled = button5.Enabled = false;
            turnBar.Value = 0;
            Turnlabel.ResetText();
            Connect();
        }

        static void ReceiveCallBack(IAsyncResult state)
        {
            Socket client = (Socket)state.AsyncState;
            try
            {
                int count = client.EndReceive(state);
                string msg = Encoding.UTF8.GetString(buffer, 0, count);
                F.Invoke(F.MessageHandler, new object[] { msg });
                client.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceiveCallBack, client);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F = this;
            legsBox.SelectedIndex = 2;
            MessageHandler = PrintMessage;
            LoadSketches();
            Connect();
        }

        private void turnBar_ValueChanged(object sender, EventArgs e)
        {
            Turnlabel.Text = turnBar.Value.ToString();
        }

        private void heightBar_ValueChanged(object sender, EventArgs e)
        {
            HRlabel.Text = (sender as TrackBar).Value.ToString();
        }

        private void heightBar_MouseUp(object sender, MouseEventArgs e)
        {
            SendMessage($"d|{heightBar.Value}");
            HRlabel.ResetText();
            heightBar.Value = 0;
        }

        private void radiusBar_MouseUp(object sender, MouseEventArgs e)
        {
            SendMessage($"d-{radiusBar.Value}");
            HRlabel.ResetText();
            radiusBar.Value = 0;
        }

        private void turnBar_MouseUp(object sender, MouseEventArgs e)
        {
            SendMessage($"d){turnBar.Value + 90}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SendMessage($"sx{legsBox.SelectedIndex}"))
            {
                legsBox.Enabled = button4.Enabled = false;
                button3.Enabled = heightBar.Enabled = radiusBar.Enabled = turnBar.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SendMessage("sx"))
            {
                legsBox.Enabled = button4.Enabled = true;
                button3.Enabled = heightBar.Enabled = radiusBar.Enabled = turnBar.Enabled = false;
                turnBar.Value = 0;
                Turnlabel.ResetText();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageHandler = PrintMessage;
        }

        private void RefreshSketches_btn_Click(object sender, EventArgs e)
        {
            LoadSketches();
        }
    }
}
