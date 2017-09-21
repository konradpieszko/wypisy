using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;





namespace rtfapp
{
    class Wypis
    {
        private static string pattern_PESEL = @"\s?(?<pesel>(\d){11})(\s|,)";
        private static string pattern_numKG = @"(?<numkg>(\d){1,5}\s*\/\s*(20)?(\d){2})(\s|r)";
        private static string pattern_Nazwisko_Imie = @"Pan\(i\)\s+(?<nazwisko>\w+)\s+(?<imie>\w+)\s"; //zwraca dwie grupy
        private static string pattern_daty = @"dnia:\s+(?<data_przyj>\d{4}-\d{2}-\d{2})\s+(do\s+dnia:\s+(?<data_wyp>\d{4}-\d{2}-\d{2}))?";
        private static string pattern_telefon = @"telefon:\s+(?<telefon>(\d|-|\s)+)$";
        private static string pattern_kod_adres = @"zamieszkały\(a\):\s+(?<adres>(?<kod_pocztowy>\d{2}-\d{3})\s+.+)($|(.*telefon))";
        private static string pattern_plec = @"Płeć\s+(?<plec>M|K)\s";

        private static string pattern_bad_naglowek = @"(?<datagodzina>\d{4}-\d{2}-\d{2}\s+\d{2}:\d{2})";
        private static string pattern_bad = @"(?<probkanormy>(?<probka>(\D(\D|1){1,11}))\s+(?<wartosc>(\d|,|\.)*)(?<jednostki>.+)(\[(?<zakres>.+)\]))";
        private static string pattern_tropGFR = @"(?<probka>(GFR)|(TROT|TRO))[^A-Z0-9a-z]*(?<wartosc>(\d|,|\.)+)";
        private static string pattten_rozpglowne = @"(?<icd10>[A-Z]\d\d\.\d)\s\-\s(?<rozpoznanie>.*)";
        private static string pattten_procedura = @"(?<icd9>\d{2}\.\d{2,3})\s(?<procedura>.*)";


        public string PlikRtf;// wlasny plik należacy do  danego wypisu

        private string RozpoznaniaRtf;
        private string EKGRtf;
        private string EpikryzaRtf;
        private string LekiRtf;
        private string EchoRtf;
        private string InneZaleceniaRtf;
        private string ZastosowaneLeczenieRtf;


        RegexOptions options = RegexOptions.Multiline;
        

        
      
        





        //Tableadapters etc

        private BazaDataSet bazaDataSet;       
        private BazaDataSetTableAdapters.pacjenciTableAdapter pacjenciTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;       
        private BazaDataSetTableAdapters.hospitalizacjeTableAdapter hospitalizacjeTableAdapter;      
        private BazaDataSetTableAdapters.badania_laboratoryjneTableAdapter badania_laboratoryjneTableAdapter;
        private BazaDataSetTableAdapters.hosp_rozpTableAdapter hosp_rozpTableAdapter;  
        private BazaDataSetTableAdapters.lekarzeTableAdapter lekarzeTableAdapter;
        private BazaDataSetTableAdapters.elektrokardiogramyTableAdapter elektrokardiogramyTableAdapter;
        private BazaDataSetTableAdapters.rozpoznaniaTableAdapter rozpoznaniaTableAdapter;

        //listy roznych rzeczy ktore sa modyfikowanye przez okno wypisu
        public List<string> ListaRozpoznan;
        public List<Procedura> ListaProcedur;
      
        public Rozpoznanie RozpoznanieGlowne;
        public Echo Echokardiogram;
        public ListaLekow ListaLek;
        public ListaEKG ListaEkg;

        

        //To wszystko do odczytania z podstawowych danych w wypisie
        public string Pesel;
        public string Imie;
        public string Nazwisko;
        public string Plec;
        public string KodPocztowy;
        public string Adres;
        public string Telef1;
        public string Telef2;
        public string NumKg;
        public DateTime DataPrzyj;
        public DateTime DataWyp;
        public bool Ink;
        public bool Kard;
        public bool Reh;

        private List<string> ListaNazwProbek;
        private List<string> ListaNazwBadan;
        private List<string> ListaJendostek;

        public List<WynikBadania> ListaWynikowBadan;

        private char spacja = ' ';

