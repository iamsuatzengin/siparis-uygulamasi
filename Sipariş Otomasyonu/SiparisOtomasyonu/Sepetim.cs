using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class Sepetim : Form
    {
        
        public Sepetim()
        {
            InitializeComponent();
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
    }
}
