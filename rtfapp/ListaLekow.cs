using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rtfapp
{
    //klasa ma za zadanie utworzy liste leku wewnatrz obiektu wypisu lub wewnatrz obiekug wizyty. Zaiwera metody potrzebne do dodawania lekow, tworzenia tekstu, tworzenia recepty
    class ListaLekow
    {
        //Tableadapters etc

        private BazaDataSet bazaDataSet;
        private BazaDataSetTableAdapters.lekiTableAdapter LekiTableAdapter;
        private BazaDataSetTableAdapters.hosp_lekiTableAdapter Hosp_lekiTableAdapter;

        //public System.Windows.Forms.DataGridViewRowCollection LekiDataGridRows;
        private List<Lek> ListaLek;
        public string NumKG;

        



        public  ListaLekow()
        {
            bazaDataSet = new BazaDataSet();
            LekiTableAdapter = new BazaDataSetTableAdapters.lekiTableAdapter();
            Hosp_lekiTableAdapter = new BazaDataSetTableAdapters.hosp_lekiTableAdapter();
            //LekiDataGridRows = new DataGridViewRowCollection(RodzicDataGrid);
            ListaLek = new List<Lek>();

            LekiTableAdapter.Fill(bazaDataSet.leki);
            Hosp_lekiTableAdapter.Fill(bazaDataSet.hosp_leki);
                      
                
        }

        public void DodajLekDoListy(int LekID, string LekDawska, string Nazwa, string Dawka, string Dawkowanie)
        {
            Lek NowyLek = new Lek();
            NowyLek.LekID = LekID;
            NowyLek.TekstNaWypis = LekDawska;
            NowyLek.Nazwa = Nazwa;
            NowyLek.Dawka = Dawka;
            NowyLek.Dawkowanie = Dawkowanie;

            ListaLek.Add(NowyLek);
            
        }


         public void Wyczysc()
        {
            this.ListaLek.Clear();
        }
     

        public void WygenerujWydrukRecepty()
        {



        }

        public int WczytajLekiZBazy()
        {


            return 1;
        }

        public void ZaktualizujLekiWBazie()
        {
            Hosp_lekiTableAdapter.DeleteByNumKG(NumKG);
            foreach (Lek Lekarstwo in ListaLek)
            {
                Hosp_lekiTableAdapter.InsertQuery(Lekarstwo.LekID, NumKG, Lekarstwo.TekstNaWypis);

            }


        }

        public string TekstLekowDoWstawienia()
        {
            string TekstLekow = "";

            TekstLekow = @"\pard\ltrpar\fi-360\li720\qj\ulnone\b0\f3\'b7\tab\b\f0 oszcz\'eadzaj\'b9cy tryb \'bfycia z unikaniem wi\'eakszego wysi\'b3ku fizycznego;\par
\b0\f3\'b7\tab\b\f0 wypisano recepty na ni\'bfej wymienione leki na okres miesi\'b9ca:\par";

            foreach (Lek Lekarstwo in this.ListaLek)
            {
                TekstLekow += "---" + Lekarstwo.TekstNaWypis+ @"\par";
                

            }


TekstLekow += @"\pard\ltrpar\fi-360\li720\qj\ulnone\b0\f3\'b7\tab\b\f0  okresowa kontrola stanu zdrowia w Poradni Kardiologicznej;\par
\b0\f3\'b7\tab\b\f0 p\'b3yt\'ea CD z badania wydano;\par";



            return TekstLekow;
        }




    }
}
