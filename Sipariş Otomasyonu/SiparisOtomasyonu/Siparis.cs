using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class Siparis
    {
        public double vergi;
        public int id { get; set; }
        public string durum { get; set; }
        public DateTime tarih { get; set; }
        public double odeme { get; set; }
        
        public const  double  Vergi_orani = 0.1;


        public double toplamTutarHesapla()
        {
            odeme = odeme + vergi;
            return  odeme;
        }

        public double  vergiHesapla()
        {
            vergi = odeme * Vergi_orani;
            return vergi;
        }
        public void toplamAgirlikHesapla()
        {

        }
    }
}
