namespace otomasyonprojesii
{
    partial class frmgiderlisesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtkayıtDataSet10 = new otomasyonprojesii.yurtkayıtDataSet10();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerTableAdapter = new otomasyonprojesii.yurtkayıtDataSet10TableAdapters.giderlerTableAdapter();
            this.odemeİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektirkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diğerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeİdDataGridViewTextBoxColumn,
            this.elektirkDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.doğalgazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.diğerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yurtkayıtDataSet10
            // 
            this.yurtkayıtDataSet10.DataSetName = "yurtkayıtDataSet10";
            this.yurtkayıtDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "giderler";
            this.giderlerBindingSource.DataSource = this.yurtkayıtDataSet10;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // odemeİdDataGridViewTextBoxColumn
            // 
            this.odemeİdDataGridViewTextBoxColumn.DataPropertyName = "odemeİd";
            this.odemeİdDataGridViewTextBoxColumn.HeaderText = "odemeİd";
            this.odemeİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeİdDataGridViewTextBoxColumn.Name = "odemeİdDataGridViewTextBoxColumn";
            this.odemeİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeİdDataGridViewTextBoxColumn.Width = 125;
            // 
            // elektirkDataGridViewTextBoxColumn
            // 
            this.elektirkDataGridViewTextBoxColumn.DataPropertyName = "Elektirk";
            this.elektirkDataGridViewTextBoxColumn.HeaderText = "Elektirk";
            this.elektirkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektirkDataGridViewTextBoxColumn.Name = "elektirkDataGridViewTextBoxColumn";
            this.elektirkDataGridViewTextBoxColumn.Width = 125;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.Width = 125;
            // 
            // doğalgazDataGridViewTextBoxColumn
            // 
            this.doğalgazDataGridViewTextBoxColumn.DataPropertyName = "doğalgaz";
            this.doğalgazDataGridViewTextBoxColumn.HeaderText = "doğalgaz";
            this.doğalgazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doğalgazDataGridViewTextBoxColumn.Name = "doğalgazDataGridViewTextBoxColumn";
            this.doğalgazDataGridViewTextBoxColumn.Width = 125;
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "internet";
            this.internetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            this.internetDataGridViewTextBoxColumn.Width = 125;
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "gıda";
            this.gıdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            this.gıdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            this.personelDataGridViewTextBoxColumn.Width = 125;
            // 
            // diğerDataGridViewTextBoxColumn
            // 
            this.diğerDataGridViewTextBoxColumn.DataPropertyName = "diğer";
            this.diğerDataGridViewTextBoxColumn.HeaderText = "diğer";
            this.diğerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diğerDataGridViewTextBoxColumn.Name = "diğerDataGridViewTextBoxColumn";
            this.diğerDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmgiderlisesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmgiderlisesi";
            this.Text = "frmgiderlisesi";
            this.Load += new System.EventHandler(this.frmgiderlisesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtkayıtDataSet10 yurtkayıtDataSet10;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private yurtkayıtDataSet10TableAdapters.giderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektirkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diğerDataGridViewTextBoxColumn;
    }
}