using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    class Randevu : IRandevu
    {
        private int _id { get; set; }
        private DateTime _tarih { get; set; }
        private DateTime _saat { get; set; }
        private Doktor _doktor { get; set; }
        private Hasta _hasta { get; set; }
        private string _sikayet { get; set; }

        sqlbaglantisi bgl;
        public void RandevuAl(string tc, string sikayet, int id)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1, RandevuHastaId=(select HastaId from Tbl_Hastalar where HastaTC=@p1), HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            komut.Parameters.AddWithValue("@p2",sikayet);
            komut.Parameters.AddWithValue("@p3", id);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void RandevuEkle(DateTime tarih, DateTime saat, string brans, string doktor)
        {
            string[] split = doktor.Split(' ');
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktorId) values (@r1,@r2,@r3,(select DoktorId from Tbl_Doktorlar where DoktorAd=@r4 and DoktorSoyad=@r5))", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", tarih);
            komutkaydet.Parameters.AddWithValue("@r2", saat);
            komutkaydet.Parameters.AddWithValue("@r3", brans);
            komutkaydet.Parameters.AddWithValue("@r4", split[0]);
            komutkaydet.Parameters.AddWithValue("@r5", split[1]);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
