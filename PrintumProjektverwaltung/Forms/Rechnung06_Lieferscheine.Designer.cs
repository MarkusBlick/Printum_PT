namespace PrintumProjektverwaltung.Forms
{
    partial class Rechnung06_Lieferscheine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnung06_Lieferscheine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projekteDataGridView = new System.Windows.Forms.DataGridView();
            this.priProLieferscheinRechnungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.projekteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.priProLieferscheinRechnungTableAdapter1 = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.PriProLieferscheinRechnungTableAdapter();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.projekteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.LieferscheinNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieferscheinBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieferscheinDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieferscheinErsteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS_Firmenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS_Strasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS_PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS_Stadt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS_Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projekteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekteBindingNavigator)).BeginInit();
            this.projekteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1_suchen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 85);
            this.panel1.TabIndex = 0;
            // 
            // textBox1_suchen
            // 
            this.textBox1_suchen.Location = new System.Drawing.Point(27, 29);
            this.textBox1_suchen.Name = "textBox1_suchen";
            this.textBox1_suchen.Size = new System.Drawing.Size(245, 26);
            this.textBox1_suchen.TabIndex = 0;
            this.textBox1_suchen.TextChanged += new System.EventHandler(this.textBox1_suchen_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.projekteDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 607);
            this.panel2.TabIndex = 1;
            // 
            // projekteDataGridView
            // 
            this.projekteDataGridView.AutoGenerateColumns = false;
            this.projekteDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.projekteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projekteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LieferscheinNr,
            this.LieferscheinBeschreibung,
            this.LieferscheinDatum,
            this.LieferscheinErsteller,
            this.LS_Firmenname,
            this.LS_Name,
            this.LS_Strasse,
            this.LS_PLZ,
            this.LS_Stadt,
            this.LS_Land,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.projekteDataGridView.DataSource = this.priProLieferscheinRechnungBindingSource;
            this.projekteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projekteDataGridView.Location = new System.Drawing.Point(0, 0);
            this.projekteDataGridView.Name = "projekteDataGridView";
            this.projekteDataGridView.ReadOnly = true;
            this.projekteDataGridView.RowHeadersVisible = false;
            this.projekteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projekteDataGridView.Size = new System.Drawing.Size(807, 607);
            this.projekteDataGridView.TabIndex = 0;
            this.projekteDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projekteDataGridView_CellDoubleClick);
            // 
            // priProLieferscheinRechnungBindingSource
            // 
            this.priProLieferscheinRechnungBindingSource.DataMember = "PriProLieferscheinRechnung";
            this.priProLieferscheinRechnungBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressenTableAdapter = null;
            this.tableAdapterManager.ArtikelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BestellungenTableAdapter = null;
            this.tableAdapterManager.BestellungPositionenTableAdapter = null;
            this.tableAdapterManager.EinheitTableAdapter = null;
            this.tableAdapterManager.LieferungLieferscheinTableAdapter = null;
            this.tableAdapterManager.LieferungPositionenTableAdapter = null;
            this.tableAdapterManager.LieferungRechnungenTableAdapter = null;
            this.tableAdapterManager.LieferungTableAdapter = null;
            this.tableAdapterManager.PriProLieferscheinRechnungTableAdapter = this.priProLieferscheinRechnungTableAdapter1;
            this.tableAdapterManager.PriProRechnungTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projekteBindingNavigator
            // 
            this.projekteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.projekteBindingNavigator.BindingSource = this.priProLieferscheinRechnungBindingSource;
            this.projekteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.projekteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.projekteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.projekteBindingNavigatorSaveItem});
            this.projekteBindingNavigator.Location = new System.Drawing.Point(0, 85);
            this.projekteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.projekteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.projekteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.projekteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.projekteBindingNavigator.Name = "projekteBindingNavigator";
            this.projekteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.projekteBindingNavigator.Size = new System.Drawing.Size(807, 25);
            this.projekteBindingNavigator.TabIndex = 2;
            this.projekteBindingNavigator.Text = "bindingNavigator1";
            this.projekteBindingNavigator.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
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
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // priProLieferscheinRechnungTableAdapter1
            // 
            this.priProLieferscheinRechnungTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // projekteBindingNavigatorSaveItem
            // 
            this.projekteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projekteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("projekteBindingNavigatorSaveItem.Image")));
            this.projekteBindingNavigatorSaveItem.Name = "projekteBindingNavigatorSaveItem";
            this.projekteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.projekteBindingNavigatorSaveItem.Text = "Daten speichern";
            this.projekteBindingNavigatorSaveItem.Click += new System.EventHandler(this.projekteBindingNavigatorSaveItem_Click);
            // 
            // LieferscheinNr
            // 
            this.LieferscheinNr.DataPropertyName = "LieferscheinNr";
            this.LieferscheinNr.HeaderText = "LieferscheinNr";
            this.LieferscheinNr.Name = "LieferscheinNr";
            this.LieferscheinNr.ReadOnly = true;
            this.LieferscheinNr.Width = 200;
            // 
            // LieferscheinBeschreibung
            // 
            this.LieferscheinBeschreibung.DataPropertyName = "LieferscheinBeschreibung";
            this.LieferscheinBeschreibung.HeaderText = "LieferscheinBeschreibung";
            this.LieferscheinBeschreibung.Name = "LieferscheinBeschreibung";
            this.LieferscheinBeschreibung.ReadOnly = true;
            this.LieferscheinBeschreibung.Width = 300;
            // 
            // LieferscheinDatum
            // 
            this.LieferscheinDatum.DataPropertyName = "LieferscheinDatum";
            this.LieferscheinDatum.HeaderText = "LieferscheinDatum";
            this.LieferscheinDatum.Name = "LieferscheinDatum";
            this.LieferscheinDatum.ReadOnly = true;
            // 
            // LieferscheinErsteller
            // 
            this.LieferscheinErsteller.DataPropertyName = "LieferscheinErsteller";
            this.LieferscheinErsteller.HeaderText = "LieferscheinErsteller";
            this.LieferscheinErsteller.Name = "LieferscheinErsteller";
            this.LieferscheinErsteller.ReadOnly = true;
            // 
            // LS_Firmenname
            // 
            this.LS_Firmenname.DataPropertyName = "LS_Firmenname";
            this.LS_Firmenname.HeaderText = "LS_Firmenname";
            this.LS_Firmenname.Name = "LS_Firmenname";
            this.LS_Firmenname.ReadOnly = true;
            this.LS_Firmenname.Width = 200;
            // 
            // LS_Name
            // 
            this.LS_Name.DataPropertyName = "LS_Name";
            this.LS_Name.HeaderText = "LS_Name";
            this.LS_Name.Name = "LS_Name";
            this.LS_Name.ReadOnly = true;
            // 
            // LS_Strasse
            // 
            this.LS_Strasse.DataPropertyName = "LS_Strasse";
            this.LS_Strasse.HeaderText = "LS_Strasse";
            this.LS_Strasse.Name = "LS_Strasse";
            this.LS_Strasse.ReadOnly = true;
            // 
            // LS_PLZ
            // 
            this.LS_PLZ.DataPropertyName = "LS_PLZ";
            this.LS_PLZ.HeaderText = "LS_PLZ";
            this.LS_PLZ.Name = "LS_PLZ";
            this.LS_PLZ.ReadOnly = true;
            // 
            // LS_Stadt
            // 
            this.LS_Stadt.DataPropertyName = "LS_Stadt";
            this.LS_Stadt.HeaderText = "LS_Stadt";
            this.LS_Stadt.Name = "LS_Stadt";
            this.LS_Stadt.ReadOnly = true;
            // 
            // LS_Land
            // 
            this.LS_Land.DataPropertyName = "LS_Land";
            this.LS_Land.HeaderText = "LS_Land";
            this.LS_Land.Name = "LS_Land";
            this.LS_Land.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Projektname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Projektname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 600;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 600;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Projektnummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Projektnummer";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Rechnung06_Lieferscheine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(807, 692);
            this.Controls.Add(this.projekteBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rechnung06_Lieferscheine";
            this.Text = "Lieferschein auswählen";
            this.Load += new System.EventHandler(this.Rechnung06_Lieferscheine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projekteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekteBindingNavigator)).EndInit();
            this.projekteBindingNavigator.ResumeLayout(false);
            this.projekteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource priProLieferscheinRechnungBindingSource;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator projekteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton projekteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView projekteDataGridView;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private DAL.DataSet1TableAdapters.PriProLieferscheinRechnungTableAdapter priProLieferscheinRechnungTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieferscheinNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieferscheinBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieferscheinDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieferscheinErsteller;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS_Firmenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS_Strasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS_PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS_Stadt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS_Land;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}