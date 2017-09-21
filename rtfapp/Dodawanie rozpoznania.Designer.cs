namespace rtfapp
{
    partial class Dodawanie_rozpoznania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodawanie_rozpoznania));
            this.bazaDataSet = new rtfapp.BazaDataSet();
            this.rozpoznaniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rozpoznaniaTableAdapter = new rtfapp.BazaDataSetTableAdapters.rozpoznaniaTableAdapter();
            this.tableAdapterManager = new rtfapp.BazaDataSetTableAdapters.TableAdapterManager();
            this.rozpoznaniaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rozpoznaniaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rozpoznaniaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajNoweRozp = new System.Windows.Forms.Button();
            this.textBoxICD = new System.Windows.Forms.TextBox();
            this.textBoxNazwRozp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaBindingNavigator)).BeginInit();
            this.rozpoznaniaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.badania_laboratoryjneTableAdapter = null;
            this.tableAdapterManager.elektrokardiogramyTableAdapter = null;
            this.tableAdapterManager.hosp_lekiTableAdapter = null;
            this.tableAdapterManager.hosp_rozpTableAdapter = null;
            this.tableAdapterManager.hospitalizacjeTableAdapter = null;
            this.tableAdapterManager.lekarzeTableAdapter = null;
            this.tableAdapterManager.lekiTableAdapter = null;
            this.tableAdapterManager.pacjenciTableAdapter = null;
            this.tableAdapterManager.rozpoznaniaTableAdapter = this.rozpoznaniaTableAdapter;
            this.tableAdapterManager.UpdateOrder = rtfapp.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rozpoznaniaBindingNavigator
            // 
            this.rozpoznaniaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rozpoznaniaBindingNavigator.BindingSource = this.rozpoznaniaBindingSource;
            this.rozpoznaniaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rozpoznaniaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rozpoznaniaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rozpoznaniaBindingNavigatorSaveItem});
            this.rozpoznaniaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rozpoznaniaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rozpoznaniaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rozpoznaniaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rozpoznaniaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rozpoznaniaBindingNavigator.Name = "rozpoznaniaBindingNavigator";
            this.rozpoznaniaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rozpoznaniaBindingNavigator.Size = new System.Drawing.Size(750, 25);
            this.rozpoznaniaBindingNavigator.TabIndex = 0;
            this.rozpoznaniaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rozpoznaniaBindingNavigatorSaveItem
            // 
            this.rozpoznaniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rozpoznaniaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rozpoznaniaBindingNavigatorSaveItem.Image")));
            this.rozpoznaniaBindingNavigatorSaveItem.Name = "rozpoznaniaBindingNavigatorSaveItem";
            this.rozpoznaniaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rozpoznaniaBindingNavigatorSaveItem.Text = "Save Data";
            this.rozpoznaniaBindingNavigatorSaveItem.Click += new System.EventHandler(this.rozpoznaniaBindingNavigatorSaveItem_Click);
            // 
            // rozpoznaniaDataGridView
            // 
            this.rozpoznaniaDataGridView.AllowUserToOrderColumns = true;
            this.rozpoznaniaDataGridView.AutoGenerateColumns = false;
            this.rozpoznaniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rozpoznaniaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rozpoznaniaDataGridView.DataSource = this.rozpoznaniaBindingSource;
            this.rozpoznaniaDataGridView.Location = new System.Drawing.Point(301, 12);
            this.rozpoznaniaDataGridView.Name = "rozpoznaniaDataGridView";
            this.rozpoznaniaDataGridView.Size = new System.Drawing.Size(444, 336);
            this.rozpoznaniaDataGridView.TabIndex = 1;
            this.rozpoznaniaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rozpoznaniaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ICD_10";
            this.dataGridViewTextBoxColumn2.HeaderText = "ICD_10";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazwa rozpoznania";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwa rozpoznania";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // buttonDodajNoweRozp
            // 
            this.buttonDodajNoweRozp.Location = new System.Drawing.Point(77, 246);
            this.buttonDodajNoweRozp.Name = "buttonDodajNoweRozp";
            this.buttonDodajNoweRozp.Size = new System.Drawing.Size(138, 32);
            this.buttonDodajNoweRozp.TabIndex = 2;
            this.buttonDodajNoweRozp.Text = "Dodaj nowe";
            this.buttonDodajNoweRozp.UseVisualStyleBackColor = true;
            this.buttonDodajNoweRozp.Click += new System.EventHandler(this.buttonDodajNoweRozp_Click);
            // 
            // textBoxICD
            // 
            this.textBoxICD.Location = new System.Drawing.Point(12, 108);
            this.textBoxICD.Name = "textBoxICD";
            this.textBoxICD.Size = new System.Drawing.Size(261, 20);
            this.textBoxICD.TabIndex = 3;
            // 
            // textBoxNazwRozp
            // 
            this.textBoxNazwRozp.Location = new System.Drawing.Point(12, 162);
            this.textBoxNazwRozp.Name = "textBoxNazwRozp";
            this.textBoxNazwRozp.Size = new System.Drawing.Size(261, 20);
            this.textBoxNazwRozp.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ICD-10";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rozpoznanie";
            // 
            // Dodawanie_rozpoznania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazwRozp);
            this.Controls.Add(this.textBoxICD);
            this.Controls.Add(this.buttonDodajNoweRozp);
            this.Controls.Add(this.rozpoznaniaDataGridView);
            this.Controls.Add(this.rozpoznaniaBindingNavigator);
            this.Name = "Dodawanie_rozpoznania";
            this.Text = "Dodawanie_rozpoznania";
            this.Load += new System.EventHandler(this.Dodawanie_rozpoznania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaBindingNavigator)).EndInit();
            this.rozpoznaniaBindingNavigator.ResumeLayout(false);
            this.rozpoznaniaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznaniaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource rozpoznaniaBindingSource;
        private BazaDataSetTableAdapters.rozpoznaniaTableAdapter rozpoznaniaTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rozpoznaniaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rozpoznaniaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rozpoznaniaDataGridView;
        private System.Windows.Forms.Button buttonDodajNoweRozp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBoxICD;
        private System.Windows.Forms.TextBox textBoxNazwRozp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}