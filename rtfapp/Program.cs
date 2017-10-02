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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {

            //  Wydruk NowyWydruk = new Wydruk("Konrad", "Pieszko", "89112903119", "Rzeźniczaka29b/7, 65-119 Zielona Góra", "25-05-2017", "podsumowanie_wizyty");
           OknoWypisu NoweOknoWypisu;

            // NowyWydruk.DoWydruku();
          
          string[]  args = Environment.GetCommandLineArgs();
            if (args.Count() > 1)
            {
                NoweOknoWypisu = new OknoWypisu(args[1]);
               // MessageBox.Show(args[1]);
                
                NoweOknoWypisu.Show();
                NoweOknoWypisu.ZaladujWypis();
                
                //Console.Write(NoweOknoWypisu.Potwierdzenie());
                Application.Exit();


            }
            else
            {
                NoweOknoWypisu = new OknoWypisu();
                NoweOknoWypisu.ShowDialog();// do stuff
            }
            
         
            




        }
        
       

        public static string GetRtfEncoding(char c)
        {
            //if (c == '\\') return "\\\\";
           // if (c == '{') return "\\{";
           // if (c == '}') return "\\}";
          //  if (c == '\n') return "\r\n\\line ";
            int intCode = Convert.ToInt32(c);
            if (char.IsLetter(c) && intCode < 0x80)
            {
                return c.ToString();
            }
            return "\\u" + intCode + "?";
        }
        public static string GetRtfString(string s)
        {
            if (s == null) return "";
            StringBuilder returned = new StringBuilder();
            foreach (char c in s)
            {
                returned.Append(GetRtfEncoding(c));
            }
            return returned.ToString();
        }

        public static string PolskieZnakiRTF(string s) //funkcja zamiany polskich znaków na kodowanie rtf
        {

            if (s == null) return "";
            StringBuilder returned = new StringBuilder();
            foreach (char c in s)
            {
                if (c == 'ą') returned.Append("\'b9");
                else if (c == 'ę') returned.Append("\'ea");
                else if (c == 'ć') returned.Append("\'e6");
                else if (c == 'ź') returned.Append("\'9f");
                else if (c == 'ż') returned.Append("\'bf");
                else if (c == 'ó') returned.Append("\'f3");
                else if (c == 'ł') returned.Append("\'b3");
                else if (c == 'ń') returned.Append("\'f1");
                else if (c == 'ś') returned.Append("\'9c");

                else returned.Append(c);
            }
            return returned.ToString();

        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }
    }
}
