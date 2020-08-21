using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class Hasta :Insan , IHasta
    {
        public int _id { get; set; }
        public string _telefon { get; set; }
        public string _cinsiyet { get; set; }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public void bilgileriGüncelle(string ad, string soyad, string telefon, string sifre, string cinsiyet, string tc)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 Where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", ad);
            komut2.Parameters.AddWithValue("@p2", soyad);
            komut2.Parameters.AddWithValue("@p3", telefon);
            komut2.Parameters.AddWithValue("@p4", sifre);
            komut2.Parameters.AddWithValue("@p5", cinsiyet);
            komut2.Parameters.AddWithValue("@p6", tc);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            
        }

        public Hasta bilgiGetir(string tc)
        {
            Hasta hasta = new Hasta();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                hasta.Ad = dr[1].ToString();
                hasta.Soyad = dr[2].ToString();
                hasta._telefon = dr[4].ToString();
                hasta.Sifre= dr[5].ToString();
                hasta._cinsiyet = dr[6].ToString();
            }
            bgl.baglanti().Close();
            return hasta;
        }
    }
}
