using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public class Siparis
    {
        
        public int id { get; set; }
        public string durum { get; set; }
        public DateTime tarih { get; set; }
        public double odeme { get; set; }
        public List<SiparisDetayi> siparisDetayi = new List<SiparisDetayi>();
        public double vergi { get; set; }
        public const double Vergi_orani = 0.1;

        public Siparis()
        {
            durum = "Beklemede";
        }
        public double toplamTutarHesapla()
        {
            double toplamOdeme = 0F;
            toplamOdeme = odeme + vergiHesapla();
            
            return toplamOdeme;
        }

        public double vergiHesapla()
        {
            vergi = odeme * Vergi_orani;
            return vergi;

        }
        public int toplamAgirlikHesapla()
        {
            int toplamAgirlik = 0;
            foreach (SiparisDetayi detay in siparisDetayi)
            {
                toplamAgirlik += detay.urunMiktari ;
            }
            return toplamAgirlik;
        }
        public void siparisDetayiListeDoldur(SiparisDetayi urun)
        {
            siparisDetayi.Add(urun);
        }
        public void siparisDetay()
        {
            string detayMesaj = "";

            foreach(SiparisDetayi detay in siparisDetayi)
            {
                detayMesaj += detay.urunAdi + " - Adet:" + detay.urunAdeti +  " - Miktar: " +  detay.urunMiktari + " -Ürün Fiyatı: "+ detay.urunFiyati +  "\n";
            }

            MessageBox.Show(detayMesaj + "\n" + "Toplam Agirlik:" + toplamAgirlikHesapla().ToString() + "\nToplam Fiyat: " + toplamTutarHesapla());
        }
    }
}
