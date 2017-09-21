using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rtfapp
{
    public partial class EchoControl : UserControl
    {
        public rtfapp.Echo Echokardiogram;
        private BazaDataSet bazaDataSet;
        private BazaDataSet.lekarzeDataTable TabelaLekarze;
        private BazaDataSetTableAdapters.lekarzeTableAdapter lekarzeTableAdapter;

        public EchoControl()
        {
            InitializeComponent();
            bazaDataSet = new BazaDataSet();
            Echokardiogram = new rtfapp.Echo();
            this.dateTimePicker1.Value = DateTime.Now; //domyslnie echo wykonane dzis
            this.Enabled = false; // kontrolka jest dezaktywowane bez podstawowych danych, co najmniej PESELU

            
                
        }

        public void UstawPacjenta(string PESEL, string NumKG ="", string NumWizyty = "")
        {
            Echokardiogram.PESEL = PESEL;
            tbPESEL.Text = PESEL;
           
            if ((NumKG=="") && (NumWizyty == ""))
            {
                MessageBox.Show("blad");

            }
            else if (NumKG!="") //Jesli dodajemy echo szpitalne
            {

                Echokardiogram.NumKG = NumKG;
                Echokardiogram.CzyOdzialowe = true;
                this.Enabled = true;
                

            }
            else
            {

                Echokardiogram.NumWizyty = NumWizyty; //jesli ambulatoryjne
                Echokardiogram.CzyOdzialowe = false;
                this.Enabled = true;

            }
     

        }

        public void ZapiszDaneEcha()
        {
            Echokardiogram.LA = tbLA.Text;
            Echokardiogram.LV = tbLV.Text;
            Echokardiogram.Ao = tbAo.Text;
            Echokardiogram.RV = tbRV.Text;
            Echokardiogram.IVS = tbIVS.Text;
            Echokardiogram.PWLV = tbPWLV.Text;

            Echokardiogram.AcT = tbAcT.Text;
            Echokardiogram.Pulm = tbPulm.Text;
            Echokardiogram.Mitralna_Morf = tbMiMorf.Text;
            Echokardiogram.Mitralna_Czynn = TbMiCz.Text;
            Echokardiogram.Mitralna_Vmax = tbMiVmax.Text;
            Echokardiogram.Aortalna_Morf = tbAoMorf.Text;
            Echokardiogram.Aortalna_Czynn = tbAoCz.Text;
            Echokardiogram.Aortalna_Vmax = tbAoVmax.Text;
            Echokardiogram.Trojdzielna = tbTroj.Text;
            Echokardiogram.Trojdzielna_MaxPG = tbTRmaxPG.Text;
            Echokardiogram.Kurczliwosc = tbKurczliwosc.Text;
            Echokardiogram.EF = tbEF.Text;
            Echokardiogram.Rozkurcz = tbRozkurcz.Text;
            Echokardiogram.CzyUposledzony = radioButtonRozkurcz.Checked;
            Echokardiogram.DataBadania = dateTimePicker1.Value;
            Echokardiogram.FalaA = tbfalaA.Text;
            Echokardiogram.FalaE = tbfalaE.Text;
            Echokardiogram.Lekarz = this.wyborlekarzacomboBox.Text;

        }

        public void DodajLekarzaDoListy(string Lekarz)
        {
            this.wyborlekarzacomboBox.Items.Add(Lekarz);
        }
























        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EchoControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            this.ZapiszDaneEcha();

        }
    }
}
