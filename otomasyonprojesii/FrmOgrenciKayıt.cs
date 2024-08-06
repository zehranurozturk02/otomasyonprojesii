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

namespace otomasyonprojesii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
     
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        sqlbağlantım bgl = new sqlbağlantım();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet2.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtkayıtDataSet2.ogrenci);

            //bölümleri combobox1 e getiri

            SqlCommand komut = new SqlCommand("select bolumad from bolumler ", bgl.bağlantı());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            bgl.bağlantı().Close();
            

            //boş odaları combobox2 ye getirir
         
            SqlCommand komut2 = new SqlCommand("select odano from odalarr where odakapasite != odaaktif", bgl.bağlantı());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2[0].ToString());
            }
            bgl.bağlantı().Close();






        }//form1_load


      
        // 2 ) kayıt ekleme butonu                               ?************************************************
           private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into (ograd,ogrsoyad,ogrtc,ogrdogum,ogrbolum,ogrVeliad,ogreveliadres,odano) values(@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,", bgl.bağlantı());
            komut.Parameters.AddWithValue("@a2", textBox1İsim);
            komut.Parameters.AddWithValue("@a3",textBox2soyisim);
            komut.Parameters.AddWithValue("@a4", maskedTextBox11karakter);
            komut.Parameters.AddWithValue("@a5", maskedTextBox3slah);
            komut.Parameters.AddWithValue("@a6",comboBox1 );
            komut.Parameters.AddWithValue("@a7", textBox5veliad);
            komut.Parameters.AddWithValue("@a8", textBox7adres);
            komut.Parameters.AddWithValue("@a9", comboBox2);

            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();


        }

        //silme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            //SqlCommand komut3 = new SqlCommand("delete from ogrenci", bgl.bağlantı());
            //komut3.ExecuteNonQuery();
            //bgl.bağlantı().Close();
        }



        //1)öğrenciler tablosunu datagridde göster        ?*************************************************************
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
