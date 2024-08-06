namespace otomasyonprojesii
{
    partial class Formadmingiriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1kullancııad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2kullanıcışifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı ad";
            // 
            // textBox1kullancııad
            // 
            this.textBox1kullancııad.Location = new System.Drawing.Point(166, 144);
            this.textBox1kullancııad.Name = "textBox1kullancııad";
            this.textBox1kullancııad.Size = new System.Drawing.Size(150, 22);
            this.textBox1kullancııad.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2kullanıcışifre
            // 
            this.textBox2kullanıcışifre.Location = new System.Drawing.Point(166, 194);
            this.textBox2kullanıcışifre.Name = "textBox2kullanıcışifre";
            this.textBox2kullanıcışifre.Size = new System.Drawing.Size(150, 22);
            this.textBox2kullanıcışifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "sifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci Yurt Otomasyon Sistemi";
            // 
            // Formadmingiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2kullanıcışifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1kullancııad);
            this.Controls.Add(this.label1);
            this.Name = "Formadmingiriş";
            this.Text = "Formadmingiriş";
            this.Load += new System.EventHandler(this.Formadmingiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1kullancııad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2kullanıcışifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}