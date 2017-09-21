using System;
using System.Globalization;




namespace rtfapp
{
    class WynikBadania
    {
        public string NazwaBadania;
        public DateTime DataBadania;
        public string Wynik;
        public string Zakres;
        public string Jednostka;
        

        public WynikBadania(string Nazwa, string Wynik, string Data, string Zakres, string Jednostka )
        {
            this.NazwaBadania = Nazwa;
           if( !DateTime.TryParseExact(Data, "yyyy-MM-dd HH:mm", null, DateTimeStyles.None, out this.DataBadania))
                System.Windows.Forms.MessageBox.Show("nie udalo sie przetworzyc daty |"+Data+"|");

            this.Wynik = Wynik.Replace(',', '.');
            this.Zakres = Zakres;
            this.Jednostka = Jednostka;
            

        }
    }
}
