
namespace SiparisOtomasyonu
{
    partial class Sepetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sepetim));
            this.listViewSepet = new System.Windows.Forms.ListView();
            this.stnUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnToplamFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcOdeme = new System.Windows.Forms.TabControl();
            this.krediKart = new System.Windows.Forms.TabPage();
            this.tarih = new System.Windows.Forms.TextBox();
            this.lblCvc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.tbCvc = new System.Windows.Forms.TextBox();
            this.tbKartNo = new System.Windows.Forms.TextBox();
            this.cek = new System.Windows.Forms.TabPage();
            this.btnCekileTamamla = new System.Windows.Forms.Button();
            this.tbCekId = new System.Windows.Forms.TextBox();
            this.lblCekId = new System.Windows.Forms.Label();
            this.lblCekAdi = new System.Windows.Forms.Label();
            this.tbCekAdi = new System.Windows.Forms.TextBox();
            this.nakit = new System.Windows.Forms.TabPage();
            this.btnNakitileTamamla = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tcOdeme.SuspendLayout();
            this.krediKart.SuspendLayout();
            this.cek.SuspendLayout();
            this.nakit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSepet
            // 
            this.listViewSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnUrunAdi,
            this.stnUrunMiktari,
            this.stnUrunAdedi,
            this.stnToplamFiyat});
            this.listViewSepet.HideSelection = false;
            this.listViewSepet.Location = new System.Drawing.Point(23, 153);
            this.listViewSepet.Name = "listViewSepet";
            this.listViewSepet.Size = new System.Drawing.Size(586, 450);
            this.listViewSepet.TabIndex = 1;
            this.listViewSepet.UseCompatibleStateImageBehavior = false;
            this.listViewSepet.View = System.Windows.Forms.View.Details;
            this.listViewSepet.SelectedIndexChanged += new System.EventHandler(this.listViewSepet_SelectedIndexChanged);
            // 
            // stnUrunAdi
            // 
            this.stnUrunAdi.Text = "Ürün Adı";
            this.stnUrunAdi.Width = 220;
            // 
            // stnUrunMiktari
            // 
            this.stnUrunMiktari.Text = "Ürün Miktarı";
            this.stnUrunMiktari.Width = 120;
            // 
            // stnUrunAdedi
            // 
            this.stnUrunAdedi.Text = "Ürün Adeti";
            this.stnUrunAdedi.Width = 120;
            // 
            // stnToplamFiyat
            // 
            this.stnToplamFiyat.Text = "Ürün Fiyati";
            this.stnToplamFiyat.Width = 120;
            // 
            // tcOdeme
            // 
            this.tcOdeme.Controls.Add(this.krediKart);
            this.tcOdeme.Controls.Add(this.cek);
            this.tcOdeme.Controls.Add(this.nakit);
            this.tcOdeme.Location = new System.Drawing.Point(638, 153);
            this.tcOdeme.Name = "tcOdeme";
            this.tcOdeme.SelectedIndex = 0;
            this.tcOdeme.Size = new System.Drawing.Size(538, 322);
            this.tcOdeme.TabIndex = 2;
            // 
            // krediKart
            // 
            this.krediKart.Controls.Add(this.tarih);
            this.krediKart.Controls.Add(this.lblCvc);
            this.krediKart.Controls.Add(this.label2);
            this.krediKart.Controls.Add(this.lblKartNo);
            this.krediKart.Controls.Add(this.btnTamamla);
            this.krediKart.Controls.Add(this.tbCvc);
            this.krediKart.Controls.Add(this.tbKartNo);
            this.krediKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.krediKart.Location = new System.Drawing.Point(4, 25);
            this.krediKart.Margin = new System.Windows.Forms.Padding(15);
            this.krediKart.Name = "krediKart";
            this.krediKart.Padding = new System.Windows.Forms.Padding(3);
            this.krediKart.Size = new System.Drawing.Size(530, 293);
            this.krediKart.TabIndex = 0;
            this.krediKart.Text = "Kredi Kartı";
            this.krediKart.UseVisualStyleBackColor = true;
            this.krediKart.Click += new System.EventHandler(this.krediKart_Click);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(221, 116);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(276, 23);
            this.tarih.TabIndex = 6;
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCvc.Location = new System.Drawing.Point(137, 173);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(53, 20);
            this.lblCvc.TabIndex = 5;
            this.lblCvc.Text = "CVC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Son Kullanma Tarihi:";
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNo.Location = new System.Drawing.Point(111, 69);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(79, 20);
            this.lblKartNo.TabIndex = 3;
            this.lblKartNo.Text = "Kart No:";
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.White;
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(270, 226);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(227, 44);
            this.btnTamamla.TabIndex = 3;
            this.btnTamamla.Text = "Alışverişi Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // tbCvc
            // 
            this.tbCvc.Location = new System.Drawing.Point(221, 170);
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.Size = new System.Drawing.Size(276, 23);
            this.tbCvc.TabIndex = 2;
            // 
            // tbKartNo
            // 
            this.tbKartNo.Location = new System.Drawing.Point(221, 66);
            this.tbKartNo.Name = "tbKartNo";
            this.tbKartNo.Size = new System.Drawing.Size(276, 23);
            this.tbKartNo.TabIndex = 0;
            this.tbKartNo.TextChanged += new System.EventHandler(this.tbKartNo_TextChanged);
            // 
            // cek
            // 
            this.cek.Controls.Add(this.btnCekileTamamla);
            this.cek.Controls.Add(this.tbCekId);
            this.cek.Controls.Add(this.lblCekId);
            this.cek.Controls.Add(this.lblCekAdi);
            this.cek.Controls.Add(this.tbCekAdi);
            this.cek.Location = new System.Drawing.Point(4, 25);
            this.cek.Name = "cek";
            this.cek.Padding = new System.Windows.Forms.Padding(3);
            this.cek.Size = new System.Drawing.Size(530, 293);
            this.cek.TabIndex = 1;
            this.cek.Text = "Çek";
            this.cek.UseVisualStyleBackColor = true;
            // 
            // btnCekileTamamla
            // 
            this.btnCekileTamamla.Location = new System.Drawing.Point(296, 229);
            this.btnCekileTamamla.Name = "btnCekileTamamla";
            this.btnCekileTamamla.Size = new System.Drawing.Size(150, 44);
            this.btnCekileTamamla.TabIndex = 6;
            this.btnCekileTamamla.Text = "Alışverişi Tamamla";
            this.btnCekileTamamla.UseVisualStyleBackColor = true;
            this.btnCekileTamamla.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbCekId
            // 
            this.tbCekId.Location = new System.Drawing.Point(180, 149);
            this.tbCekId.Name = "tbCekId";
            this.tbCekId.Size = new System.Drawing.Size(266, 22);
            this.tbCekId.TabIndex = 2;
            // 
            // lblCekId
            // 
            this.lblCekId.AutoSize = true;
            this.lblCekId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekId.Location = new System.Drawing.Point(87, 149);
            this.lblCekId.Name = "lblCekId";
            this.lblCekId.Size = new System.Drawing.Size(31, 20);
            this.lblCekId.TabIndex = 1;
            this.lblCekId.Text = "ID:";
            // 
            // lblCekAdi
            // 
            this.lblCekAdi.AutoSize = true;
            this.lblCekAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekAdi.Location = new System.Drawing.Point(87, 84);
            this.lblCekAdi.Name = "lblCekAdi";
            this.lblCekAdi.Size = new System.Drawing.Size(34, 20);
            this.lblCekAdi.TabIndex = 1;
            this.lblCekAdi.Text = "Ad:";
            // 
            // tbCekAdi
            // 
            this.tbCekAdi.Location = new System.Drawing.Point(180, 82);
            this.tbCekAdi.Name = "tbCekAdi";
            this.tbCekAdi.Size = new System.Drawing.Size(266, 22);
            this.tbCekAdi.TabIndex = 0;
            // 
            // nakit
            // 
            this.nakit.Controls.Add(this.btnNakitileTamamla);
            this.nakit.Controls.Add(this.lblTutar);
            this.nakit.Location = new System.Drawing.Point(4, 25);
            this.nakit.Name = "nakit";
            this.nakit.Padding = new System.Windows.Forms.Padding(3);
            this.nakit.Size = new System.Drawing.Size(530, 293);
            this.nakit.TabIndex = 2;
            this.nakit.Text = "Nakit";
            this.nakit.UseVisualStyleBackColor = true;
            // 
            // btnNakitileTamamla
            // 
            this.btnNakitileTamamla.Location = new System.Drawing.Point(319, 210);
            this.btnNakitileTamamla.Name = "btnNakitileTamamla";
            this.btnNakitileTamamla.Size = new System.Drawing.Size(150, 44);
            this.btnNakitileTamamla.TabIndex = 5;
            this.btnNakitileTamamla.Text = "Alışverişi Tamamla";
            this.btnNakitileTamamla.UseVisualStyleBackColor = true;
            this.btnNakitileTamamla.Click += new System.EventHandler(this.btnNakitileTamamla_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(28, 132);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(401, 20);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Ödemeniz, kapıda ödeme olarak gerçekleştirilecektir.";
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.BackColor = System.Drawing.Color.White;
            this.btnDevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamEt.Location = new System.Drawing.Point(405, 619);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(204, 61);
            this.btnDevamEt.TabIndex = 4;
            this.btnDevamEt.Text = "Alışverişe Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = false;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.tcOdeme);
            this.Controls.Add(this.listViewSepet);
            this.Name = "Sepetim";
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.Sepetim_Load);
            this.tcOdeme.ResumeLayout(false);
            this.krediKart.ResumeLayout(false);
            this.krediKart.PerformLayout();
            this.cek.ResumeLayout(false);
            this.cek.PerformLayout();
            this.nakit.ResumeLayout(false);
            this.nakit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewSepet;
        private System.Windows.Forms.TabControl tcOdeme;
        private System.Windows.Forms.TabPage krediKart;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.TextBox tbKartNo;
        private System.Windows.Forms.TabPage cek;
        private System.Windows.Forms.TextBox tbCekId;
        private System.Windows.Forms.Label lblCekId;
        private System.Windows.Forms.Label lblCekAdi;
        private System.Windows.Forms.TextBox tbCekAdi;
        private System.Windows.Forms.TabPage nakit;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnNakitileTamamla;
        private System.Windows.Forms.Button btnCekileTamamla;
        private System.Windows.Forms.ColumnHeader stnUrunAdi;
        private System.Windows.Forms.ColumnHeader stnUrunMiktari;
        private System.Windows.Forms.ColumnHeader stnUrunAdedi;
        private System.Windows.Forms.ColumnHeader stnToplamFiyat;
        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}