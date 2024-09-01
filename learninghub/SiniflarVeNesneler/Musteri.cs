using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarVeNesneler
{
    class Musteri
    {
        public int id;
        private string ad;
        public string soyad;
        public string sehir;

        public string Ad { get => ad; set => ad = value.ToLower(); }//Ctrl+R+E ad'da basınca oldu
        public string Soyad
        { 
            get => soyad; set => soyad = value.ToUpper();//kapsulleme
        }
    }
}
