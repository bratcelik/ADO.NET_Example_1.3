namespace ADO.NET_Example_1._3
{
    partial class frmKullaniciEkle
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtKullaniciAd = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSifre = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(177, 51);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(110, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(177, 76);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(110, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(177, 100);
            txtKullaniciAd.Margin = new Padding(3, 2, 3, 2);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(110, 23);
            txtKullaniciAd.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(177, 125);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 53);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 78);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 103);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Kullanıcı Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 128);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 152);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(177, 150);
            txtSifre.Margin = new Padding(3, 2, 3, 2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(110, 23);
            txtSifre.TabIndex = 8;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(204, 192);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 22);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // frmKullaniciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 282);
            Controls.Add(btnKaydet);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtKullaniciAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmKullaniciEkle";
            Text = "frmKullaniciEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtKullaniciAd;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSifre;
        private Button btnKaydet;
    }
}