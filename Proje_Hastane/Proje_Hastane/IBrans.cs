using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    interface IBrans
    {
        void BransEkle(string bransAdi);
        void BransSil(int id);
        void BransGuncelle(int id, string bransAdi);
            
    }
}
