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
using System.Collections;

namespace Proje_Hastane
{
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            LabelTC.Text = tc;
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LabelTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LabelAdSoyad.Text = dr[0] + " "+ dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular left join Tbl_Hastalar on HastaId=RandevuHastaId Where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                ComboBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void ComboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", ComboBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                ComboDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void ComboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split = ComboDoktor.Text.Split(' ');
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where  RandevuDoktorId =(select DoktorId from Tbl_Doktorlar where DoktorAd='"+split[0]+"' and DoktorSoyad='"+split[2]+"') and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LinkDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBilgiDuzenle fr = new FormBilgiDuzenle();
            fr.TCno = LabelTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Textid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.RandevuAl(LabelTC.Text, RichSikayet.Text, int.Parse(Textid.Text));
            MessageBox.Show("Randevu Alındı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
