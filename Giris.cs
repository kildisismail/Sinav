using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris frm1 = new Giris();
            frm1.Close();
            OgrenciGiris frm3 = new OgrenciGiris();
            frm3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris frm1 = new Giris();
            frm1.Close();
            OgretmenGiris frm2 = new OgretmenGiris();
            frm2.Show();
            this.Hide();
        }

    }
}
