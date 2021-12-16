
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
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriListe = new System.Windows.Forms.Button();
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.btnSepet = new System.Windows.Forms.Button();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(939, 521);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(136, 43);
            this.btnSepeteEkle.TabIndex = 0;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler Listesi";
            // 
            // btnMusteriListe
            // 
            this.btnMusteriListe.Location = new System.Drawing.Point(25, 133);
            this.btnMusteriListe.Name = "btnMusteriListe";
            this.btnMusteriListe.Size = new System.Drawing.Size(200, 43);
            this.btnMusteriListe.TabIndex = 0;
            this.btnMusteriListe.Text = "Müşteri Listesi";
            this.btnMusteriListe.UseVisualStyleBackColor = true;
            this.btnMusteriListe.Click += new System.EventHandler(this.btnMusteriListe_Click);
            // 
            // btnSiparislerim
            // 
            this.btnSiparislerim.Location = new System.Drawing.Point(25, 64);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(200, 45);
            this.btnSiparislerim.TabIndex = 0;
            this.btnSiparislerim.Text = "Siparişlerim";
            this.btnSiparislerim.UseVisualStyleBackColor = true;
            // 
            // btnSepet
            // 
            this.btnSepet.Location = new System.Drawing.Point(25, 198);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(200, 43);
            this.btnSepet.TabIndex = 3;
            this.btnSepet.Text = "Sepet";
            this.btnSepet.UseVisualStyleBackColor = true;
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(275, 64);
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(800, 440);
            this.listViewUrunler.TabIndex = 4;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 617);
            this.Controls.Add(this.listViewUrunler);
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.btnMusteriListe);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSepeteEkle);
            this.Name = "AnaMenuForm";
            this.Text = "AnaMenuForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriListe;
        private System.Windows.Forms.Button btnSiparislerim;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.ListView listViewUrunler;
    }
}