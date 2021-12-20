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
        private bool girisOnaylama(SqlDataReader dataReader)
        {
            if (tbKullaniciAdi.Text == "" || tbSifre.Text == "")
            {
                MessageBox.Show("Basarisiz ");
                return false;
            }
            else
            {
                if (dataReader.Read())
                {
                    MessageBox.Show("Basarili");
                    return true;
                }
                MessageBox.Show("Basarisiz ");
                return false;
            }
        }
        private void yoneticiGiris()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM yonetici_table WHERE kullanici_adi=@k_ad AND sifre=@sifre", sqlBaglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", tbKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", tbSifre.Text);

            SqlDataReader dataReader = komut.ExecuteReader();
            
            if (girisOnaylama(dataReader))
            {
                AnaMenuForm anaMenuForm = new AnaMenuForm();
                anaMenuForm.Show();
                this.Hide();
            }
            sqlBaglanti.connection().Close();
        }
        
        private void musteriGiris()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM musteri_tablo WHERE kullanici_adi=@k_ad AND sifre=@sifre", sqlBaglanti.connection());
            komut.Parameters.AddWithValue("@k_ad", tbKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", tbSifre.Text);

            SqlDataReader dataReader = komut.ExecuteReader();

            
            if (girisOnaylama(dataReader))
            {
                AnaMenuMusteriForm anaMenuMusteriForm = new AnaMenuMusteriForm();
                anaMenuMusteriForm.mevcutMusteriKAd = tbKullaniciAdi.Text;
                anaMenuMusteriForm.Show();
                this.Hide();
            }
            sqlBaglanti.connection().Close();

        }
        private void yoneticiKayit()
        {

            if (tbKullaniciAdiKayit.Text == "" || tbSifreKayit.Text == "")
            {
                MessageBox.Show("Basarisiz ");
            }
            else
            {
                string sorgu = "INSERT INTO yonetici_table (kullanici_adi, sifre) values (@k_ad, @sifre)";
                SqlCommand komut = new SqlCommand(sorgu, sqlBaglanti.connection());
                komut.Parameters.AddWithValue("@k_ad", tbKullaniciAdiKayit.Text);
                komut.Parameters.AddWithValue("@sifre", tbSifreKayit.Text);

                komut.ExecuteNonQuery();
                sqlBaglanti.connection().Close();
                AnaMenuForm anaMenuForm = new AnaMenuForm();
                anaMenuForm.Show();
                this.Hide();
            }
            
            
        }
        private void musteriKayit()
        {
            if (tbAd.Text == "" || tbSoyad.Text == "" || tbAdres.Text == "" || tbTelefon.Text == "" || tbKullaniciAdiKayit.Text == "" || tbSifreKayit.Text == "") {
                MessageBox.Show("alanlar boş bırakılamaz!!");

            }
            else
            {
                musteri.ad = tbAd.Text;
                musteri.soyad = tbSoyad.Text;
                musteri.adres = tbAdres.Text;
                musteri.telefon = tbTelefon.Text;
                musteri.kullaniciAdi = tbKullaniciAdiKayit.Text;
                musteri.sifre = tbSifreKayit.Text;

                musteri.musteriKayit();
                AnaMenuMusteriForm anaMenuMusteriForm = new AnaMenuMusteriForm();
                anaMenuMusteriForm.Show();
                this.Hide();
            }
            
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            if(rbYoneticiGiris.Checked == true)
            {
                yoneticiGiris();
                
            }
            else
            {
                musteriGiris();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if(rbYonetici.Checked == true)
            {
                if (kullaniciKontrol("yonetici_table")) { 
                    yoneticiKayit();
                }
            }
            else 
            {
                if (kullaniciKontrol("musteri_tablo"))
                {
                    musteriKayit();
                }
            }
        }
        private bool kullaniciKontrol(String tablo)
        {
            string sorgu = "SELECT kullanici_adi FROM " + tablo;
            SqlCommand komut = new SqlCommand(sorgu, sqlBaglanti.connection());

            SqlDataReader dataReader = komut.ExecuteReader();

            List<String> musterilerKAd = new List<string>();
            string tbKullaniciAdi = tbKullaniciAdiKayit.Text;

            while (dataReader.Read()) {
                musterilerKAd.Add(dataReader["kullanici_adi"].ToString());
            }

            foreach (var kullaniciAd in musterilerKAd)
            {
                if (kullaniciAd == tbKullaniciAdi)
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı daha önce alınmış! Farklı bir kullanıcı adı deneyiniz.");
                    return false;
                }
            }

            dataReader.Close();
            sqlBaglanti.connection().Close();
            return true;
        }
    }
}
