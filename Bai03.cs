using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            Form tcpServer = new Bai3a();
            tcpServer.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            Form tcpClient = new Bai3b();
            tcpClient.Show();
        }
    }
}
