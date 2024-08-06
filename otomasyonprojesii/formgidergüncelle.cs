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
    public partial class formgidergüncelle : Form
    {
        public formgidergüncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, doğalgaz, internet, gıda, personel, diğer,id;
        sqlbağlantım bağlantım = new sqlbağlantım();

     
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" update giderler set Elektirk=@a1,Su=@a2 ,doğalgaz=@a3 , internet=@a4,gıda=@a5 , personel=@a6, diğer=@a7 where odemeİd=@a8", bağlantım.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBoxelektrik.Text);
            komut.Parameters.AddWithValue("@a2", textBoxsu.Text);
            komut.Parameters.AddWithValue("@a3", textBoxdoğalgaz.Text);
            komut.Parameters.AddWithValue("@a4", textBox4internet.Text);
            komut.Parameters.AddWithValue("@a5", textBox7gıda.Text);
            komut.Parameters.AddWithValue("@a6", textBoxpersonel.Text);
            komut.Parameters.AddWithValue("@a7", textBox5diğer.Text);
            komut.Parameters.AddWithValue("@a8", textBox1giderİD.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("güncellendi");

            bağlantım.bağlantı().Close();

        }

        private void formgidergüncelle_Load(object sender, EventArgs e)
        {

            textBoxelektrik.Text = elektrik;
            textBoxsu.Text = su;
            textBoxdoğalgaz.Text = doğalgaz;
            textBox4internet.Text = internet;
            textBox7gıda.Text = gıda;
            textBoxpersonel.Text = personel;
            textBox5diğer.Text = diğer;
            textBox1giderİD.Text = id;


        }
    }
}
