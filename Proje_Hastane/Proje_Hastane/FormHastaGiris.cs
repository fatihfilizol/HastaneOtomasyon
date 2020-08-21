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
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void LinkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayit fr = new FormHastaKayit();
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MaskeTc.Text);
            komut.Parameters.AddWithValue("@p2", TextSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FormHastaDetay fr = new FormHastaDetay();
                fr.tc = MaskeTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifre Hatalı!");
            }
            bgl.baglanti().Close();
        }
    }
}
