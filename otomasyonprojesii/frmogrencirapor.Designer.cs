namespace otomasyonprojesii
{
    partial class frmogrencirapor
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
            this.ogrenciTableAdapter1 = new otomasyonprojesii.yurtkayıtDataSet1TableAdapters.ogrenciTableAdapter();
            this.SuspendLayout();
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // frmogrencirapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmogrencirapor";
            this.Text = "frmogrencirapor";
            this.ResumeLayout(false);

        }

        #endregion

        private yurtkayıtDataSet1TableAdapters.ogrenciTableAdapter ogrenciTableAdapter1;
    }
}