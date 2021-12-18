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


        public Siparis_Detayi siparis_Detayi;
        public Siparis(Siparis_Detayi siparis_Detayi)
        {
            this.siparis_Detayi = siparis_Detayi;
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
