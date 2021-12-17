
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
            this.lblAnaMenu = new System.Windows.Forms.Label();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.stnUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stnUrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSepetim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnaMenu
            // 
            this.lblAnaMenu.AutoSize = true;
            this.lblAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaMenu.Location = new System.Drawing.Point(509, 30);
            this.lblAnaMenu.Name = "lblAnaMenu";
            this.lblAnaMenu.Size = new System.Drawing.Size(247, 57);
            this.lblAnaMenu.TabIndex = 0;
            this.lblAnaMenu.Text = "Ana Menü";
            this.lblAnaMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stnUrunAdi,
            this.stnUrunMiktari,
            this.stnUrunAdedi});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(335, 106);
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(905, 552);
            this.listViewUrunler.TabIndex = 1;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            this.listViewUrunler.View = System.Windows.Forms.View.Details;
            // 
            // stnUrunAdi
            // 
            this.stnUrunAdi.Text = "Ürün Adı";
            this.stnUrunAdi.Width = 400;
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
            // btnSiparislerim
            // 
            this.btnSiparislerim.Location = new System.Drawing.Point(56, 106);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(174, 44);
            this.btnSiparislerim.TabIndex = 2;
            this.btnSiparislerim.Text = "Siparişlerim";
            this.btnSiparislerim.UseVisualStyleBackColor = true;
            this.btnSiparislerim.Click += new System.EventHandler(this.btnSiparislerim_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(1114, 677);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(126, 39);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSepetim
            // 
            this.btnSepetim.Location = new System.Drawing.Point(56, 190);
            this.btnSepetim.Name = "btnSepetim";
            this.btnSepetim.Size = new System.Drawing.Size(174, 43);
            this.btnSepetim.TabIndex = 4;
            this.btnSepetim.Text = "Sepetim";
            this.btnSepetim.UseVisualStyleBackColor = true;
            this.btnSepetim.Click += new System.EventHandler(this.btnSepetim_Click);
            // 
            // AnaMenuMusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 763);
            this.Controls.Add(this.btnSepetim);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.listViewUrunler);
            this.Controls.Add(this.lblAnaMenu);
            this.Name = "AnaMenuMusteriForm";
            this.Text = "AnaMenuMusteriForm";
            this.Load += new System.EventHandler(this.AnaMenuMusteriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnaMenu;
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.Button btnSiparislerim;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ColumnHeader stnUrunAdi;
        private System.Windows.Forms.ColumnHeader stnUrunMiktari;
        private System.Windows.Forms.ColumnHeader stnUrunAdedi;
        private System.Windows.Forms.Button btnSepetim;
    }
}