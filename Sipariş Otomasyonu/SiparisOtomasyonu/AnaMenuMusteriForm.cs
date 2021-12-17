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
    public partial class AnaMenuMusteriForm : Form
    {
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
    }
}
