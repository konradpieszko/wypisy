using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rtfapp
{
    public partial class DodajNowyLek : Form
    {
        
        public DodajNowyLek()
        {
            InitializeComponent();
        }

        private void lekiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lekiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);

        }

        private void DodajNowyLek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.leki' table. You can move, or remove it, as needed.
            this.lekiTableAdapter.Fill(this.bazaDataSet.leki);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajLek();
        }

        private void DodajLek()
        {
            string TekstLekDawka = textBoxNazwa.Text + "  " + textBoxDawka + "mg ; " + textBoxDawkowanie.Text;
            lekiTableAdapter.InsertQuery(textBoxNazwa.Text, textBoxSubstancje.Text, textBoxDawka.Text, textBoxDawkowanie.Text, comboBoxProducent.Text, comboBoxKategoria.Text, TekstLekDawka);

            textBoxDawka.Text = "";
            textBoxDawkowanie.Text = "";
            textBoxNazwa.Text = "";
            textBoxSubstancje.Text = "";
            comboBoxKategoria.Text = "";
            comboBoxProducent.Text = "";
            this.lekiTableAdapter.Fill(this.bazaDataSet.leki);
        }
    }
}
