using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace otomasyonprojesii
{
    public partial class Form1ogrKayıt : Form
    {
        
        public Form1ogrKayıt()
        {
            InitializeComponent();

        }
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-7HBVF7V\\SQLEXPRESS04;Initial Catalog=yurtkayıt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void maskedTextBox1VELİTEL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1ogrKayıt_Load(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut3 = new SqlCommand("select bolumad from bolumler", bağlantı);
            SqlDataReader oku = komut3.ExecuteReader();

            while (oku.Read())
            {
                comboBox1BÖLÜM.Items.Add(oku[0].ToString());
            }
            bağlantı.Close();


            bağlantı.Open();
            SqlCommand komut5 = new SqlCommand("select odano from odalarr where odakapasite != odaaktif", bağlantı);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
              comboBox1ODANO.Items.Add(oku5[0].ToString());
            }
            bağlantı.Close();





        }
        private void button1_Click(object sender, EventArgs e) //ekleme butonu +
        {
          

            bağlantı.Open();


            SqlCommand komutkaydet = new SqlCommand("insert into ogrenci (ograd,ogrsoyad,ogrtc,ogrdogum,ogrbolum,ogrVeliad,ogrveliadres,ogrid) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)", bağlantı);
            komutkaydet.Parameters.AddWithValue("@a1", textBox1isim.Text);
            komutkaydet.Parameters.AddWithValue("@a2",textBox2soyisim.Text );
            komutkaydet.Parameters.AddWithValue("@a3", maskedTextBox1TC.Text );
            komutkaydet.Parameters.AddWithValue("@a4",maskedTextBox3DOĞUM.Text);
            komutkaydet.Parameters.AddWithValue("@a5",comboBox1BÖLÜM.Text);
            komutkaydet.Parameters.AddWithValue("@a6",textBox4VELİAD.Text );
            komutkaydet.Parameters.AddWithValue("@a7",textBox1ADRES.Text );
            komutkaydet.Parameters.AddWithValue("@a8",textBox1İD.Text);


            komutkaydet.ExecuteNonQuery();
            MessageBox.Show("kaydedildi");
            bağlantı.Close();

            //ODA SAYISINI BİR ARTTIRMA
            bağlantı.Open();
            SqlCommand komut8 = new SqlCommand("Update odalarr set odaaktif=odaaktif+1 where odano=@a1 ", bağlantı);
            komut8.Parameters.AddWithValue("@a1", comboBox1ODANO.Text);
            komut8.ExecuteNonQuery();
            bağlantı.Close();


        }

        private void button2_Click(object sender, EventArgs e)//silme butonu +
        {

            bağlantı.Open();
            SqlCommand komut = new SqlCommand("delete from ogrenci", bağlantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("silindi");
            bağlantı.Close();

            //kontenjan azaltma
            bağlantı.Open();
            SqlCommand komut8 = new SqlCommand("Update odalarr set odaaktif=odaaktif-1 where odano=@a1 ", bağlantı);
            komut8.Parameters.AddWithValue("@a1", comboBox1ODANO.Text);
            komut8.ExecuteNonQuery();
            bağlantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)//güncelleme butonu
        {
            
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("Update ogrenci set ograd=@a1 where ogrtc='11111111111' ",bağlantı);
            komut.Parameters.Add("@a1", textBox1isim.Text);
           
            komut.ExecuteNonQuery();
            MessageBox.Show("güncellendi");
            bağlantı.Close();

           

        }
    }
}
