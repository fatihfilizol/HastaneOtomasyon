using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    abstract class Insan
    {
        private string _ad;
        private string _soyad;
        private string _tc;
        private string _sifre;
        

        public string Ad 
        {
            get
            {
                return _ad;
            }
            set 
            {
                _ad = value;
            } 
        }
        public string Soyad
        {
            get
            {
                return _soyad;
            }
            set
            {
                _soyad = value;
            }
        }
        public string Tc
        {
            get
            {
                return _tc;
            }
            set
            {
                _tc = value;
            }
        }
        public string Sifre
        {
            get
            {
                return _sifre;
            }
            set
            {
                _sifre = value;
            }
        }
    }
}
