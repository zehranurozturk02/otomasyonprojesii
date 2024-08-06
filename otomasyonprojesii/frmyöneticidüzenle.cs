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
    public partial class frmyöneticidüzenle : Form
    {
        public frmyöneticidüzenle()
        {
            InitializeComponent();
        }

        sqlbağlantım bağlantım = new sqlbağlantım();

        private void frmyöneticidüzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet12.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtkayıtDataSet12.personel);

        }

        private void button1_Click(object sender, EventArgs e)// ekleme işlemi  ??????????????????????????????????????????????
        {
            SqlCommand komut = new SqlCommand("insert into personel(personelid,personelaAdSoyad,personelDepartman) values(@a1,@a2,@a3)", bağlantım.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBox1.Text);
            komut.Parameters.AddWithValue("@a2", textBox2.Text);
            komut.Parameters.AddWithValue("@a3", textBox3.Text);

            komut.ExecuteNonQuery();
            bağlantım.bağlantı().Close();
        }

        private void button2_Click(object sender, EventArgs e)//silme işlemi
        {
            SqlCommand komut = new SqlCommand("delete from personel where personelid=@a1", bağlantım.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("silindi");
            bağlantım.bağlantı().Close();
        }

        private void button3_Click(object sender, EventArgs e)//güncelleme
        {
            SqlCommand komut = new SqlCommand("update personel set personelaAdSoyad=@a2 where personelid=@a1", bağlantım.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBox1.Text);
            komut.Parameters.AddWithValue("@a2", textBox2.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("güncellendi");
            bağlantım.bağlantı().Close();

        }
    }
}
