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
    public partial class frmKullaniciSil : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DIJIBILConnStr"].ConnectionString);

        public frmKullaniciSil()
        {
            InitializeComponent();
        }

        void KullaniciSil(int kullaniciID)
        {
            if (kullaniciID > 0)
            {
                try
                {
                    using (conn)
                    {
                        SqlCommand cmd = new SqlCommand("pr_KullaniciSil", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "KullaniciID";
                        param.SqlDbType = SqlDbType.Int;
                        param.Value = kullaniciID;

                        cmd.Parameters.Add(param);
                        cmd.Connection.Open();
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Başarıyla Silindi!");
                        }
                        else
                        {
                            MessageBox.Show("Hata!");
                        }
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void KullaniciGetir()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_KullanicilariGetir";

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<Kullanici> kullanicilar = new List<Kullanici>();
                while (dr.Read())
                {
                    var user = new Kullanici(
                        kullaniciID: dr.GetInt32(0),
                        ad: dr.GetString(1),
                        soyad: dr.GetString(2),
                        kullaniciAd: dr.GetString(3),
                        email: dr.GetString(4),
                        sifre: dr.GetString(5)
                    );

                    kullanicilar.Add(user);
                }

                dgKullanicilar.DataSource = kullanicilar;
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

        private void btnKullanicilariGetir_Click(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            int kullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            KullaniciSil(kullaniciID);
        }
    }
}
