namespace otomasyonprojesii
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1İsim = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2soyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5veliad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7adres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3mail = new System.Windows.Forms.TextBox();
            this.maskedTextBox11karakter = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2531 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3slah = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4velitel = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtkayıtDataSet2 = new otomasyonprojesii.yurtkayıtDataSet2();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new otomasyonprojesii.yurtkayıtDataSet2TableAdapters.ogrenciTableAdapter();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVelitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad";
            // 
            // textBox1İsim
            // 
            this.textBox1İsim.Location = new System.Drawing.Point(140, 8);
            this.textBox1İsim.Name = "textBox1İsim";
            this.textBox1İsim.Size = new System.Drawing.Size(100, 22);
            this.textBox1İsim.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(361, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "yeni kayıt ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2soyisim
            // 
            this.textBox2soyisim.Location = new System.Drawing.Point(140, 45);
            this.textBox2soyisim.Name = "textBox2soyisim";
            this.textBox2soyisim.Size = new System.Drawing.Size(100, 22);
            this.textBox2soyisim.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "ogrtel";
            // 
            // textBox5veliad
            // 
            this.textBox5veliad.Location = new System.Drawing.Point(361, 87);
            this.textBox5veliad.Name = "textBox5veliad";
            this.textBox5veliad.Size = new System.Drawing.Size(100, 22);
            this.textBox5veliad.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ogrdogum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "bölüm";
            // 
            // textBox7adres
            // 
            this.textBox7adres.Location = new System.Drawing.Point(361, 167);
            this.textBox7adres.Multiline = true;
            this.textBox7adres.Name = "textBox7adres";
            this.textBox7adres.Size = new System.Drawing.Size(130, 50);
            this.textBox7adres.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "odano";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "vel ad soyad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "veli tel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "adres";
            // 
            // textBox3mail
            // 
            this.textBox3mail.Location = new System.Drawing.Point(361, 5);
            this.textBox3mail.Name = "textBox3mail";
            this.textBox3mail.Size = new System.Drawing.Size(100, 22);
            this.textBox3mail.TabIndex = 13;
            // 
            // maskedTextBox11karakter
            // 
            this.maskedTextBox11karakter.Location = new System.Drawing.Point(140, 85);
            this.maskedTextBox11karakter.Mask = "00000000000";
            this.maskedTextBox11karakter.Name = "maskedTextBox11karakter";
            this.maskedTextBox11karakter.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox11karakter.TabIndex = 30;
            this.maskedTextBox11karakter.ValidatingType = typeof(int);
            // 
            // maskedTextBox2531
            // 
            this.maskedTextBox2531.Location = new System.Drawing.Point(140, 128);
            this.maskedTextBox2531.Mask = "(999) 000-0000";
            this.maskedTextBox2531.Name = "maskedTextBox2531";
            this.maskedTextBox2531.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2531.TabIndex = 31;
            // 
            // maskedTextBox3slah
            // 
            this.maskedTextBox3slah.Location = new System.Drawing.Point(140, 167);
            this.maskedTextBox3slah.Mask = "00/00/0000";
            this.maskedTextBox3slah.Name = "maskedTextBox3slah";
            this.maskedTextBox3slah.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox3slah.TabIndex = 32;
            this.maskedTextBox3slah.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox4velitel
            // 
            this.maskedTextBox4velitel.Location = new System.Drawing.Point(361, 131);
            this.maskedTextBox4velitel.Mask = "(999) 000-0000";
            this.maskedTextBox4velitel.Name = "maskedTextBox4velitel";
            this.maskedTextBox4velitel.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox4velitel.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 34;
            this.button2.Text = "kayıtları sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrdogumDataGridViewTextBoxColumn,
            this.ogrbolumDataGridViewTextBoxColumn,
            this.ogrVeliadDataGridViewTextBoxColumn,
            this.ogrVelitelDataGridViewTextBoxColumn,
            this.ogrveliadresDataGridViewTextBoxColumn,
            this.odanoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-18, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 157);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yurtkayıtDataSet2
            // 
            this.yurtkayıtDataSet2.DataSetName = "yurtkayıtDataSet2";
            this.yurtkayıtDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtkayıtDataSet2;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            this.ogradDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            this.ogrsoyadDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrdogumDataGridViewTextBoxColumn
            // 
            this.ogrdogumDataGridViewTextBoxColumn.DataPropertyName = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.HeaderText = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrdogumDataGridViewTextBoxColumn.Name = "ogrdogumDataGridViewTextBoxColumn";
            this.ogrdogumDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrbolumDataGridViewTextBoxColumn
            // 
            this.ogrbolumDataGridViewTextBoxColumn.DataPropertyName = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.HeaderText = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrbolumDataGridViewTextBoxColumn.Name = "ogrbolumDataGridViewTextBoxColumn";
            this.ogrbolumDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrVeliadDataGridViewTextBoxColumn
            // 
            this.ogrVeliadDataGridViewTextBoxColumn.DataPropertyName = "ogrVeliad";
            this.ogrVeliadDataGridViewTextBoxColumn.HeaderText = "ogrVeliad";
            this.ogrVeliadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVeliadDataGridViewTextBoxColumn.Name = "ogrVeliadDataGridViewTextBoxColumn";
            this.ogrVeliadDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrVelitelDataGridViewTextBoxColumn
            // 
            this.ogrVelitelDataGridViewTextBoxColumn.DataPropertyName = "ogrVelitel";
            this.ogrVelitelDataGridViewTextBoxColumn.HeaderText = "ogrVelitel";
            this.ogrVelitelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVelitelDataGridViewTextBoxColumn.Name = "ogrVelitelDataGridViewTextBoxColumn";
            this.ogrVelitelDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrveliadresDataGridViewTextBoxColumn
            // 
            this.ogrveliadresDataGridViewTextBoxColumn.DataPropertyName = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.HeaderText = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrveliadresDataGridViewTextBoxColumn.Name = "ogrveliadresDataGridViewTextBoxColumn";
            this.ogrveliadresDataGridViewTextBoxColumn.Width = 80;
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "odano";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "odano";
            this.odanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            this.odanoDataGridViewTextBoxColumn.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox4velitel);
            this.Controls.Add(this.maskedTextBox3slah);
            this.Controls.Add(this.maskedTextBox2531);
            this.Controls.Add(this.maskedTextBox11karakter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7adres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5veliad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2soyisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1İsim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1İsim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2soyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5veliad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7adres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3mail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11karakter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2531;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3slah;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4velitel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtkayıtDataSet2 yurtkayıtDataSet2;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurtkayıtDataSet2TableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrdogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVelitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn;
    }
}

