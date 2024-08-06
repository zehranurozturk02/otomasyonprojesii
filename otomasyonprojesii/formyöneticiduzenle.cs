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
    public partial class formyöneticiduzenle : Form
    {
        public formyöneticiduzenle()
        {
            InitializeComponent();
        }
        sqlbağlantım bağlantı = new sqlbağlantım();

        private void formyöneticiduzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet11.admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtkayıtDataSet11.admin);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)                //kaydetme butonu ????????????????????????????????????
        {
            //SqlCommand komut = new SqlCommand("insert into admin(yoneticiid,yoneticiad,yoneticisifre) values(@a0,@a1,@a2)", bağlantı.bağlantı());
            //komut.Parameters.AddWithValue("@a0", textBox1İD.Text);
            //komut.Parameters.AddWithValue("@a1", textBox2KULLANICIAD.Text);
            //komut.Parameters.AddWithValue("@a2", textBox3ŞİFRE.Text);

            //komut.ExecuteNonQuery();
            //bağlantı.bağlantı().Close();
           // this.adminTableAdapter.Fill(this.yurtkayıtDataSet11.admin);

        }

        private void button2_Click(object sender, EventArgs e)//silme butonu
        {
            SqlCommand komut = new SqlCommand("delete from admin where yoneticiid=@a1", bağlantı.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBox1İD.Text);
            komut.ExecuteNonQuery();
            bağlantı.bağlantı().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //seçilen satırın textlerde gösterilmesini sağlar
        {
            int seçilen;
            seçilen = dataGridView1.SelectedCells[0].RowIndex;

            string id, ad, şifre;

            id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            şifre = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();

            textBox1İD.Text= id;
            textBox2KULLANICIAD.Text =ad;
            textBox3ŞİFRE.Text = şifre;

        }

        private void button3_Click(object sender, EventArgs e)//güncelleme butonu
        {
            SqlCommand komut = new SqlCommand("update admin set yoneticiad=@a1, yoneticisifre=@a2 where  yoneticiid=@a3",bağlantı.bağlantı());
            komut.Parameters.AddWithValue("@a3", textBox1İD.Text);
            komut.Parameters.AddWithValue("@a1", textBox2KULLANICIAD.Text);
            komut.Parameters.AddWithValue("@a2", textBox3ŞİFRE.Text);

            komut.ExecuteNonQuery();
            bağlantı.bağlantı().Close();

        }
    }
}
