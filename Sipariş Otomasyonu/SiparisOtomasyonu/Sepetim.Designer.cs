
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tcOdeme = new System.Windows.Forms.TabControl();
            this.krediKart = new System.Windows.Forms.TabPage();
            this.lblCvc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.btnKKartileTamamla = new System.Windows.Forms.Button();
            this.tbCvc = new System.Windows.Forms.TextBox();
            this.tbTarih = new System.Windows.Forms.TextBox();
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
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnAvDetayi = new System.Windows.Forms.Button();
            this.tcOdeme.SuspendLayout();
            this.krediKart.SuspendLayout();
            this.cek.SuspendLayout();
            this.nakit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(486, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sepetim";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(586, 450);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tcOdeme
            // 
            this.tcOdeme.Controls.Add(this.krediKart);
            this.tcOdeme.Controls.Add(this.cek);
            this.tcOdeme.Controls.Add(this.nakit);
            this.tcOdeme.Location = new System.Drawing.Point(631, 153);
            this.tcOdeme.Name = "tcOdeme";
            this.tcOdeme.SelectedIndex = 0;
            this.tcOdeme.Size = new System.Drawing.Size(538, 322);
            this.tcOdeme.TabIndex = 2;
            // 
            // krediKart
            // 
            this.krediKart.Controls.Add(this.lblCvc);
            this.krediKart.Controls.Add(this.label2);
            this.krediKart.Controls.Add(this.lblKartNo);
            this.krediKart.Controls.Add(this.btnKKartileTamamla);
            this.krediKart.Controls.Add(this.tbCvc);
            this.krediKart.Controls.Add(this.tbTarih);
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
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCvc.Location = new System.Drawing.Point(140, 173);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(49, 20);
            this.lblCvc.TabIndex = 5;
            this.lblCvc.Text = "CVC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Son Kullanma Tarihi:";
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNo.Location = new System.Drawing.Point(118, 69);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(71, 20);
            this.lblKartNo.TabIndex = 3;
            this.lblKartNo.Text = "Kart No:";
            // 
            // btnKKartileTamamla
            // 
            this.btnKKartileTamamla.Location = new System.Drawing.Point(347, 229);
            this.btnKKartileTamamla.Name = "btnKKartileTamamla";
            this.btnKKartileTamamla.Size = new System.Drawing.Size(150, 44);
            this.btnKKartileTamamla.TabIndex = 3;
            this.btnKKartileTamamla.Text = "Alışverişi Tamamla";
            this.btnKKartileTamamla.UseVisualStyleBackColor = true;
            this.btnKKartileTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // tbCvc
            // 
            this.tbCvc.Location = new System.Drawing.Point(221, 170);
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.Size = new System.Drawing.Size(276, 23);
            this.tbCvc.TabIndex = 2;
            // 
            // tbTarih
            // 
            this.tbTarih.Location = new System.Drawing.Point(221, 116);
            this.tbTarih.Name = "tbTarih";
            this.tbTarih.Size = new System.Drawing.Size(276, 23);
            this.tbTarih.TabIndex = 1;
            // 
            // tbKartNo
            // 
            this.tbKartNo.Location = new System.Drawing.Point(221, 66);
            this.tbKartNo.Name = "tbKartNo";
            this.tbKartNo.Size = new System.Drawing.Size(276, 23);
            this.tbKartNo.TabIndex = 0;
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
            this.nakit.Controls.Add(this.tbTutar);
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
            this.btnNakitileTamamla.Location = new System.Drawing.Point(286, 227);
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
            this.lblTutar.Location = new System.Drawing.Point(91, 106);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(53, 20);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Tutar:";
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(168, 104);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(268, 22);
            this.tbTutar.TabIndex = 0;
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(434, 632);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(175, 42);
            this.btnDevamEt.TabIndex = 4;
            this.btnDevamEt.Text = "Alışverişe Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnAvDetayi
            // 
            this.btnAvDetayi.Location = new System.Drawing.Point(979, 620);
            this.btnAvDetayi.Name = "btnAvDetayi";
            this.btnAvDetayi.Size = new System.Drawing.Size(190, 42);
            this.btnAvDetayi.TabIndex = 5;
            this.btnAvDetayi.Text = "Alışveriş Detayı";
            this.btnAvDetayi.UseVisualStyleBackColor = true;
            this.btnAvDetayi.Click += new System.EventHandler(this.btnAvDetayi_Click);
            // 
            // Sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 749);
            this.Controls.Add(this.btnAvDetayi);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.tcOdeme);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Sepetim";
            this.Text = "Sepetim";
            this.tcOdeme.ResumeLayout(false);
            this.krediKart.ResumeLayout(false);
            this.krediKart.PerformLayout();
            this.cek.ResumeLayout(false);
            this.cek.PerformLayout();
            this.nakit.ResumeLayout(false);
            this.nakit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tcOdeme;
        private System.Windows.Forms.TabPage krediKart;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.TextBox tbTarih;
        private System.Windows.Forms.TextBox tbKartNo;
        private System.Windows.Forms.TabPage cek;
        private System.Windows.Forms.TextBox tbCekId;
        private System.Windows.Forms.Label lblCekId;
        private System.Windows.Forms.Label lblCekAdi;
        private System.Windows.Forms.TextBox tbCekAdi;
        private System.Windows.Forms.TabPage nakit;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Button btnKKartileTamamla;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnNakitileTamamla;
        private System.Windows.Forms.Button btnCekileTamamla;
        private System.Windows.Forms.Button btnAvDetayi;
    }
}