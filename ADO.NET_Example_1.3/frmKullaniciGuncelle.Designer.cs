namespace ADO.NET_Example_1._3
{
    partial class frmKullaniciGuncelle
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
            btnKaydet = new Button();
            label5 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtKullaniciAd = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            txtKullaniciID = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(155, 217);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 22);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 177);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 20;
            label5.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(128, 175);
            txtSifre.Margin = new Padding(3, 2, 3, 2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(110, 23);
            txtSifre.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 153);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 128);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 17;
            label3.Text = "Kullanıcı Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 103);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 16;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 78);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 15;
            label1.Text = "Ad:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 150);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(128, 125);
            txtKullaniciAd.Margin = new Padding(3, 2, 3, 2);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(110, 23);
            txtKullaniciAd.TabIndex = 13;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(128, 101);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(110, 23);
            txtSoyad.TabIndex = 12;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(128, 76);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(110, 23);
            txtAd.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 51);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 23;
            label6.Text = "Kullanıcı ID:";
            // 
            // txtKullaniciID
            // 
            txtKullaniciID.Location = new Point(128, 49);
            txtKullaniciID.Margin = new Padding(3, 2, 3, 2);
            txtKullaniciID.Name = "txtKullaniciID";
            txtKullaniciID.Size = new Size(110, 23);
            txtKullaniciID.TabIndex = 22;
            // 
            // frmKullaniciGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 304);
            Controls.Add(label6);
            Controls.Add(txtKullaniciID);
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
            Name = "frmKullaniciGuncelle";
            Text = "frmKullaniciGuncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label5;
        private TextBox txtSifre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtKullaniciAd;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private TextBox txtKullaniciID;
    }
}