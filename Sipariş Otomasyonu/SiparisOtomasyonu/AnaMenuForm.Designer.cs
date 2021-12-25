
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriListe = new System.Windows.Forms.Button();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.stnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            btnUrunEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = System.Drawing.Color.White;
            btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnUrunEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnUrunEkle.Location = new System.Drawing.Point(13, 146);
            btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new System.Drawing.Size(213, 55);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(608, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜNLER LİSTESİ\r\n";
            // 
            // btnMusteriListe
            // 
            this.btnMusteriListe.BackColor = System.Drawing.Color.White;
            this.btnMusteriListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriListe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMusteriListe.Location = new System.Drawing.Point(40, 634);
            this.btnMusteriListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriListe.Name = "btnMusteriListe";
            this.btnMusteriListe.Size = new System.Drawing.Size(297, 53);
            this.btnMusteriListe.TabIndex = 0;
            this.btnMusteriListe.Text = "Müşteri Listesi";
            this.btnMusteriListe.UseVisualStyleBackColor = false;
            this.btnMusteriListe.Click += new System.EventHandler(this.btnMusteriListe_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.BackColor = System.Drawing.Color.White;
            this.btnUrunCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunCikar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUrunCikar.Location = new System.Drawing.Point(13, 313);
            this.btnUrunCikar.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(213, 53);
            this.btnUrunCikar.TabIndex = 3;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = false;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnId,
            this.stnUrunAdi,
            this.stnUrunMiktari,
            this.stnUrunAdedi,
            this.stnUrunFiyati});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(355, 146);
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
            // stnUrunFiyati
            // 
            this.stnUrunFiyati.Text = "Ürün Fiyati";
            this.stnUrunFiyati.Width = 300;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuncelle.Location = new System.Drawing.Point(13, 481);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(213, 51);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(232, 470);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(251, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1460, 759);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}