        public Wypis() // pusty konstruktor
        {
          ListaNazwProbek = new List<string>();
          ListaNazwBadan = new List<string>();
          ListaJendostek = new List<string>();
          ListaWynikowBadan = new List<WynikBadania>();
            ListaEkg = new ListaEKG();

            ListaRozpoznan = new List<string>();
            ListaProcedur = new List<Procedura>();
            ListaLek = new ListaLekow();
            Echokardiogram = new Echo();

            //inicjalizujemy stringi do podmian
            RozpoznaniaRtf = "<rozpoznania>";
            EKGRtf = "<elektrokardiogramy>";
            EchoRtf = "<wyniki_USKG>";
            LekiRtf = "<leki_wypisane>";
            InneZaleceniaRtf = "<inne_zalecenia>";
            ZastosowaneLeczenieRtf = "<zastosowane_leczenie>";

            EpikryzaRtf = "<epikryza>";

            /*
                  private BazaDataSet bazaDataSet;
                    private BazaDataSetTableAdapters.pacjenciTableAdapter pacjenciTableAdapter;
                    private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
                    private BazaDataSetTableAdapters.hospitalizacjeTableAdapter hospitalizacjeTableAdapter;
                    private BazaDataSetTableAdapters.badania_laboratoryjneTableAdapter badania_laboratoryjneTableAdapter;
                    private BazaDataSetTableAdapters.hosp_rozpTableAdapter hosp_rozpTableAdapter;
                    private BazaDataSetTableAdapters.lekarzeTableAdapter lekarzeTableAdapter;
                    private BazaDataSetTableAdapters.elektrokardiogramyTableAdapter elektrokardiogramyTableAdapter;
                    private BazaDataSetTableAdapters.rozpoznaniaTableAdapter rozpoznaniaTableAdapter;*/

            bazaDataSet = new BazaDataSet();
            hosp_rozpTableAdapter = new BazaDataSetTableAdapters.hosp_rozpTableAdapter();
            rozpoznaniaTableAdapter = new BazaDataSetTableAdapters.rozpoznaniaTableAdapter();
           




    }


        public void CzytajRegEx(string txtwypisu)
        {

            string SameBadania = ""; //czesc wypisu tylko z badaniami
            NumKg = Regex.Match(txtwypisu, pattern_numKG, options).Groups["numkg"].Value.Replace(" ", string.Empty);
            Pesel = Regex.Match(txtwypisu, pattern_PESEL, options).Groups["pesel"].Value;
            Imie = Regex.Match(txtwypisu, pattern_Nazwisko_Imie, options).Groups["imie"].Value;
            Nazwisko= Regex.Match(txtwypisu, pattern_Nazwisko_Imie, options).Groups["nazwisko"].Value;

            if (!(DateTime.TryParseExact(Regex.Match(txtwypisu, pattern_daty, options).Groups["data_przyj"].Value, "yyyy-MM-dd", null, DateTimeStyles.None, out this.DataPrzyj)))

                Console.WriteLine("date not in an acceptable format.");


            Adres = Regex.Match(txtwypisu, pattern_kod_adres, options).Groups["adres"].Value;

            Telef1 = Regex.Match(txtwypisu, pattern_telefon, options).Groups["telefon"].Value;

            Plec = Regex.Match(txtwypisu, pattern_plec, options).Value;

            RozpoznanieGlowne = new Rozpoznanie(Regex.Match(txtwypisu, pattten_rozpglowne, options).Groups["rozpoznanie"].Value,
                                                Regex.Match(txtwypisu, pattten_rozpglowne, options).Groups["icd10"].Value);

            foreach( Match M in Regex.Matches(txtwypisu, pattten_procedura, options)) //dodanie procedur do listy
            {
                Procedura P = new Procedura(M.Groups["icd9"].Value, M.Groups["procedura"].Value);
                
                ListaProcedur.Add(P);
            }

            //wydaje sie ze od gdy wczytujemy wyniki lepsze bedzie podejscie sekwencyjne
            SameBadania = Regex.Split(txtwypisu, @"BADANIA LABORATORYJNE:\s")[1];



            string[] BadaniaWgDat = Regex.Split(SameBadania, pattern_bad_naglowek, options); //tworzymy tablce stringow, gdzie kazdy element zaczyna sie od daty i godziny

            // MessageBox.Show(BadaniaWgDat.Length.ToString());
            string TekstDebug="";
            string DataGodzina = "";
            foreach (String S in BadaniaWgDat)
           {
               // MessageBox.Show(S);

                // Na zamianę powinny pojawiać się daty i treści badania
                if(Regex.Match(S, pattern_bad_naglowek, options).Value!="")
                {
                  DataGodzina= Regex.Match(S, pattern_bad_naglowek, options).Value;
                 
                }
                else
                {
                   // if (Regex.Match(S, pattern_bad, options).Value == "") continue;

                        MatchCollection BadMatches = Regex.Matches(S, pattern_bad, options);
                        if (BadMatches.Count == 0)
                        {
                            BadMatches = Regex.Matches(S, pattern_tropGFR, options); //probujemy jeszcze alternatywny wzor dla trop/gfr
                        }

                        if (BadMatches.Count>0)
                        {

                            foreach ( Match M in BadMatches)
                            {
                          /*
                                TekstDebug = "Data Badania: "; // trafiliśmy na nowe badanie
                                TekstDebug += DataGodzina + "\n";
                                TekstDebug += "\n  Badanie:      ";
                                TekstDebug += M.Groups["probka"];
                                TekstDebug += "\n       Wartosc:      ";
                                TekstDebug += M.Groups["wartosc"];
                                TekstDebug += "\n       Zakres:      ";
                                TekstDebug += M.Groups["zakres"];
                                TekstDebug += "\n       Jedn:      ";
                                TekstDebug += M.Groups["jednostki"];

                                MessageBox.Show(TekstDebug);
                                TekstDebug = "";
                                
                            */
                            this.ListaWynikowBadan.Add(new WynikBadania( M.Groups["probka"].Value,
                                                                         M.Groups["wartosc"].Value,
                                                                         DataGodzina,
                                                                         M.Groups["zakres"].Value,
                                                                         M.Groups["jednostki"].Value));

                                                    
                            }
                            
                        }
                  
                        
                }
               
      
            }



            //ustawienie zeby odpowiednio dzialaly nam listy i ich funkcje
            ListaLek.NumKG = NumKg;
            ListaEkg.numkg = NumKg;
            ListaEkg.pesel = Pesel;


            /*********************************************************************************/
        }



