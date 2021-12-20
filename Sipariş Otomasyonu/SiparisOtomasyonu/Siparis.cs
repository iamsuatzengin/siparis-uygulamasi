using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    class Siparis
    {
        public int id { get; set; }
        public string durum { get; set; }
        public string tarih { get; set; }


        public SiparisDetayi siparisDetayi;
        public Siparis(SiparisDetayi siparisDetayi)
        {
            this.siparisDetayi = siparisDetayi;
        }
        public void toplamTutarHesapla()
        {
           
        }

        public void vergiHesapla()
        {

        }
        public void toplamAgirlikHesapla()
        {

        }
    }
}
