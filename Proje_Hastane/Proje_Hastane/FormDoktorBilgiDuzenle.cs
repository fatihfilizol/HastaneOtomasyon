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
    public partial class FormDoktorBilgiDuzenle : Form
    {
        public FormDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;

        private void FormDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MaskeTc.Text = TCNO;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MaskeTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TextAd.Text = dr[1].ToString();
                TextSoyad.Text = dr[2].ToString();
                ComboBrans.Text = dr[3].ToString();
                TextSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TextAd.Text);
            komut.Parameters.AddWithValue("@p2", TextSoyad.Text);
            komut.Parameters.AddWithValue("@p3", ComboBrans.Text);
            komut.Parameters.AddWithValue("@p4", TextSifre.Text);
            komut.Parameters.AddWithValue("@p5", MaskeTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
