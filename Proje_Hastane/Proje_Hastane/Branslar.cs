using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    class Branslar : IBrans
    {
        public int bransId { get; set; }

        public string bransAdi { get; set; }

        public Branslar()
        {

        }
        sqlbaglantisi bgl;
        public void BransEkle(string bransAdi)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", bransAdi);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void BransSil(int id)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", id);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void BransGuncelle(int id, string bransAdi)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransAdi);
            komut.Parameters.AddWithValue("@p2", id);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
