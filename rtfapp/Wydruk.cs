using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace rtfapp
{
    class Wydruk
    {
        private string Szablon;

        private string Typ_wydruku = "podsumowanie_wizyty";
        private string SciezkaZapisu;
        private string NazwaPliku;

        private string Imie= "<imie>";
        private string Nazwisko= "<nazwisko>";
        private string Pesel= "<pesel>";
        private string Adres ="<adres>";
        private string Data_Wystawienia="<data_wystawienia>";
        private RichTextBox KonwerterRTF;
        
        public Wydruk(string imie, string nazwisko, string pesel, string adres, string data_wystawienia, string typ_wydruku) // domyślny konstruktor
        {

            Typ_wydruku = typ_wydruku;

            KonwerterRTF = new RichTextBox();
            
            // SciezkaZapisu = new string("");
            SciezkaZapisu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Pliki Wygenerowane RtfApp\";
            Szablon = System.IO.File.ReadAllText("szablon_" + this.Typ_wydruku + ".rtf"); //wczytanie szablonu z pliku szablonu

            //inicjalizacja najbardziej podstawowych elem wydruku
            Imie = Podmiana(Imie, imie);
            Nazwisko = Podmiana(Nazwisko,nazwisko);
            Pesel = Podmiana(Pesel,pesel);
            Data_Wystawienia =Podmiana(Data_Wystawienia, data_wystawienia);
            Adres = Podmiana(Adres, adres);
         
            //NazwaPliku = new string();
            NazwaPliku = Typ_wydruku + "_" + Nazwisko + "_" + Imie + "_" + Pesel + "_" + Data_Wystawienia + ".rtf";

        }

        private string Podmiana(string starawartosc, string nowawartosc) //przyjmuje wskaznik do starej wartosci i nowa wartosc
        {
           
          // KonwerterRTF.rf
           Szablon= Szablon.Replace(starawartosc, rtfapp.Program.GetRtfString(nowawartosc));

            return nowawartosc;

            //przyklad uzycia: 
            //Nazwiksko musi byc zainicjalizowane jako <nazwisko> (jak w szablonie)
            //Nazwisko = Podmiana(Nazwisko, Nazwisko_Pacjenta)

        }

      

        public void DoWydruku()
        {
            File.WriteAllText(SciezkaZapisu+NazwaPliku,Szablon);
            System.Diagnostics.Process.Start(SciezkaZapisu+NazwaPliku);

        }

  
    }
}
