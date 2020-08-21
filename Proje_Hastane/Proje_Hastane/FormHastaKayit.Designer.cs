namespace Proje_Hastane
{
    partial class FormHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaKayit));
            this.TextAd = new System.Windows.Forms.TextBox();
            this.MaskeTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaskeTelefon = new System.Windows.Forms.MaskedTextBox();
            this.ComboCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAd
            // 
            this.TextAd.Location = new System.Drawing.Point(318, 42);
            this.TextAd.Name = "TextAd";
            this.TextAd.Size = new System.Drawing.Size(207, 40);
            this.TextAd.TabIndex = 1;
            // 
            // MaskeTc
            // 
            this.MaskeTc.Location = new System.Drawing.Point(318, 146);
            this.MaskeTc.Mask = "00000000000";
            this.MaskeTc.Name = "MaskeTc";
            this.MaskeTc.Size = new System.Drawing.Size(207, 40);
            this.MaskeTc.TabIndex = 3;
            this.MaskeTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // TextSoyad
            // 
            this.TextSoyad.Location = new System.Drawing.Point(318, 96);
            this.TextSoyad.Name = "TextSoyad";
            this.TextSoyad.Size = new System.Drawing.Size(207, 40);
            this.TextSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon Numarası:";
            // 
            // TextSifre
            // 
            this.TextSifre.Location = new System.Drawing.Point(318, 247);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(207, 40);
            this.TextSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre: ";
            // 
            // MaskeTelefon
            // 
            this.MaskeTelefon.Location = new System.Drawing.Point(318, 198);
            this.MaskeTelefon.Mask = "(999) 000-0000";
            this.MaskeTelefon.Name = "MaskeTelefon";
            this.MaskeTelefon.Size = new System.Drawing.Size(207, 40);
            this.MaskeTelefon.TabIndex = 4;
            // 
            // ComboCinsiyet
            // 
            this.ComboCinsiyet.FormattingEnabled = true;
            this.ComboCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.ComboCinsiyet.Location = new System.Drawing.Point(318, 296);
            this.ComboCinsiyet.Name = "ComboCinsiyet";
            this.ComboCinsiyet.Size = new System.Drawing.Size(121, 39);
            this.ComboCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnKayitYap.Location = new System.Drawing.Point(318, 389);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(207, 45);
            this.BtnKayitYap.TabIndex = 18;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FormHastaKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(550, 542);
            this.Controls.Add(this.BtnKayitYap);
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
            this.Name = "FormHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAd;
        private System.Windows.Forms.MaskedTextBox MaskeTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MaskeTelefon;
        private System.Windows.Forms.ComboBox ComboCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}