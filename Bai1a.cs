using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai1a : Form
    {
        public delegate void ShowMessage(string message);
        public ShowMessage myDelegate;
        Int32 port = 8080;
        UdpClient udpClient = new UdpClient(8080);
        Thread thread;
        public Bai1a()
        {
            InitializeComponent();
        }
        private async void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Hide();
                richTextBox1.Text = "Start Listening\n";
                await ReceiveMessagesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ReceiveMessagesAsync()
        {
            while (true)
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, port);
                byte[] content = await Task.Run(() => udpClient.Receive(ref remoteIPEndPoint));
                if (content.Length > 0)
                {
                    string message = remoteIPEndPoint.Address.ToString() + ": " + Encoding.UTF32.GetString(content);
                    ShowMessageMethod(message);
                }
            }
        }

        private void ShowMessageMethod(string message)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.Text += message + "\n"; });
            }
            else
            {
                richTextBox1.Text += message + "\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
