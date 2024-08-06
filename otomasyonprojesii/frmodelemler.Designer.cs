namespace otomasyonprojesii
{
    partial class frmodelemler
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1İD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrkalanborcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtkayıtDataSet8 = new otomasyonprojesii.yurtkayıtDataSet8();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2ÖDENEN = new System.Windows.Forms.TextBox();
            this.textBox3KALANBORÇ = new System.Windows.Forms.TextBox();
            this.yurtkayıtDataSet7 = new otomasyonprojesii.yurtkayıtDataSet7();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borclarTableAdapter = new otomasyonprojesii.yurtkayıtDataSet7TableAdapters.borclarTableAdapter();
            this.borclarTableAdapter1 = new otomasyonprojesii.yurtkayıtDataSet8TableAdapters.borclarTableAdapter();
            this.textBox1ödenenAY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ogrenci id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ödenen";
            // 
            // textBox1İD
            // 
            this.textBox1İD.Location = new System.Drawing.Point(116, 9);
            this.textBox1İD.Name = "textBox1İD";
            this.textBox1İD.Size = new System.Drawing.Size(100, 22);
            this.textBox1İD.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "ödeme al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrkalanborcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 223);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            this.ogradDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            this.ogrsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrkalanborcDataGridViewTextBoxColumn
            // 
            this.ogrkalanborcDataGridViewTextBoxColumn.DataPropertyName = "ogrkalanborc";
            this.ogrkalanborcDataGridViewTextBoxColumn.HeaderText = "ogrkalanborc";
            this.ogrkalanborcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrkalanborcDataGridViewTextBoxColumn.Name = "ogrkalanborcDataGridViewTextBoxColumn";
            this.ogrkalanborcDataGridViewTextBoxColumn.Width = 125;
            // 
            // borclarBindingSource1
            // 
            this.borclarBindingSource1.DataMember = "borclar";
            this.borclarBindingSource1.DataSource = this.yurtkayıtDataSet8;
            // 
            // yurtkayıtDataSet8
            // 
            this.yurtkayıtDataSet8.DataSetName = "yurtkayıtDataSet8";
            this.yurtkayıtDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "kalan borç";
            // 
            // textBox2ÖDENEN
            // 
            this.textBox2ÖDENEN.Location = new System.Drawing.Point(116, 48);
            this.textBox2ÖDENEN.Name = "textBox2ÖDENEN";
            this.textBox2ÖDENEN.Size = new System.Drawing.Size(100, 22);
            this.textBox2ÖDENEN.TabIndex = 6;
            // 
            // textBox3KALANBORÇ
            // 
            this.textBox3KALANBORÇ.Location = new System.Drawing.Point(349, 6);
            this.textBox3KALANBORÇ.Name = "textBox3KALANBORÇ";
            this.textBox3KALANBORÇ.Size = new System.Drawing.Size(100, 22);
            this.textBox3KALANBORÇ.TabIndex = 7;
            // 
            // yurtkayıtDataSet7
            // 
            this.yurtkayıtDataSet7.DataSetName = "yurtkayıtDataSet7";
            this.yurtkayıtDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "borclar";
            this.borclarBindingSource.DataSource = this.yurtkayıtDataSet7;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // borclarTableAdapter1
            // 
            this.borclarTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1ödenenAY
            // 
            this.textBox1ödenenAY.Location = new System.Drawing.Point(349, 48);
            this.textBox1ödenenAY.Name = "textBox1ödenenAY";
            this.textBox1ödenenAY.Size = new System.Drawing.Size(100, 22);
            this.textBox1ödenenAY.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ödenen ay";
            // 
            // frmodelemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1ödenenAY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3KALANBORÇ);
            this.Controls.Add(this.textBox2ÖDENEN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1İD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmodelemler";
            this.Text = "frmodelemler";
            this.Load += new System.EventHandler(this.frmodelemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1İD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2ÖDENEN;
        private System.Windows.Forms.TextBox textBox3KALANBORÇ;
        private yurtkayıtDataSet7 yurtkayıtDataSet7;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private yurtkayıtDataSet7TableAdapters.borclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrkalanborcDataGridViewTextBoxColumn;
        private yurtkayıtDataSet8 yurtkayıtDataSet8;
        private System.Windows.Forms.BindingSource borclarBindingSource1;
        private yurtkayıtDataSet8TableAdapters.borclarTableAdapter borclarTableAdapter1;
        private System.Windows.Forms.TextBox textBox1ödenenAY;
        private System.Windows.Forms.Label label4;
    }
}