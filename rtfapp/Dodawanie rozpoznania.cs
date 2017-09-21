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
    public partial class Dodawanie_rozpoznania : Form
    {
        public Dodawanie_rozpoznania()
        {
            InitializeComponent();
            this.rozpoznaniaTableAdapter.Fill(this.bazaDataSet.rozpoznania);
        }

        private void rozpoznaniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         //   this.Validate();
          //  this.rozpoznaniaBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.bazaDataSet);

        }

        private void Dodawanie_rozpoznania_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.rozpoznania' table. You can move, or remove it, as needed.
           // this.rozpoznaniaTableAdapter.Fill(this.bazaDataSet.rozpoznania);

        }

        private void rozpoznaniaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajNoweRozp_Click(object sender, EventArgs e)
        {
            if(textBoxNazwRozp.Text!="")
            {
                if( this.rozpoznaniaTableAdapter.GetDataByRoszerzoneRozp(this.textBoxNazwRozp.Text).Rows.Count==0) //jeśli jeszcze nie mamy rozpoznania o takiej nazwie
                {
                    this.rozpoznaniaTableAdapter.InsertQuery(textBoxICD.Text, textBoxNazwRozp.Text, textBoxNazwRozp.Text); // dodaj nowe rozpo z dwoma takimi samymi nazwami
                }
                else
                {
                    MessageBox.Show("Takie już istnieje");
                }
            }
            else
            {
                MessageBox.Show("Podaj przynajmiej nazwę nowego rozpoznania");
            }

            this.rozpoznaniaTableAdapter.Fill(this.bazaDataSet.rozpoznania);
        }
    }
}
