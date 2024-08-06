namespace otomasyonprojesii
{
    partial class frmGelirİstatistik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2kalanParaMiktarı = new System.Windows.Forms.Label();
            this.comboBox1seçilenay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4seçilenparamiktarı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KASADAKİ TOPLAM PARA:";
            // 
            // label2kalanParaMiktarı
            // 
            this.label2kalanParaMiktarı.AutoSize = true;
            this.label2kalanParaMiktarı.Location = new System.Drawing.Point(520, 34);
            this.label2kalanParaMiktarı.Name = "label2kalanParaMiktarı";
            this.label2kalanParaMiktarı.Size = new System.Drawing.Size(14, 16);
            this.label2kalanParaMiktarı.TabIndex = 1;
            this.label2kalanParaMiktarı.Text = "0";
            // 
            // comboBox1seçilenay
            // 
            this.comboBox1seçilenay.FormattingEnabled = true;
            this.comboBox1seçilenay.Location = new System.Drawing.Point(120, 46);
            this.comboBox1seçilenay.Name = "comboBox1seçilenay";
            this.comboBox1seçilenay.Size = new System.Drawing.Size(121, 24);
            this.comboBox1seçilenay.TabIndex = 2;
            this.comboBox1seçilenay.SelectedIndexChanged += new System.EventHandler(this.comboBox1seçilenay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay Seçilen";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 234);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "aylar";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(549, 189);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "aylık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(420, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "seçilen ay";
            // 
            // label4seçilenparamiktarı
            // 
            this.label4seçilenparamiktarı.AutoSize = true;
            this.label4seçilenparamiktarı.Location = new System.Drawing.Point(520, 70);
            this.label4seçilenparamiktarı.Name = "label4seçilenparamiktarı";
            this.label4seçilenparamiktarı.Size = new System.Drawing.Size(14, 16);
            this.label4seçilenparamiktarı.TabIndex = 6;
            this.label4seçilenparamiktarı.Text = "0";
            // 
            // frmGelirİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.label4seçilenparamiktarı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1seçilenay);
            this.Controls.Add(this.label2kalanParaMiktarı);
            this.Controls.Add(this.label1);
            this.Name = "frmGelirİstatistik";
            this.Text = "frmGelirİstatistik";
            this.Load += new System.EventHandler(this.frmGelirİstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2kalanParaMiktarı;
        private System.Windows.Forms.ComboBox comboBox1seçilenay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4seçilenparamiktarı;
    }
}