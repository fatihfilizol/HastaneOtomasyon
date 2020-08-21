using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    interface IRandevu
    {
        void RandevuAl(string tc, string sikayet, int id);
       
        void RandevuEkle(DateTime tarih, DateTime saat, string brans, string doktor);


    }
}
