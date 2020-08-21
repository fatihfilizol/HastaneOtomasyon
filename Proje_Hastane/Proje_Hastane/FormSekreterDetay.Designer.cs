namespace Proje_Hastane
{
    partial class FormSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelAdSoyad = new System.Windows.Forms.Label();
            this.LabelTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.RichDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MaskeTC = new System.Windows.Forms.MaskedTextBox();
            this.ComboDoktor = new System.Windows.Forms.ComboBox();
            this.ComboBrans = new System.Windows.Forms.ComboBox();
            this.MaskeSaat = new System.Windows.Forms.MaskedTextBox();
            this.Textid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.BtnDoktorPanel = new System.Windows.Forms.Button();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelAdSoyad);
            this.groupBox1.Controls.Add(this.LabelTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LabelAdSoyad
            // 
            this.LabelAdSoyad.AutoSize = true;
            this.LabelAdSoyad.Location = new System.Drawing.Point(271, 106);
            this.LabelAdSoyad.Name = "LabelAdSoyad";
            this.LabelAdSoyad.Size = new System.Drawing.Size(112, 33);
            this.LabelAdSoyad.TabIndex = 3;
            this.LabelAdSoyad.Text = "Null Null";
            // 
            // LabelTC
            // 
            this.LabelTC.AutoSize = true;
            this.LabelTC.Location = new System.Drawing.Point(271, 62);
            this.LabelTC.Name = "LabelTC";
            this.LabelTC.Size = new System.Drawing.Size(180, 33);
            this.LabelTC.TabIndex = 2;
            this.LabelTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik Numarası:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BtnOlustur);
            this.groupBox2.Controls.Add(this.RichDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(102, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOlustur.Location = new System.Drawing.Point(288, 200);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(163, 48);
            this.BtnOlustur.TabIndex = 1;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = false;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // RichDuyuru
            // 
            this.RichDuyuru.Location = new System.Drawing.Point(6, 39);
            this.RichDuyuru.Name = "RichDuyuru";
            this.RichDuyuru.Size = new System.Drawing.Size(445, 155);
            this.RichDuyuru.TabIndex = 0;
            this.RichDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimeTarih);
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.MaskeTC);
            this.groupBox3.Controls.Add(this.ComboDoktor);
            this.groupBox3.Controls.Add(this.ComboBrans);
            this.groupBox3.Controls.Add(this.MaskeSaat);
            this.groupBox3.Controls.Add(this.Textid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(489, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 475);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnKaydet.Location = new System.Drawing.Point(344, 408);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(163, 48);
            this.BtnKaydet.TabIndex = 18;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(138, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 37);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Durum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MaskeTC
            // 
            this.MaskeTC.Location = new System.Drawing.Point(342, 297);
            this.MaskeTC.Mask = "00000000000";
            this.MaskeTC.Name = "MaskeTC";
            this.MaskeTC.Size = new System.Drawing.Size(165, 40);
            this.MaskeTC.TabIndex = 16;
            this.MaskeTC.ValidatingType = typeof(int);
            // 
            // ComboDoktor
            // 
            this.ComboDoktor.FormattingEnabled = true;
            this.ComboDoktor.Location = new System.Drawing.Point(138, 240);
            this.ComboDoktor.Name = "ComboDoktor";
            this.ComboDoktor.Size = new System.Drawing.Size(163, 39);
            this.ComboDoktor.TabIndex = 15;
            // 
            // ComboBrans
            // 
            this.ComboBrans.FormattingEnabled = true;
            this.ComboBrans.Location = new System.Drawing.Point(138, 191);
            this.ComboBrans.Name = "ComboBrans";
            this.ComboBrans.Size = new System.Drawing.Size(163, 39);
            this.ComboBrans.TabIndex = 14;
            this.ComboBrans.SelectedIndexChanged += new System.EventHandler(this.ComboBrans_SelectedIndexChanged);
            // 
            // MaskeSaat
            // 
            this.MaskeSaat.Location = new System.Drawing.Point(138, 145);
            this.MaskeSaat.Mask = "00:00";
            this.MaskeSaat.Name = "MaskeSaat";
            this.MaskeSaat.Size = new System.Drawing.Size(163, 40);
            this.MaskeSaat.TabIndex = 13;
            this.MaskeSaat.ValidatingType = typeof(System.DateTime);
            // 
            // Textid
            // 
            this.Textid.Location = new System.Drawing.Point(138, 55);
            this.Textid.Name = "Textid";
            this.Textid.Size = new System.Drawing.Size(163, 40);
            this.Textid.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 33);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hasta TC Kiimlik Numarası:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(1080, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 305);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(1080, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(505, 305);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(499, 266);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnRandevuListe);
            this.groupBox6.Controls.Add(this.BtnBransPanel);
            this.groupBox6.Controls.Add(this.BtnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 528);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(967, 107);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnRandevuListe.Location = new System.Drawing.Point(626, 39);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(220, 48);
            this.BtnRandevuListe.TabIndex = 4;
            this.BtnRandevuListe.Text = "Randevu Listesi";
            this.BtnRandevuListe.UseVisualStyleBackColor = false;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnBransPanel.Location = new System.Drawing.Point(351, 39);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(220, 48);
            this.BtnBransPanel.TabIndex = 3;
            this.BtnBransPanel.Text = "Branş Paneli";
            this.BtnBransPanel.UseVisualStyleBackColor = false;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // BtnDoktorPanel
            // 
            this.BtnDoktorPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnDoktorPanel.Location = new System.Drawing.Point(81, 39);
            this.BtnDoktorPanel.Name = "BtnDoktorPanel";
            this.BtnDoktorPanel.Size = new System.Drawing.Size(220, 48);
            this.BtnDoktorPanel.TabIndex = 2;
            this.BtnDoktorPanel.Text = "Doktor Paneli";
            this.BtnDoktorPanel.UseVisualStyleBackColor = false;
            this.BtnDoktorPanel.Click += new System.EventHandler(this.BtnDoktorPanel_Click);
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTarih.Location = new System.Drawing.Point(136, 99);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(165, 40);
            this.dateTimeTarih.TabIndex = 19;
            // 
            // FormSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1588, 643);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FormSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelAdSoyad;
        private System.Windows.Forms.Label LabelTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.RichTextBox RichDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Textid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox MaskeTC;
        private System.Windows.Forms.ComboBox ComboDoktor;
        private System.Windows.Forms.ComboBox ComboBrans;
        private System.Windows.Forms.MaskedTextBox MaskeSaat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRandevuListe;
        private System.Windows.Forms.Button BtnBransPanel;
        private System.Windows.Forms.Button BtnDoktorPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
    }
}