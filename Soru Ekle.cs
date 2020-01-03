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
    public partial class Soru_Ekle : Form
    {
        public Soru_Ekle()
        {
            InitializeComponent();
        }
        string soru, cvpA, cvpB, cvpC, cvpD, cvpDogru, foto, komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-T1ORC6LM\SQLEXPRESS;Initial Catalog=konular;Integrated Security=True");

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int uzunluk;
        private void soruRichTextBox_TextChanged(object sender, EventArgs e)
        {
            uzunluk= soruRichTextBox.TextLength;
            lblUzunluk.Text = "Karakter sayısı=" + soruRichTextBox.TextLength.ToString();
            if (uzunluk == 250)
            {
                MessageBox.Show("Max karakter sayısına ulaşıldı!!!");
            }
        }

        private void aRichTextBox_TextChanged(object sender, EventArgs e)
        {
            uzunluk = aRichTextBox.TextLength;
            lblUzunluk.Text = "Karakter sayısı=" + aRichTextBox.TextLength.ToString();
            if (uzunluk == 50)
            {
                MessageBox.Show("Max karakter sayısına ulaşıldı!!!");
            }
        }

        private void bRichTextBox_TextChanged(object sender, EventArgs e)
        {
            uzunluk = bRichTextBox.TextLength;
            lblUzunluk.Text = "Karakter sayısı=" + bRichTextBox.TextLength.ToString();
            if (uzunluk == 50)
            {
                MessageBox.Show("Max karakter sayısına ulaşıldı!!!");
            }
        }

        private void cRichTextBox_TextChanged(object sender, EventArgs e)
        {
            uzunluk = cRichTextBox.TextLength;
            lblUzunluk.Text = "Karakter sayısı=" + cRichTextBox.TextLength.ToString();
            if (uzunluk == 50)
            {
                MessageBox.Show("Max karakter sayısına ulaşıldı!!!");
            }
        }

        private void dRichTextBox_TextChanged(object sender, EventArgs e)
        {
            uzunluk = dRichTextBox.TextLength;
            lblUzunluk.Text = "Karakter sayısı=" + dRichTextBox.TextLength.ToString();
            if (uzunluk == 50)
            {
                MessageBox.Show("Max karakter sayısına ulaşıldı!!!");
            }
        }

        private void dogruRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            uzunluk = dogruRichTextBox1.TextLength;
            lblUzunluk.Text = "Karakter sayısı=" + dogruRichTextBox1.TextLength.ToString();
            if (uzunluk == 50)
            {
                MessageBox.Show("Max karakter sayısına ulaşıldı!!!");
            }
        }
        public void temizle()
        {
            soruRichTextBox.Text = "";
            aRichTextBox.Text = "";
            bRichTextBox.Text = "";
            cRichTextBox.Text = "";
            dRichTextBox.Text = "";
            dogruRichTextBox1.Text = "";
            fotoTextBox1.Text = "";
        }

        private void btnEsitsizlik_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into esitsizlikler(soru,a,b,c,d,dogru,fotograf) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", soruRichTextBox.Text);
                komut.Parameters.AddWithValue("@p2", aRichTextBox.Text);
                komut.Parameters.AddWithValue("@p3", bRichTextBox.Text);
                komut.Parameters.AddWithValue("@p4", cRichTextBox.Text);
                komut.Parameters.AddWithValue("@p5", dRichTextBox.Text);
                komut.Parameters.AddWithValue("@p6", dogruRichTextBox1.Text);
                komut.Parameters.AddWithValue("@p7", fotoTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Soru başarıyla Eklendi...");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu!" + hata.ToString());
            }
            temizle();
            panel2.Visible = false;
        }

        private void btnOlasilik_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into olasilik(soru,a,b,c,d,dogru,fotograf) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", soruRichTextBox.Text);
                komut.Parameters.AddWithValue("@p2", aRichTextBox.Text);
                komut.Parameters.AddWithValue("@p3", bRichTextBox.Text);
                komut.Parameters.AddWithValue("@p4", cRichTextBox.Text);
                komut.Parameters.AddWithValue("@p5", dRichTextBox.Text);
                komut.Parameters.AddWithValue("@p6", dogruRichTextBox1.Text);
                komut.Parameters.AddWithValue("@p7", fotoTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Soru başarıyla Eklendi...");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu!" + hata.ToString());
            }
            temizle();
            panel2.Visible = false;
        }

        private void btnVeriAnalizi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into veriAnalizi(soru,a,b,c,d,dogru,fotograf) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", soruRichTextBox.Text);
                komut.Parameters.AddWithValue("@p2", aRichTextBox.Text);
                komut.Parameters.AddWithValue("@p3", bRichTextBox.Text);
                komut.Parameters.AddWithValue("@p4", cRichTextBox.Text);
                komut.Parameters.AddWithValue("@p5", dRichTextBox.Text);
                komut.Parameters.AddWithValue("@p6", dogruRichTextBox1.Text);
                komut.Parameters.AddWithValue("@p7", fotoTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Soru başarıyla Eklendi...");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu!" + hata.ToString());
            }
            temizle();
            panel2.Visible = false;
        }

        private void Soru_Ekle_Load(object sender, EventArgs e)
        {
            soruRichTextBox.MaxLength = 250;
            aRichTextBox.MaxLength = 50;
            bRichTextBox.MaxLength = 50;
            cRichTextBox.MaxLength = 50;
            dRichTextBox.MaxLength = 50;
            dogruRichTextBox1.MaxLength = 50;
        }

        private void btnDogrusalDenklemler_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into dogrusalDenklemler(soru,a,b,c,d,dogru,fotograf) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", soruRichTextBox.Text);
                komut.Parameters.AddWithValue("@p2", aRichTextBox.Text);
                komut.Parameters.AddWithValue("@p3", bRichTextBox.Text);
                komut.Parameters.AddWithValue("@p4", cRichTextBox.Text);
                komut.Parameters.AddWithValue("@p5", dRichTextBox.Text);
                komut.Parameters.AddWithValue("@p6", dogruRichTextBox1.Text);
                komut.Parameters.AddWithValue("@p7", fotoTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Soru başarıyla Eklendi...");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu!" + hata.ToString());
            }
            temizle();
            panel2.Visible = false;
        }

        private void btnCarpan_Click(object sender, EventArgs e)
        {
           
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into carpanlar(soru,a,b,c,d,dogru,fotograf) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", soruRichTextBox.Text);
                komut.Parameters.AddWithValue("@p2", aRichTextBox.Text);
                komut.Parameters.AddWithValue("@p3", bRichTextBox.Text);
                komut.Parameters.AddWithValue("@p4", cRichTextBox.Text);
                komut.Parameters.AddWithValue("@p5", dRichTextBox.Text);
                komut.Parameters.AddWithValue("@p6", dogruRichTextBox1.Text);
                komut.Parameters.AddWithValue("@p7", fotoTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Soru başarıyla Eklendi...");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu!" + hata.ToString());
            }
            temizle();
            panel2.Visible = false;
        }

        private void boldCheck_CheckedChanged(object sender, EventArgs e)
        {
            soruRichTextBox.Font = new Font(soruRichTextBox.Font, soruRichTextBox.Font.Style ^ FontStyle.Bold);
        }

        private void altıCiziliCheck_CheckedChanged(object sender, EventArgs e)
        {
            soruRichTextBox.Font = new Font(soruRichTextBox.Font, soruRichTextBox.Font.Style ^ FontStyle.Underline);
        }

        private void soruEkle_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void fotoEkle_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "JPG dosyası(*.jpg)|*.jpg|PNG(*.png)|*.png";
            dosya.ShowDialog();
            string dosyaYolu = dosya.FileName;
            fotoTextBox1.Text = dosyaYolu;
            pictureBox1.ImageLocation = dosyaYolu;
        }
    }
}
