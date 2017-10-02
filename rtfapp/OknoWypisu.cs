using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rtfapp
{
    public partial class OknoWypisu : Form
    {
        static int IDpolaRozpoznan = 200;
        static int IDpolaEKG= 201;
        static int IDpolaUSKG = 207;
        static int IDpolaZalecen = 203;
        static int IDpolaLekow = 204;
        static int IDpolaEpikryzy = 205;

        string tekstRt;
        public string WczytywanyWypisJakoTekst;
        private Wypis BiezacyWypis;
        private AutoCompleteStringCollection ListaAutoCompleteRozpoznania;
        private AutoCompleteStringCollection ListaAutoCompleteLeki;
        private BazaDataSet.rozpoznaniaDataTable TabelaRozpoznania;
        private BazaDataSet.lekiDataTable TabelaLeki;
        private BazaDataSet.lekarzeDataTable TabelaLekarze;
        
        private BazaDataSet.biezaceDataTable BiezaceViewDT;
        private BazaDataSetTableAdapters.biezace_wypisyTableAdapter BiezaceWypisyTableAdapter;
        private BazaDataSetTableAdapters.biezaceTableAdapter BiezaceViewTableAdapter;
        //private BazaDataSetTableAdapters.lekarzeTableAdapter lekarzeTableAdapter;
        private  string sciezkapliku;
        
       // private EchoControl FormularzEcho;



            
        //Kod odpowiedzialny za drag and drop w rozpoznaniach
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

          

        public OknoWypisu(string sciezka = "")
        {
            
            InitializeComponent();
            //FormularzEcho = new EchoControl();
            this.BiezacyWypis = new Wypis();
            TabelaRozpoznania = new BazaDataSet.rozpoznaniaDataTable();
            TabelaLeki = new BazaDataSet.lekiDataTable();

            BiezaceViewDT = new BazaDataSet.biezaceDataTable();
            BiezaceViewTableAdapter = new BazaDataSetTableAdapters.biezaceTableAdapter();
            BiezaceWypisyTableAdapter = new BazaDataSetTableAdapters.biezace_wypisyTableAdapter();
            sciezkapliku = sciezka;
            
            
           //this.sciezkapliku = args[1];
           
            //utworzenie listy lekarzy do wyboru
            TabelaLekarze = new BazaDataSet.lekarzeDataTable();
          
            TabelaLekarze = lekarzeTableAdapter.GetData();
            
            foreach (BazaDataSet.lekarzeRow LekarzRow in TabelaLekarze.Rows)
            {
              wyborlekarzacomboBox.Items.Add(LekarzRow.Nazwa);
              echoControl1.DodajLekarzaDoListy(LekarzRow.Nazwa);
            }

            ZakutalizujWidokBiezacychWypisow();
          


            textControl.ButtonBar = buttonBar;
       

            ZaktualizujListePodpowiedziRozp();
            ZaktualizujListePodpowiedziLekow();

       
            



           // if (sciezkapliku != "") this.ZaladujWypis(sciezkapliku); // jesli bylo z parametrem wywolani
        }



       

        private void OknoWypisu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.elektrokardiogramy' table. You can move, or remove it, as needed.
            //this.elektrokardiogramyTableAdapter.Fill(this.bazaDataSet.elektrokardiogramy);
            // TODO: This line of code loads data into the 'bazaDataSet.lekarze' table. You can move, or remove it, as needed.
            this.lekarzeTableAdapter.Fill(this.bazaDataSet.lekarze);
            // TODO: This line of code loads data into the 'bazaDataSet.rozpoznania' table. You can move, or remove it, as needed.
            this.rozpoznaniaTableAdapter.Fill(this.bazaDataSet.rozpoznania);
          

        }

        private void pacjenciBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacjenciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);

        }

        



       
        //NOWA WERSJA
        public void ZaladujWypis() //można z argumentem lub bez
        {
            Stream myStream = null;
          

            if (sciezkapliku=="")   textControl.Load(TXTextControl.StreamType.RichTextFormat);
            else
            {
                textControl.Load(sciezkapliku,TXTextControl.StreamType.RichTextFormat);
            }
       
            textBox1.Text = textControl.Text;


  
           

             BiezacyWypis.CzytajRegEx(textControl.Text);

            //dodanie wypisu do listy aktualnych wypisów
            BiezaceWypisyTableAdapter.InsertQuery(BiezacyWypis.NumKg, DateTime.Now);
            

         
            this.pESELTextBox.Text = BiezacyWypis.Pesel;
            this.imieTextBox.Text = BiezacyWypis.Imie;
            this.nazwiskoTextBox.Text = BiezacyWypis.Nazwisko;
            this.numKgTextBox.Text = BiezacyWypis.NumKg;


            
 
            try
            {
                this.data_PrzyjeciaDateTimePicker.Value = BiezacyWypis.DataPrzyj;
            }
            catch (Exception ex)
            {
                this.data_PrzyjeciaDateTimePicker.Value = DateTime.Now;
                MessageBox.Show("blad kontrolki datetime " + ex.Message);
            }

            

            BazaDataSet.pacjenciDataTable TabelaPacjenci; // utworzenie obiektu tabeli - zdaje się ze tymczasow kopia danych z bazy

            TabelaPacjenci = this.pacjenciTableAdapter.GetDataByPESEL(BiezacyWypis.Pesel); // wyciagamy tylko jeden wiersz z bazy - tak na przyszlosc, dla efektywnosci

            if (TabelaPacjenci.FindByPESEL(this.BiezacyWypis.Pesel) != null) // jeżeli nie ma PESELU w bazie
            {
                this.pESELTextBox.ForeColor = Color.Green;
            }
            else
            {//pacjenta nie ma w bazie  to go dodajemy
                this.pESELTextBox.ForeColor = Color.Red;
                this.pacjenciTableAdapter.Insert(BiezacyWypis.Pesel, BiezacyWypis.Imie, BiezacyWypis.Nazwisko, "", BiezacyWypis.Adres, "", "", "");

            }

            BazaDataSet.hospitalizacjeDataTable TabelaHospitalizacje; // utworzenie obiekut tabeli - zdaje się ze tymczasow kopia danych z bazy

            TabelaHospitalizacje = this.hospitalizacjeTableAdapter.GetDataByNumKg(BiezacyWypis.NumKg);

            if (TabelaHospitalizacje.FindByNumKg(this.BiezacyWypis.NumKg) != null) // jeżeli nie ma NmeruKG w bazie
            {
                this.numKgTextBox.ForeColor = Color.Green;
            }
            else
            {//pacjenta nie ma w bazie  to go dodajemy
                this.numKgTextBox.ForeColor = Color.Red;
                
                this.hospitalizacjeTableAdapter.Insert(BiezacyWypis.NumKg, BiezacyWypis.Pesel,BiezacyWypis.RozpoznanieGlowne.ICD_10 , BiezacyWypis.DataPrzyj, DateTime.Now, 0, "", "");
            }

            //najpierw usuniemy stare wyniki dla tego numeru kg
            this.badania_laboratoryjneTableAdapter.DeleteByNumKg(BiezacyWypis.NumKg);

            foreach (WynikBadania Wyn in BiezacyWypis.ListaWynikowBadan)
            {
                this.badania_laboratoryjneTableAdapter.InsertQuery(BiezacyWypis.Pesel, Wyn.NazwaBadania, Wyn.DataBadania, Wyn.Wynik, Wyn.Jednostka, Wyn.Zakres, BiezacyWypis.NumKg);
            }

            //ROZPOZNANIA

            if (BiezacyWypis.WczytajRozpoznaniaZBazy() != 0)
            {
                foreach (string Rozpoznanie in BiezacyWypis.ListaRozpoznan)
                {
                    string[] RowArray = { Rozpoznanie };  //tworzymi tablice z jednym elementem
                    this.hosp_rozpDataGridView.Rows.Insert(hosp_rozpDataGridView.Rows.Count - 1, RowArray); //wstawiamy element do datagrid, pobrany z obiektu wypisu, ktroyw sobie wczesniej sciagnal rozpoznania z bazy
                }

            }
            // else MessageBox.Show("Nie dodano jeszcze rozpoznań");
            // ZaktualizaujListeRozpoznan();

            BiezacyWypis.ListaEkg.WczytajZBazy();

            
            this.buttonDodajRozp.Enabled = true;
       
            this.badania_laboratoryjneTableAdapter.FillByNumKg(bazaDataSet.badania_laboratoryjne, BiezacyWypis.NumKg);
            this.elektrokardiogramyTableAdapter.FillByNumKg(bazaDataSet.elektrokardiogramy, BiezacyWypis.NumKg);



            //ZACZEPY!!!

            echoControl1.UstawPacjenta(BiezacyWypis.Pesel, BiezacyWypis.NumKg);

            int Pozycja_Rozpoznania = textControl.Find("ROZPOZNANIE") + 16;
            int Pozycja_EKG = textControl.Find("BADANIA LABORATORYJNE") -2;
            int Pozycja_Epikryza= textControl.Find("EPIKRYZA") + 9;
            int Pozycja_USKG = Pozycja_Epikryza - 12;
            int Pozycja_Zalecenia= textControl.Find("ZALECENIA LEKARSKIE") + 22;
            int Pozycja_Leki = Pozycja_Zalecenia + 4;

            StworzZaczep(Pozycja_Rozpoznania, IDpolaRozpoznan);
            StworzZaczep(Pozycja_EKG, IDpolaEKG);
            StworzZaczep(Pozycja_Epikryza, IDpolaEpikryzy);
            StworzZaczep(Pozycja_Leki, IDpolaLekow);
            StworzZaczep(Pozycja_USKG, IDpolaUSKG);
            StworzZaczep(Pozycja_Zalecenia, IDpolaZalecen);

            //itd
            //TU SKONCZYLEM

            // byte[] BinaryFile;

          // textControl.Save
            ZaktualizujWidokWypisu();
        }

        private void StworzZaczep(int inputpos, int ID)
        {

            TXTextControl.InputPosition Inputp = new TXTextControl.InputPosition(inputpos);

            textControl.InputPosition = Inputp;
            TXTextControl.TextField NewField = new TXTextControl.TextField("");
            int FieldId = ID;
            NewField.ID = FieldId;
            textControl.TextFields.Add(NewField);



            /*
            textControl.Selection.Start = textControl.TextFields.GetItem(FieldId).Start - 1;
            textControl.Selection.Length = textControl.TextFields.GetItem(FieldId).Length + 1;
            
            textControl.Selection.FontName = "Tahoma";
            textControl.Selection.FontSize = 400;
            textControl.Selection.Bold = true;
            */
        }


        private void ZaktualizujListePodpowiedziRozp()

        {
            this.TabelaRozpoznania = this.rozpoznaniaTableAdapter.GetData();

            textBoxWyszukiwanieRozp.AutoCompleteCustomSource.Clear(); //wyrzuca wyszytko co było dotychczas

            //utworzenie lity podpowiedzi do rozpoznań
            foreach (BazaDataSet.rozpoznaniaRow RozpRow in TabelaRozpoznania.Rows)
            {
                textBoxWyszukiwanieRozp.AutoCompleteCustomSource.Add(RozpRow.Roszerzone_rozpoznanie);

            }
            
        }

        private void ZaktualizujListePodpowiedziLekow()
        {
            this.TabelaLeki = this.lekiTableAdapter1.GetData();

            comboBoxDodawanieLeku.AutoCompleteCustomSource.Clear();

            foreach (BazaDataSet.lekiRow LekRow in TabelaLeki.Rows)
            {
                comboBoxDodawanieLeku.AutoCompleteCustomSource.Add(LekRow.LekDawka);
            }



        }



        public void PrzyciskLadowaniaWypisu_Click(object sender, EventArgs e)
        {
            ZaladujWypis();
        }

       

        private void buttonDodajRozp_Click(object sender, EventArgs e)
        {
            if(textBoxWyszukiwanieRozp.Text!="")
            {
                //dodajemy nowe rozpozananie szczegolowe do tabeli, zmieniamy pobieramy id na podstawie tableli rozpoznan  

                string[] RowArray = { textBoxWyszukiwanieRozp.Text };
                             
                this.hosp_rozpDataGridView.Rows.Insert(hosp_rozpDataGridView.Rows.Count-1,RowArray);
            

                ZaktualizaujListeRozpoznan(); 
                BiezacyWypis.ZaktualizujRozpoznaniaWBazie();
                textBoxWyszukiwanieRozp.Text = "";
            }
          
            
        }

         


        private void ZaktualizaujListeRozpoznan()
        {
            BiezacyWypis.ListaRozpoznan.Clear(); //czyscimy aktualna liste rozpoznan

            foreach (DataGridViewRow Row in this.hosp_rozpDataGridView.Rows)
            {

                if (Row.Cells[0].Value != null)
                {
                    BiezacyWypis.ListaRozpoznan.Add(Row.Cells[0].Value.ToString()); //dodajemy kolejno rozpoznania z okienka DataGridView
                }


            }
            ZaktualizujWidokWypisu();
           
        }


        private void ZaktualizujListeLekow()
        {

            BiezacyWypis.ListaLek.Wyczysc();

            foreach (DataGridViewRow Row in this.dataGridViewLeki.Rows)
            {

                int LekId;

                if (!Row.IsNewRow)
                {
                    Int32.TryParse(Row.Cells[0].Value.ToString(), out LekId); // żeby lekId bylo intem
                    BiezacyWypis.ListaLek.DodajLekDoListy(LekId, Row.Cells[1].Value.ToString(), Row.Cells[2].Value.ToString(), Row.Cells[3].Value.ToString(), Row.Cells[4].Value.ToString());
                }
               // BiezacyWypis.ZaktualizujRtf();
                ZaktualizujWidokWypisu();
            }
           

            



        }

        private void textBoxWyszukiwanieRozp_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.buttonDodajRozp;
        }

        private void textBoxWyszukiwanieRozp_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = this.buttonAccept;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
  //          
             //  tekstRt =richTextBoxBiezacyWypis.Rtf;
           

        }
        private void UstawTekstPola(string nowytext, int IDpola, int rozmiar = 200, string czcionka = "Tahoma", bool bold=true)
        {
            textControl.TextFields.GetItem(IDpola).Text = nowytext;

            textControl.Selection.Start = textControl.TextFields.GetItem(IDpola).Start - 1;
            textControl.Selection.Length = textControl.TextFields.GetItem(IDpola).Length + 1;

            textControl.Selection.FontName = czcionka;
            textControl.Selection.FontSize = rozmiar;
            textControl.Selection.Bold = bold;
        }
   
        private void ZaktualizujWidokWypisu()
        {
            UstawTekstPola(BiezacyWypis.RozpoznaniaNaWypis(), IDpolaRozpoznan);
            UstawTekstPola(BiezacyWypis.ListaEkg.ListaNaWypis(), IDpolaEKG);
            UstawTekstPola("USKG", IDpolaUSKG);
            UstawTekstPola("Epikryza", IDpolaEpikryzy);
            UstawTekstPola("Zalecenia:", IDpolaZalecen);
            UstawTekstPola("Leki", IDpolaLekow);




            //TODO - powiniene w tym miejscu zapisac tez aktualny RTF do bazy dancyh
        }

        private void buttonDodajEKG_Click(object sender, EventArgs e)
        {

            string etykieta;

            if (ekgDataGridView.Rows.Count == 1) etykieta = "EKG przy przyjęciu";
            else etykieta = "EKG kontrolne";


            if (textBoxEKG.Text != "")
            {

                string[] RowArray = {etykieta, textBoxEKG.Text };

                ekgDataGridView.Rows.Insert(ekgDataGridView.Rows.Count - 1, RowArray);
                ZaktualizujListeEkg();
                ZaktualizujWidokWypisu();
                
                textBoxEKG.Text = "";


            }


        }
        private void ZaktualizujListeEkg()
        {
            BiezacyWypis.ListaEkg.Wyczysc();

            foreach (DataGridViewRow Row in this.ekgDataGridView.Rows)
            {

                if (Row.Cells[0].Value != null)
                BiezacyWypis.ListaEkg.DodajEKG(Row.Cells[0].Value.ToString()+": "+ Row.Cells[1].Value.ToString());
            }

                  
            BiezacyWypis.ListaEkg.ZaktualizujDoBazy();
        }

        private void buttonDodajNoweRozp_Click(object sender, EventArgs e)
        {
           Dodawanie_rozpoznania FormDodawanieRozp = new Dodawanie_rozpoznania();
            FormDodawanieRozp.ShowDialog();
            ZaktualizujListePodpowiedziRozp();
        }


        private void echoControl1_Leave(object sender, EventArgs e)
        {
            echoControl1.ZapiszDaneEcha();
            BiezacyWypis.Echokardiogram = echoControl1.Echokardiogram;
            //BiezacyWypis.ZaktualizujRtf();
            ZaktualizujWidokWypisu();
        }

        private void echoControl1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void buttonDodajNowyLek_Click(object sender, EventArgs e)
        {
            DodajNowyLek DodawanieLeku;
            DodawanieLeku = new DodajNowyLek();
            DodawanieLeku.ShowDialog();
        }





        public void ZakutalizujWidokBiezacychWypisow()
        {
            BiezaceViewDT = BiezaceViewTableAdapter.GetData();

            listBoxWypisy.Items.Clear();
            foreach (BazaDataSet.biezaceRow BW in BiezaceViewDT.Rows)
            {
                // ListBox.ObjectCollection obc;
                // obc = new ListBox.ObjectCollection(listBoxWypisy);
                //obc.

                listBoxWypisy.Items.Add(BW.imie_i_nazwisko);
            }



        }



        /***************************************DGV*******************************************************************/
        //Drag and drop:

        private void DGV_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DGV_DragDrop(DataGridView dgv, object sender, DragEventArgs e)
        {

            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgv.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dgv.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                dgv.Rows.RemoveAt(rowIndexFromMouseDown);
                dgv.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

                ZaktualizaujListeRozpoznan(); //aktualizujemy wszystko
                BiezacyWypis.ZaktualizujRozpoznaniaWBazie();


            }


        }

        private void DGV_MouseMove(DataGridView dgv, object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgv.DoDragDrop(
                    dgv.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void DGV_MouseDown(DataGridView dgv, object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgv.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }


        /**************************hosp-rozp*************************************************************/
        private void hosp_rozpDataGridView_DragOver(object sender, DragEventArgs e)
        {
            DGV_DragOver(sender, e);
        }

        private void hosp_rozpDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            DGV_DragDrop(hosp_rozpDataGridView, sender, e);
        }

        private void hosp_rozpDataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            DGV_MouseMove(hosp_rozpDataGridView, sender, e);
        }

        private void hosp_rozpDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DGV_MouseDown(hosp_rozpDataGridView, sender, e);
        }

        private void hosp_rozpDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ZaktualizaujListeRozpoznan();
            BiezacyWypis.ZaktualizujRozpoznaniaWBazie();
        }


        /*******************************leki***************************************************************/


        private void dataGridViewLeki_MouseMove(object sender, MouseEventArgs e)
        {
            DGV_MouseMove(dataGridViewLeki, sender, e);
        }

        private void dataGridViewLeki_MouseDown(object sender, MouseEventArgs e)
        {
            DGV_MouseDown(dataGridViewLeki, sender, e);
        }

        private void dataGridViewLeki_DragOver(object sender, DragEventArgs e)
        {
            DGV_DragOver(sender, e);
        }

        private void dataGridViewLeki_DragDrop(object sender, DragEventArgs e)
        {
            DGV_DragDrop(dataGridViewLeki, sender, e);
        }

        private void dataGridViewLeki_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ZaktualizujListeLekow();
            BiezacyWypis.ListaLek.ZaktualizujLekiWBazie();
        }

    











        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEpikryza_TextChanged(object sender, EventArgs e)
        {

        }

        private void DzisiejszeWypisy_Click(object sender, EventArgs e)
        {

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zgonCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void zgonLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_PrzyjeciaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        private void hosp_rozpDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxWyszukiwanieRozp_TextChanged(object sender, EventArgs e)
        {

        }

        private void elektrokardiogramyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OknoWypisu_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

     

        private void comboBoxDodawanieLeku_TextUpdate(object sender, EventArgs e)
        {
            //comboBoxDodawanieLeku.AutoCompleteCustomSource = BiezacyWypis.ListaLek.DajListePodpowiedziLekow(comboBoxDodawanieLeku.Text, comboBoxDodawanieLeku);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxDodawanieLeku.Text != "")
            {
                //dodajemy nowe rozpozananie szczegolowe do tabeli, zmieniamy pobieramy id na podstawie tableli rozpoznan  

                BazaDataSet.lekiDataTable LekNaPodstawieOpisu = new BazaDataSet.lekiDataTable();

                string LekDawka = Program.FirstCharToUpper(comboBoxDodawanieLeku.Text);
                    
                

                LekNaPodstawieOpisu = lekiTableAdapter1.GetDataByLekDawka(comboBoxDodawanieLeku.Text); //pobieramy rekord leku na podstawie jego "tekstu z nazwą i dawką"

                string LekId = LekNaPodstawieOpisu.First().Lek_ID.ToString();
                string LekNazwa = LekNaPodstawieOpisu.First().Nazwa_Handlowa;
                string LekTypDawka = LekNaPodstawieOpisu.First().Typowa_Dawka;
                string LekDawkowanie = LekNaPodstawieOpisu.First().Typowe_Dawkowanie;
                    
                string[] RowArray = {LekId , LekDawka, LekNazwa , LekTypDawka,  LekDawkowanie};

                dataGridViewLeki.Rows.Insert(dataGridViewLeki.Rows.Count - 1, RowArray);

                //this.hosp_rozpDataGridView.Rows.Insert(hosp_rozpDataGridView.Rows.Count - 1, RowArray);


                ZaktualizujListeLekow();
                BiezacyWypis.ListaLek.ZaktualizujLekiWBazie();
               comboBoxDodawanieLeku.Text = "";
            }
        }

        private void comboBoxDodawanieLeku_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.buttonDodajLek;
        }

        private void comboBoxDodawanieLeku_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = this.buttonAccept;
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDoWydruku_Click(object sender, EventArgs e)
        {
            WypisDoWydruku();
        }

        public void WypisDoWydruku()
        {
            string SciezkaZapisu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pliki Wygenerowane RtfApp\";
            string NazwaPliku = "Wypis_INK_" + BiezacyWypis.Nazwisko + "_" + BiezacyWypis.Imie + "_" + BiezacyWypis.Pesel + "_" + DateTime.Now.ToShortDateString() + ".rtf";
            File.WriteAllText(SciezkaZapisu + NazwaPliku, BiezacyWypis.PlikRtf);
            System.Diagnostics.Process.Start(SciezkaZapisu + NazwaPliku);

        }

        private void textControl1_Click(object sender, EventArgs e)
        {

        }

        private void OknoWypisu_Validated(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void listBoxWypisy_MouseLeave(object sender, EventArgs e)
        {
            listBoxWypisy.Height = 69;
        }

        private void listBoxWypisy_MouseHover(object sender, EventArgs e)
        {
            listBoxWypisy.Height = 693;
            //ZakutalizujWidokBiezacychWypisow();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ZakutalizujWidokBiezacychWypisow();
        }

        private void listBoxWypisy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
