using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiparisOtomasyonu
{
    public partial class Sepetim : Form
    {
        SqlBaglanti baglanti = new SqlBaglanti();
        
        Musteri musteri = new Musteri();
        List<SiparisDetayi> urunler = new List<SiparisDetayi>();
        public Sepetim()
        {
            InitializeComponent();
        }
        private void Sepetim_Load(object sender, EventArgs e)
        {
            sepetListesi();
            
        }
        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            AnaMenuMusteriForm anaMenuMusteriForm = new AnaMenuMusteriForm();
            anaMenuMusteriForm.Show();
            this.Hide();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
           

            if (tbKartNo.Text == "" || tarih.Text == "" || tbCvc.Text == "")
            {
                MessageBox.Show("Hatalı giriş !!");
            }
            else
            {
                Siparislerim siparislerim = new Siparislerim();

                Kredi krediKart = new Kredi();

                krediKart.Numara = tbKartNo.Text;
                krediKart.CVC = tbCvc.Text;
                krediKart.SKT = tarih.Text;

                siparislerim.krediKartBilgileri = krediKart;
                MessageBox.Show(krediKart.Yetkilimesaj());
                siparisiTamamla();
                sepetBoşalt();
                siparislerim.butonGizleme = true;
                siparislerim.odemeSekli = true;
                siparislerim.Show();
                this.Hide();
            }


        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            if (tbCekAdi.Text == "" || tbCekId.Text == "")
            {
                MessageBox.Show(" Hatalı giriş!!");

            }
            else
            {
                Siparislerim siparislerim = new Siparislerim();
                Cek cek = new Cek();
                cek.Adi = tbCekAdi.Text;
                cek.BankaID = tbCekId.Text;
                MessageBox.Show(cek.Yetkilimesaj());
                
                siparisiTamamla();
                sepetBoşalt();
                siparislerim.butonGizleme = true;
                siparislerim.cekbilgikeri = cek;
                siparislerim.odemeSekli = false;
                siparislerim.Show();
                this.Hide();
            
        }
            
        }

        private void btnNakitileTamamla_Click(object sender, EventArgs e)
        {
            Siparislerim siparislerim = new Siparislerim();
            //tbTutar.Text = ;
            siparisiTamamla();
            sepetBoşalt();
            siparislerim.butonGizleme = true;
            siparislerim.Show();
            this.Hide();

        }

        private void btnAvDetayi_Click(object sender, EventArgs e)
        {
            //Siparis siparis = new Siparis();
            //siparis.tarih = DateTime.Now;
            //siparis.toplamTutarHesapla();
            //siparis.vergiHesapla();
            //siparis.toplamAgirlikHesapla();

            //MessageBox.Show(siparis.tarih.ToString() + " " + siparis.toplamTutarHesapla() + " " + siparis.vergiHesapla());
        }

        private void sepetListesi()
        {
            

            string sorgu = "SELECT * FROM sepetim WHERE kullanici_adi = @k_ad";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", kullaniciAdi()); 
            SqlDataReader reader = komut.ExecuteReader();


            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["urun_adi"].ToString());
                item.SubItems.Add(reader["urun_miktari"].ToString());
                item.SubItems.Add(reader["urun_adeti"].ToString());
                item.SubItems.Add(reader["urun_fiyati"].ToString());
                
                listViewSepet.Items.Add(item);
            }

            baglanti.connection().Close();
            
        }


        private void listViewSepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siparisiTamamla()
        {
            string sorgu = "SELECT * FROM sepetim WHERE kullanici_adi = @k_ad";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", kullaniciAdi());
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                SiparisDetayi urun = new SiparisDetayi();
                urun.id = Convert.ToInt32(reader["urunID"].ToString());
                urun.urunAdi = reader["urun_adi"].ToString();
                urun.urunMiktari = Convert.ToInt32(reader["urun_miktari"].ToString());
                urun.urunAdeti = Convert.ToInt32(reader["urun_adeti"].ToString());
                urun.urunFiyati = Convert.ToDecimal(reader["urun_fiyati"]);

                urunler.Add(urun);

                Siparis siparis = new Siparis();
                musteri.siparis = siparis;
                musteri.siparis.tarih = DateTime.Now;
            }

            musteri.siparisEkle(urunler);
            baglanti.connection().Close();
        }

        public string kullaniciAdi()
        {
            string sorgu = "SELECT * FROM giris_kayitlari_tablo";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                musteri.kullaniciAdi = reader["kullanici_adi"].ToString();
            }

            return musteri.kullaniciAdi;
        }

        private void sepetBoşalt()
        {
            string sorgu = "DELETE FROM sepetim WHERE kullanici_adi = @k_ad";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", kullaniciAdi());

            komut.ExecuteNonQuery();
            baglanti.connection().Close();

        }

        private void krediKart_Click(object sender, EventArgs e)
        {

        }

        private void tbKartNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
