namespace rtfapp
{
    partial class OknoWypisu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pESELLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label numKgLabel;
            System.Windows.Forms.Label data_PrzyjeciaLabel;
            System.Windows.Forms.Label zgonLabel;
            System.Windows.Forms.Label data_WypisuLabel;
            this.Taby = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosp_rozpDataGridView = new System.Windows.Forms.DataGridView();
            this.Rozpoznania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajNoweRozp = new System.Windows.Forms.Button();
            this.buttonDodajRozp = new System.Windows.Forms.Button();
            this.textBoxWyszukiwanieRozp = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ekgDataGridView = new System.Windows.Forms.DataGridView();
            this.Etykieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rytm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czestosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EkgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajEKG = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxEKG = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.echoControl1 = new rtfapp.EchoControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxDodawanieLeku = new System.Windows.Forms.ComboBox();
            this.buttonDodajNowyLek = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLeki = new System.Windows.Forms.DataGridView();
            this.LekID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TekstLeku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dawka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dawkowanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajLek = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.TabEpikryza = new System.Windows.Forms.TabPage();
            this.textBoxEpikryza = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.badania_laboratoryjneDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badania_laboratoryjneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new rtfapp.BazaDataSet();
            this.elektrokardiogramyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrzyciskLadowaniaWypisu = new System.Windows.Forms.Button();
            this.pacjenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESELTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.numKgTextBox = new System.Windows.Forms.TextBox();
            this.hospitalizacjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_PrzyjeciaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zgonCheckBox = new System.Windows.Forms.CheckBox();
            this.data_WypisuDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.wyborlekarzacomboBox = new System.Windows.Forms.ComboBox();
            this.DzisiejszeWypisy = new System.Windows.Forms.Label();
            this.hosp_rozpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacjenciTableAdapter = new rtfapp.BazaDataSetTableAdapters.pacjenciTableAdapter();
            this.tableAdapterManager = new rtfapp.BazaDataSetTableAdapters.TableAdapterManager();
            this.hospitalizacjeTableAdapter = new rtfapp.BazaDataSetTableAdapters.hospitalizacjeTableAdapter();
            this.badania_laboratoryjneTableAdapter = new rtfapp.BazaDataSetTableAdapters.badania_laboratoryjneTableAdapter();
            this.hosp_rozpTableAdapter = new rtfapp.BazaDataSetTableAdapters.hosp_rozpTableAdapter();
            this.rozpoznaniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rozpoznaniaTableAdapter = new rtfapp.BazaDataSetTableAdapters.rozpoznaniaTableAdapter();
            this.lekarzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekarzeTableAdapter = new rtfapp.BazaDataSetTableAdapters.lekarzeTableAdapter();
            this.elektrokardiogramyTableAdapter = new rtfapp.BazaDataSetTableAdapters.elektrokardiogramyTableAdapter();
            this.lekiTableAdapter1 = new rtfapp.BazaDataSetTableAdapters.lekiTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textControl = new TXTextControl.TextControl();
            this.buttonBar = new TXTextControl.ButtonBar();
            this.serverTextControl1 = new TXTextControl.ServerTextControl();
            pESELLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            numKgLabel = new System.Windows.Forms.Label();
            data_PrzyjeciaLabel = new System.Windows.Forms.Label();
            zgonLabel = new System.Windows.Forms.Label();
            data_WypisuLabel = new System.Windows.Forms.Label();
            this.Taby.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosp_rozpDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekgDataGridView)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeki)).BeginInit();
            this.TabEpikryza.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badania_laboratoryjneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badania_laboratoryjneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elektrokardiogramyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalizacjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosp_rozpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzeBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pESELLabel
            // 
            pESELLabel.AutoSize = true;
            pESELLabel.Location = new System.Drawing.Point(11, 14);
            pESELLabel.Name = "pESELLabel";
            pESELLabel.Size = new System.Drawing.Size(44, 13);
            pESELLabel.TabIndex = 14;
            pESELLabel.Text = "PESEL:";
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(167, 14);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(29, 13);
            imieLabel.TabIndex = 15;
            imieLabel.Text = "Imie:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(307, 14);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            nazwiskoLabel.TabIndex = 16;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // numKgLabel
            // 
            numKgLabel.AutoSize = true;
            numKgLabel.Location = new System.Drawing.Point(7, 41);
            numKgLabel.Name = "numKgLabel";
            numKgLabel.Size = new System.Drawing.Size(48, 13);
            numKgLabel.TabIndex = 18;
            numKgLabel.Text = "Num Kg:";
            // 
            // data_PrzyjeciaLabel
            // 
            data_PrzyjeciaLabel.AutoSize = true;
            data_PrzyjeciaLabel.Location = new System.Drawing.Point(163, 45);
            data_PrzyjeciaLabel.Name = "data_PrzyjeciaLabel";
            data_PrzyjeciaLabel.Size = new System.Drawing.Size(78, 13);
            data_PrzyjeciaLabel.TabIndex = 19;
            data_PrzyjeciaLabel.Text = "Data Przyjecia:";
            // 
            // zgonLabel
            // 
            zgonLabel.AutoSize = true;
            zgonLabel.Location = new System.Drawing.Point(393, 45);
            zgonLabel.Name = "zgonLabel";
            zgonLabel.Size = new System.Drawing.Size(35, 13);
            zgonLabel.TabIndex = 20;
            zgonLabel.Text = "Zgon:";
            zgonLabel.Click += new System.EventHandler(this.zgonLabel_Click);
            // 
            // data_WypisuLabel
            // 
            data_WypisuLabel.AutoSize = true;
            data_WypisuLabel.Location = new System.Drawing.Point(170, 71);
            data_WypisuLabel.Name = "data_WypisuLabel";
            data_WypisuLabel.Size = new System.Drawing.Size(71, 13);
            data_WypisuLabel.TabIndex = 21;
            data_WypisuLabel.Text = "Data Wypisu:";
            // 
            // Taby
            // 
            this.Taby.Controls.Add(this.tabPage1);
            this.Taby.Controls.Add(this.tabPage2);
            this.Taby.Controls.Add(this.tabPage10);
            this.Taby.Controls.Add(this.tabPage3);
            this.Taby.Controls.Add(this.tabPage4);
            this.Taby.Controls.Add(this.tabPage6);
            this.Taby.Controls.Add(this.TabEpikryza);
            this.Taby.Controls.Add(this.tabPage5);
            this.Taby.Dock = System.Windows.Forms.DockStyle.Right;
            this.Taby.HotTrack = true;
            this.Taby.Location = new System.Drawing.Point(962, 116);
            this.Taby.Multiline = true;
            this.Taby.Name = "Taby";
            this.tableLayoutPanel1.SetRowSpan(this.Taby, 2);
            this.Taby.SelectedIndex = 0;
            this.Taby.Size = new System.Drawing.Size(555, 717);
            this.Taby.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.hosp_rozpDataGridView);
            this.tabPage1.Controls.Add(this.buttonDodajNoweRozp);
            this.tabPage1.Controls.Add(this.buttonDodajRozp);
            this.tabPage1.Controls.Add(this.textBoxWyszukiwanieRozp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rozpoznania";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rozpoznania z poprzednich pobytów";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView3.Location = new System.Drawing.Point(6, 369);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(429, 194);
            this.dataGridView3.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Rozpoznania";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // hosp_rozpDataGridView
            // 
            this.hosp_rozpDataGridView.AllowDrop = true;
            this.hosp_rozpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hosp_rozpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rozpoznania});
            this.hosp_rozpDataGridView.Location = new System.Drawing.Point(6, 56);
            this.hosp_rozpDataGridView.Name = "hosp_rozpDataGridView";
            this.hosp_rozpDataGridView.Size = new System.Drawing.Size(429, 257);
            this.hosp_rozpDataGridView.TabIndex = 5;
            this.hosp_rozpDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.hosp_rozpDataGridView_UserDeletedRow);
            this.hosp_rozpDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.hosp_rozpDataGridView_DragDrop);
            this.hosp_rozpDataGridView.DragOver += new System.Windows.Forms.DragEventHandler(this.hosp_rozpDataGridView_DragOver);
            this.hosp_rozpDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hosp_rozpDataGridView_MouseDown);
            this.hosp_rozpDataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hosp_rozpDataGridView_MouseMove);
            // 
            // Rozpoznania
            // 
            this.Rozpoznania.HeaderText = "Rozpoznania";
            this.Rozpoznania.Name = "Rozpoznania";
            this.Rozpoznania.Width = 400;
            // 
            // buttonDodajNoweRozp
            // 
            this.buttonDodajNoweRozp.Location = new System.Drawing.Point(373, 10);
            this.buttonDodajNoweRozp.Name = "buttonDodajNoweRozp";
            this.buttonDodajNoweRozp.Size = new System.Drawing.Size(62, 39);
            this.buttonDodajNoweRozp.TabIndex = 4;
            this.buttonDodajNoweRozp.Text = "Dodaj nowe rozpoznanie";
            this.buttonDodajNoweRozp.UseVisualStyleBackColor = true;
            this.buttonDodajNoweRozp.Click += new System.EventHandler(this.buttonDodajNoweRozp_Click);
            // 
            // buttonDodajRozp
            // 
            this.buttonDodajRozp.Enabled = false;
            this.buttonDodajRozp.Location = new System.Drawing.Point(285, 10);
            this.buttonDodajRozp.Name = "buttonDodajRozp";
            this.buttonDodajRozp.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajRozp.TabIndex = 2;
            this.buttonDodajRozp.Text = "Dodaj";
            this.buttonDodajRozp.UseVisualStyleBackColor = true;
            this.buttonDodajRozp.Click += new System.EventHandler(this.buttonDodajRozp_Click);
            // 
            // textBoxWyszukiwanieRozp
            // 
            this.textBoxWyszukiwanieRozp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxWyszukiwanieRozp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxWyszukiwanieRozp.Location = new System.Drawing.Point(6, 12);
            this.textBoxWyszukiwanieRozp.Name = "textBoxWyszukiwanieRozp";
            this.textBoxWyszukiwanieRozp.Size = new System.Drawing.Size(271, 20);
            this.textBoxWyszukiwanieRozp.TabIndex = 1;
            this.textBoxWyszukiwanieRozp.TextChanged += new System.EventHandler(this.textBoxWyszukiwanieRozp_TextChanged);
            this.textBoxWyszukiwanieRozp.Enter += new System.EventHandler(this.textBoxWyszukiwanieRozp_Enter);
            this.textBoxWyszukiwanieRozp.Leave += new System.EventHandler(this.textBoxWyszukiwanieRozp_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ekgDataGridView);
            this.tabPage2.Controls.Add(this.buttonDodajEKG);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBoxEKG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EKG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ekgDataGridView
            // 
            this.ekgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ekgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etykieta,
            this.Opis,
            this.Rytm,
            this.Czestosc,
            this.EkgId});
            this.ekgDataGridView.Location = new System.Drawing.Point(17, 175);
            this.ekgDataGridView.Name = "ekgDataGridView";
            this.ekgDataGridView.Size = new System.Drawing.Size(516, 182);
            this.ekgDataGridView.TabIndex = 6;
            // 
            // Etykieta
            // 
            this.Etykieta.HeaderText = "Etykieta";
            this.Etykieta.Name = "Etykieta";
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.Width = 400;
            // 
            // Rytm
            // 
            this.Rytm.HeaderText = "Rytm";
            this.Rytm.Name = "Rytm";
            this.Rytm.Visible = false;
            // 
            // Czestosc
            // 
            this.Czestosc.HeaderText = "Czestosc";
            this.Czestosc.Name = "Czestosc";
            this.Czestosc.Visible = false;
            // 
            // EkgId
            // 
            this.EkgId.HeaderText = "EkgId";
            this.EkgId.Name = "EkgId";
            this.EkgId.Visible = false;
            // 
            // buttonDodajEKG
            // 
            this.buttonDodajEKG.Location = new System.Drawing.Point(340, 16);
            this.buttonDodajEKG.Name = "buttonDodajEKG";
            this.buttonDodajEKG.Size = new System.Drawing.Size(79, 23);
            this.buttonDodajEKG.TabIndex = 5;
            this.buttonDodajEKG.Text = "Do wypisu";
            this.buttonDodajEKG.UseVisualStyleBackColor = true;
            this.buttonDodajEKG.Click += new System.EventHandler(this.buttonDodajEKG_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "AF";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "RZM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxEKG
            // 
            this.textBoxEKG.Location = new System.Drawing.Point(9, 129);
            this.textBoxEKG.Name = "textBoxEKG";
            this.textBoxEKG.Size = new System.Drawing.Size(410, 20);
            this.textBoxEKG.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.textBox1);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(547, 691);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "Leczenie";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 446);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.echoControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(547, 691);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DodajEcho";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // echoControl1
            // 
            this.echoControl1.Enabled = false;
            this.echoControl1.Location = new System.Drawing.Point(-9, 3);
            this.echoControl1.Name = "echoControl1";
            this.echoControl1.Size = new System.Drawing.Size(571, 548);
            this.echoControl1.TabIndex = 0;
            this.echoControl1.Leave += new System.EventHandler(this.echoControl1_Leave);
            this.echoControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.echoControl1_MouseUp);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxDodawanieLeku);
            this.tabPage4.Controls.Add(this.buttonDodajNowyLek);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.dataGridViewLeki);
            this.tabPage4.Controls.Add(this.buttonDodajLek);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(547, 691);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Leki";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxDodawanieLeku
            // 
            this.comboBoxDodawanieLeku.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDodawanieLeku.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxDodawanieLeku.FormattingEnabled = true;
            this.comboBoxDodawanieLeku.Location = new System.Drawing.Point(20, 18);
            this.comboBoxDodawanieLeku.Name = "comboBoxDodawanieLeku";
            this.comboBoxDodawanieLeku.Size = new System.Drawing.Size(400, 21);
            this.comboBoxDodawanieLeku.TabIndex = 7;
            this.comboBoxDodawanieLeku.TextUpdate += new System.EventHandler(this.comboBoxDodawanieLeku_TextUpdate);
            this.comboBoxDodawanieLeku.Enter += new System.EventHandler(this.comboBoxDodawanieLeku_Enter);
            this.comboBoxDodawanieLeku.Leave += new System.EventHandler(this.comboBoxDodawanieLeku_Leave);
            // 
            // buttonDodajNowyLek
            // 
            this.buttonDodajNowyLek.Location = new System.Drawing.Point(434, 88);
            this.buttonDodajNowyLek.Name = "buttonDodajNowyLek";
            this.buttonDodajNowyLek.Size = new System.Drawing.Size(95, 48);
            this.buttonDodajNowyLek.TabIndex = 6;
            this.buttonDodajNowyLek.Text = "Dodaj Nowy Lek";
            this.buttonDodajNowyLek.UseVisualStyleBackColor = true;
            this.buttonDodajNowyLek.Click += new System.EventHandler(this.buttonDodajNowyLek_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(400, 122);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewLeki
            // 
            this.dataGridViewLeki.AllowDrop = true;
            this.dataGridViewLeki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LekID,
            this.TekstLeku,
            this.Nazwa,
            this.Dawka,
            this.Dawkowanie});
            this.dataGridViewLeki.Location = new System.Drawing.Point(20, 55);
            this.dataGridViewLeki.Name = "dataGridViewLeki";
            this.dataGridViewLeki.Size = new System.Drawing.Size(400, 226);
            this.dataGridViewLeki.TabIndex = 4;
            this.dataGridViewLeki.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewLeki_UserDeletedRow);
            this.dataGridViewLeki.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewLeki_DragDrop);
            this.dataGridViewLeki.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewLeki_DragOver);
            this.dataGridViewLeki.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewLeki_MouseDown);
            this.dataGridViewLeki.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewLeki_MouseMove);
            // 
            // LekID
            // 
            this.LekID.HeaderText = "ID";
            this.LekID.Name = "LekID";
            this.LekID.Visible = false;
            // 
            // TekstLeku
            // 
            this.TekstLeku.HeaderText = "Nazwa i dawkowanie";
            this.TekstLeku.Name = "TekstLeku";
            this.TekstLeku.Width = 300;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Visible = false;
            // 
            // Dawka
            // 
            this.Dawka.HeaderText = "Dawka";
            this.Dawka.Name = "Dawka";
            this.Dawka.Visible = false;
            // 
            // Dawkowanie
            // 
            this.Dawkowanie.HeaderText = "Dawkowanie";
            this.Dawkowanie.Name = "Dawkowanie";
            this.Dawkowanie.Visible = false;
            // 
            // buttonDodajLek
            // 
            this.buttonDodajLek.Location = new System.Drawing.Point(426, 17);
            this.buttonDodajLek.Name = "buttonDodajLek";
            this.buttonDodajLek.Size = new System.Drawing.Size(116, 21);
            this.buttonDodajLek.TabIndex = 1;
            this.buttonDodajLek.Text = "Dodaj";
            this.buttonDodajLek.UseVisualStyleBackColor = true;
            this.buttonDodajLek.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(547, 691);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Zalecenia";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // TabEpikryza
            // 
            this.TabEpikryza.Controls.Add(this.textBoxEpikryza);
            this.TabEpikryza.Controls.Add(this.button15);
            this.TabEpikryza.Controls.Add(this.button14);
            this.TabEpikryza.Controls.Add(this.button13);
            this.TabEpikryza.Controls.Add(this.button12);
            this.TabEpikryza.Controls.Add(this.button11);
            this.TabEpikryza.Controls.Add(this.button10);
            this.TabEpikryza.Controls.Add(this.button9);
            this.TabEpikryza.Controls.Add(this.button8);
            this.TabEpikryza.Controls.Add(this.button7);
            this.TabEpikryza.Controls.Add(this.button6);
            this.TabEpikryza.Controls.Add(this.button5);
            this.TabEpikryza.Controls.Add(this.button4);
            this.TabEpikryza.Location = new System.Drawing.Point(4, 22);
            this.TabEpikryza.Name = "TabEpikryza";
            this.TabEpikryza.Padding = new System.Windows.Forms.Padding(3);
            this.TabEpikryza.Size = new System.Drawing.Size(547, 691);
            this.TabEpikryza.TabIndex = 3;
            this.TabEpikryza.Text = "Epikryza";
            this.TabEpikryza.UseVisualStyleBackColor = true;
            // 
            // textBoxEpikryza
            // 
            this.textBoxEpikryza.Location = new System.Drawing.Point(26, 241);
            this.textBoxEpikryza.Multiline = true;
            this.textBoxEpikryza.Name = "textBoxEpikryza";
            this.textBoxEpikryza.Size = new System.Drawing.Size(502, 180);
            this.textBoxEpikryza.TabIndex = 12;
            this.textBoxEpikryza.TextChanged += new System.EventHandler(this.textBoxEpikryza_TextChanged);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(427, 177);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(101, 33);
            this.button15.TabIndex = 11;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(285, 177);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 33);
            this.button14.TabIndex = 10;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(154, 177);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 33);
            this.button13.TabIndex = 9;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(27, 177);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 33);
            this.button12.TabIndex = 8;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(427, 102);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 33);
            this.button11.TabIndex = 7;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(285, 102);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(101, 33);
            this.button10.TabIndex = 6;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(154, 102);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 33);
            this.button9.TabIndex = 5;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 102);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 33);
            this.button8.TabIndex = 4;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(427, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 33);
            this.button7.TabIndex = 3;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(285, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(154, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.badania_laboratoryjneDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(547, 691);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Badania laboratoryjne";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // badania_laboratoryjneDataGridView
            // 
            this.badania_laboratoryjneDataGridView.AutoGenerateColumns = false;
            this.badania_laboratoryjneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.badania_laboratoryjneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.badania_laboratoryjneDataGridView.DataSource = this.badania_laboratoryjneBindingSource;
            this.badania_laboratoryjneDataGridView.Location = new System.Drawing.Point(21, 25);
            this.badania_laboratoryjneDataGridView.Name = "badania_laboratoryjneDataGridView";
            this.badania_laboratoryjneDataGridView.Size = new System.Drawing.Size(462, 438);
            this.badania_laboratoryjneDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazwa Badania";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwa Badania";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_badania";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data_badania";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Wynik";
            this.dataGridViewTextBoxColumn5.HeaderText = "Wynik";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Komentarz";
            this.dataGridViewTextBoxColumn6.HeaderText = "Komentarz";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // badania_laboratoryjneBindingSource
            // 
            this.badania_laboratoryjneBindingSource.DataMember = "badania_laboratoryjne";
            this.badania_laboratoryjneBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elektrokardiogramyBindingSource
            // 
            this.elektrokardiogramyBindingSource.DataMember = "elektrokardiogramy";
            this.elektrokardiogramyBindingSource.DataSource = this.bazaDataSet;
            // 
            // PrzyciskLadowaniaWypisu
            // 
            this.PrzyciskLadowaniaWypisu.Location = new System.Drawing.Point(482, 3);
            this.PrzyciskLadowaniaWypisu.Name = "PrzyciskLadowaniaWypisu";
            this.PrzyciskLadowaniaWypisu.Size = new System.Drawing.Size(65, 58);
            this.PrzyciskLadowaniaWypisu.TabIndex = 13;
            this.PrzyciskLadowaniaWypisu.Text = "Załaduj";
            this.PrzyciskLadowaniaWypisu.UseVisualStyleBackColor = true;
            this.PrzyciskLadowaniaWypisu.Click += new System.EventHandler(this.PrzyciskLadowaniaWypisu_Click);
            // 
            // pacjenciBindingSource
            // 
            this.pacjenciBindingSource.DataMember = "pacjenci";
            this.pacjenciBindingSource.DataSource = this.bazaDataSet;
            // 
            // pESELTextBox
            // 
            this.pESELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, "PESEL", true));
            this.pESELTextBox.Location = new System.Drawing.Point(61, 11);
            this.pESELTextBox.Name = "pESELTextBox";
            this.pESELTextBox.Size = new System.Drawing.Size(100, 20);
            this.pESELTextBox.TabIndex = 15;
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, "Imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(202, 11);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 20);
            this.imieTextBox.TabIndex = 16;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacjenciBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(369, 11);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoTextBox.TabIndex = 17;
            // 
            // numKgTextBox
            // 
            this.numKgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalizacjeBindingSource, "NumKg", true));
            this.numKgTextBox.Location = new System.Drawing.Point(61, 38);
            this.numKgTextBox.Name = "numKgTextBox";
            this.numKgTextBox.Size = new System.Drawing.Size(100, 20);
            this.numKgTextBox.TabIndex = 19;
            // 
            // hospitalizacjeBindingSource
            // 
            this.hospitalizacjeBindingSource.DataMember = "PacjenciHospitalizacje";
            this.hospitalizacjeBindingSource.DataSource = this.pacjenciBindingSource;
            // 
            // data_PrzyjeciaDateTimePicker
            // 
            this.data_PrzyjeciaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hospitalizacjeBindingSource, "Data_Przyjecia", true));
            this.data_PrzyjeciaDateTimePicker.Location = new System.Drawing.Point(247, 41);
            this.data_PrzyjeciaDateTimePicker.Name = "data_PrzyjeciaDateTimePicker";
            this.data_PrzyjeciaDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.data_PrzyjeciaDateTimePicker.TabIndex = 20;
            this.data_PrzyjeciaDateTimePicker.ValueChanged += new System.EventHandler(this.data_PrzyjeciaDateTimePicker_ValueChanged);
            // 
            // zgonCheckBox
            // 
            this.zgonCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hospitalizacjeBindingSource, "Zgon", true));
            this.zgonCheckBox.Location = new System.Drawing.Point(434, 40);
            this.zgonCheckBox.Name = "zgonCheckBox";
            this.zgonCheckBox.Size = new System.Drawing.Size(44, 24);
            this.zgonCheckBox.TabIndex = 21;
            this.zgonCheckBox.UseVisualStyleBackColor = true;
            this.zgonCheckBox.CheckedChanged += new System.EventHandler(this.zgonCheckBox_CheckedChanged);
            // 
            // data_WypisuDateTimePicker
            // 
            this.data_WypisuDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hospitalizacjeBindingSource, "Data_Wypisu", true));
            this.data_WypisuDateTimePicker.Location = new System.Drawing.Point(247, 67);
            this.data_WypisuDateTimePicker.Name = "data_WypisuDateTimePicker";
            this.data_WypisuDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.data_WypisuDateTimePicker.TabIndex = 22;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(472, 71);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 23;
            this.buttonAccept.Text = "Zatwierdź";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // wyborlekarzacomboBox
            // 
            this.wyborlekarzacomboBox.FormattingEnabled = true;
            this.wyborlekarzacomboBox.Location = new System.Drawing.Point(9, 66);
            this.wyborlekarzacomboBox.Name = "wyborlekarzacomboBox";
            this.wyborlekarzacomboBox.Size = new System.Drawing.Size(161, 21);
            this.wyborlekarzacomboBox.TabIndex = 25;
            // 
            // DzisiejszeWypisy
            // 
            this.DzisiejszeWypisy.AutoSize = true;
            this.DzisiejszeWypisy.Location = new System.Drawing.Point(3, 0);
            this.DzisiejszeWypisy.Name = "DzisiejszeWypisy";
            this.DzisiejszeWypisy.Size = new System.Drawing.Size(0, 13);
            this.DzisiejszeWypisy.TabIndex = 28;
            this.DzisiejszeWypisy.Click += new System.EventHandler(this.DzisiejszeWypisy_Click);
            // 
            // hosp_rozpBindingSource
            // 
            this.hosp_rozpBindingSource.DataMember = "hosp_rozp";
            this.hosp_rozpBindingSource.DataSource = this.bazaDataSet;
            // 
            // pacjenciTableAdapter
            // 
            this.pacjenciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.badania_laboratoryjne1TableAdapter = null;
            this.tableAdapterManager.badania_laboratoryjneTableAdapter = null;
            this.tableAdapterManager.elektrokardiogramy1TableAdapter = null;
            this.tableAdapterManager.elektrokardiogramyTableAdapter = null;
            this.tableAdapterManager.hosp_leki1TableAdapter = null;
            this.tableAdapterManager.hosp_lekiTableAdapter = null;
            this.tableAdapterManager.hosp_rozp1TableAdapter = null;
            this.tableAdapterManager.hosp_rozpTableAdapter = null;
            this.tableAdapterManager.hospitalizacje1TableAdapter = null;
            this.tableAdapterManager.hospitalizacjeTableAdapter = this.hospitalizacjeTableAdapter;
            this.tableAdapterManager.lekarze1TableAdapter = null;
            this.tableAdapterManager.lekarzeTableAdapter = null;
            this.tableAdapterManager.lekiTableAdapter = null;
            this.tableAdapterManager.pacjenci1TableAdapter = null;
            this.tableAdapterManager.pacjenciTableAdapter = this.pacjenciTableAdapter;
            this.tableAdapterManager.rozpoznania1TableAdapter = null;
            this.tableAdapterManager.rozpoznaniaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = rtfapp.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hospitalizacjeTableAdapter
            // 
            this.hospitalizacjeTableAdapter.ClearBeforeFill = true;
            // 
            // badania_laboratoryjneTableAdapter
            // 
            this.badania_laboratoryjneTableAdapter.ClearBeforeFill = true;
            // 
            // hosp_rozpTableAdapter
            // 
            this.hosp_rozpTableAdapter.ClearBeforeFill = true;
            // 
            // rozpoznaniaBindingSource
            // 
            this.rozpoznaniaBindingSource.DataMember = "rozpoznania";
            this.rozpoznaniaBindingSource.DataSource = this.bazaDataSet;
            // 
            // rozpoznaniaTableAdapter
            // 
            this.rozpoznaniaTableAdapter.ClearBeforeFill = true;
            // 
            // lekarzeBindingSource
            // 
            this.lekarzeBindingSource.DataMember = "lekarze";
            this.lekarzeBindingSource.DataSource = this.bazaDataSet;
            // 
            // lekarzeTableAdapter
            // 
            this.lekarzeTableAdapter.ClearBeforeFill = true;
            // 
            // elektrokardiogramyTableAdapter
            // 
            this.elektrokardiogramyTableAdapter.ClearBeforeFill = true;
            // 
            // lekiTableAdapter1
            // 
            this.lekiTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.263823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.73618F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 561F));
            this.tableLayoutPanel1.Controls.Add(this.DzisiejszeWypisy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Taby, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1520, 856);
            this.tableLayoutPanel1.TabIndex = 29;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrzyciskLadowaniaWypisu);
            this.panel1.Controls.Add(this.pESELTextBox);
            this.panel1.Controls.Add(pESELLabel);
            this.panel1.Controls.Add(this.imieTextBox);
            this.panel1.Controls.Add(this.wyborlekarzacomboBox);
            this.panel1.Controls.Add(imieLabel);
            this.panel1.Controls.Add(this.buttonAccept);
            this.panel1.Controls.Add(this.nazwiskoTextBox);
            this.panel1.Controls.Add(data_WypisuLabel);
            this.panel1.Controls.Add(nazwiskoLabel);
            this.panel1.Controls.Add(this.data_WypisuDateTimePicker);
            this.panel1.Controls.Add(this.numKgTextBox);
            this.panel1.Controls.Add(numKgLabel);
            this.panel1.Controls.Add(zgonLabel);
            this.panel1.Controls.Add(this.data_PrzyjeciaDateTimePicker);
            this.panel1.Controls.Add(this.zgonCheckBox);
            this.panel1.Controls.Add(data_PrzyjeciaLabel);
            this.panel1.Location = new System.Drawing.Point(961, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 102);
            this.panel1.TabIndex = 30;
            // 
            // textControl
            // 
            this.textControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl.Location = new System.Drawing.Point(15, 116);
            this.textControl.Name = "textControl";
            this.tableLayoutPanel1.SetRowSpan(this.textControl, 3);
            this.textControl.Size = new System.Drawing.Size(940, 737);
            this.textControl.TabIndex = 32;
            this.textControl.Click += new System.EventHandler(this.textControl1_Click);
            // 
            // buttonBar
            // 
            this.buttonBar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBar.Location = new System.Drawing.Point(15, 82);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(940, 28);
            this.buttonBar.TabIndex = 33;
            this.buttonBar.Text = "buttonBar1";
            // 
            // serverTextControl1
            // 
            this.serverTextControl1.SpellChecker = null;
            // 
            // OknoWypisu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 905);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OknoWypisu";
            this.Text = "Wypis";
            this.Load += new System.EventHandler(this.OknoWypisu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OknoWypisu_KeyPress);
            this.Validated += new System.EventHandler(this.OknoWypisu_Validated);
            this.Taby.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosp_rozpDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekgDataGridView)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeki)).EndInit();
            this.TabEpikryza.ResumeLayout(false);
            this.TabEpikryza.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badania_laboratoryjneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badania_laboratoryjneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elektrokardiogramyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacjenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalizacjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosp_rozpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzeBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Taby;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TabEpikryza;
        private System.Windows.Forms.Button PrzyciskLadowaniaWypisu;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource pacjenciBindingSource;
        private BazaDataSetTableAdapters.pacjenciTableAdapter pacjenciTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaDataSetTableAdapters.hospitalizacjeTableAdapter hospitalizacjeTableAdapter;
        private System.Windows.Forms.TextBox pESELTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.BindingSource hospitalizacjeBindingSource;
        private System.Windows.Forms.TextBox numKgTextBox;
        private System.Windows.Forms.DateTimePicker data_PrzyjeciaDateTimePicker;
        private System.Windows.Forms.CheckBox zgonCheckBox;
        private System.Windows.Forms.DateTimePicker data_WypisuDateTimePicker;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource badania_laboratoryjneBindingSource;
        private BazaDataSetTableAdapters.badania_laboratoryjneTableAdapter badania_laboratoryjneTableAdapter;
        private System.Windows.Forms.DataGridView badania_laboratoryjneDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource hosp_rozpBindingSource;
        private BazaDataSetTableAdapters.hosp_rozpTableAdapter hosp_rozpTableAdapter;
        private System.Windows.Forms.Button buttonDodajRozp;
        private System.Windows.Forms.TextBox textBoxWyszukiwanieRozp;
        private System.Windows.Forms.BindingSource rozpoznaniaBindingSource;
        private BazaDataSetTableAdapters.rozpoznaniaTableAdapter rozpoznaniaTableAdapter;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDodajNoweRozp;
        private System.Windows.Forms.BindingSource lekarzeBindingSource;
        private BazaDataSetTableAdapters.lekarzeTableAdapter lekarzeTableAdapter;
        private System.Windows.Forms.ComboBox wyborlekarzacomboBox;
        private System.Windows.Forms.TextBox textBoxEKG;
        private System.Windows.Forms.Button buttonDodajLek;
        private System.Windows.Forms.BindingSource elektrokardiogramyBindingSource;
        private BazaDataSetTableAdapters.elektrokardiogramyTableAdapter elektrokardiogramyTableAdapter;
        private System.Windows.Forms.Button buttonDodajEKG;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView hosp_rozpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rozpoznania;
        private System.Windows.Forms.TextBox textBoxEpikryza;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private EchoControl echoControl1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridViewLeki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label DzisiejszeWypisy;
        private System.Windows.Forms.Button buttonDodajNowyLek;
        private System.Windows.Forms.ComboBox comboBoxDodawanieLeku;
        private System.Windows.Forms.DataGridViewTextBoxColumn LekID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TekstLeku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dawka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dawkowanie;
        private BazaDataSetTableAdapters.lekiTableAdapter lekiTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ekgDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etykieta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rytm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czestosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn EkgId;
        private TXTextControl.TextControl textControl;
        private TXTextControl.ButtonBar buttonBar;
        private TXTextControl.ServerTextControl serverTextControl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}