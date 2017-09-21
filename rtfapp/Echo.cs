using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtfapp
{
    public class Echo
    {
        public string PESEL;
        public string NumKG;
        public string NumWizyty;
        public bool CzyOdzialowe;
        public DateTime DataBadania;
        private int EchoID;

        public string LA;
        public string LV;
        public string Ao;
        public string RV;
        public string IVS;
        public string PWLV;
        public string AcT;
        public string Pulm;
        public string Mitralna_Morf;
        public string Mitralna_Czynn;
        public string Aortalna_Morf;
        public string Aortalna_Czynn;
        public string Mitralna_Vmax;
        public string Aortalna_Vmax;
        public string Trojdzielna;
        public string Trojdzielna_MaxPG;
        public string Kurczliwosc;
        public string EF;
        public string FalaE;
        public string FalaA;
        public string Rozkurcz;
        public bool CzyUposledzony;
        public string Uwagi;
        public string Lekarz;



        public int ZaladujDoBazy()
        {
            int NoweEchoID =0;

            return NoweEchoID;
        }

        public void WczytajZBazy()
        {


        }

        public void UaktualnijDaneWBazie()
        {



        }

        public string TekstEchoDoWstawienia()
        {
            string TekstEcho="";
            //opcjonalne dodatki:
            string Mvmax ="";
            string Avmax = "";
            string Trmax = "";
            string EFtxt = "";
            string Etxt = "";
            string Atxt = "";
            string TakNieRozk = @"   Upo\'9cledzona:     NIE\par";


            if (EF != "") EFtxt = @"\b EF: \b0    " + rtfapp.Program.GetRtfString(EF) + @"%"; else EFtxt = "";
            if (CzyUposledzony==true) TakNieRozk= @"    Upo\'9cledzona:    \ul TAK\ulnone\tab \par";
            if (Trojdzielna_MaxPG != "") Trmax = @"\par\b TR Max PG:\b0  " + Trojdzielna_MaxPG + @" mmHg \par"; else Trmax = "";


            TekstEcho = @"\ul\b Wynik badania USKG:\par
\ulnone\b0 LA -" + rtfapp.Program.GetRtfString(LA) + @" mm, Ao - " + rtfapp.Program.GetRtfString(Ao) + @" mm, IVS - " + rtfapp.Program.GetRtfString(IVS) + @" mm, LVDD - " + rtfapp.Program.GetRtfString(LV) + @" mm, RV - " + rtfapp.Program.GetRtfString(RV) + @" mm, PWLV - " + rtfapp.Program.GetRtfString(PWLV) + @" mm.\par
\ul\b Zastawka pnia p\'b3ucnego:\ulnone " + rtfapp.Program.GetRtfString(Pulm) + @"   AcT:\b0  " + rtfapp.Program.GetRtfString(AcT) + @" ms \b    \par
\ul Zastawka mitralna:\par
\ulnone Morfologicznie:\b0 " + rtfapp.Program.GetRtfString(Mitralna_Morf) + @"\par
\b Czynno\'9cciowo:\b0  " + rtfapp.Program.GetRtfString(Mitralna_Czynn) + rtfapp.Program.GetRtfString(Mvmax) + @"\ul\b\par
Zastawka aortalna:\par
\ulnone Morfologicznie:\b0 " + rtfapp.Program.GetRtfString(Aortalna_Morf) + @"\par
\b Czynno\'9cciowo:\b0  " + rtfapp.Program.GetRtfString(Aortalna_Czynn) + rtfapp.Program.GetRtfString(Avmax) + @"\ul\b\par
Zastawka tr\'f3jdzielna\ulnone :\b0  " + rtfapp.Program.GetRtfString(Trojdzielna) + @"\par
"+Trmax+@"
\ul\b Kurczliwo\'9c\'e6 LV:\ulnone\b0  " + rtfapp.Program.GetRtfString(Kurczliwosc) + @"\tab"+EFtxt+@" \par
\par
 \ul\b Funkcja rozkurczowa:\ulnone\b0 " + TakNieRozk+ @"\par "+rtfapp.Program.GetRtfString(Rozkurcz) +

@"\b0\par";

            

        return TekstEcho;
        }

        
    }
}
