using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai3a : Form
    {
        private TcpListener listener;

        public Bai3a()
        {
            InitializeComponent();
        }

        private async void btnListen_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8080;
            listener = new TcpListener(ipAddress, port);
            listener.Start();
            listViewCommand.Items.Add(new ListViewItem("Server started. Listening for connections..."));

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                ProcessClient(client);
            }
        }

        private async void ProcessClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listViewCommand.Items.Add(new ListViewItem(data));
            }

            stream.Close();
            client.Close();
        }
    }
}
