
namespace SiparisOtomasyonu
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.rbMusteriGiris = new System.Windows.Forms.RadioButton();
            this.rbYoneticiGiris = new System.Windows.Forms.RadioButton();
            this.lblGirisYap = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBoxKayit = new System.Windows.Forms.GroupBox();
            this.tbMusteri = new System.Windows.Forms.RadioButton();
            this.rbYonetici = new System.Windows.Forms.RadioButton();
            this.lblTelefonKayit = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lblSifreKayit = new System.Windows.Forms.Label();
            this.lblKullaniciAdiKayit = new System.Windows.Forms.Label();
            this.lblAdresKayit = new System.Windows.Forms.Label();
            this.lblSoyadKayit = new System.Windows.Forms.Label();
            this.lblAdKayit = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.tbSifreKayit = new System.Windows.Forms.TextBox();
            this.tbKullaniciAdiKayit = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.lblKayit = new System.Windows.Forms.Label();
            this.lbSİTEADI = new System.Windows.Forms.Label();
            this.groupBoxGiris.SuspendLayout();
            this.groupBoxKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxGiris.Controls.Add(this.rbMusteriGiris);
            this.groupBoxGiris.Controls.Add(this.rbYoneticiGiris);
            this.groupBoxGiris.Controls.Add(this.lblGirisYap);
            this.groupBoxGiris.Controls.Add(this.lblSifre);
            this.groupBoxGiris.Controls.Add(this.lblKullaniciAdi);
            this.groupBoxGiris.Controls.Add(this.btnGiris);
            this.groupBoxGiris.Controls.Add(this.tbSifre);
            this.groupBoxGiris.Controls.Add(this.tbKullaniciAdi);
            this.groupBoxGiris.Location = new System.Drawing.Point(188, 179);
            this.groupBoxGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGiris.Size = new System.Drawing.Size(465, 418);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            // 
            // rbMusteriGiris
            // 
            this.rbMusteriGiris.AutoSize = true;
            this.rbMusteriGiris.BackColor = System.Drawing.Color.Transparent;
            this.rbMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMusteriGiris.ForeColor = System.Drawing.Color.Black;
            this.rbMusteriGiris.Location = new System.Drawing.Point(272, 129);
            this.rbMusteriGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMusteriGiris.Name = "rbMusteriGiris";
            this.rbMusteriGiris.Size = new System.Drawing.Size(93, 24);
            this.rbMusteriGiris.TabIndex = 7;
            this.rbMusteriGiris.TabStop = true;
            this.rbMusteriGiris.Text = "Müşteri";
            this.rbMusteriGiris.UseVisualStyleBackColor = false;
            // 
            // rbYoneticiGiris
            // 
            this.rbYoneticiGiris.AutoSize = true;
            this.rbYoneticiGiris.BackColor = System.Drawing.Color.Transparent;
            this.rbYoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYoneticiGiris.Location = new System.Drawing.Point(172, 129);
            this.rbYoneticiGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbYoneticiGiris.Name = "rbYoneticiGiris";
            this.rbYoneticiGiris.Size = new System.Drawing.Size(97, 24);
            this.rbYoneticiGiris.TabIndex = 6;
            this.rbYoneticiGiris.TabStop = true;
            this.rbYoneticiGiris.Text = "Yönetici";
            this.rbYoneticiGiris.UseVisualStyleBackColor = false;
            // 
            // lblGirisYap
            // 
            this.lblGirisYap.AutoSize = true;
            this.lblGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYap.Location = new System.Drawing.Point(164, 19);
            this.lblGirisYap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGirisYap.Name = "lblGirisYap";
            this.lblGirisYap.Size = new System.Drawing.Size(202, 48);
            this.lblGirisYap.TabIndex = 5;
            this.lblGirisYap.Text = "Giriş Yap";
            this.lblGirisYap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(75, 236);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(55, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(37, 177);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(120, 20);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(280, 292);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 28);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(164, 236);
            this.tbSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(216, 22);
            this.tbSifre.TabIndex = 1;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbKullaniciAdi.Location = new System.Drawing.Point(164, 175);
            this.tbKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(216, 22);
            this.tbKullaniciAdi.TabIndex = 0;
            // 
            // groupBoxKayit
            // 
            this.groupBoxKayit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKayit.Controls.Add(this.tbMusteri);
            this.groupBoxKayit.Controls.Add(this.rbYonetici);
            this.groupBoxKayit.Controls.Add(this.lblTelefonKayit);
            this.groupBoxKayit.Controls.Add(this.tbTelefon);
            this.groupBoxKayit.Controls.Add(this.lblSifreKayit);
            this.groupBoxKayit.Controls.Add(this.lblKullaniciAdiKayit);
            this.groupBoxKayit.Controls.Add(this.lblAdresKayit);
            this.groupBoxKayit.Controls.Add(this.lblSoyadKayit);
            this.groupBoxKayit.Controls.Add(this.lblAdKayit);
            this.groupBoxKayit.Controls.Add(this.btnKayitOl);
            this.groupBoxKayit.Controls.Add(this.tbSifreKayit);
            this.groupBoxKayit.Controls.Add(this.tbKullaniciAdiKayit);
            this.groupBoxKayit.Controls.Add(this.tbAdres);
            this.groupBoxKayit.Controls.Add(this.tbSoyad);
            this.groupBoxKayit.Controls.Add(this.tbAd);
            this.groupBoxKayit.Controls.Add(this.lblKayit);
            this.groupBoxKayit.Location = new System.Drawing.Point(725, 179);
            this.groupBoxKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKayit.Name = "groupBoxKayit";
            this.groupBoxKayit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKayit.Size = new System.Drawing.Size(426, 418);
            this.groupBoxKayit.TabIndex = 1;
            this.groupBoxKayit.TabStop = false;
            // 
            // tbMusteri
            // 
            this.tbMusteri.AutoSize = true;
            this.tbMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMusteri.Location = new System.Drawing.Point(231, 95);
            this.tbMusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMusteri.Name = "tbMusteri";
            this.tbMusteri.Size = new System.Drawing.Size(93, 24);
            this.tbMusteri.TabIndex = 20;
            this.tbMusteri.TabStop = true;
            this.tbMusteri.Text = "Müşteri";
            this.tbMusteri.UseVisualStyleBackColor = true;
            this.tbMusteri.CheckedChanged += new System.EventHandler(this.tbMusteri_CheckedChanged);
            // 
            // rbYonetici
            // 
            this.rbYonetici.AutoSize = true;
            this.rbYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYonetici.Location = new System.Drawing.Point(139, 95);
            this.rbYonetici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbYonetici.Name = "rbYonetici";
            this.rbYonetici.Size = new System.Drawing.Size(97, 24);
            this.rbYonetici.TabIndex = 19;
            this.rbYonetici.TabStop = true;
            this.rbYonetici.Text = "Yönetici";
            this.rbYonetici.UseVisualStyleBackColor = true;
            this.rbYonetici.CheckedChanged += new System.EventHandler(this.rbYonetici_CheckedChanged);
            // 
            // lblTelefonKayit
            // 
            this.lblTelefonKayit.AutoSize = true;
            this.lblTelefonKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonKayit.Location = new System.Drawing.Point(54, 251);
            this.lblTelefonKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonKayit.Name = "lblTelefonKayit";
            this.lblTelefonKayit.Size = new System.Drawing.Size(77, 20);
            this.lblTelefonKayit.TabIndex = 18;
            this.lblTelefonKayit.Text = "Telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(139, 249);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(220, 22);
            this.tbTelefon.TabIndex = 17;
            // 
            // lblSifreKayit
            // 
            this.lblSifreKayit.AutoSize = true;
            this.lblSifreKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreKayit.Location = new System.Drawing.Point(76, 312);
            this.lblSifreKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreKayit.Name = "lblSifreKayit";
            this.lblSifreKayit.Size = new System.Drawing.Size(55, 20);
            this.lblSifreKayit.TabIndex = 16;
            this.lblSifreKayit.Text = "Şifre:";
            // 
            // lblKullaniciAdiKayit
            // 
            this.lblKullaniciAdiKayit.AutoSize = true;
            this.lblKullaniciAdiKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdiKayit.Location = new System.Drawing.Point(19, 283);
            this.lblKullaniciAdiKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdiKayit.Name = "lblKullaniciAdiKayit";
            this.lblKullaniciAdiKayit.Size = new System.Drawing.Size(120, 20);
            this.lblKullaniciAdiKayit.TabIndex = 15;
            this.lblKullaniciAdiKayit.Text = "Kullanıcı Adı:";
            // 
            // lblAdresKayit
            // 
            this.lblAdresKayit.AutoSize = true;
            this.lblAdresKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdresKayit.Location = new System.Drawing.Point(67, 214);
            this.lblAdresKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresKayit.Name = "lblAdresKayit";
            this.lblAdresKayit.Size = new System.Drawing.Size(64, 20);
            this.lblAdresKayit.TabIndex = 14;
            this.lblAdresKayit.Text = "Adres:";
            // 
            // lblSoyadKayit
            // 
            this.lblSoyadKayit.AutoSize = true;
            this.lblSoyadKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadKayit.Location = new System.Drawing.Point(65, 184);
            this.lblSoyadKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyadKayit.Name = "lblSoyadKayit";
            this.lblSoyadKayit.Size = new System.Drawing.Size(66, 20);
            this.lblSoyadKayit.TabIndex = 13;
            this.lblSoyadKayit.Text = "Soyad:";
            // 
            // lblAdKayit
            // 
            this.lblAdKayit.AutoSize = true;
            this.lblAdKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdKayit.Location = new System.Drawing.Point(94, 149);
            this.lblAdKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdKayit.Name = "lblAdKayit";
            this.lblAdKayit.Size = new System.Drawing.Size(37, 20);
            this.lblAdKayit.TabIndex = 12;
            this.lblAdKayit.Text = "Ad:";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.White;
            this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.Location = new System.Drawing.Point(236, 358);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(100, 28);
            this.btnKayitOl.TabIndex = 11;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // tbSifreKayit
            // 
            this.tbSifreKayit.Location = new System.Drawing.Point(139, 310);
            this.tbSifreKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSifreKayit.Name = "tbSifreKayit";
            this.tbSifreKayit.Size = new System.Drawing.Size(220, 22);
            this.tbSifreKayit.TabIndex = 10;
            this.tbSifreKayit.UseSystemPasswordChar = true;
            // 
            // tbKullaniciAdiKayit
            // 
            this.tbKullaniciAdiKayit.Location = new System.Drawing.Point(139, 280);
            this.tbKullaniciAdiKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKullaniciAdiKayit.Name = "tbKullaniciAdiKayit";
            this.tbKullaniciAdiKayit.Size = new System.Drawing.Size(220, 22);
            this.tbKullaniciAdiKayit.TabIndex = 9;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(139, 212);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(220, 22);
            this.tbAdres.TabIndex = 8;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(139, 182);
            this.tbSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(220, 22);
            this.tbSoyad.TabIndex = 7;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(139, 147);
            this.tbAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(220, 22);
            this.tbAd.TabIndex = 6;
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.Location = new System.Drawing.Point(148, 19);
            this.lblKayit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(176, 48);
            this.lblKayit.TabIndex = 5;
            this.lblKayit.Text = "Kayıt Ol";
            this.lblKayit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSİTEADI
            // 
            this.lbSİTEADI.AutoSize = true;
            this.lbSİTEADI.BackColor = System.Drawing.Color.Transparent;
            this.lbSİTEADI.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSİTEADI.ForeColor = System.Drawing.Color.Black;
            this.lbSİTEADI.Location = new System.Drawing.Point(379, 38);
            this.lbSİTEADI.Name = "lbSİTEADI";
            this.lbSİTEADI.Size = new System.Drawing.Size(693, 69);
            this.lbSİTEADI.TabIndex = 2;
            this.lbSİTEADI.Text = "ROJİN\'İ ÇOK SEVİYOM";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 679);
            this.Controls.Add(this.lbSİTEADI);
            this.Controls.Add(this.groupBoxKayit);
            this.Controls.Add(this.groupBoxGiris);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GirisForm";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.groupBoxKayit.ResumeLayout(false);
            this.groupBoxKayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Label lblGirisYap;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.GroupBox groupBoxKayit;
        private System.Windows.Forms.Label lblSifreKayit;
        private System.Windows.Forms.Label lblKullaniciAdiKayit;
        private System.Windows.Forms.Label lblAdresKayit;
        private System.Windows.Forms.Label lblSoyadKayit;
        private System.Windows.Forms.Label lblAdKayit;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox tbSifreKayit;
        private System.Windows.Forms.TextBox tbKullaniciAdiKayit;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.RadioButton tbMusteri;
        private System.Windows.Forms.RadioButton rbYonetici;
        private System.Windows.Forms.Label lblTelefonKayit;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.RadioButton rbMusteriGiris;
        private System.Windows.Forms.RadioButton rbYoneticiGiris;
        private System.Windows.Forms.Label lbSİTEADI;
    }
}

