
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
            this.lisstsiparislerim = new System.Windows.Forms.ListView();
            this.btnanageridon = new System.Windows.Forms.Button();
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
            // lisstsiparislerim
            // 
            this.lisstsiparislerim.HideSelection = false;
            this.lisstsiparislerim.Location = new System.Drawing.Point(354, 137);
            this.lisstsiparislerim.Name = "lisstsiparislerim";
            this.lisstsiparislerim.Size = new System.Drawing.Size(419, 235);
            this.lisstsiparislerim.TabIndex = 1;
            this.lisstsiparislerim.UseCompatibleStateImageBehavior = false;
            // 
            // btnanageridon
            // 
            this.btnanageridon.Location = new System.Drawing.Point(437, 479);
            this.btnanageridon.Name = "btnanageridon";
            this.btnanageridon.Size = new System.Drawing.Size(230, 77);
            this.btnanageridon.TabIndex = 2;
            this.btnanageridon.Text = "Ana Menü Geri Dön";
            this.btnanageridon.UseVisualStyleBackColor = true;
            this.btnanageridon.Click += new System.EventHandler(this.btnanageridon_Click);
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 744);
            this.Controls.Add(this.btnanageridon);
            this.Controls.Add(this.lisstsiparislerim);
            this.Controls.Add(this.lblsiparişlerim);
            this.Name = "Siparislerim";
            this.Text = "Siparislerim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsiparişlerim;
        private System.Windows.Forms.ListView lisstsiparislerim;
        private System.Windows.Forms.Button btnanageridon;
    }
}