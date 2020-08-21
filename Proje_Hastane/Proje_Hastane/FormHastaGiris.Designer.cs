namespace Proje_Hastane
{
    partial class FormHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaskeTc = new System.Windows.Forms.MaskedTextBox();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.LinkUyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre: ";
            // 
            // MaskeTc
            // 
            this.MaskeTc.Location = new System.Drawing.Point(326, 143);
            this.MaskeTc.Mask = "00000000000";
            this.MaskeTc.Name = "MaskeTc";
            this.MaskeTc.Size = new System.Drawing.Size(207, 40);
            this.MaskeTc.TabIndex = 3;
            this.MaskeTc.ValidatingType = typeof(int);
            // 
            // TextSifre
            // 
            this.TextSifre.Location = new System.Drawing.Point(326, 202);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(207, 40);
            this.TextSifre.TabIndex = 4;
            this.TextSifre.UseSystemPasswordChar = true;
            // 
            // LinkUyeOl
            // 
            this.LinkUyeOl.AutoSize = true;
            this.LinkUyeOl.Location = new System.Drawing.Point(591, 282);
            this.LinkUyeOl.Name = "LinkUyeOl";
            this.LinkUyeOl.Size = new System.Drawing.Size(92, 33);
            this.LinkUyeOl.TabIndex = 5;
            this.LinkUyeOl.TabStop = true;
            this.LinkUyeOl.Text = "Üye Ol";
            this.LinkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUyeOl_LinkClicked);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(385, 273);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(129, 48);
            this.BtnGirisYap.TabIndex = 6;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // FormHastaGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(776, 378);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.LinkUyeOl);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.MaskeTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FormHastaGiris";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MaskeTc;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.LinkLabel LinkUyeOl;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}