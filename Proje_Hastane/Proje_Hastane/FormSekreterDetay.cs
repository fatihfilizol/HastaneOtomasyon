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
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            LabelTC.Text = TCnumara;

            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAd, SekreterSoyad From Tbl_Sekreter Where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LabelTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LabelAdSoyad.Text = dr1[0].ToString() + " " + dr1[1].ToString();
            }
            bgl.baglanti().Close();


            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' +  DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            //Branşı Combobox a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                ComboBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.RandevuEkle(Convert.ToDateTime( dateTimeTarih.Text),Convert.ToDateTime( MaskeSaat.Text), ComboBrans.Text, ComboDoktor.Text);
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void ComboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ComboBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ComboDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            Duyuru duyuru = new Duyuru();
            duyuru.DuyuruEkle(RichDuyuru.Text);
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli drp = new FormDoktorPaneli();
            drp.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FormBransPaneli frb = new FormBransPaneli();
            frb.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FormRandevuListesi frl = new FormRandevuListesi();
            frl.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