        public void ZaktualizujRozpoznaniaWBazie()
        {
            hosp_rozpTableAdapter.DeleteByNumKG(NumKg); //USUWA WSZYSTKIE DOTYCHCZASOWE ROZPOZNANIA
            foreach(string Rozpoznanie in ListaRozpoznan)
            {
                if (Rozpoznanie == "" || Rozpoznanie==null) continue;
                hosp_rozpTableAdapter.InsertQuery(NumKg, rozpoznaniaTableAdapter.GetDataByRoszerzoneRozp(Rozpoznanie).Last<BazaDataSet.rozpoznaniaRow>().Rozp_ID,Pesel, Rozpoznanie);
               //dodalismy od nowa wszystkie rozpoznania wg listy
            }   

        }


        public int WczytajRozpoznaniaZBazy()
        {
            ListaRozpoznan.Clear(); //opróżnia listę rozpoznań
            BazaDataSet.hosp_rozpDataTable TabelaHospRozp = new BazaDataSet.hosp_rozpDataTable();
            TabelaHospRozp = hosp_rozpTableAdapter.GetDataByNumKG(NumKg);

            if (TabelaHospRozp.Rows.Count == 0) return 0; //zwraca zero gdy nie było rozpoznań w bazie

            foreach (BazaDataSet.hosp_rozpRow Row in TabelaHospRozp.Rows)
            {
                ListaRozpoznan.Add(Row.Rozp_Szczegolowe); // wypełniamy rozpoznaniami z bazy

            }

            return 1;
        }

        public string RozpoznaniaNaWypis() //funkcja, ktora ma na zadanie na podstawie wewnetrzej listy rozpoznan zmodyfikowac plik rtf
        {
           


            string NoweRozpoznania;
            NoweRozpoznania = "";

            foreach (string Rozpoznanie in ListaRozpoznan)
            {
                NoweRozpoznania += Rozpoznanie + ". ";
            }

            return NoweRozpoznania;

          
           
        }

        public string EKGnaWypis()
        {
            return ListaEkg.ListaNaWypis();

        }

        private void PodmienEcho()
        {
            string NowyTekstEcho = Echokardiogram.TekstEchoDoWstawienia();

                PlikRtf = PlikRtf.Replace(EchoRtf, NowyTekstEcho); //podmiana aktualnego echa na wygenerowany tekst a echa przechowywanego w tym obiekcie wypis
                EchoRtf = NowyTekstEcho; // nowa definicja aktualnego tekstu echa
         

        }

        private void LekiNaWypis()
        {

            string NowyTekstLekow = ListaLek.TekstLekowDoWstawienia();
           PlikRtf = PlikRtf.Replace(LekiRtf, NowyTekstLekow); //podmiana aktualnego na wygenerowany tekst
           LekiRtf = NowyTekstLekow;

        }

      
    }
}