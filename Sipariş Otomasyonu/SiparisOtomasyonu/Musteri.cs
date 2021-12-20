using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public class Musteri: User
    {
        
        public string ad{ get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }

        private List<Siparis> siparislerim;

        SqlBaglanti sqlBaglan = new SqlBaglanti();
        public void musteriKayit()
        {
            string sorgu = "INSERT INTO musteri_tablo (ad, soyad, adres, telefon, kullanici_adi, sifre) values (@ad, @soyad, @adres, @telefon, @k_ad, @sifre)";
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@telefon", telefon);
            komut.Parameters.AddWithValue("@k_ad", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);

            komut.ExecuteNonQuery();
            sqlBaglan.connection().Close();
        }

        public void musteriListeleListView(ListView listView)
        {
            string sorgu = "SELECT * FROM musteri_tablo";
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());

            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read()) {
                ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                item.SubItems.Add(dataReader["ad"].ToString());
                item.SubItems.Add(dataReader["soyad"].ToString());
                item.SubItems.Add(dataReader["adres"].ToString());
                item.SubItems.Add(dataReader["telefon"].ToString());
                item.SubItems.Add(dataReader["kullanici_adi"].ToString());
                listView.Items.Add(item);
            }
            sqlBaglan.connection().Close();
        }

        public void sepeteEkle(Urun urun)
        {
            string sorgu = "INSERT INTO sepetim (kullanici_adi,kullanici_adresi,tarih,urun_adi,urun_miktari,urun_adeti, urunID)" +
                "values (@k_ad, @k_adres, @tarih, @urun_adi, @urun_miktari, @urun_adeti, @urun_id)";
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());

            komut.Parameters.AddWithValue("@k_ad", kullaniciAdi);
            komut.Parameters.AddWithValue("@k_adres", adres);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@urun_adi", urun.urunAdi);
            komut.Parameters.AddWithValue("@urun_miktari", urun.urunMiktari);
            komut.Parameters.AddWithValue("@urun_adeti", urun.urunAdeti);
            komut.Parameters.AddWithValue("@urun_id", urun.id);
            

            komut.ExecuteNonQuery();
            sqlBaglan.connection().Close();

        }
    }
}
