using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Example_1._3
{
    public partial class frmKullaniciGuncelle : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DIJIBILConnStr"].ConnectionString);

        public frmKullaniciGuncelle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var kullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            var ad = txtAd.Text;
            var soyad = txtSoyad.Text;
            var kullaniciAd = txtKullaniciAd.Text;
            var email = txtEmail.Text;
            var sifre = txtSifre.Text;
            KullaniciGuncelle(kullaniciID, ad, soyad, kullaniciAd, email, sifre);
        }

        void KullaniciGuncelle(int kullaniciID,string ad, string soyad, string kullaniciAd, string email, string sifre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_KullaniciGuncelle";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@Ad",ad),
                    new SqlParameter("@Soyad",soyad),
                    new SqlParameter("@KullaniciAd",kullaniciAd),
                    new SqlParameter("@Email",email),
                    new SqlParameter("@Sifre",sifre),
                    new SqlParameter("@KullaniciID",kullaniciID)
                };

                cmd.Parameters.AddRange(parameters);
                cmd.Connection.Open();

                string mesaj = string.Empty;

                int etkilenenKayitSayisi = cmd.ExecuteNonQuery();

                if(etkilenenKayitSayisi > 0)
                {
                    mesaj = ("İşlem Başarılı!");
                }
                else
                {
                    mesaj = ("İşlem Başarısız!");
                }

                MessageBox.Show(mesaj);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
