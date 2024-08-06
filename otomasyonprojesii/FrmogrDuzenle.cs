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


namespace otomasyonprojesii
{
    public partial class FrmogrDuzenle : Form
    {
        public FrmogrDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-7HBVF7V\\SQLEXPRESS04;Initial Catalog=yurtkayıt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public string id;
        public string ad;
        public string soyad;
        public string tc;
        public string dogum;
        public string bolum;
        public string veliad;

        private void FrmogrDuzenle_Load(object sender, EventArgs e)
        {
            textBoxİD.Text = id;
            textBox1isim.Text = ad;
            textBox2soyisim.Text = soyad;
            maskedTextBox1TC.Text = tc;
            maskedTextBox3DOĞUM.Text = dogum;
            comboBox1BÖLÜM.Text = bolum;
            textBox4VELİAD.Text = veliad;
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("update ogrenci set ograd=@a1,ogrsoyad=@a2 where ogrid=@a3",bağlantı);
            komut.Parameters.AddWithValue("@a1", textBox1isim.Text);
            komut.Parameters.AddWithValue("@a2", textBox2soyisim.Text);
            komut.Parameters.AddWithValue("@a3", textBoxİD.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show(" seçili id li öğrenci güncellendi ");
            bağlantı.Close();


        }

        private void button1sil_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komutsil = new SqlCommand("delete from ogrenci where ogrid=@a1", bağlantı);
            komutsil.Parameters.AddWithValue("@a1", textBoxİD.Text);
            komutsil.ExecuteNonQuery();
            MessageBox.Show("silindi");
            bağlantı.Close();

        }
    }
}
