
namespace SiparisOtomasyonu
{
    partial class Siparislerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparislerim));
            this.lblsiparişlerim = new System.Windows.Forms.Label();
            this.listViewSiparisler = new System.Windows.Forms.ListView();
            this.stnSiparisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stntarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnanageridon = new System.Windows.Forms.Button();
            this.button1_ = new System.Windows.Forms.Button();
            this.btnbilgi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsiparişlerim
            // 
            this.lblsiparişlerim.AutoSize = true;
            this.lblsiparişlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsiparişlerim.ForeColor = System.Drawing.Color.White;
            this.lblsiparişlerim.Location = new System.Drawing.Point(156, 30);
            this.lblsiparişlerim.Name = "lblsiparişlerim";
            this.lblsiparişlerim.Size = new System.Drawing.Size(462, 69);
            this.lblsiparişlerim.TabIndex = 0;
            this.lblsiparişlerim.Text = "SİPARİŞLERİM";
            // 
            // listViewSiparisler
            // 
            this.listViewSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnSiparisID,
            this.stntarih,
            this.stnDurum});
            this.listViewSiparisler.HideSelection = false;
            this.listViewSiparisler.Location = new System.Drawing.Point(42, 131);
            this.listViewSiparisler.Name = "listViewSiparisler";
            this.listViewSiparisler.Size = new System.Drawing.Size(668, 440);
            this.listViewSiparisler.TabIndex = 1;
            this.listViewSiparisler.UseCompatibleStateImageBehavior = false;
            this.listViewSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // stnSiparisID
            // 
            this.stnSiparisID.Text = "#Sipariş ID";
            this.stnSiparisID.Width = 120;
            // 
            // stntarih
            // 
            this.stntarih.Text = "Tarih";
            this.stntarih.Width = 250;
            // 
            // stnDurum
            // 
            this.stnDurum.Text = "Sipariş Durumu";
            this.stnDurum.Width = 250;
            // 
            // btnanageridon
            // 
            this.btnanageridon.BackColor = System.Drawing.Color.White;
            this.btnanageridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanageridon.Location = new System.Drawing.Point(430, 605);
            this.btnanageridon.Name = "btnanageridon";
            this.btnanageridon.Size = new System.Drawing.Size(280, 71);
            this.btnanageridon.TabIndex = 2;
            this.btnanageridon.Text = "Ana Menüye Dön";
            this.btnanageridon.UseVisualStyleBackColor = false;
            this.btnanageridon.Click += new System.EventHandler(this.btnanageridon_Click);
            // 
            // button1_
            // 
            this.button1_.BackColor = System.Drawing.Color.White;
            this.button1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_.Location = new System.Drawing.Point(841, 149);
            this.button1_.Name = "button1_";
            this.button1_.Size = new System.Drawing.Size(278, 99);
            this.button1_.TabIndex = 3;
            this.button1_.Text = "Sipariş Detayı";
            this.button1_.UseVisualStyleBackColor = false;
            this.button1_.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnbilgi
            // 
            this.btnbilgi.BackColor = System.Drawing.Color.White;
            this.btnbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgi.Location = new System.Drawing.Point(841, 316);
            this.btnbilgi.Name = "btnbilgi";
            this.btnbilgi.Size = new System.Drawing.Size(278, 97);
            this.btnbilgi.TabIndex = 4;
            this.btnbilgi.Text = "Ödeme Bilgilerim";
            this.btnbilgi.UseVisualStyleBackColor = false;
            this.btnbilgi.Click += new System.EventHandler(this.btnbilgi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(786, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbilgi);
            this.Controls.Add(this.button1_);
            this.Controls.Add(this.btnanageridon);
            this.Controls.Add(this.listViewSiparisler);
            this.Controls.Add(this.lblsiparişlerim);
            this.Name = "Siparislerim";
            this.Text = "Siparislerim";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsiparişlerim;
        private System.Windows.Forms.ListView listViewSiparisler;
        private System.Windows.Forms.Button btnanageridon;
        private System.Windows.Forms.ColumnHeader stntarih;
        private System.Windows.Forms.ColumnHeader stnDurum;
        private System.Windows.Forms.Button button1_;
        private System.Windows.Forms.ColumnHeader stnSiparisID;
        public System.Windows.Forms.Button btnbilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}