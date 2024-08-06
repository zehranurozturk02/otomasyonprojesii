namespace otomasyonprojesii
{
    partial class frmogrListe
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
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtkayıtDataSet9 = new otomasyonprojesii.yurtkayıtDataSet9();
            this.ogrenciTableAdapter = new otomasyonprojesii.yurtkayıtDataSet9TableAdapters.ogrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet9)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrdogumDataGridViewTextBoxColumn
            // 
            this.ogrdogumDataGridViewTextBoxColumn.DataPropertyName = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.HeaderText = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrdogumDataGridViewTextBoxColumn.Name = "ogrdogumDataGridViewTextBoxColumn";
            this.ogrdogumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrbolumDataGridViewTextBoxColumn
            // 
            this.ogrbolumDataGridViewTextBoxColumn.DataPropertyName = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.HeaderText = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrbolumDataGridViewTextBoxColumn.Name = "ogrbolumDataGridViewTextBoxColumn";
            this.ogrbolumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrVeliadDataGridViewTextBoxColumn
            // 
            this.ogrVeliadDataGridViewTextBoxColumn.DataPropertyName = "ogrVeliad";
            this.ogrVeliadDataGridViewTextBoxColumn.HeaderText = "ogrVeliad";
            this.ogrVeliadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVeliadDataGridViewTextBoxColumn.Name = "ogrVeliadDataGridViewTextBoxColumn";
            this.ogrVeliadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrVelitelDataGridViewTextBoxColumn
            // 
            this.ogrVelitelDataGridViewTextBoxColumn.DataPropertyName = "ogrVelitel";
            this.ogrVelitelDataGridViewTextBoxColumn.HeaderText = "ogrVelitel";
            this.ogrVelitelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVelitelDataGridViewTextBoxColumn.Name = "ogrVelitelDataGridViewTextBoxColumn";
            this.ogrVelitelDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrveliadresDataGridViewTextBoxColumn
            // 
            this.ogrveliadresDataGridViewTextBoxColumn.DataPropertyName = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.HeaderText = "ogrveliadres";
            this.ogrveliadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrveliadresDataGridViewTextBoxColumn.Name = "ogrveliadresDataGridViewTextBoxColumn";
            this.ogrveliadresDataGridViewTextBoxColumn.Width = 125;
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "odano";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "odano";
            this.odanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            this.odanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtkayıtDataSet9;
            // 
            // yurtkayıtDataSet9
            // 
            this.yurtkayıtDataSet9.DataSetName = "yurtkayıtDataSet9";
            this.yurtkayıtDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // frmogrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmogrListe";
            this.Text = "frmogrListe";
            this.Load += new System.EventHandler(this.frmogrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurtkayıtDataSet9 yurtkayıtDataSet9;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurtkayıtDataSet9TableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
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