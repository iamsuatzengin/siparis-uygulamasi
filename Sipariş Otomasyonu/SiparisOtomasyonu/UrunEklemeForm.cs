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
    public partial class UrunEklemeForm : Form
    {
        SqlBaglanti baglanti = new SqlBaglanti();
        Urun urun = new Urun();
        public ListView listView;
        public int id;
        public bool nereden; // true -> Güncelleme butonundan geleni ifade eder.
        public UrunEklemeForm()
        {
            InitializeComponent();
            
        }
        private void UrunEklemeForm_Load(object sender, EventArgs e)
        {
            textBoxDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (nereden)
            {
                // güncelleme
                urun.urunAdi = tbUrunAdi.Text;
                urun.urunMiktari = Convert.ToInt32(tbUrunMiktari.Text);
                urun.urunAdeti = Convert.ToInt32(tbUrunAdet.Text);
                urun.urunFiyati = float.Parse(tbUrunFiyat.Text);
                urun.urunFiyati = Math.Round(urun.urunFiyati, 2);

                urun.urunGuncelle(this.id);
                listView.Items.Clear();
                urun.urunListele(listView);
            }
            else
            {
                string urunAdi = tbUrunAdi.Text;
                int urunMiktari = Convert.ToInt32(tbUrunMiktari.Text);
                int urunAdedi = Convert.ToInt32(tbUrunAdet.Text);
                double urunFiyat = float.Parse(tbUrunFiyat.Text);
                urunFiyat = Math.Round(urunFiyat, 2); ;

                urun.urunAdi = urunAdi;
                urun.urunMiktari = urunMiktari;
                urun.urunAdeti = urunAdedi;
                urun.urunFiyati = urunFiyat;
                urun.urunEkle();
                listView.Items.Clear();
                urun.urunListele(listView);
            }
            
            this.Hide();
        }
        private void textBoxDoldur()
        {
            if (nereden)
            {
                string sorgu = "SELECT * FROM urun_detayi WHERE id=@id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti.connection());

                komut.Parameters.AddWithValue("@id", this.id);
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    tbUrunAdi.Text = dataReader["urun_adi"].ToString();
                    tbUrunMiktari.Text = dataReader["urun_miktari"].ToString();
                    tbUrunAdet.Text = dataReader["urun_adedi"].ToString();
                    tbUrunFiyat.Text = dataReader["urun_fiyati"].ToString();
                }
            }
            else
            {
                tbUrunAdi.Text = "";
                tbUrunMiktari.Text = "";
                tbUrunAdet.Text = "";
                tbUrunFiyat.Text = "";

            }
            
            baglanti.connection().Close();
        }

        
    }
}
