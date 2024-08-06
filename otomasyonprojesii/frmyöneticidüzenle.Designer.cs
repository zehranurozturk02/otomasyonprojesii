namespace otomasyonprojesii
{
    partial class frmyöneticidüzenle
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personelid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.personelgörev = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.yurtkayıtDataSet12 = new otomasyonprojesii.yurtkayıtDataSet12();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new otomasyonprojesii.yurtkayıtDataSet12TableAdapters.personelTableAdapter();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelaAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 0;
            // 
            // personelid
            // 
            this.personelid.AutoSize = true;
            this.personelid.Location = new System.Drawing.Point(88, 26);
            this.personelid.Name = "personelid";
            this.personelid.Size = new System.Drawing.Size(71, 16);
            this.personelid.TabIndex = 1;
            this.personelid.Text = "personelid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelaAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(516, 165);
            this.dataGridView1.TabIndex = 3;
            // 
            // personelad
            // 
            this.personelad.AutoSize = true;
            this.personelad.Location = new System.Drawing.Point(83, 64);
            this.personelad.Name = "personelad";
            this.personelad.Size = new System.Drawing.Size(76, 16);
            this.personelad.TabIndex = 5;
            this.personelad.Text = "personelad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 4;
            // 
            // personelgörev
            // 
            this.personelgörev.AutoSize = true;
            this.personelgörev.Location = new System.Drawing.Point(64, 108);
            this.personelgörev.Name = "personelgörev";
            this.personelgörev.Size = new System.Drawing.Size(95, 16);
            this.personelgörev.TabIndex = 7;
            this.personelgörev.Text = "personelgörev";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 22);
            this.textBox3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yurtkayıtDataSet12
            // 
            this.yurtkayıtDataSet12.DataSetName = "yurtkayıtDataSet12";
            this.yurtkayıtDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.yurtkayıtDataSet12;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelaAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelaAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "personelaAdSoyad";
            this.personelaAdSoyadDataGridViewTextBoxColumn.HeaderText = "personelaAdSoyad";
            this.personelaAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelaAdSoyadDataGridViewTextBoxColumn.Name = "personelaAdSoyadDataGridViewTextBoxColumn";
            this.personelaAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "personelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "personelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            this.personelDepartmanDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmyöneticidüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.personelgörev);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.personelad);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personelid);
            this.Controls.Add(this.textBox1);
            this.Name = "frmyöneticidüzenle";
            this.Text = "frmyöneticidüzenle";
            this.Load += new System.EventHandler(this.frmyöneticidüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label personelid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label personelad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label personelgörev;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private yurtkayıtDataSet12 yurtkayıtDataSet12;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private yurtkayıtDataSet12TableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelaAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}