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
    public partial class SinavEkrani : Form
    {
        public SinavEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-T1ORC6LM\\SQLEXPRESS;Initial Catalog=konular;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-T1ORC6LM\\SQLEXPRESS;Initial Catalog=istatistikPuan;Integrated Security=True");
        int sayac = 0, puan = 0, zaman = 60;
        public int[,] isaretlenenSoru=new int[5,2];
        int[] konularCozulecek = new int[5];
        public int[] sorusayisi = new int[5];
        int konu=0;


    

    public void soruSayılariniCek()
        {
            baglanti.Open();
            int[,] ogrencidogruYanlislar = new int[5, 2];
            int toplamSoruSayisi = 0,enBuyuk=0;
            SqlCommand komut1 = new SqlCommand("SELECT SUM(carpanlarDogru),SUM(carpanlarYanlis),SUM(dogrusalDenklemlerDogru),SUM(dogrusalDenklemlerYanlis),SUM(esitsizliklerDogru),SUM(esitsizliklerYanlis),SUM(olasilikDogru),SUM(olasilikYanlis),SUM(veriAnaliziDogru),SUM(veriAnaliziYanlis) FROM istatistik ", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                //                 dogrular                                                     yanlışlar
                ogrencidogruYanlislar[0, 0] = Convert.ToInt32(dr1[0]); ogrencidogruYanlislar[0, 1] = Convert.ToInt32(dr1[1]);

                ogrencidogruYanlislar[1, 0] = Convert.ToInt32(dr1[2]); ogrencidogruYanlislar[1, 1] = Convert.ToInt32(dr1[3]);

                ogrencidogruYanlislar[2, 0] = Convert.ToInt32(dr1[4]); ogrencidogruYanlislar[2, 1] = Convert.ToInt32(dr1[5]);

                ogrencidogruYanlislar[3, 0] = Convert.ToInt32(dr1[6]); ogrencidogruYanlislar[3, 1] = Convert.ToInt32(dr1[7]);

                ogrencidogruYanlislar[4, 0] = Convert.ToInt32(dr1[8]); ogrencidogruYanlislar[4, 1] = Convert.ToInt32(dr1[9]);


                double yanlislartoplam = 0;

                int toplam = 0;

                for (int i = 0; i < 5; i++)
                {
                    double yuzde = (100 * ogrencidogruYanlislar[i, 1]) / (ogrencidogruYanlislar[i, 0] + ogrencidogruYanlislar[i, 1]);
                    yanlislartoplam += yuzde;
                }

                for (int i = 0; i < 5; i++)
                {
                    toplam += ogrencidogruYanlislar[i, 0] + ogrencidogruYanlislar[i, 1];
                    double yuzde = (100 * ogrencidogruYanlislar[i, 1]) / (ogrencidogruYanlislar[i, 0] + ogrencidogruYanlislar[i, 1]);

                    sorusayisi[i] = Convert.ToInt32((50 * yuzde) / yanlislartoplam);


                }

                for (int i = 0; i < 5; i++)
                {

                    toplamSoruSayisi += sorusayisi[i];
                    if (sorusayisi[i] > enBuyuk)
                    {
                        enBuyuk = i;
                    }

                }

                if (toplamSoruSayisi > 50)
                {

                    sorusayisi[enBuyuk] = toplamSoruSayisi - 50;

                }




                sorusayisi[1] += sorusayisi[0];
                sorusayisi[2] += sorusayisi[1];
                sorusayisi[3] += sorusayisi[2];
                sorusayisi[4] += sorusayisi[3];




            }

            baglanti.Close();
        }// Hangi Konudan Kaç Soru Sorulacağını Hesaplar

    
    public void isaretlenenSorureset()
        {
            for(int i = 0; i < 5; i++)
            {
                isaretlenenSoru[i, 0] = 0;
                isaretlenenSoru[i, 1] = 0;

            }
        }

        public void sinavSonuist() {
            chrtSinavSonu.Visible = true;
            chrtSinavSonu.Series["Dogru"].Points.AddXY("carpanlar", isaretlenenSoru[0,0].ToString());
            chrtSinavSonu.Series["Yanlis"].Points.AddXY("carpanlar", isaretlenenSoru[0,1].ToString());
            chrtSinavSonu.Series["Dogru"].Points.AddXY("dogrusalDenklemler", isaretlenenSoru[1, 0].ToString());
            chrtSinavSonu.Series["Yanlis"].Points.AddXY("dogrusalDenklemler", isaretlenenSoru[1, 1].ToString());
            chrtSinavSonu.Series["Dogru"].Points.AddXY("esitsizlikler", isaretlenenSoru[2, 0].ToString());
            chrtSinavSonu.Series["Yanlis"].Points.AddXY("esitsizlikler", isaretlenenSoru[2, 1].ToString());
            chrtSinavSonu.Series["Dogru"].Points.AddXY("olasilik", isaretlenenSoru[3, 0].ToString());
            chrtSinavSonu.Series["Yanlis"].Points.AddXY("olasilik", isaretlenenSoru[3, 1].ToString());
            chrtSinavSonu.Series["Dogru"].Points.AddXY("veriAnalizi", isaretlenenSoru[4, 0].ToString());
            chrtSinavSonu.Series["Yanlis"].Points.AddXY("veriAnalizi", isaretlenenSoru[4, 1].ToString());
        }


        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            zaman = 60;
            btnA.BackColor = Color.Gray;
            btnB.BackColor = Color.Gray;
            btnC.BackColor = Color.Gray;
            btnD.BackColor = Color.Gray;
            btnBasla.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnBasla.Text = "SONRAKİ";
            sayac++;
            lblSoru.Text = sayac.ToString();
             
            if (sayac <= sorusayisi[0]) 
            {
            konu = 0;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from carpanlar ORDER BY NewID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
            {
                btnA.Text = (oku["a"].ToString());
                btnB.Text = (oku["b"].ToString());
                btnC.Text = (oku["c"].ToString());
                btnD.Text = (oku["d"].ToString());
                textBox1.Text = (oku["soru"].ToString());
                lblDogru.Text = (oku["dogru"].ToString());
            }
                baglan.Close();
            }
                else if (sayac <= sorusayisi[1])
            {
                konu = 1;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from dogrusalDenklemler order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            else if (sayac <= sorusayisi[2])
            {
                konu = 2;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from esitsizlikler order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            else if (sayac <= sorusayisi[3])
            {
                konu = 3;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from olasilik order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            else if (sayac < sorusayisi[4])
            {
                konu = 4;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from veriAnalizi order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lblDogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 50)
            {
                btnBasla.Text = "Sınav Bitir!";
                btnBasla.Enabled = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                
            }
            if (sayac==51)
            {
                panel1.Visible = false;
                sinavSonuist();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if(btnA.Text == lblDogru.Text)
            {
                isaretlenenSoru[konu,0]++;
                puan = puan + 2;
                lblPuan.Text = puan.ToString();
                btnA.BackColor = Color.Green;
            }
            else
            { 
                isaretlenenSoru[konu,1]++;
                btnA.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == lblDogru.Text)
            {
                isaretlenenSoru[konu, 0]++;
                puan = puan + 2;
                lblPuan.Text = puan.ToString();
                btnB.BackColor = Color.Green;
            }
            else
            {
                isaretlenenSoru[konu, 1]++;
                btnB.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == lblDogru.Text)
            {
                isaretlenenSoru[konu, 0]++;
                puan = puan + 2;
                lblPuan.Text = puan.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                isaretlenenSoru[konu, 1]++;
                btnC.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == lblDogru.Text)
            {
                isaretlenenSoru[konu, 0]++;
                puan = puan + 2;
                lblPuan.Text = puan.ToString();
                btnD.BackColor = Color.Green;

            }
            else
            {
                isaretlenenSoru[konu, 1]++;
                btnD.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void SinavEkrani_Load_1(object sender, EventArgs e)
        {
            soruSayılariniCek();
           // MessageBox.Show(sorusayisi[0]+","+sorusayisi[1] + ","+ sorusayisi[2] + ","+ sorusayisi[3] + ","+ sorusayisi[4] );
           
            btnA.BackColor = Color.Gray;
            btnB.BackColor = Color.Gray;
            btnC.BackColor = Color.Gray;
            btnD.BackColor = Color.Gray;
            lblDogru.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 3000)
            {
                timer2.Stop();
                MessageBox.Show("Süre Bitti");
                btnBasla.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string komut;
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DateTime bugun = DateTime.Now;   
            SqlCommand komut =new SqlCommand("insert into istatistik(ogrenciId,tarih,carpanlarDogru,carpanlarYanlis,dogrusalDenklemlerDogru,dogrusalDenklemlerYanlis,esitsizliklerDogru,esitsizliklerYanlis,olasilikDogru,olasilikYanlis,veriAnaliziDogru,veriAnaliziYanlis) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut.Parameters.AddWithValue("@p1", 1);
            komut.Parameters.AddWithValue("@p2",bugun);
            komut.Parameters.AddWithValue("@p3",isaretlenenSoru[0,0]);
            komut.Parameters.AddWithValue("@p4", isaretlenenSoru[0,1]);
            komut.Parameters.AddWithValue("@p5", isaretlenenSoru[1, 0]);
            komut.Parameters.AddWithValue("@p6", isaretlenenSoru[1, 1]);
            komut.Parameters.AddWithValue("@p7", isaretlenenSoru[2, 0]);
            komut.Parameters.AddWithValue("@p8", isaretlenenSoru[2, 1]);
            komut.Parameters.AddWithValue("@p9", isaretlenenSoru[3, 0]);
            komut.Parameters.AddWithValue("@p10", isaretlenenSoru[3, 1]);
            komut.Parameters.AddWithValue("@p11", isaretlenenSoru[4, 0]);
            komut.Parameters.AddWithValue("@p12", isaretlenenSoru[4, 1]);
            
            komut.ExecuteNonQuery();            
            baglanti.Close();
            isaretlenenSorureset();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinavEkrani frm1 = new SinavEkrani();
            frm1.Close();
            OgrenciGiris frm3 = new OgrenciGiris();
            frm3.Show();
            this.Hide();
        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istatistikChart frm3 = new istatistikChart();
            frm3.Show();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLScVOfJ_5f3HDfpOaB6x_0i4dRizaOJLWWGBSFkR0ILvpeosJA/viewform?vc=0&c=0&w=1");

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama proje ödevi amacıyla Matematik 8. sınıf konularını içeren test sınav uygulaması için hazırlanmıştır. Tüm hakları geliştiriciye aittir. Geliştirici, harici düzenleme, kopyalama ve diğer işlemlerle ilgili yasal hak sahibidir. Bizi kullandığınız için teşekkürler");

        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            zaman = zaman - 1;
            lblSoruZamani.Text = zaman.ToString();
            if (zaman == 0)
            {
                lblSoruZamani.Visible = false;
                MessageBox.Show("Süre Doldu Diğer soruya Geçiniz...");
                btnBasla.Enabled = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
            }
        }

        private void SinavEkrani_Load(object sender, EventArgs e)
        {
            lblSoru.Text = sayac.ToString();
        }

    }
}
