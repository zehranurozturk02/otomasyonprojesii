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
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet1.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtkayıtDataSet1.ogrenci);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }



        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1ogrKayıt öğrenciKAYIT = new Form1ogrKayıt();
            öğrenciKAYIT.Show();
        }
        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmogrListe liste = new frmogrListe();
            liste.Show();
        }
        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)//silme
        {
            FrmogrDuzenle sil = new FrmogrDuzenle();
            sil.Show();

        }
        private void bölğmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Bolumler bölümekle = new Form2Bolumler();
            bölümekle.Show();
        }
        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Bolumler bölümekle = new Form2Bolumler();
            bölümekle.Show();
        }
        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmodelemler ödemeler = new frmodelemler();
            ödemeler.Show();
        }
        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormGider giderekle = new FormGider();
            giderekle.Show();
        }
        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiderlisesi giderlistesi = new frmgiderlisesi();
            giderlistesi.Show();
        }
        private void gelirİstatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirİstatistik geliristatistik = new frmGelirİstatistik();
            geliristatistik.Show();
        }

        private void giderİstatistikToolStripMenuItem_Click(object sender, EventArgs e)// ********************************************
        {
            
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)//*********************************************
        {
        }

        private void personleDüzenleToolStripMenuItem_Click(object sender, EventArgs e)//******************************************
        {

        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotekle notekle =new frmnotekle();
            notekle.Show();
        }
    }
}
