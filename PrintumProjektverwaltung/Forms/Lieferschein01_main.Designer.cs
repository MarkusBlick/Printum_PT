namespace PrintumProjektverwaltung.Forms
{
    partial class Lieferschein01_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lieferschein01_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.button1_neuerLieferschein = new System.Windows.Forms.Button();
            this.button2_rechnung = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priProLieferscheinRechnungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projektnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieferscheinPfad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priProLieferscheinRechnungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_speichern = new System.Windows.Forms.Label();
            this.button_aenderungSpeichern = new System.Windows.Forms.Button();
            this.priProLieferscheinRechnungTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.PriProLieferscheinRechnungTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.priProLieferscheinRechnungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.priProLieferscheinRechnungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungBindingNavigator)).BeginInit();
            this.priProLieferscheinRechnungBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1_suchen);
            this.panel1.Controls.Add(this.button1_neuerLieferschein);
            this.panel1.Controls.Add(this.button2_rechnung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lieferscheine";
            // 
            // textBox1_suchen
            // 
            this.textBox1_suchen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_suchen.Location = new System.Drawing.Point(276, 20);
            this.textBox1_suchen.Name = "textBox1_suchen";
            this.textBox1_suchen.Size = new System.Drawing.Size(175, 26);
            this.textBox1_suchen.TabIndex = 13;
            this.textBox1_suchen.TextChanged += new System.EventHandler(this.textBox1_suchen_TextChanged);
            // 
            // button1_neuerLieferschein
            // 
            this.button1_neuerLieferschein.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1_neuerLieferschein.FlatAppearance.BorderSize = 0;
            this.button1_neuerLieferschein.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1_neuerLieferschein.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1_neuerLieferschein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_neuerLieferschein.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_neuerLieferschein.Location = new System.Drawing.Point(501, 15);
            this.button1_neuerLieferschein.Name = "button1_neuerLieferschein";
            this.button1_neuerLieferschein.Size = new System.Drawing.Size(160, 36);
            this.button1_neuerLieferschein.TabIndex = 12;
            this.button1_neuerLieferschein.Text = "neuer Lieferschein";
            this.button1_neuerLieferschein.UseVisualStyleBackColor = false;
            this.button1_neuerLieferschein.Click += new System.EventHandler(this.button1_neuerLieferschein_Click);
            // 
            // button2_rechnung
            // 
            this.button2_rechnung.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2_rechnung.FlatAppearance.BorderSize = 0;
            this.button2_rechnung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2_rechnung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2_rechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_rechnung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2_rechnung.Location = new System.Drawing.Point(711, 15);
            this.button2_rechnung.Name = "button2_rechnung";
            this.button2_rechnung.Size = new System.Drawing.Size(212, 36);
            this.button2_rechnung.TabIndex = 11;
            this.button2_rechnung.Text = "Rechnungs-Nr eintragen";
            this.button2_rechnung.UseVisualStyleBackColor = false;
            this.button2_rechnung.Click += new System.EventHandler(this.button2_rechnung_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.priProLieferscheinRechnungDataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1200, 624);
            this.panel2.TabIndex = 1;
            // 
            // priProLieferscheinRechnungDataGridView
            // 
            this.priProLieferscheinRechnungDataGridView.AutoGenerateColumns = false;
            this.priProLieferscheinRechnungDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.priProLieferscheinRechnungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priProLieferscheinRechnungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Projektnummer,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.RechnungsNr,
            this.RechnungDatum,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.LieferscheinPfad,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.priProLieferscheinRechnungDataGridView.DataSource = this.priProLieferscheinRechnungBindingSource;
            this.priProLieferscheinRechnungDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priProLieferscheinRechnungDataGridView.Location = new System.Drawing.Point(10, 42);
            this.priProLieferscheinRechnungDataGridView.MultiSelect = false;
            this.priProLieferscheinRechnungDataGridView.Name = "priProLieferscheinRechnungDataGridView";
            this.priProLieferscheinRechnungDataGridView.ReadOnly = true;
            this.priProLieferscheinRechnungDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.priProLieferscheinRechnungDataGridView.Size = new System.Drawing.Size(1180, 572);
            this.priProLieferscheinRechnungDataGridView.TabIndex = 0;
            this.priProLieferscheinRechnungDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.priProLieferscheinRechnungDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PriProLieferscheinRechnungID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PriProLieferscheinRechnungID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Projektnummer
            // 
            this.Projektnummer.DataPropertyName = "Projektnummer";
            this.Projektnummer.HeaderText = "Projektnummer";
            this.Projektnummer.Name = "Projektnummer";
            this.Projektnummer.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LieferscheinNr";
            this.dataGridViewTextBoxColumn2.HeaderText = "LieferscheinNr";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LieferscheinBeschreibung";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lieferschein - Beschreibung";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LS_Firmenname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Firmenname";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // RechnungsNr
            // 
            this.RechnungsNr.DataPropertyName = "RechnungsNr";
            this.RechnungsNr.HeaderText = "RechnungsNr";
            this.RechnungsNr.MinimumWidth = 150;
            this.RechnungsNr.Name = "RechnungsNr";
            this.RechnungsNr.ReadOnly = true;
            this.RechnungsNr.Width = 150;
            // 
            // RechnungDatum
            // 
            this.RechnungDatum.DataPropertyName = "RechnungDatum";
            this.RechnungDatum.HeaderText = "Rechnungs - Datum";
            this.RechnungDatum.MinimumWidth = 110;
            this.RechnungDatum.Name = "RechnungDatum";
            this.RechnungDatum.ReadOnly = true;
            this.RechnungDatum.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LieferscheinErsteller";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ersteller";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LieferscheinDatum";
            this.dataGridViewTextBoxColumn4.HeaderText = "erstellt am";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LS_Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LS_Strasse";
            this.dataGridViewTextBoxColumn8.HeaderText = "Strasse";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LS_PLZ";
            this.dataGridViewTextBoxColumn9.HeaderText = "PLZ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LS_Stadt";
            this.dataGridViewTextBoxColumn10.HeaderText = "Stadt";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LS_Land";
            this.dataGridViewTextBoxColumn11.HeaderText = "Land";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // LieferscheinPfad
            // 
            this.LieferscheinPfad.DataPropertyName = "LieferscheinPfad";
            this.LieferscheinPfad.HeaderText = "LieferscheinPfad";
            this.LieferscheinPfad.Name = "LieferscheinPfad";
            this.LieferscheinPfad.ReadOnly = true;
            this.LieferscheinPfad.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RechnungBetrag";
            this.dataGridViewTextBoxColumn14.HeaderText = "RechnungBetrag";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "RechnungBerechnungsgrund";
            this.dataGridViewTextBoxColumn15.HeaderText = "RechnungBerechnungsgrund";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "RechnungErsteller";
            this.dataGridViewTextBoxColumn17.HeaderText = "RechnungErsteller";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RE_Firmenname";
            this.dataGridViewTextBoxColumn18.HeaderText = "RE_Firmenname";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "RE_Name";
            this.dataGridViewTextBoxColumn19.HeaderText = "RE_Name";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "RE_Strasse";
            this.dataGridViewTextBoxColumn20.HeaderText = "RE_Strasse";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RE_PLZ";
            this.dataGridViewTextBoxColumn21.HeaderText = "RE_PLZ";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "RE_Stadt";
            this.dataGridViewTextBoxColumn22.HeaderText = "RE_Stadt";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "RE_Land";
            this.dataGridViewTextBoxColumn23.HeaderText = "RE_Land";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "RechnungPfad";
            this.dataGridViewTextBoxColumn24.HeaderText = "RechnungPfad";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label_speichern);
            this.panel3.Controls.Add(this.button_aenderungSpeichern);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 32);
            this.panel3.TabIndex = 1;
            this.panel3.Visible = false;
            // 
            // label_speichern
            // 
            this.label_speichern.AutoSize = true;
            this.label_speichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speichern.ForeColor = System.Drawing.Color.DarkGray;
            this.label_speichern.Location = new System.Drawing.Point(123, 3);
            this.label_speichern.Name = "label_speichern";
            this.label_speichern.Size = new System.Drawing.Size(564, 24);
            this.label_speichern.TabIndex = 6;
            this.label_speichern.Text = "RechnungNr und Rechnungs-Datum können eingetragen werden";
            // 
            // button_aenderungSpeichern
            // 
            this.button_aenderungSpeichern.BackColor = System.Drawing.Color.IndianRed;
            this.button_aenderungSpeichern.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_aenderungSpeichern.FlatAppearance.BorderSize = 0;
            this.button_aenderungSpeichern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_aenderungSpeichern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button_aenderungSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aenderungSpeichern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_aenderungSpeichern.Location = new System.Drawing.Point(900, 0);
            this.button_aenderungSpeichern.Name = "button_aenderungSpeichern";
            this.button_aenderungSpeichern.Size = new System.Drawing.Size(280, 32);
            this.button_aenderungSpeichern.TabIndex = 5;
            this.button_aenderungSpeichern.Text = "Änderung speichern";
            this.button_aenderungSpeichern.UseVisualStyleBackColor = false;
            this.button_aenderungSpeichern.Click += new System.EventHandler(this.button_aenderungSpeichern_Click);
            // 
            // priProLieferscheinRechnungTableAdapter
            // 
            this.priProLieferscheinRechnungTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PriProLieferscheinRechnungTableAdapter = this.priProLieferscheinRechnungTableAdapter;
            this.tableAdapterManager.PriProRechnungTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // priProLieferscheinRechnungBindingNavigator
            // 
            this.priProLieferscheinRechnungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.priProLieferscheinRechnungBindingNavigator.BindingSource = this.priProLieferscheinRechnungBindingSource;
            this.priProLieferscheinRechnungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.priProLieferscheinRechnungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.priProLieferscheinRechnungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.priProLieferscheinRechnungBindingNavigatorSaveItem});
            this.priProLieferscheinRechnungBindingNavigator.Location = new System.Drawing.Point(0, 68);
            this.priProLieferscheinRechnungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.priProLieferscheinRechnungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.priProLieferscheinRechnungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.priProLieferscheinRechnungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.priProLieferscheinRechnungBindingNavigator.Name = "priProLieferscheinRechnungBindingNavigator";
            this.priProLieferscheinRechnungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.priProLieferscheinRechnungBindingNavigator.Size = new System.Drawing.Size(1200, 25);
            this.priProLieferscheinRechnungBindingNavigator.TabIndex = 2;
            this.priProLieferscheinRechnungBindingNavigator.Text = "bindingNavigator1";
            this.priProLieferscheinRechnungBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // priProLieferscheinRechnungBindingNavigatorSaveItem
            // 
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("priProLieferscheinRechnungBindingNavigatorSaveItem.Image")));
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Name = "priProLieferscheinRechnungBindingNavigatorSaveItem";
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Text = "Daten speichern";
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Click += new System.EventHandler(this.priProLieferscheinRechnungBindingNavigatorSaveItem_Click);
            // 
            // Lieferschein01_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.priProLieferscheinRechnungBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lieferschein01_main";
            this.Text = "Lieferscheine";
            this.Load += new System.EventHandler(this.Lieferschein01_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priProLieferscheinRechnungBindingNavigator)).EndInit();
            this.priProLieferscheinRechnungBindingNavigator.ResumeLayout(false);
            this.priProLieferscheinRechnungBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_neuerLieferschein;
        private System.Windows.Forms.Button button2_rechnung;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private System.Windows.Forms.Label label1;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource priProLieferscheinRechnungBindingSource;
        private DAL.DataSet1TableAdapters.PriProLieferscheinRechnungTableAdapter priProLieferscheinRechnungTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator priProLieferscheinRechnungBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton priProLieferscheinRechnungBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView priProLieferscheinRechnungDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_speichern;
        private System.Windows.Forms.Button button_aenderungSpeichern;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projektnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungsNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieferscheinPfad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}