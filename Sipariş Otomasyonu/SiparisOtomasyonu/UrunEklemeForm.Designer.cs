
namespace SiparisOtomasyonu
{
    partial class UrunEklemeForm
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
            this.tbUrunAdi = new System.Windows.Forms.TextBox();
            this.tbUrunMiktari = new System.Windows.Forms.TextBox();
            this.tbUrunAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.Location = new System.Drawing.Point(547, 113);
            this.tbUrunAdi.Multiline = true;
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(287, 37);
            this.tbUrunAdi.TabIndex = 0;
            // 
            // tbUrunMiktari
            // 
            this.tbUrunMiktari.Location = new System.Drawing.Point(547, 221);
            this.tbUrunMiktari.Multiline = true;
            this.tbUrunMiktari.Name = "tbUrunMiktari";
            this.tbUrunMiktari.Size = new System.Drawing.Size(287, 37);
            this.tbUrunMiktari.TabIndex = 0;
            // 
            // tbUrunAdet
            // 
            this.tbUrunAdet.Location = new System.Drawing.Point(547, 334);
            this.tbUrunAdet.Multiline = true;
            this.tbUrunAdet.Name = "tbUrunAdet";
            this.tbUrunAdet.Size = new System.Drawing.Size(287, 37);
            this.tbUrunAdet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Adedi:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(730, 420);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // UrunEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 710);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUrunAdet);
            this.Controls.Add(this.tbUrunMiktari);
            this.Controls.Add(this.tbUrunAdi);
            this.Name = "UrunEklemeForm";
            this.Text = "UrunEklemeForm";
            this.Load += new System.EventHandler(this.UrunEklemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrunAdi;
        private System.Windows.Forms.TextBox tbUrunMiktari;
        private System.Windows.Forms.TextBox tbUrunAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
    }
}