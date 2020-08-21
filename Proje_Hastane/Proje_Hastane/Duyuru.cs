using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    class Duyuru
    {
        private int _id { get; set; }
        private string _duyuru { get; set; }

        sqlbaglantisi bgl;
        public void DuyuruEkle(string duyuru)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", duyuru);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
