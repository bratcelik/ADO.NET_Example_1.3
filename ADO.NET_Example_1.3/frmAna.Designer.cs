namespace ADO.NET_Example_1._3
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKullaniciEkle = new Button();
            btnKullaniciGuncelle = new Button();
            btnKullaniciSil = new Button();
            SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(108, 63);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(127, 35);
            btnKullaniciEkle.TabIndex = 0;
            btnKullaniciEkle.Text = "Kullanıcı Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // btnKullaniciGuncelle
            // 
            btnKullaniciGuncelle.Location = new Point(108, 114);
            btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            btnKullaniciGuncelle.Size = new Size(127, 35);
            btnKullaniciGuncelle.TabIndex = 1;
            btnKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciGuncelle.Click += btnKullaniciGuncelle_Click;
            // 
            // btnKullaniciSil
            // 
            btnKullaniciSil.Location = new Point(108, 167);
            btnKullaniciSil.Name = "btnKullaniciSil";
            btnKullaniciSil.Size = new Size(127, 35);
            btnKullaniciSil.TabIndex = 2;
            btnKullaniciSil.Text = "Kullanıcı Sil";
            btnKullaniciSil.UseVisualStyleBackColor = true;
            btnKullaniciSil.Click += btnKullaniciSil_Click;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 291);
            Controls.Add(btnKullaniciSil);
            Controls.Add(btnKullaniciGuncelle);
            Controls.Add(btnKullaniciEkle);
            Name = "frmAna";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullaniciEkle;
        private Button btnKullaniciGuncelle;
        private Button btnKullaniciSil;
    }
}