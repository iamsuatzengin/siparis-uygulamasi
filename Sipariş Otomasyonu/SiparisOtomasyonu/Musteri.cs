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
    }
}
