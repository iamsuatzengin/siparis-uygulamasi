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
    public partial class AnaMenuMusteriForm : Form
    {
        SqlBaglanti baglanti = new SqlBaglanti();
        public string mevcutMusteriKAd;
        Urun urun = new Urun();
        Musteri musteri = new Musteri();
        public AnaMenuMusteriForm()
        {
            InitializeComponent();
        }
        
        private void AnaMenuMusteriForm_Load(object sender, EventArgs e)
        {
            urun.urunListele(listViewUrunler);
            
            //MessageBox.Show(this.mevcutMusteriKAd);
        }
        
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            

            if (listViewUrunler.SelectedItems.Count > 0)
            {
                sepeteEkle();

            }

            this.Hide();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            Siparislerim siparislerim = new Siparislerim();
            siparislerim.Show();
            this.Hide();
        }

        private void btnSepetim_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            this.Hide();
        }

        private void listViewUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sepeteEkle()
        {
            
            urun.id = Convert.ToInt32(listViewUrunler.SelectedItems[0].SubItems[0].Text);
            urun.urunAdi = listViewUrunler.SelectedItems[0].SubItems[1].Text;
            urun.urunMiktari = Convert.ToInt32(listViewUrunler.SelectedItems[0].SubItems[2].Text);
            urun.urunAdeti = 1;
            urun.urunFiyati = Convert.ToDouble(listViewUrunler.SelectedItems[0].SubItems[4].Text);
            mevcutKullaniciVeriler();
            
            musteri.sepeteEkle(urun);
            urun.urunAdetGuncelle(urun.id);
            baglanti.connection().Close();
        }
        
        private void mevcutKullaniciVeriler()
        {
            
            string sorgu = "SELECT * FROM musteri_tablo WHERE kullanici_adi=@k_ad";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", mevcutMusteriKAd);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                musteri.id = Convert.ToInt32(reader["id"]);
                musteri.kullaniciAdi = reader["kullanici_adi"].ToString();
                musteri.adres = reader["adres"].ToString();
            }
            Sepetim sepet = new Sepetim();
            
            //reader.Close();
            baglanti.connection().Close();
        }

        private void AnaMenuMusteriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.Exit();
        }
    }


    
}
