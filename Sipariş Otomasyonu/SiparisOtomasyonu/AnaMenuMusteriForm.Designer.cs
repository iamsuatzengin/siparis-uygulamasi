
namespace SiparisOtomasyonu
{
    partial class AnaMenuMusteriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenuMusteriForm));
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.stnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSepetim = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnID,
            this.stnUrunAdi,
            this.stnUrunMiktari,
            this.stnUrunAdedi,
            this.stnUrunFiyati});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(324, 69);
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(905, 552);
            this.listViewUrunler.TabIndex = 1;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            this.listViewUrunler.View = System.Windows.Forms.View.Details;
            this.listViewUrunler.SelectedIndexChanged += new System.EventHandler(this.listViewUrunler_SelectedIndexChanged);
            // 
            // stnID
            // 
            this.stnID.Text = "Sıra";
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
            this.stnUrunFiyati.Text = "Ürün Fiyatı";
            this.stnUrunFiyati.Width = 100;
            // 
            // btnSiparislerim
            // 
            this.btnSiparislerim.BackColor = System.Drawing.Color.White;
            this.btnSiparislerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparislerim.Location = new System.Drawing.Point(58, 435);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(218, 70);
            this.btnSiparislerim.TabIndex = 2;
            this.btnSiparislerim.Text = "Siparişlerim";
            this.btnSiparislerim.UseVisualStyleBackColor = false;
            this.btnSiparislerim.Click += new System.EventHandler(this.btnSiparislerim_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.White;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSepeteEkle.Location = new System.Drawing.Point(1011, 648);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(218, 70);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSepetim
            // 
            this.btnSepetim.BackColor = System.Drawing.Color.White;
            this.btnSepetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepetim.Location = new System.Drawing.Point(58, 551);
            this.btnSepetim.Name = "btnSepetim";
            this.btnSepetim.Size = new System.Drawing.Size(218, 70);
            this.btnSepetim.TabIndex = 4;
            this.btnSepetim.Text = "Sepetim";
            this.btnSepetim.UseVisualStyleBackColor = false;
            this.btnSepetim.Click += new System.EventHandler(this.btnSepetim_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // AnaMenuMusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 763);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSepetim);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.listViewUrunler);
            this.Name = "AnaMenuMusteriForm";
            this.Text = "AnaMenuMusteriForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaMenuMusteriForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaMenuMusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.Button btnSiparislerim;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ColumnHeader stnUrunAdi;
        private System.Windows.Forms.ColumnHeader stnUrunMiktari;
        private System.Windows.Forms.ColumnHeader stnUrunAdedi;
        private System.Windows.Forms.Button btnSepetim;
        private System.Windows.Forms.ColumnHeader stnUrunFiyati;
        private System.Windows.Forms.ColumnHeader stnID;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}