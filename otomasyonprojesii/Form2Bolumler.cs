using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyonprojesii
{
    public partial class Form2Bolumler : Form
    {
        public Form2Bolumler()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-7HBVF7V\\SQLEXPRESS04;Initial Catalog=yurtkayıt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        //artık her seferinde bağlantı yazmıyoruz sqlbağlantı sınıfında open bir şekilde geri döndüren metodu yaptık

        sqlbağlantım bağlan = new sqlbağlantım();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet.bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtkayıtDataSet.bolumler);

        }

        private void pictureBox1_Click(object sender, EventArgs e)   //bölüm ekleme 
        {
            SqlCommand komut4 = new SqlCommand("insert into bolumler (bolumad)values (@a1)", bağlan.bağlantı());
            komut4.Parameters.AddWithValue("@a1", textBox1.Text);
            komut4.ExecuteNonQuery();
            MessageBox.Show("eklendi");
            bağlan.bağlantı().Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //bölüm silme
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("delete from bolumler where bolumid=@1", bağlantı);
            komut.Parameters.AddWithValue("@1", textBox2.Text);
            komut.ExecuteNonQuery();
            bağlantı.Close();

            MessageBox.Show("başarıyla silindi");

        }
        int seçilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //seçilen datagridde
        {
            string id, bolumad;
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();

            textBox1.Text = bolumad;
            textBox2.Text = id;

        }
        private void pictureBox3_Click(object sender, EventArgs e) //güncelleme işlemi yapma
        {
            bağlantı.Open();
            SqlCommand komut1 = new SqlCommand("update bolumler set bolumad=@1 where bolumid=@2 ", bağlantı);

            komut1.Parameters.AddWithValue("@2", textBox2.Text);
            komut1.Parameters.AddWithValue("@1", textBox1.Text);

            komut1.ExecuteNonQuery();
            MessageBox.Show("başaryıla güncellendi");
            bağlantı.Close();
        }













       
    }
}
