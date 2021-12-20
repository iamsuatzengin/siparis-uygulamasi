using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public  class Siparis_Detayi
    {
        public double  Adet { get; set; }
        public string Vergi_Durumu{ get; set; }
        public double odeme_miktari { get; set; }

        public double Toplam_Hesap()
        {
         odeme_miktari = odeme_miktari * Adet;
           
            return odeme_miktari;
        }
        public void Toplam_Agirlik()
        {

        }


    }
}
