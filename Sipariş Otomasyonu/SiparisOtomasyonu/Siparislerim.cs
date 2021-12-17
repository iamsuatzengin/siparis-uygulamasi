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
    public partial class Siparislerim : Form
    {
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
    }
}
