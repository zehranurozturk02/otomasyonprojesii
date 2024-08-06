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
    public partial class FormGider : Form
    {
        public FormGider()
        {
            InitializeComponent();
        }
        sqlbağlantım bağlantım = new sqlbağlantım();

        private void button1kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into giderler (Elektirk,Su,doğalgaz,internet,gıda,personel,diğer) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", bağlantım.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBoxelektrik.Text);
            komut.Parameters.AddWithValue("@a2", textBoxsu.Text);
            komut.Parameters.AddWithValue("@a3", textBoxdoğalgaz.Text);
            komut.Parameters.AddWithValue("@a4", textBox4internet.Text);
            komut.Parameters.AddWithValue("@a5", textBox7gıda.Text);
            komut.Parameters.AddWithValue("@a6", textBoxpersonel.Text);
            komut.Parameters.AddWithValue("@a7", textBox5diğer.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("giderler kaydedildi");

            bağlantım.bağlantı().Close();
        }

        private void FormGider_Load(object sender, EventArgs e)
        {

        }
    }
}
