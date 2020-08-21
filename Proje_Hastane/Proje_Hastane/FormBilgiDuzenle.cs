using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FormBilgiDuzenle : Form
    {
        public FormBilgiDuzenle()
        {
            InitializeComponent();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
        

            Hasta hasta = new Hasta();
            hasta.bilgileriGüncelle(TextAd.Text, TextSoyad.Text, MaskeTelefon.Text, TextSifre.Text, ComboCinsiyet.Text, MaskeTc.Text);
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MaskeTc.Text = TCno;
            Hasta hasta = new Hasta();
            hasta=hasta.bilgiGetir(TCno);
            TextAd.Text = hasta.Ad;
            TextSoyad.Text = hasta.Soyad;
            MaskeTelefon.Text = hasta._telefon;
            TextSifre.Text = hasta.Sifre;
            ComboCinsiyet.Text = hasta._cinsiyet;

            
        }
    }
}
