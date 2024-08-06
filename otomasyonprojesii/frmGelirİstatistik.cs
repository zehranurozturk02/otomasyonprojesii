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
using System.Reflection.Emit;

namespace otomasyonprojesii
{
    public partial class frmGelirİstatistik : Form
    {
        public frmGelirİstatistik()
        {
            InitializeComponent();
        }

        sqlbağlantım bağlan = new sqlbağlantım();

        private void frmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //para mikatırını getiriyor

            SqlCommand komut = new SqlCommand("Select Sum(odememiktar) from kasa", bağlan.bağlantı());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label2kalanParaMiktarı.Text = oku[0].ToString();
            }

            //comboboxa ayları getir

            SqlCommand komut2 = new SqlCommand("Select distinct (odemeay) from kasa order by odemeay desc", bağlan.bağlantı());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox1seçilenay.Items.Add(oku2[0].ToString());
            }

            bağlan.bağlantı().Close();




            SqlCommand komut3 = new SqlCommand("Select odemeay, SUM(odememiktar) from kasa group by odemeay", bağlan.bağlantı());

            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["aylar"].Points.AddXY(oku3[0], oku3[1]);
            }

            bağlan.bağlantı().Close();




        }

        private void comboBox1seçilenay_SelectedIndexChanged(object sender, EventArgs e)//seçtiğim aydaki toplam para
        {
            SqlCommand komut2 = new SqlCommand("select sum(odememiktar) from kasa where odemeay=@a1", bağlan.bağlantı());
            komut2.Parameters.AddWithValue("@a1", comboBox1seçilenay.Text);

            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                label4seçilenparamiktarı.Text = oku[0].ToString();

            }
            bağlan.bağlantı().Close();
        }
    }
}

