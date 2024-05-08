using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai1b : Form
    {
        public Bai1b()
        {
            InitializeComponent();
        }
        UdpClient udpClient = new UdpClient();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                int port;
                if (!Int32.TryParse(tbPort.Text, out port))
                {
                    MessageBox.Show("Invalid port number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IPAddress ip;
                if (!IPAddress.TryParse(tbIP.Text.Trim(), out ip))
                {
                    MessageBox.Show("Invalid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
                byte[] content = Encoding.UTF32.GetBytes(rtbMessage.Text);

                int count = await SendDataAsync(content, ipEndPoint);
                if (count > 0)
                {
                    rtbMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Task<int> SendDataAsync(byte[] content, IPEndPoint ipEndPoint)
        {
            return Task.Run(() =>
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    return udpClient.Send(content, content.Length, ipEndPoint);
                }
            });
        }

    }
}
