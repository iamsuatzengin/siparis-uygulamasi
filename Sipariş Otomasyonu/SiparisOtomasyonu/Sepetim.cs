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
            Siparislerim siparislerim = new Siparislerim();
            siparislerim.Show();
            this.Hide();

            


        }

    }
}
