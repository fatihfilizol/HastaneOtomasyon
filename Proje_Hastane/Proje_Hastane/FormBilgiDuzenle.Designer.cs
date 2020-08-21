namespace Proje_Hastane
{
    partial class FormBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilgiDuzenle));
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboCinsiyet = new System.Windows.Forms.ComboBox();
            this.MaskeTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAd = new System.Windows.Forms.TextBox();
            this.MaskeTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(319, 369);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(207, 45);
            this.BtnBilgiGuncelle.TabIndex = 7;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet:";
            // 
            // ComboCinsiyet
            // 
            this.ComboCinsiyet.FormattingEnabled = true;
            this.ComboCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.ComboCinsiyet.Location = new System.Drawing.Point(319, 297);
            this.ComboCinsiyet.Name = "ComboCinsiyet";
            this.ComboCinsiyet.Size = new System.Drawing.Size(121, 39);
            this.ComboCinsiyet.TabIndex = 6;
            // 
            // MaskeTelefon
            // 
            this.MaskeTelefon.Location = new System.Drawing.Point(319, 199);
            this.MaskeTelefon.Mask = "(999) 000-0000";
            this.MaskeTelefon.Name = "MaskeTelefon";
            this.MaskeTelefon.Size = new System.Drawing.Size(207, 40);
            this.MaskeTelefon.TabIndex = 4;
            // 
            // TextSifre
            // 
            this.TextSifre.Location = new System.Drawing.Point(319, 248);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(207, 40);
            this.TextSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "Şifre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 33);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefon Numarası:";
            // 
            // TextSoyad
            // 
            this.TextSoyad.Location = new System.Drawing.Point(319, 97);
            this.TextSoyad.Name = "TextSoyad";
            this.TextSoyad.Size = new System.Drawing.Size(207, 40);
            this.TextSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Soyad:";
            // 
            // TextAd
            // 
            this.TextAd.Location = new System.Drawing.Point(319, 43);
            this.TextAd.Name = "TextAd";
            this.TextAd.Size = new System.Drawing.Size(207, 40);
            this.TextAd.TabIndex = 1;
            // 
            // MaskeTc
            // 
            this.MaskeTc.Location = new System.Drawing.Point(319, 147);
            this.MaskeTc.Mask = "00000000000";
            this.MaskeTc.Name = "MaskeTc";
            this.MaskeTc.Size = new System.Drawing.Size(207, 40);
            this.MaskeTc.TabIndex = 3;
            this.MaskeTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // FormBilgiDuzenle
            // 
            this.AcceptButton = this.BtnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(665, 497);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboCinsiyet);
            this.Controls.Add(this.MaskeTelefon);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Name = "FormBilgiDuzenle";
            this.Text = "Düzenle";
            this.Load += new System.EventHandler(this.FormBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboCinsiyet;
        private System.Windows.Forms.MaskedTextBox MaskeTelefon;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAd;
        private System.Windows.Forms.MaskedTextBox MaskeTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}