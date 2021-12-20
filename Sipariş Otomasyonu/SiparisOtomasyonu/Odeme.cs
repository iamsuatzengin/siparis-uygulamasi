using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public abstract class Odeme
    {
        public Siparis odeme_tutari { get; set; }
    }
    interface Yetkili
    {
        string Yetkilimesaj();

    }
    public class Kredi : Odeme,Yetkili
    {
        public string Numara { get; set; }
        public string CVC { get; set; }
        public string SKT { get; set; }

       public  string Yetkilimesaj()
        {
            return "Kredi kartıyla ödemeniz alınmıştır.";
        }
    }
    public class Nakit : Odeme
    {
        public string Nakittutar  { get; set; }
    }
    public class Cek : Odeme,Yetkili
    {
        public string Adi { get; set; }
        public string BankaID { get; set; }

      public   string Yetkilimesaj()
        {
            return "Çek ile ödemeniz alınmıştır.";
        }
    }

}
