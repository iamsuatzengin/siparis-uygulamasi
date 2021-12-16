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
        
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void btnMusteriListe_Click(object sender, EventArgs e)
        {
            MusteriListeForm musteriListeForm = new MusteriListeForm();
            musteriListeForm.Show();
        }
    }
}
