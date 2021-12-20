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
    public partial class AnaMenuForm : Form
    {
        Urun urunler = new Urun();
        
        public AnaMenuForm()
        {
            InitializeComponent();
        }
        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            urunler.urunListele(listViewUrunler);
        }
        private void btnMusteriListe_Click(object sender, EventArgs e)
        {
            MusteriListeForm musteriListeForm = new MusteriListeForm();
            musteriListeForm.Show();
        }

        private void listViewUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count > 0)
            {
                string item = listViewUrunler.SelectedItems[0].Text; // ürün id
                listViewUrunler.Items.Clear();
                urunler.urunCikar(Convert.ToInt32(item), listViewUrunler);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!");
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEklemeForm urunEklemeForm = new UrunEklemeForm();
            urunEklemeForm.listView = listViewUrunler;
            urunEklemeForm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunEklemeForm urunEklemeForm = new UrunEklemeForm();
            urunEklemeForm.listView = listViewUrunler;
            

            if (listViewUrunler.SelectedItems.Count > 0)
            {
                string item = listViewUrunler.SelectedItems[0].Text; // ürün id
                urunEklemeForm.id = Convert.ToInt32(item);
                urunEklemeForm.nereden = true;
                urunEklemeForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!");
            }
            
        }
    }
}
