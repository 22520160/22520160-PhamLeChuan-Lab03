using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(serverLoad));
            serverThread.Start();
        }

        private void serverLoad()
        {
            Application.Run(new Bai4a());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread clientThread = new Thread(new ThreadStart(clientLoad));
            clientThread.Start();
        }

        private void clientLoad()
        {
            Application.Run(new Bai6b());
        }
        private void Bai06_Load(object sender, EventArgs e)
        {

        }
    }
}
