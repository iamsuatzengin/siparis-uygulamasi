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

        public Siparis siparis = new Siparis();

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

        public void sepeteEkle(SiparisDetayi urun)
        {
            string sorgu = "INSERT INTO sepetim (kullanici_adi,kullanici_adresi,tarih,urun_adi,urun_miktari,urun_adeti, urunID, urun_fiyati)" +
                "values (@k_ad, @k_adres, @tarih, @urun_adi, @urun_miktari, @urun_adeti, @urun_id, @urun_fiyati)";
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());

            komut.Parameters.AddWithValue("@k_ad", kullaniciAdi);
            komut.Parameters.AddWithValue("@k_adres", adres);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@urun_adi", urun.urunAdi);
            komut.Parameters.AddWithValue("@urun_miktari", urun.urunMiktari);
            komut.Parameters.AddWithValue("@urun_adeti", urun.urunAdeti);
            komut.Parameters.AddWithValue("@urun_id", urun.id);
            komut.Parameters.AddWithValue("@urun_fiyati", urun.urunFiyati);
            

            komut.ExecuteNonQuery();
            sqlBaglan.connection().Close();

        }

        public int toplamFiyat()
        {
            int toplam = 0;

            string sorgu = "SELECT * FROM sepetim WHERE kullanici_adi = @k_ad";
            
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());
            komut.Parameters.AddWithValue("@k_ad", this.kullaniciAdi);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                toplam += Convert.ToInt32(reader["urun_fiyati"]);
            }

            return toplam;

        }

        public void siparisEkle(List<SiparisDetayi> urunler)
        {
            
            foreach (SiparisDetayi urun in urunler)
            {
                string sorgu = "INSERT INTO siparislerim (kullanici_adi, durum,tarih,urun_adi,urun_miktari,urun_adeti, urunID, urun_fiyati)" +
                "values (@k_ad, @durum,@tarih, @urun_adi, @urun_miktari, @urun_adeti, @urun_id, @urun_fiyati)";
                SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());

                komut.Parameters.AddWithValue("@k_ad", kullaniciAdi);
                komut.Parameters.AddWithValue("@durum", siparis.durum);
                //komut.Parameters.AddWithValue("@k_adres", adres);
                komut.Parameters.AddWithValue("@tarih", siparis.tarih.ToString());
                komut.Parameters.AddWithValue("@urun_adi", urun.urunAdi);
                komut.Parameters.AddWithValue("@urun_miktari", urun.urunMiktari);
                komut.Parameters.AddWithValue("@urun_adeti", urun.urunAdeti);
                komut.Parameters.AddWithValue("@urun_id", urun.id);
                komut.Parameters.AddWithValue("@urun_fiyati", urun.urunFiyati);

                komut.ExecuteNonQuery();
                sqlBaglan.connection().Close();
            }
            
            
        }
        public void siparisListe()
        {
            string sorgu = "SELECT * FROM siparislerim WHERE kullanici_adi=@k_ad";
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglan.connection());
            komut.Parameters.AddWithValue("@k_ad", this.kullaniciAdi);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                
            }

            sqlBaglan.connection().Close();
            
        }
        public string urunIDs()
        {
            List<string> urunIDs = new List<string>();
            string sorgu1 = "SELECT * FROM sepetim WHERE kullanici_adi = @k_ad";
            SqlCommand komut1 = new SqlCommand(sorgu1, sqlBaglan.connection());

            komut1.Parameters.AddWithValue("@k_ad", this.kullaniciAdi);
            SqlDataReader reader = komut1.ExecuteReader();

            while (reader.Read())
            {
                urunIDs.Add(reader["urunIDs"].ToString());
            }

            string urunIDsString = "";
            foreach (var urun in urunIDs)
            {
                urunIDsString += urun + ",";
            }

            return urunIDsString;
        }
    }
}
