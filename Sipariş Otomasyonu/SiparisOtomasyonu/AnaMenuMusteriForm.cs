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
        Urun urunler = new Urun();
        public AnaMenuMusteriForm()
        {
            InitializeComponent();
        }
        Urun urun = new Urun();
        private void AnaMenuMusteriForm_Load(object sender, EventArgs e)
        {
            urun.urunListele(listViewUrunler);
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
           
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            this.Hide();
            if (listViewUrunler.SelectedItems.Count > 0)
            {
                string item = listViewUrunler.SelectedItems[0].Text; // ürün id
                listViewUrunler.Items.Clear();
                urunler.urunGonder(Convert.ToInt32(item), listViewUrunler);

            }
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
    }
}
