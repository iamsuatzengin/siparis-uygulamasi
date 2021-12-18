
namespace SiparisOtomasyonu
{
    partial class AnaMenuForm
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
            System.Windows.Forms.Button btnUrunEkle;
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriListe = new System.Windows.Forms.Button();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.stnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.stnUrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            btnUrunEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new System.Drawing.Point(33, 79);
            btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new System.Drawing.Size(267, 55);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(793, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler Listesi";
            // 
            // btnMusteriListe
            // 
            this.btnMusteriListe.Location = new System.Drawing.Point(33, 567);
            this.btnMusteriListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriListe.Name = "btnMusteriListe";
            this.btnMusteriListe.Size = new System.Drawing.Size(267, 53);
            this.btnMusteriListe.TabIndex = 0;
            this.btnMusteriListe.Text = "Müşteri Listesi";
            this.btnMusteriListe.UseVisualStyleBackColor = true;
            this.btnMusteriListe.Click += new System.EventHandler(this.btnMusteriListe_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.Location = new System.Drawing.Point(33, 249);
            this.btnUrunCikar.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(267, 53);
            this.btnUrunCikar.TabIndex = 3;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = true;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnId,
            this.stnUrunAdi,
            this.stnUrunMiktari,
            this.stnUrunAdedi,
            this.stnUrunFiyati});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(367, 79);
            this.listViewUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(1065, 541);
            this.listViewUrunler.TabIndex = 4;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            this.listViewUrunler.View = System.Windows.Forms.View.Details;
            this.listViewUrunler.SelectedIndexChanged += new System.EventHandler(this.listViewUrunler_SelectedIndexChanged);
            // 
            // stnId
            // 
            this.stnId.Text = "Sıra";
            this.stnId.Width = 100;
            // 
            // stnUrunAdi
            // 
            this.stnUrunAdi.Text = "Ürün Adı";
            this.stnUrunAdi.Width = 250;
            // 
            // stnUrunMiktari
            // 
            this.stnUrunMiktari.Text = "Ürün Miktarı";
            this.stnUrunMiktari.Width = 200;
            // 
            // stnUrunAdedi
            // 
            this.stnUrunAdedi.Text = "Ürün Adedi";
            this.stnUrunAdedi.Width = 200;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(33, 413);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(267, 51);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // stnUrunFiyati
            // 
            this.stnUrunFiyati.Text = "Ürün Fiyati";
            this.stnUrunFiyati.Width = 100;
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 759);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.listViewUrunler);
            this.Controls.Add(this.btnUrunCikar);
            this.Controls.Add(this.btnMusteriListe);
            this.Controls.Add(btnUrunEkle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaMenuForm";
            this.Text = "AnaMenuForm";
            this.Load += new System.EventHandler(this.AnaMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriListe;
        private System.Windows.Forms.Button btnUrunCikar;
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.ColumnHeader stnUrunAdi;
        private System.Windows.Forms.ColumnHeader stnUrunMiktari;
        private System.Windows.Forms.ColumnHeader stnUrunAdedi;
        private System.Windows.Forms.ColumnHeader stnId;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ColumnHeader stnUrunFiyati;
    }
}