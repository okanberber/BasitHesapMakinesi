namespace BasitHesapMakinesi
{
    partial class Form1
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
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sonuc = new System.Windows.Forms.TextBox();
            this.tb_sayi1 = new System.Windows.Forms.MaskedTextBox();
            this.tb_sayi2 = new System.Windows.Forms.MaskedTextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(220, 32);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(75, 23);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "TOPLA";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(220, 61);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(75, 23);
            this.btn_cikar.TabIndex = 2;
            this.btn_cikar.Text = "ÇIKAR";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(220, 90);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(75, 23);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "ÇARP";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(220, 119);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(75, 23);
            this.btn_bol.TabIndex = 2;
            this.btn_bol.Text = "BÖL";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.SAYI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.SAYI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SONUÇ";
            // 
            // tb_sonuc
            // 
            this.tb_sonuc.Enabled = false;
            this.tb_sonuc.Location = new System.Drawing.Point(72, 119);
            this.tb_sonuc.Name = "tb_sonuc";
            this.tb_sonuc.Size = new System.Drawing.Size(100, 20);
            this.tb_sonuc.TabIndex = 4;
            // 
            // tb_sayi1
            // 
            this.tb_sayi1.HidePromptOnLeave = true;
            this.tb_sayi1.HideSelection = false;
            this.tb_sayi1.Location = new System.Drawing.Point(72, 32);
            this.tb_sayi1.Mask = "0000000000000000";
            this.tb_sayi1.Name = "tb_sayi1";
            this.tb_sayi1.PromptChar = ' ';
            this.tb_sayi1.Size = new System.Drawing.Size(100, 20);
            this.tb_sayi1.TabIndex = 5;
            // 
            // tb_sayi2
            // 
            this.tb_sayi2.HidePromptOnLeave = true;
            this.tb_sayi2.HideSelection = false;
            this.tb_sayi2.Location = new System.Drawing.Point(72, 58);
            this.tb_sayi2.Mask = "0000000000000000";
            this.tb_sayi2.Name = "tb_sayi2";
            this.tb_sayi2.PromptChar = ' ';
            this.tb_sayi2.Size = new System.Drawing.Size(100, 20);
            this.tb_sayi2.TabIndex = 5;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(220, 148);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 180);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.tb_sayi2);
            this.Controls.Add(this.tb_sayi1);
            this.Controls.Add(this.tb_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_topla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sonuc;
        private System.Windows.Forms.MaskedTextBox tb_sayi1;
        private System.Windows.Forms.MaskedTextBox tb_sayi2;
        private System.Windows.Forms.Button btn_temizle;
    }
}

