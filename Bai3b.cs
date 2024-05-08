using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai3b : Form
    {
        private TcpClient tcpClient;
        private NetworkStream ns;

        public Bai3b()
        {
            InitializeComponent();
            this.tcpClient = new TcpClient();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 8080;
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                tcpClient.Connect(ipEndPoint);
                ns = tcpClient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
{
    try
    {
        string message = rtbSend.Text.Trim(); 
        if (string.IsNullOrEmpty(message))
        {
            MessageBox.Show("Please enter a message to send.");
            return;
        }

        Byte[] data = Encoding.ASCII.GetBytes(message + "\n"); 
        ns.Write(data, 0, data.Length); 
        rtbSend.Clear();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error sending data: " + ex.Message);
    }
}


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ns != null)
                {
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes("quit\n");
                    ns.Write(data, 0, data.Length);
                    ns.Close();
                }
                if (tcpClient != null)
                    tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disconnecting from server: " + ex.Message);
            }
            Close();
        }

    }
}


