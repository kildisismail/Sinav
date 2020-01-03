using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sınav
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;
            con = new SqlConnection("Data Source=LAPTOP-T1ORC6LM\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ogrenciler where kullaniciAdi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                OgrenciGiris frm1 = new OgrenciGiris();
                frm1.Close();
                SinavEkrani frm2 = new SinavEkrani();
                frm2.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciGiris frm1 = new OgrenciGiris();
            frm1.Close();
            Giris frm3 = new Giris();
            frm3.Show();
            this.Hide();
        }
    }


}

   
        