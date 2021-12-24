﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
   public  class SiparisDetayi
    {
        public int id { get; set; }
        public string urunAdi { get; set; }
        public int urunMiktari { get; set; }
        public int urunAdeti { get; set; }
        public decimal urunFiyati { get; set; }

        SqlBaglanti baglanti = new SqlBaglanti();

        public string Vergi_Durumu { get; set; }

        public decimal Toplam_Hesap()
        {

            urunFiyati = urunFiyati * urunAdeti;
            return urunFiyati;

        }
        public void Toplam_Agirlik()
        {

        }
        public void urunListele(ListView listViewUrunler)
        {
            string sorgu = "SELECT * FROM urun_detayi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());

            SqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                item.SubItems.Add(dataReader["urun_adi"].ToString());
                item.SubItems.Add(dataReader["urun_miktari"].ToString());
                item.SubItems.Add(dataReader["urun_adedi"].ToString());
                item.SubItems.Add(dataReader["urun_fiyati"].ToString());
                listViewUrunler.Items.Add(item);
            }
            baglanti.connection().Close();
        }
        public void urunEkle()
        {
            string sorgu = "INSERT INTO urun_detayi (urun_adi, urun_miktari, urun_adedi , urun_fiyati) values (@adi, @miktar, @adet , @fiyat)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());

            komut.Parameters.AddWithValue("@adi", urunAdi);
            komut.Parameters.AddWithValue("@miktar", urunMiktari);
            komut.Parameters.AddWithValue("@adet", urunAdeti);
            komut.Parameters.AddWithValue("@fiyat", urunFiyati);

            komut.ExecuteNonQuery();
            baglanti.connection().Close();
        }
        public void urunCikar(int id, ListView listViewUrunler)
        {
        
            SqlCommand komut = new SqlCommand("DELETE FROM urun_detayi WHERE id=@id", baglanti.connection());
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.connection().Close();
            urunListele(listViewUrunler);
        }
        public void urunGuncelle(int id)
        {
            string sorgu = "UPDATE urun_detayi SET urun_adi=@ad, urun_miktari=@miktar, urun_adedi=@adet , urun_fiyati=@fiyat  WHERE id=@id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());

            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@ad", urunAdi);
            komut.Parameters.AddWithValue("@miktar", urunMiktari);
            komut.Parameters.AddWithValue("@adet", urunAdeti);
            komut.Parameters.AddWithValue("@fiyat", urunFiyati);


            komut.ExecuteNonQuery();
            baglanti.connection().Close();
        }
        public void urunGonder(int id, ListView listViewUrunler)
        {

            SqlCommand komut = new SqlCommand("DELETE FROM urun_detayi WHERE id=@id", baglanti.connection());
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.connection().Close();
            urunListele(listViewUrunler);
        }

        public void urunAdetGuncelle(int id)
        {

            string sorgu = "UPDATE urun_detayi SET urun_adedi -= @adet  WHERE id=@id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@adet", 1);


            komut.ExecuteNonQuery();
            baglanti.connection().Close();
        }
    }
}
