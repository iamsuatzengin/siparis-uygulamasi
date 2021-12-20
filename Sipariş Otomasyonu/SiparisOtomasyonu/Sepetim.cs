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
            Cek cek = new Cek();
           

            if (tbCekAdi.Text==""|| tbCekId.Text=="")
            {
                MessageBox.Show(" Hatalı giriş!!");
                
            }
            else
            {
                MessageBox.Show(cek.Yetkilimesaj());
             
            }
           
            
           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kredi kredi = new Kredi();

            if (tbKartNo.Text=="" || tbTarih.Text=="" || tbCvc.Text=="")
            {
                MessageBox.Show("Hatalı giriş !!");
            }
            else
            {
                MessageBox.Show(kredi.Yetkilimesaj());
               

            }

         



        }

        private void btnAvNakit_Click(object sender, EventArgs e)
        {
           

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.tarih = DateTime.Now;
            siparis.toplamTutarHesapla();
            siparis.vergiHesapla();
            siparis.toplamAgirlikHesapla();

            MessageBox.Show(siparis.tarih.ToString()+" "+siparis.toplamTutarHesapla()+" "+siparis.vergiHesapla());
            
        }

        private void Sepetim_Load(object sender, EventArgs e)
        {

        }
    }
}
