namespace ADO.NET_Example_1._3
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }

        public Kullanici(int kullaniciID, string ad, string soyad, string kullaniciAd, string sifre, string email)
        {
            KullaniciID = kullaniciID;
            Ad = ad;
            Soyad = soyad;
            KullaniciAd = kullaniciAd;
            Sifre = sifre;
            Email = email;
        }
    }
}
