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
    public partial class istatistikChart : Form
    {
        public istatistikChart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-T1ORC6LM\\SQLEXPRESS;Initial Catalog=istatistikPuan;Integrated Security=True");

        private void istatistikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SUM(carpanlarDogru),SUM(carpanlarYanlis),SUM(dogrusalDenklemlerDogru),SUM(dogrusalDenklemlerYanlis),SUM(esitsizliklerDogru),SUM(esitsizliklerYanlis),SUM(olasilikDogru),SUM(olasilikYanlis),SUM(veriAnaliziDogru),SUM(veriAnaliziYanlis) from istatistik", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Dogru"].Points.AddXY("carpanlar", dr[0].ToString());
                chart1.Series["Yanlis"].Points.AddXY("carpanlar", dr[1].ToString());
                chart1.Series["Dogru"].Points.AddXY("dogrusalDenklemler", dr[2].ToString());
                chart1.Series["Yanlis"].Points.AddXY("dogrusalDenklemler", dr[3].ToString());
                chart1.Series["Dogru"].Points.AddXY("esitsizlikler", dr[4].ToString());
                chart1.Series["Yanlis"].Points.AddXY("esitsizlikler", dr[5].ToString());
                chart1.Series["Dogru"].Points.AddXY("olasilik", dr[6].ToString());
                chart1.Series["Yanlis"].Points.AddXY("olasilik", dr[7].ToString());
                chart1.Series["Dogru"].Points.AddXY("veriAnalizi", dr[8].ToString());
                chart1.Series["Yanlis"].Points.AddXY("veriAnalizi", dr[9].ToString());
                
            }


            baglanti.Close();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLScVOfJ_5f3HDfpOaB6x_0i4dRizaOJLWWGBSFkR0ILvpeosJA/viewform?vc=0&c=0&w=1");
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama proje ödevi amacıyla Matematik 8. sınıf konularını içeren test sınav uygulaması için hazırlanmıştır. Tüm hakları geliştiriciye aittir. Geliştirici, harici düzenleme, kopyalama ve diğer işlemlerle ilgili yasal hak sahibidir. Bizi kullandığınız için teşekkürler");
        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
