
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUrunFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.Location = new System.Drawing.Point(597, 208);
            this.tbUrunAdi.Multiline = true;
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(287, 37);
            this.tbUrunAdi.TabIndex = 0;
            // 
            // tbUrunMiktari
            // 
            this.tbUrunMiktari.Location = new System.Drawing.Point(597, 300);
            this.tbUrunMiktari.Multiline = true;
            this.tbUrunMiktari.Name = "tbUrunMiktari";
            this.tbUrunMiktari.Size = new System.Drawing.Size(287, 37);
            this.tbUrunMiktari.TabIndex = 0;
            // 
            // tbUrunAdet
            // 
            this.tbUrunAdet.Location = new System.Drawing.Point(597, 395);
            this.tbUrunAdet.Multiline = true;
            this.tbUrunAdet.Name = "tbUrunAdet";
            this.tbUrunAdet.Size = new System.Drawing.Size(287, 37);
            this.tbUrunAdet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(472, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(440, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(448, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Adedi:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(730, 566);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(154, 48);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(501, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN EKLEME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(459, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün Fiyati";
            // 
            // tbUrunFiyat
            // 
            this.tbUrunFiyat.Location = new System.Drawing.Point(597, 485);
            this.tbUrunFiyat.Multiline = true;
            this.tbUrunFiyat.Name = "tbUrunFiyat";
            this.tbUrunFiyat.Size = new System.Drawing.Size(287, 37);
            this.tbUrunFiyat.TabIndex = 4;
            // 
            // UrunEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1326, 710);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUrunFiyat);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUrunFiyat;
    }
}