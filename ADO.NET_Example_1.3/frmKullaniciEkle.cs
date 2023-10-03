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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DIJIBILConnStr"].ConnectionString);

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ad = txtAd.Text;
            var soyad = txtSoyad.Text;
            var kullaniciAd = txtKullaniciAd.Text;
            var email = txtEmail.Text;
            var sifre = txtSifre.Text;
            KullaniciEkle(ad,soyad,kullaniciAd,email,sifre);
        }

        void KullaniciEkle(string ad, string soyad, string kullaniciAd, string email, string sifre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_KullaniciEkle";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@Ad",ad),
                    new SqlParameter("@Soyad",soyad),
                    new SqlParameter("@KullaniciAd",kullaniciAd),
                    new SqlParameter("@Email",email),
                    new SqlParameter("@Sifre",sifre),
                };

                conn.Open();
                cmd.Parameters.AddRange(parameters);
                int x = cmd.ExecuteNonQuery();
                MessageBox.Show("Etkilenen Kayıt Sayısı : " + x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
