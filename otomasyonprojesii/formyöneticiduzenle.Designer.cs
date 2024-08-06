namespace otomasyonprojesii
{
    partial class formyöneticiduzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1İD = new System.Windows.Forms.TextBox();
            this.textBox2KULLANICIAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3ŞİFRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticisifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtkayıtDataSet11 = new otomasyonprojesii.yurtkayıtDataSet11();
            this.adminTableAdapter = new otomasyonprojesii.yurtkayıtDataSet11TableAdapters.adminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "yönetici id";
            // 
            // textBox1İD
            // 
            this.textBox1İD.Location = new System.Drawing.Point(172, 53);
            this.textBox1İD.Name = "textBox1İD";
            this.textBox1İD.Size = new System.Drawing.Size(100, 22);
            this.textBox1İD.TabIndex = 1;
            // 
            // textBox2KULLANICIAD
            // 
            this.textBox2KULLANICIAD.Location = new System.Drawing.Point(172, 92);
            this.textBox2KULLANICIAD.Name = "textBox2KULLANICIAD";
            this.textBox2KULLANICIAD.Size = new System.Drawing.Size(100, 22);
            this.textBox2KULLANICIAD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "kullanıcı ad";
            // 
            // textBox3ŞİFRE
            // 
            this.textBox3ŞİFRE.Location = new System.Drawing.Point(172, 136);
            this.textBox3ŞİFRE.Name = "textBox3ŞİFRE";
            this.textBox3ŞİFRE.Size = new System.Drawing.Size(100, 22);
            this.textBox3ŞİFRE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "şifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiadDataGridViewTextBoxColumn,
            this.yoneticisifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 161);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.yoneticiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiadDataGridViewTextBoxColumn
            // 
            this.yoneticiadDataGridViewTextBoxColumn.DataPropertyName = "yoneticiad";
            this.yoneticiadDataGridViewTextBoxColumn.HeaderText = "yoneticiad";
            this.yoneticiadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiadDataGridViewTextBoxColumn.Name = "yoneticiadDataGridViewTextBoxColumn";
            this.yoneticiadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticisifreDataGridViewTextBoxColumn
            // 
            this.yoneticisifreDataGridViewTextBoxColumn.DataPropertyName = "yoneticisifre";
            this.yoneticisifreDataGridViewTextBoxColumn.HeaderText = "yoneticisifre";
            this.yoneticisifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticisifreDataGridViewTextBoxColumn.Name = "yoneticisifreDataGridViewTextBoxColumn";
            this.yoneticisifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.yurtkayıtDataSet11;
            // 
            // yurtkayıtDataSet11
            // 
            this.yurtkayıtDataSet11.DataSetName = "yurtkayıtDataSet11";
            this.yurtkayıtDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // formyöneticiduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3ŞİFRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2KULLANICIAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1İD);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formyöneticiduzenle";
            this.Text = "formyöneticiduzenle";
            this.Load += new System.EventHandler(this.formyöneticiduzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1İD;
        private System.Windows.Forms.TextBox textBox2KULLANICIAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3ŞİFRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtkayıtDataSet11 yurtkayıtDataSet11;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private yurtkayıtDataSet11TableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticisifreDataGridViewTextBoxColumn;
    }
}