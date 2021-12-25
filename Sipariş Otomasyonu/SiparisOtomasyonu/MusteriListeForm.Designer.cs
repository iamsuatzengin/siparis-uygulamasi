

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
            this.label1 = new System.Windows.Forms.Label();
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
            this.listViewMusteri.Location = new System.Drawing.Point(108, 153);
            this.listViewMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMusteri.Name = "listViewMusteri";
            this.listViewMusteri.Size = new System.Drawing.Size(884, 511);
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
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.Location = new System.Drawing.Point(1088, 571);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(223, 93);
            this.btn.TabIndex = 1;
            this.btn.Text = "Ana Menüye Dön";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(344, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÜŞTERİ LİSTESİ";
            // 
            // MusteriListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.listViewMusteri);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriListeForm";
            this.Text = "MusteriListeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}