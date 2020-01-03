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

    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
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
            cmd.CommandText = "SELECT * FROM ogretmenler where kullaniciAdi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                OgretmenGiris frm1 = new OgretmenGiris();
                frm1.Close();
                Soru_Ekle frm2 = new Soru_Ekle();
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
            OgretmenGiris frm1 = new OgretmenGiris();
            frm1.Close();
            Giris frm2 = new Giris();
            frm2.Show();
            this.Hide();
        }
    }

       
    }

