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
    public partial class MusteriListeForm : Form
    {
        Musteri musteri = new Musteri();
        public MusteriListeForm()
        {
            InitializeComponent();
            musteri.musteriListeleListView(listViewMusteri);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(listViewMusteri.SelectedItems.Count > 0)
            {
                string item = listViewMusteri.SelectedItems[0].Text; // müşteri id alındı.
                MessageBox.Show(item);
            }
        }
    }
}
