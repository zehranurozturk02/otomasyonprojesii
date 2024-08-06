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
    public partial class Formadmingiriş : Form
    {
        public Formadmingiriş()
        {
            InitializeComponent();
        }
        sqlbağlantım bağlantım = new sqlbağlantım();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@a1 and yoneticisifre=@a2",bağlantım.bağlantı());
            komut.Parameters.AddWithValue("@a1", textBox1kullancııad.Text);
            komut.Parameters.AddWithValue("@a2", textBox2kullanıcışifre.Text);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
                {
                    frmAnaForm anaform = new frmAnaForm();
                    anaform.Show();
                    this.Hide();
                }
            
            else { MessageBox.Show("hatalı giriş"); }

        
            bağlantım.bağlantı().Close();
        }



        private void Formadmingiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
