using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace otomasyonprojesii
{
    public partial class frmnotekle : Form
    {
        public frmnotekle()
        {
            InitializeComponent();
        }

        private void frmnotekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "kayıt yeri seçin";
            saveFileDialog1.Filter = "metin dosyası |*.txt";
            saveFileDialog1.InitialDirectory= "C:\\deneme\\Yeni Metin Belgesi.txt";
            saveFileDialog1.ShowDialog();

            StreamWriter yaz = new StreamWriter(saveFileDialog1.FileName);
            yaz.WriteLine(richTextBox1.Text);
            yaz.Close();
            MessageBox.Show("kayıt başarılı");
        }
    }
}
