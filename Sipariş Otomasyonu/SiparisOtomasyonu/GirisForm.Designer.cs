
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
            this.groupBoxGiris.SuspendLayout();
            this.groupBoxKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.Controls.Add(this.rbMusteriGiris);
            this.groupBoxGiris.Controls.Add(this.rbYoneticiGiris);
            this.groupBoxGiris.Controls.Add(this.lblGirisYap);
            this.groupBoxGiris.Controls.Add(this.lblSifre);
            this.groupBoxGiris.Controls.Add(this.lblKullaniciAdi);
            this.groupBoxGiris.Controls.Add(this.btnGiris);
            this.groupBoxGiris.Controls.Add(this.tbSifre);
            this.groupBoxGiris.Controls.Add(this.tbKullaniciAdi);
            this.groupBoxGiris.Location = new System.Drawing.Point(33, 63);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Size = new System.Drawing.Size(485, 400);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            // 
            // rbMusteriGiris
            // 
            this.rbMusteriGiris.AutoSize = true;
            this.rbMusteriGiris.Location = new System.Drawing.Point(248, 114);
            this.rbMusteriGiris.Name = "rbMusteriGiris";
            this.rbMusteriGiris.Size = new System.Drawing.Size(59, 17);
            this.rbMusteriGiris.TabIndex = 7;
            this.rbMusteriGiris.TabStop = true;
            this.rbMusteriGiris.Text = "Müşteri";
            this.rbMusteriGiris.UseVisualStyleBackColor = true;
            // 
            // rbYoneticiGiris
            // 
            this.rbYoneticiGiris.AutoSize = true;
            this.rbYoneticiGiris.Location = new System.Drawing.Point(179, 114);
            this.rbYoneticiGiris.Name = "rbYoneticiGiris";
            this.rbYoneticiGiris.Size = new System.Drawing.Size(63, 17);
            this.rbYoneticiGiris.TabIndex = 6;
            this.rbYoneticiGiris.TabStop = true;
            this.rbYoneticiGiris.Text = "Yönetici";
            this.rbYoneticiGiris.UseVisualStyleBackColor = true;
            // 
            // lblGirisYap
            // 
            this.lblGirisYap.AutoSize = true;
            this.lblGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYap.Location = new System.Drawing.Point(153, 48);
            this.lblGirisYap.Name = "lblGirisYap";
            this.lblGirisYap.Size = new System.Drawing.Size(165, 39);
            this.lblGirisYap.TabIndex = 5;
            this.lblGirisYap.Text = "Giriş Yap";
            this.lblGirisYap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(95, 214);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(31, 13);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(59, 162);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(261, 250);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(132, 207);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(204, 20);
            this.tbSifre.TabIndex = 1;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbKullaniciAdi.Location = new System.Drawing.Point(132, 155);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(204, 20);
            this.tbKullaniciAdi.TabIndex = 0;
            // 
            // groupBoxKayit
            // 
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
            this.groupBoxKayit.Location = new System.Drawing.Point(551, 63);
            this.groupBoxKayit.Name = "groupBoxKayit";
            this.groupBoxKayit.Size = new System.Drawing.Size(485, 400);
            this.groupBoxKayit.TabIndex = 1;
            this.groupBoxKayit.TabStop = false;
            // 
            // tbMusteri
            // 
            this.tbMusteri.AutoSize = true;
            this.tbMusteri.Location = new System.Drawing.Point(274, 99);
            this.tbMusteri.Name = "tbMusteri";
            this.tbMusteri.Size = new System.Drawing.Size(59, 17);
            this.tbMusteri.TabIndex = 20;
            this.tbMusteri.TabStop = true;
            this.tbMusteri.Text = "Müşteri";
            this.tbMusteri.UseVisualStyleBackColor = true;
            this.tbMusteri.CheckedChanged += new System.EventHandler(this.tbMusteri_CheckedChanged);
            // 
            // rbYonetici
            // 
            this.rbYonetici.AutoSize = true;
            this.rbYonetici.Location = new System.Drawing.Point(205, 99);
            this.rbYonetici.Name = "rbYonetici";
            this.rbYonetici.Size = new System.Drawing.Size(63, 17);
            this.rbYonetici.TabIndex = 19;
            this.rbYonetici.TabStop = true;
            this.rbYonetici.Text = "Yönetici";
            this.rbYonetici.UseVisualStyleBackColor = true;
            this.rbYonetici.CheckedChanged += new System.EventHandler(this.rbYonetici_CheckedChanged);
            // 
            // lblTelefonKayit
            // 
            this.lblTelefonKayit.AutoSize = true;
            this.lblTelefonKayit.Location = new System.Drawing.Point(113, 224);
            this.lblTelefonKayit.Name = "lblTelefonKayit";
            this.lblTelefonKayit.Size = new System.Drawing.Size(46, 13);
            this.lblTelefonKayit.TabIndex = 18;
            this.lblTelefonKayit.Text = "Telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(165, 217);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(204, 20);
            this.tbTelefon.TabIndex = 17;
            // 
            // lblSifreKayit
            // 
            this.lblSifreKayit.AutoSize = true;
            this.lblSifreKayit.Location = new System.Drawing.Point(128, 279);
            this.lblSifreKayit.Name = "lblSifreKayit";
            this.lblSifreKayit.Size = new System.Drawing.Size(31, 13);
            this.lblSifreKayit.TabIndex = 16;
            this.lblSifreKayit.Text = "Şifre:";
            // 
            // lblKullaniciAdiKayit
            // 
            this.lblKullaniciAdiKayit.AutoSize = true;
            this.lblKullaniciAdiKayit.Location = new System.Drawing.Point(92, 250);
            this.lblKullaniciAdiKayit.Name = "lblKullaniciAdiKayit";
            this.lblKullaniciAdiKayit.Size = new System.Drawing.Size(67, 13);
            this.lblKullaniciAdiKayit.TabIndex = 15;
            this.lblKullaniciAdiKayit.Text = "Kullanıcı Adı:";
            // 
            // lblAdresKayit
            // 
            this.lblAdresKayit.AutoSize = true;
            this.lblAdresKayit.Location = new System.Drawing.Point(122, 197);
            this.lblAdresKayit.Name = "lblAdresKayit";
            this.lblAdresKayit.Size = new System.Drawing.Size(37, 13);
            this.lblAdresKayit.TabIndex = 14;
            this.lblAdresKayit.Text = "Adres:";
            // 
            // lblSoyadKayit
            // 
            this.lblSoyadKayit.AutoSize = true;
            this.lblSoyadKayit.Location = new System.Drawing.Point(119, 171);
            this.lblSoyadKayit.Name = "lblSoyadKayit";
            this.lblSoyadKayit.Size = new System.Drawing.Size(40, 13);
            this.lblSoyadKayit.TabIndex = 13;
            this.lblSoyadKayit.Text = "Soyad:";
            // 
            // lblAdKayit
            // 
            this.lblAdKayit.AutoSize = true;
            this.lblAdKayit.Location = new System.Drawing.Point(136, 145);
            this.lblAdKayit.Name = "lblAdKayit";
            this.lblAdKayit.Size = new System.Drawing.Size(23, 13);
            this.lblAdKayit.TabIndex = 12;
            this.lblAdKayit.Text = "Ad:";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(294, 317);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(75, 23);
            this.btnKayitOl.TabIndex = 11;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // tbSifreKayit
            // 
            this.tbSifreKayit.Location = new System.Drawing.Point(165, 272);
            this.tbSifreKayit.Name = "tbSifreKayit";
            this.tbSifreKayit.Size = new System.Drawing.Size(204, 20);
            this.tbSifreKayit.TabIndex = 10;
            this.tbSifreKayit.UseSystemPasswordChar = true;
            // 
            // tbKullaniciAdiKayit
            // 
            this.tbKullaniciAdiKayit.Location = new System.Drawing.Point(165, 243);
            this.tbKullaniciAdiKayit.Name = "tbKullaniciAdiKayit";
            this.tbKullaniciAdiKayit.Size = new System.Drawing.Size(204, 20);
            this.tbKullaniciAdiKayit.TabIndex = 9;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(165, 190);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(204, 20);
            this.tbAdres.TabIndex = 8;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(165, 164);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(204, 20);
            this.tbSoyad.TabIndex = 7;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(165, 138);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(204, 20);
            this.tbAd.TabIndex = 6;
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.Location = new System.Drawing.Point(198, 48);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(144, 39);
            this.lblKayit.TabIndex = 5;
            this.lblKayit.Text = "Kayıt Ol";
            this.lblKayit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 552);
            this.Controls.Add(this.groupBoxKayit);
            this.Controls.Add(this.groupBoxGiris);
            this.Name = "GirisForm";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.groupBoxKayit.ResumeLayout(false);
            this.groupBoxKayit.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

