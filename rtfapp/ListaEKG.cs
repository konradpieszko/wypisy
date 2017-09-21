using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtfapp
{
    class ListaEKG
    {
        public List<ekg> Lista;
        private BazaDataSet bazaDataSet;
        private BazaDataSetTableAdapters.elektrokardiogramyTableAdapter elektrokardiogramytableadapter;
        public string pesel;
        public string numkg;

        public ListaEKG()
        {
            Lista = new List<ekg>();
            bazaDataSet = new BazaDataSet();
            elektrokardiogramytableadapter = new BazaDataSetTableAdapters.elektrokardiogramyTableAdapter();
            pesel = "";
            numkg = "";
    }
        public void Wyczysc()
        {
            Lista.Clear();
        }
        public void WczytajZBazy()
        {
            Wyczysc();
            BazaDataSet.elektrokardiogramyDataTable ekgDataTable=  elektrokardiogramytableadapter.GetDataByNumKg(numkg);
            foreach (BazaDataSet.elektrokardiogramyRow R in ekgDataTable)
            {
                DodajEKG(R.Opis, R.Rytm, R.Czestotliwosc);

            }


        }
        public void DodajEKG(string opis, string rytm = "nieokreslono", string czestotliwosc = "nieokreslona", int obnizenie = 0, int uniesienie = 0)
        {
            ekg noweekg = new ekg();
            noweekg.OpisEKG = opis;
            noweekg.Rytm = rytm;
            noweekg.Czestotliwosc = czestotliwosc;
            noweekg.Obnizenie = obnizenie;
            noweekg.Uniesienie = uniesienie;
            Lista.Add(noweekg);

        }


        public void ZaktualizujDoBazy()
        {
            if (numkg == "") return;
            elektrokardiogramytableadapter.DeletByNumKgQuery(numkg);

            foreach (ekg e in Lista)
            {
                elektrokardiogramytableadapter.InsertQuery(pesel, numkg,e.Rytm, e.Czestotliwosc, "", e.OpisEKG);
            }
            

        }

        public string ListaNaWypis()
        {
            string ListaW = "";
            

            foreach(ekg e in Lista)
            {
                ListaW += e.OpisEKG + "\n";

            }
            return ListaW;
        }
    }
}
