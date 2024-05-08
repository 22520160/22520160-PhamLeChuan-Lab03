using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;

namespace Lab03
{
    public partial class Bai6b : Form
    {
        public Bai6b()
        {
            InitializeComponent();
        }
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        StreamWriter streamWriter;
        StreamReader streamReader;
        TcpClient tcpClient = new TcpClient();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                String messaage = textBox2.Text;
                if (String.IsNullOrEmpty(messaage))
                {
                    throw new Exception("Nhập tin nhắn");
                }
                streamWriter.WriteLine(name + ": " + messaage);
                streamWriter.Flush();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                if (String.IsNullOrEmpty(name))
                {
                    throw new Exception("Nhập tên client");
                }
                if (!tcpClient.Connected)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    tcpClient.Connect(iPEndPoint);
                    textBox1.Enabled = false;
                    button2.Enabled = false;
                    streamReader = new StreamReader(tcpClient.GetStream());
                    streamWriter = new StreamWriter(tcpClient.GetStream());
                    streamWriter.AutoFlush = true;
                    Thread thread = new Thread(new ThreadStart(ReceiveMessage));
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessage()
        {
            try
            {
                while (tcpClient.Connected)
                {
                    String receiveMessage = streamReader.ReadLine();
                    if (receiveMessage != null)
                    {
                        richTextBox1.AppendText(receiveMessage + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                streamReader.Close();
                streamWriter.Close();
                tcpClient.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            streamWriter.WriteLine(name + " has left the chat");
            streamWriter.Flush();
            this.Hide();
        }
        private void Bai4b_Load(object sender, EventArgs e)
        {

        }
       
    }
}
