using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    class SiparisDetayi
    {
        public int adet { get; set; } // ürün adeti

        public Urun urun { get; set; }
        public string Vergi_Durumu { get; set; }
        public void fiyat() { }
        public void agirlikHesapla() { }
    }
}
