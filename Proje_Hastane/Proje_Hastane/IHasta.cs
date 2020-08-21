using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    interface IHasta
    {
        void bilgileriGüncelle(string ad, string soyad, string telefon, string sifre, string cinsiyet, string tc);
        Hasta bilgiGetir(string tc);

    }
}
