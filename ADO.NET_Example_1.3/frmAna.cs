namespace ADO.NET_Example_1._3
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }


        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
            frmKullaniciEkle.Show();
        }


        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            frmKullaniciGuncelle frmKullaniciEkle = new frmKullaniciGuncelle();
            frmKullaniciEkle.Show();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            frmKullaniciSil frmKullaniciSil = new frmKullaniciSil();
            frmKullaniciSil.Show();
        }
    }
}