using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnUDPClient_Click(object sender, EventArgs e)
        {
            Bai1b f = new Bai1b();
            f.Show();
        }

        private void btnUDPServer_Click(object sender, EventArgs e)
        {
            Bai1a f = new Bai1a();
            f.Show();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }
    }
}
