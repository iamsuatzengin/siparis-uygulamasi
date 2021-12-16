

namespace SiparisOtomasyonu
{
    partial class MusteriListeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewMusteri = new System.Windows.Forms.ListView();
            this.stnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnKullaniciAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMusteri
            // 
            this.listViewMusteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnId,
            this.stnAd,
            this.stnSoyad,
            this.stnAdres,
            this.stnTelefon,
            this.stnKullaniciAdi});
            this.listViewMusteri.FullRowSelect = true;
            this.listViewMusteri.GridLines = true;
            this.listViewMusteri.HideSelection = false;
            this.listViewMusteri.Location = new System.Drawing.Point(386, 34);
            this.listViewMusteri.Name = "listViewMusteri";
            this.listViewMusteri.Size = new System.Drawing.Size(664, 416);
            this.listViewMusteri.TabIndex = 0;
            this.listViewMusteri.UseCompatibleStateImageBehavior = false;
            this.listViewMusteri.View = System.Windows.Forms.View.Details;
            // 
            // stnId
            // 
            this.stnId.Text = "No";
            this.stnId.Width = 110;
            // 
            // stnAd
            // 
            this.stnAd.Text = "Ad";
            this.stnAd.Width = 110;
            // 
            // stnSoyad
            // 
            this.stnSoyad.Text = "Soyad";
            this.stnSoyad.Width = 110;
            // 
            // stnAdres
            // 
            this.stnAdres.Text = "Adres";
            this.stnAdres.Width = 110;
            // 
            // stnTelefon
            // 
            this.stnTelefon.Text = "Telefon";
            this.stnTelefon.Width = 110;
            // 
            // stnKullaniciAdi
            // 
            this.stnKullaniciAdi.Text = "Kullanıcı Adı";
            this.stnKullaniciAdi.Width = 110;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(953, 468);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(97, 44);
            this.btn.TabIndex = 1;
            this.btn.Text = "Musteri";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // MusteriListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 609);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.listViewMusteri);
            this.Name = "MusteriListeForm";
            this.Text = "MusteriListeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMusteri;
        private System.Windows.Forms.ColumnHeader stnId;
        private System.Windows.Forms.ColumnHeader stnAd;
        private System.Windows.Forms.ColumnHeader stnSoyad;
        private System.Windows.Forms.ColumnHeader stnAdres;
        private System.Windows.Forms.ColumnHeader stnTelefon;
        private System.Windows.Forms.ColumnHeader stnKullaniciAdi;
        private System.Windows.Forms.Button btn;
    }
}