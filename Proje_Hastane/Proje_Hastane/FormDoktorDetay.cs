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
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FormDoktorBilgiDuzenle fr = new FormDoktorBilgiDuzenle();
            fr.TCNO = LabelTC.Text;
            fr.Show();  
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();  
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RichSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            LabelTC.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorTC= @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LabelTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LabelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevularlar where RandevuDoktor='" + LabelAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
