using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyonprojesii
{
    public partial class frmgiderlisesi : Form
    {
        public frmgiderlisesi()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmgiderlisesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet10.giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtkayıtDataSet10.giderler);

        }



          int seçilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formgidergüncelle güncelle = new formgidergüncelle();
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            güncelle.elektrik = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            güncelle.su = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            güncelle.doğalgaz = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            güncelle.internet = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            güncelle.gıda = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            güncelle.personel = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            güncelle.diğer = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
            güncelle.id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();

            güncelle.Show();

        }
    }
}
