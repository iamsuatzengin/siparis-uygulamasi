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
    public partial class GirisForm : Form
    {
        Yonetici yonetici = new Yonetici();
        Musteri musteri = new Musteri();
        public GirisForm()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
        
        private void rbYonetici_CheckedChanged(object sender, EventArgs e)
        {
            tbAd.Enabled = false;
            tbSoyad.Enabled = false;
            tbAdres.Enabled = false;
            tbTelefon.Enabled = false;
        }

        private void tbMusteri_CheckedChanged(object sender, EventArgs e)
        {
            tbAd.Enabled = true;
            tbSoyad.Enabled = true;
            tbAdres.Enabled = true;
            tbTelefon.Enabled = true;
        }
        private void yoneticiGiris()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM yonetici_tablo WHERE kullanici_adi=@k_ad AND sifre=@sifre", sqlBaglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", tbKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", tbSifre.Text);

            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                MessageBox.Show("giris basarili" );

            }
            else
            {
                MessageBox.Show("Basarisiz");
            }
            sqlBaglanti.connection().Close();
        }

        private void musteriGiris()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM musteri_tablo WHERE kullanici_adi=@k_ad AND sifre=@sifre", sqlBaglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", tbKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", tbSifre.Text);

            SqlDataReader dataReader = komut.ExecuteReader();

            if (dataReader.Read())
            {
                MessageBox.Show("giris basarili - müşteri");
            }
            else
            {
                MessageBox.Show("Basarisiz - müşteri");
            }
            sqlBaglanti.connection().Close();

        }
        private void yoneticiKayit()
        {
            string sorgu = "INSERT INTO yonetici_tablo (kullanici_adi, sifre) values (@k_ad, @sifre)";
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", tbKullaniciAdiKayit.Text);
            komut.Parameters.AddWithValue("@sifre", tbSifreKayit.Text);

            komut.ExecuteNonQuery();
            sqlBaglanti.connection().Close();
        }
        private void musteriKayit()
        {
            musteri.ad = tbAd.Text;
            musteri.soyad = tbSoyad.Text;
            musteri.adres = tbAdres.Text;
            musteri.telefon = tbTelefon.Text;
            musteri.kullaniciAdi = tbKullaniciAdiKayit.Text;
            musteri.sifre = tbSifreKayit.Text;

            musteri.musteriKayit();
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            if(rbYoneticiGiris.Checked == true)
            {
                yoneticiGiris();
                AnaMenuForm anaMenuForm = new AnaMenuForm();
               
                anaMenuForm.Show();
            }
            else
            {
                musteriGiris();
                AnaMenuForm anaMenuForm = new AnaMenuForm();
                anaMenuForm.Show();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if(rbYonetici.Checked == true)
            {
                yoneticiKayit();
            }
            else
            {
                musteriKayit();
            }
        }
    }
}
