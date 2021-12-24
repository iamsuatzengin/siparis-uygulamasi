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
    public partial class Siparislerim : Form
    {
        SqlBaglanti baglanti = new SqlBaglanti();

        Siparis siparis = new Siparis();
        public Kredi krediKartBilgileri;
        public Cek cekbilgikeri;
        public bool butonGizleme;
        public bool odemeSekli;
        public Siparislerim()
        {
            InitializeComponent();
        }

        private void btnanageridon_Click(object sender, EventArgs e)
        {
            AnaMenuMusteriForm anaMenuMusteriForm = new AnaMenuMusteriForm();
            anaMenuMusteriForm.Show();
            this.Hide();
        }
        private void Siparislerim_Load(object sender, EventArgs e)
        {
            siparisListele();
            btnbilgi.Visible = butonGizleme;
        }


        private void btnDetay_Click(object sender, EventArgs e)
        {

            siparis.siparisDetay();
        }

        private void siparisListele()
        {
            string sorgu = "SELECT * FROM siparislerim WHERE kullanici_adi = @k_ad";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            Sepetim sepetimForm = new Sepetim();
            string mevcutKullanici = sepetimForm.kullaniciAdi();
            komut.Parameters.AddWithValue("@k_ad", mevcutKullanici);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["tarih"].ToString());
                item.SubItems.Add(reader["durum"].ToString());
                listViewSiparisler.Items.Add(item);

                SiparisDetayi urun = new SiparisDetayi();
                urun.id = Convert.ToInt32(reader["urunID"].ToString());
                urun.urunAdi = reader["urun_adi"].ToString();
                urun.urunMiktari = Convert.ToInt32(reader["urun_miktari"]);
                urun.urunAdeti = Convert.ToInt32(reader["urun_adeti"]);
                urun.urunFiyati = Convert.ToDecimal(reader["urun_fiyati"].ToString());
                siparis.tarih = Convert.ToDateTime(reader["tarih"]);
                siparis.durum = reader["durum"].ToString();
                siparis.odeme += Convert.ToDouble(urun.urunFiyati);
                siparis.siparisDetayiListeDoldur(urun);
            }

            for (int i = 0; i < listViewSiparisler.Items.Count; i++)
            {
                if (listViewSiparisler.Items[i].SubItems[2].Text != "Beklemede")
                {
                    listViewSiparisler.Items[i].BackColor = Color.Yellow;
                }
            }

            baglanti.connection().Close();
        }

        private void btnbilgi_Click(object sender, EventArgs e)
        {
            if (odemeSekli)
            {
                MessageBox.Show("Kart No: " + krediKartBilgileri.Numara + "\nSKT" + krediKartBilgileri.SKT + "\nCVC" + krediKartBilgileri.CVC);
            }
            else
            {
                MessageBox.Show("Adı:" + cekbilgikeri.Adi + "\nBanka ID" + cekbilgikeri.BankaID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
