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
    public partial class frmodelemler : Form
    {
        public frmodelemler()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void frmodelemler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet8.borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtkayıtDataSet8.borclar);
            // TODO: Bu kod satırı 'yurtkayıtDataSet7.borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtkayıtDataSet7.borclar);

        }

      
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //datagridde seçtiğim hücreyitextboxta yazıyor
        {
            int seçilen;
            string id, kalan, ad;
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();

            textBox1İD.Text = id;
            textBox3KALANBORÇ.Text = kalan;
        }

        private void button1_Click(object sender, EventArgs e)//odeme butonu
        {
            int ödenen, kalan, yeniborç;
            ödenen = Convert.ToInt32(textBox2ÖDENEN.Text);
            kalan = Convert.ToInt32(textBox3KALANBORÇ.Text);
            yeniborç = kalan - ödenen;

            textBox3KALANBORÇ.Text = yeniborç.ToString();

            SqlConnection bağlantıı = new SqlConnection("Data Source=DESKTOP-7HBVF7V\\SQLEXPRESS04;Initial Catalog=yurtkayıt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            bağlantıı.Open();
            SqlCommand komut = new SqlCommand("update borclar set ogrkalanborc=@a1 where ogrid=@a2 ", bağlantıı);

            komut.Parameters.AddWithValue("@a2", textBox1İD.Text);
            komut.Parameters.AddWithValue("@a1", textBox3KALANBORÇ.Text);
            bağlantıı.Close();


            //kasa tablosuna ekleme

            bağlantıı.Open();
            SqlCommand komut2 = new SqlCommand("insert into kasa (odemeay, odememiktar) values (@a1,@a2) ",bağlantıı);
            komut2.Parameters.AddWithValue("@a1", textBox1ödenenAY.Text);
            komut2.Parameters.AddWithValue("@a2", textBox2ÖDENEN.Text);

            komut2.ExecuteNonQuery();
            bağlantıı.Close();
        }

    }
}
