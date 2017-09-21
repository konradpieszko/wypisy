using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtfapp
{
    class Rozpoznanie
    {
        public string ICD_10;
        public string Rozp;

        public Rozpoznanie(string rozp, string icd10="")
        {
            ICD_10 = icd10;
            Rozp = rozp;
        }
    }
}
