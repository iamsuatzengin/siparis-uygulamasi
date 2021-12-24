
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
            this.lblsiparişlerim = new System.Windows.Forms.Label();
            this.listViewSiparisler = new System.Windows.Forms.ListView();
            this.stnSiparisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stntarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnanageridon = new System.Windows.Forms.Button();
            this.button1_ = new System.Windows.Forms.Button();
            this.btnbilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsiparişlerim
            // 
            this.lblsiparişlerim.AutoSize = true;
            this.lblsiparişlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsiparişlerim.Location = new System.Drawing.Point(452, 39);
            this.lblsiparişlerim.Name = "lblsiparişlerim";
            this.lblsiparişlerim.Size = new System.Drawing.Size(228, 46);
            this.lblsiparişlerim.TabIndex = 0;
            this.lblsiparişlerim.Text = "Siparişlerim";
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
            this.btnanageridon.Location = new System.Drawing.Point(450, 604);
            this.btnanageridon.Name = "btnanageridon";
            this.btnanageridon.Size = new System.Drawing.Size(230, 77);
            this.btnanageridon.TabIndex = 2;
            this.btnanageridon.Text = "Ana Menü Geri Dön";
            this.btnanageridon.UseVisualStyleBackColor = true;
            this.btnanageridon.Click += new System.EventHandler(this.btnanageridon_Click);
            // 
            // button1_
            // 
            this.button1_.Location = new System.Drawing.Point(804, 168);
            this.button1_.Name = "button1_";
            this.button1_.Size = new System.Drawing.Size(278, 99);
            this.button1_.TabIndex = 3;
            this.button1_.Text = "Sipariş Detayı";
            this.button1_.UseVisualStyleBackColor = true;
            this.button1_.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnbilgi
            // 
            this.btnbilgi.Location = new System.Drawing.Point(804, 394);
            this.btnbilgi.Name = "btnbilgi";
            this.btnbilgi.Size = new System.Drawing.Size(278, 97);
            this.btnbilgi.TabIndex = 4;
            this.btnbilgi.Text = "Ödeme Bilgilerim";
            this.btnbilgi.UseVisualStyleBackColor = true;
            this.btnbilgi.Click += new System.EventHandler(this.btnbilgi_Click);
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 744);
            this.Controls.Add(this.btnbilgi);
            this.Controls.Add(this.button1_);
            this.Controls.Add(this.btnanageridon);
            this.Controls.Add(this.listViewSiparisler);
            this.Controls.Add(this.lblsiparişlerim);
            this.Name = "Siparislerim";
            this.Text = "Siparislerim";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
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
    }
}