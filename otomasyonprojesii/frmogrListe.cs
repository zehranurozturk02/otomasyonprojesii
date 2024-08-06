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
    public partial class frmogrListe : Form
    {
        public frmogrListe()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-7HBVF7V\\SQLEXPRESS04;Initial Catalog=yurtkayıt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void frmogrListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet9.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtkayıtDataSet9.ogrenci);

        }

        int seçilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmogrDuzenle düzenle = new FrmogrDuzenle();
            düzenle.id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            düzenle.ad = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            düzenle.soyad = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            düzenle.tc = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            düzenle.dogum = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            düzenle.bolum = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            düzenle.veliad = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            düzenle.Show();
        }

        
    }
}
