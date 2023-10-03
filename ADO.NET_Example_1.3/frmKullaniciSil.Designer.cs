namespace ADO.NET_Example_1._3
{
    partial class frmKullaniciSil
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
            dgKullanicilar = new DataGridView();
            label6 = new Label();
            txtKullaniciID = new TextBox();
            btnKullaniciSil = new Button();
            btnKullanicilariGetir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // dgKullanicilar
            // 
            dgKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKullanicilar.Location = new Point(291, 12);
            dgKullanicilar.Name = "dgKullanicilar";
            dgKullanicilar.RowTemplate.Height = 25;
            dgKullanicilar.Size = new Size(694, 426);
            dgKullanicilar.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 33);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 25;
            label6.Text = "Kullanıcı ID:";
            // 
            // txtKullaniciID
            // 
            txtKullaniciID.Location = new Point(175, 31);
            txtKullaniciID.Margin = new Padding(3, 2, 3, 2);
            txtKullaniciID.Name = "txtKullaniciID";
            txtKullaniciID.Size = new Size(110, 23);
            txtKullaniciID.TabIndex = 24;
            // 
            // btnKullaniciSil
            // 
            btnKullaniciSil.Location = new Point(192, 73);
            btnKullaniciSil.Name = "btnKullaniciSil";
            btnKullaniciSil.Size = new Size(93, 28);
            btnKullaniciSil.TabIndex = 26;
            btnKullaniciSil.Text = "Kullanıcı Sil";
            btnKullaniciSil.UseVisualStyleBackColor = true;
            btnKullaniciSil.Click += btnKullaniciSil_Click;
            // 
            // btnKullanicilariGetir
            // 
            btnKullanicilariGetir.Location = new Point(175, 310);
            btnKullanicilariGetir.Name = "btnKullanicilariGetir";
            btnKullanicilariGetir.Size = new Size(110, 35);
            btnKullanicilariGetir.TabIndex = 27;
            btnKullanicilariGetir.Text = "Kullanıcıları Getir";
            btnKullanicilariGetir.UseVisualStyleBackColor = true;
            btnKullanicilariGetir.Click += btnKullanicilariGetir_Click;
            // 
            // frmKullaniciSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(btnKullanicilariGetir);
            Controls.Add(btnKullaniciSil);
            Controls.Add(label6);
            Controls.Add(txtKullaniciID);
            Controls.Add(dgKullanicilar);
            Name = "frmKullaniciSil";
            Text = "frmKullaniciSil";
            ((System.ComponentModel.ISupportInitialize)dgKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgKullanicilar;
        private Label label6;
        private TextBox txtKullaniciID;
        private Button btnKullaniciSil;
        private Button btnKullanicilariGetir;
    }
}