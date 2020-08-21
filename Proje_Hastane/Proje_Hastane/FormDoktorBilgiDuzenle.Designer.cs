namespace Proje_Hastane
{
    partial class FormDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorBilgiDuzenle));
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAd = new System.Windows.Forms.TextBox();
            this.MaskeTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextSifre
            // 
            this.TextSifre.Location = new System.Drawing.Point(299, 171);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(207, 40);
            this.TextSifre.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Şifre: ";
            // 
            // TextSoyad
            // 
            this.TextSoyad.Location = new System.Drawing.Point(299, 72);
            this.TextSoyad.Name = "TextSoyad";
            this.TextSoyad.Size = new System.Drawing.Size(207, 40);
            this.TextSoyad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Soyad:";
            // 
            // TextAd
            // 
            this.TextAd.Location = new System.Drawing.Point(299, 18);
            this.TextAd.Name = "TextAd";
            this.TextAd.Size = new System.Drawing.Size(207, 40);
            this.TextAd.TabIndex = 31;
            // 
            // MaskeTc
            // 
            this.MaskeTc.Location = new System.Drawing.Point(299, 122);
            this.MaskeTc.Mask = "00000000000";
            this.MaskeTc.Name = "MaskeTc";
            this.MaskeTc.Size = new System.Drawing.Size(207, 40);
            this.MaskeTc.TabIndex = 30;
            this.MaskeTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // ComboBrans
            // 
            this.ComboBrans.FormattingEnabled = true;
            this.ComboBrans.Location = new System.Drawing.Point(299, 223);
            this.ComboBrans.Name = "ComboBrans";
            this.ComboBrans.Size = new System.Drawing.Size(121, 39);
            this.ComboBrans.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 33);
            this.label4.TabIndex = 37;
            this.label4.Text = "Branş:";
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(299, 303);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(207, 45);
            this.BtnBilgiGuncelle.TabIndex = 38;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // FormDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(627, 382);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBrans);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAd);
            this.Controls.Add(this.MaskeTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FormDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FormDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAd;
        private System.Windows.Forms.MaskedTextBox MaskeTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBilgiGuncelle;
    }
}