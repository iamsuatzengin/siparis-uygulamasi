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
            Kredi kredi = new Kredi();

            if (tbKartNo.Text == "" || tbTarih.Text == "" || tbCvc.Text == "")
            {
                MessageBox.Show("Hatalı giriş !!");
            }
            else
            {
                MessageBox.Show(kredi.Yetkilimesaj());


            }

        }

        private void krediKart_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cek cek = new Cek();


            if (tbCekAdi.Text == "" || tbCekId.Text == "")
            {
                MessageBox.Show(" Hatalı giriş!!");

            }
            else
            {
                MessageBox.Show(cek.Yetkilimesaj());

            }
        }

        private void btnNakitileTamamla_Click(object sender, EventArgs e)
        {

        }

        private void btnAvDetayi_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.tarih = DateTime.Now;
            siparis.toplamTutarHesapla();
            siparis.vergiHesapla();
            siparis.toplamAgirlikHesapla();

            MessageBox.Show(siparis.tarih.ToString() + " " + siparis.toplamTutarHesapla() + " " + siparis.vergiHesapla());
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
                item.SubItems.Add(reader["toplam_fiyat"].ToString());

                listViewSepet.Items.Add(item);
            }
        }

        private string kullaniciAdi()
        {
            string kullaniciAdi = "";
            string sorgu = "SELECT * FROM giris_kayitlari_tablo";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                kullaniciAdi = reader["kullanici_adi"].ToString();
            }


            return kullaniciAdi;
        }

        private void listViewSepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
