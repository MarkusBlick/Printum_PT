﻿namespace PrintumProjektverwaltung.Forms
{
    partial class Rechnung01_main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnung01_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.button1_neueRechnung = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priProRechnungDataGridView = new System.Windows.Forms.DataGridView();
            this.XLSX = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PDF = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RechnungNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projektnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungErsteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rechnungsbetrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ändern = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Zahlungsziel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zahlungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zahlungsbetrag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NochOffen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahnung1datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahnung2datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahnung3datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bemerkungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieferscheinNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE_Firmenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE_Strasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE_Stadt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE_Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungPfad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriProRechnungID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priProRechnungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.offeneRechnungenTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zahlungsBetragTextbox = new System.Windows.Forms.TextBox();
            this.SummeRechnungsBetragTextBox = new System.Windows.Forms.TextBox();
            this.priProRechnungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.priProRechnungTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.PriProRechnungTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priProRechnungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priProRechnungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priProRechnungBindingNavigator)).BeginInit();
            this.priProRechnungBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1_suchen);
            this.panel1.Controls.Add(this.button1_neueRechnung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1751, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rechnungen";
            // 
            // textBox1_suchen
            // 
            this.textBox1_suchen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_suchen.Location = new System.Drawing.Point(276, 20);
            this.textBox1_suchen.Name = "textBox1_suchen";
            this.textBox1_suchen.Size = new System.Drawing.Size(175, 30);
            this.textBox1_suchen.TabIndex = 13;
            this.textBox1_suchen.TextChanged += new System.EventHandler(this.textBox1_suchen_TextChanged);
            // 
            // button1_neueRechnung
            // 
            this.button1_neueRechnung.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1_neueRechnung.FlatAppearance.BorderSize = 0;
            this.button1_neueRechnung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1_neueRechnung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1_neueRechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_neueRechnung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_neueRechnung.Location = new System.Drawing.Point(501, 15);
            this.button1_neueRechnung.Name = "button1_neueRechnung";
            this.button1_neueRechnung.Size = new System.Drawing.Size(160, 36);
            this.button1_neueRechnung.TabIndex = 12;
            this.button1_neueRechnung.Text = "neue Rechnung";
            this.button1_neueRechnung.UseVisualStyleBackColor = false;
            this.button1_neueRechnung.Click += new System.EventHandler(this.button1_neueRechnung_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.priProRechnungDataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1751, 597);
            this.panel2.TabIndex = 1;
            // 
            // priProRechnungDataGridView
            // 
            this.priProRechnungDataGridView.AutoGenerateColumns = false;
            this.priProRechnungDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.priProRechnungDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.priProRechnungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priProRechnungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XLSX,
            this.PDF,
            this.RechnungNr,
            this.RechnungBeschreibung,
            this.RechnungTyp,
            this.Projektnummer,
            this.RechnungDatum,
            this.RechnungErsteller,
            this.Rechnungsbetrag,
            this.Ändern,
            this.Zahlungsziel,
            this.Zahlungsdatum,
            this.Zahlungsbetrag,
            this.NochOffen,
            this.Mahnung1datum,
            this.Mahnung2datum,
            this.Mahnung3datum,
            this.Bemerkungen,
            this.LieferscheinNr,
            this.RE_Firmenname,
            this.RE_Name,
            this.RE_Strasse,
            this.dataGridViewTextBoxColumn21,
            this.RE_Stadt,
            this.RE_Land,
            this.RechnungPfad,
            this.PriProRechnungID});
            this.priProRechnungDataGridView.DataSource = this.priProRechnungBindingSource;
            this.priProRechnungDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priProRechnungDataGridView.Location = new System.Drawing.Point(10, 67);
            this.priProRechnungDataGridView.MultiSelect = false;
            this.priProRechnungDataGridView.Name = "priProRechnungDataGridView";
            this.priProRechnungDataGridView.ReadOnly = true;
            this.priProRechnungDataGridView.RowHeadersVisible = false;
            this.priProRechnungDataGridView.RowHeadersWidth = 51;
            this.priProRechnungDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.priProRechnungDataGridView.Size = new System.Drawing.Size(1731, 520);
            this.priProRechnungDataGridView.TabIndex = 0;
            this.priProRechnungDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.priProRechnungDataGridView_CellContentClick);
            this.priProRechnungDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.priProRechnungDataGridView_CellDoubleClick);
            this.priProRechnungDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.priProRechnungDataGridView_DataBindingComplete);
            this.priProRechnungDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.priProRechnungDataGridView_RowHeaderMouseClick);
            // 
            // XLSX
            // 
            this.XLSX.HeaderText = "Excel öffnen";
            this.XLSX.MinimumWidth = 6;
            this.XLSX.Name = "XLSX";
            this.XLSX.ReadOnly = true;
            this.XLSX.Text = ".xlsx";
            this.XLSX.UseColumnTextForButtonValue = true;
            this.XLSX.Width = 50;
            // 
            // PDF
            // 
            this.PDF.HeaderText = "PDF öffnen";
            this.PDF.MinimumWidth = 6;
            this.PDF.Name = "PDF";
            this.PDF.ReadOnly = true;
            this.PDF.Text = ".pdf";
            this.PDF.UseColumnTextForButtonValue = true;
            this.PDF.Width = 50;
            // 
            // RechnungNr
            // 
            this.RechnungNr.DataPropertyName = "RechnungNr";
            this.RechnungNr.HeaderText = "Rechn.Nr";
            this.RechnungNr.MinimumWidth = 6;
            this.RechnungNr.Name = "RechnungNr";
            this.RechnungNr.ReadOnly = true;
            this.RechnungNr.Width = 125;
            // 
            // RechnungBeschreibung
            // 
            this.RechnungBeschreibung.DataPropertyName = "RechnungBeschreibung";
            this.RechnungBeschreibung.HeaderText = "Beschreibung";
            this.RechnungBeschreibung.MinimumWidth = 6;
            this.RechnungBeschreibung.Name = "RechnungBeschreibung";
            this.RechnungBeschreibung.ReadOnly = true;
            this.RechnungBeschreibung.Width = 300;
            // 
            // RechnungTyp
            // 
            this.RechnungTyp.DataPropertyName = "RechnungTyp";
            this.RechnungTyp.HeaderText = "Typ";
            this.RechnungTyp.MinimumWidth = 6;
            this.RechnungTyp.Name = "RechnungTyp";
            this.RechnungTyp.ReadOnly = true;
            this.RechnungTyp.Width = 125;
            // 
            // Projektnummer
            // 
            this.Projektnummer.DataPropertyName = "Projektnummer";
            this.Projektnummer.HeaderText = "Projekt -Nr";
            this.Projektnummer.MinimumWidth = 6;
            this.Projektnummer.Name = "Projektnummer";
            this.Projektnummer.ReadOnly = true;
            this.Projektnummer.Width = 90;
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
            // RechnungErsteller
            // 
            this.RechnungErsteller.DataPropertyName = "RechnungErsteller";
            this.RechnungErsteller.HeaderText = "Rechnungs - Ersteller";
            this.RechnungErsteller.MinimumWidth = 6;
            this.RechnungErsteller.Name = "RechnungErsteller";
            this.RechnungErsteller.ReadOnly = true;
            this.RechnungErsteller.Width = 125;
            // 
            // Rechnungsbetrag
            // 
            this.Rechnungsbetrag.DataPropertyName = "Rechnungsbetrag";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Rechnungsbetrag.DefaultCellStyle = dataGridViewCellStyle7;
            this.Rechnungsbetrag.HeaderText = "Rechnungs - Betrag";
            this.Rechnungsbetrag.MinimumWidth = 6;
            this.Rechnungsbetrag.Name = "Rechnungsbetrag";
            this.Rechnungsbetrag.ReadOnly = true;
            this.Rechnungsbetrag.Width = 125;
            // 
            // Ändern
            // 
            this.Ändern.HeaderText = "Zahlungen";
            this.Ändern.MinimumWidth = 6;
            this.Ändern.Name = "Ändern";
            this.Ändern.ReadOnly = true;
            this.Ändern.Text = "ändern";
            this.Ändern.UseColumnTextForButtonValue = true;
            this.Ändern.Width = 125;
            // 
            // Zahlungsziel
            // 
            this.Zahlungsziel.DataPropertyName = "Zahlungsziel";
            this.Zahlungsziel.HeaderText = "Zahlungsziel";
            this.Zahlungsziel.MinimumWidth = 6;
            this.Zahlungsziel.Name = "Zahlungsziel";
            this.Zahlungsziel.ReadOnly = true;
            this.Zahlungsziel.Width = 125;
            // 
            // Zahlungsdatum
            // 
            this.Zahlungsdatum.DataPropertyName = "Zahlungsdatum";
            this.Zahlungsdatum.HeaderText = "Zahlungs - Datum";
            this.Zahlungsdatum.MinimumWidth = 6;
            this.Zahlungsdatum.Name = "Zahlungsdatum";
            this.Zahlungsdatum.ReadOnly = true;
            this.Zahlungsdatum.Width = 110;
            // 
            // Zahlungsbetrag
            // 
            this.Zahlungsbetrag.DataPropertyName = "Zahlungsbetrag";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.Zahlungsbetrag.DefaultCellStyle = dataGridViewCellStyle8;
            this.Zahlungsbetrag.HeaderText = "Zahlungs - Betrag";
            this.Zahlungsbetrag.MinimumWidth = 6;
            this.Zahlungsbetrag.Name = "Zahlungsbetrag";
            this.Zahlungsbetrag.ReadOnly = true;
            this.Zahlungsbetrag.Width = 125;
            // 
            // NochOffen
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Format = "C2";
            this.NochOffen.DefaultCellStyle = dataGridViewCellStyle9;
            this.NochOffen.HeaderText = "noch offen";
            this.NochOffen.MinimumWidth = 6;
            this.NochOffen.Name = "NochOffen";
            this.NochOffen.ReadOnly = true;
            this.NochOffen.Width = 125;
            // 
            // Mahnung1datum
            // 
            this.Mahnung1datum.DataPropertyName = "Mahnung1datum";
            this.Mahnung1datum.HeaderText = "1.Mahnung";
            this.Mahnung1datum.MinimumWidth = 6;
            this.Mahnung1datum.Name = "Mahnung1datum";
            this.Mahnung1datum.ReadOnly = true;
            this.Mahnung1datum.Width = 125;
            // 
            // Mahnung2datum
            // 
            this.Mahnung2datum.DataPropertyName = "Mahnung2datum";
            this.Mahnung2datum.HeaderText = "2.Mahnung";
            this.Mahnung2datum.MinimumWidth = 6;
            this.Mahnung2datum.Name = "Mahnung2datum";
            this.Mahnung2datum.ReadOnly = true;
            this.Mahnung2datum.Width = 125;
            // 
            // Mahnung3datum
            // 
            this.Mahnung3datum.DataPropertyName = "Mahnung3datum";
            this.Mahnung3datum.HeaderText = "3.Mahnung";
            this.Mahnung3datum.MinimumWidth = 6;
            this.Mahnung3datum.Name = "Mahnung3datum";
            this.Mahnung3datum.ReadOnly = true;
            this.Mahnung3datum.Width = 125;
            // 
            // Bemerkungen
            // 
            this.Bemerkungen.DataPropertyName = "Bemerkungen";
            this.Bemerkungen.HeaderText = "Bemerkungen";
            this.Bemerkungen.MinimumWidth = 6;
            this.Bemerkungen.Name = "Bemerkungen";
            this.Bemerkungen.ReadOnly = true;
            this.Bemerkungen.Width = 225;
            // 
            // LieferscheinNr
            // 
            this.LieferscheinNr.DataPropertyName = "LieferscheinNr";
            this.LieferscheinNr.HeaderText = "Lieferschein -Nr";
            this.LieferscheinNr.MinimumWidth = 6;
            this.LieferscheinNr.Name = "LieferscheinNr";
            this.LieferscheinNr.ReadOnly = true;
            this.LieferscheinNr.Width = 125;
            // 
            // RE_Firmenname
            // 
            this.RE_Firmenname.DataPropertyName = "RE_Firmenname";
            this.RE_Firmenname.HeaderText = "Firmenname";
            this.RE_Firmenname.MinimumWidth = 6;
            this.RE_Firmenname.Name = "RE_Firmenname";
            this.RE_Firmenname.ReadOnly = true;
            this.RE_Firmenname.Width = 200;
            // 
            // RE_Name
            // 
            this.RE_Name.DataPropertyName = "RE_Name";
            this.RE_Name.HeaderText = "Name";
            this.RE_Name.MinimumWidth = 6;
            this.RE_Name.Name = "RE_Name";
            this.RE_Name.ReadOnly = true;
            this.RE_Name.Width = 125;
            // 
            // RE_Strasse
            // 
            this.RE_Strasse.DataPropertyName = "RE_Strasse";
            this.RE_Strasse.HeaderText = "Strasse";
            this.RE_Strasse.MinimumWidth = 6;
            this.RE_Strasse.Name = "RE_Strasse";
            this.RE_Strasse.ReadOnly = true;
            this.RE_Strasse.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "RE_PLZ";
            this.dataGridViewTextBoxColumn21.HeaderText = "RE_PLZ";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // RE_Stadt
            // 
            this.RE_Stadt.DataPropertyName = "RE_Stadt";
            this.RE_Stadt.HeaderText = "Stadt";
            this.RE_Stadt.MinimumWidth = 6;
            this.RE_Stadt.Name = "RE_Stadt";
            this.RE_Stadt.ReadOnly = true;
            this.RE_Stadt.Width = 125;
            // 
            // RE_Land
            // 
            this.RE_Land.DataPropertyName = "RE_Land";
            this.RE_Land.HeaderText = "Land";
            this.RE_Land.MinimumWidth = 6;
            this.RE_Land.Name = "RE_Land";
            this.RE_Land.ReadOnly = true;
            this.RE_Land.Width = 125;
            // 
            // RechnungPfad
            // 
            this.RechnungPfad.DataPropertyName = "RechnungPfad";
            this.RechnungPfad.HeaderText = "RechnungPfad";
            this.RechnungPfad.MinimumWidth = 6;
            this.RechnungPfad.Name = "RechnungPfad";
            this.RechnungPfad.ReadOnly = true;
            this.RechnungPfad.Visible = false;
            this.RechnungPfad.Width = 125;
            // 
            // PriProRechnungID
            // 
            this.PriProRechnungID.DataPropertyName = "PriProRechnungID";
            this.PriProRechnungID.HeaderText = "PriProRechnungID";
            this.PriProRechnungID.MinimumWidth = 6;
            this.PriProRechnungID.Name = "PriProRechnungID";
            this.PriProRechnungID.ReadOnly = true;
            this.PriProRechnungID.Visible = false;
            this.PriProRechnungID.Width = 125;
            // 
            // priProRechnungBindingSource
            // 
            this.priProRechnungBindingSource.DataMember = "PriProRechnung";
            this.priProRechnungBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.offeneRechnungenTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.zahlungsBetragTextbox);
            this.panel3.Controls.Add(this.SummeRechnungsBetragTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1731, 57);
            this.panel3.TabIndex = 1;
            // 
            // offeneRechnungenTextBox
            // 
            this.offeneRechnungenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offeneRechnungenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.offeneRechnungenTextBox.Location = new System.Drawing.Point(1603, 25);
            this.offeneRechnungenTextBox.Name = "offeneRechnungenTextBox";
            this.offeneRechnungenTextBox.Size = new System.Drawing.Size(106, 23);
            this.offeneRechnungenTextBox.TabIndex = 19;
            this.offeneRechnungenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1600, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "offene Rechnungen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1412, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "SUMME Zahlungsbetrag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(938, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "SUMME Rechnungsbetrag:";
            // 
            // zahlungsBetragTextbox
            // 
            this.zahlungsBetragTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahlungsBetragTextbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.zahlungsBetragTextbox.Location = new System.Drawing.Point(1458, 25);
            this.zahlungsBetragTextbox.Name = "zahlungsBetragTextbox";
            this.zahlungsBetragTextbox.Size = new System.Drawing.Size(120, 23);
            this.zahlungsBetragTextbox.TabIndex = 15;
            this.zahlungsBetragTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SummeRechnungsBetragTextBox
            // 
            this.SummeRechnungsBetragTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummeRechnungsBetragTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SummeRechnungsBetragTextBox.Location = new System.Drawing.Point(979, 25);
            this.SummeRechnungsBetragTextBox.Name = "SummeRechnungsBetragTextBox";
            this.SummeRechnungsBetragTextBox.Size = new System.Drawing.Size(125, 23);
            this.SummeRechnungsBetragTextBox.TabIndex = 14;
            this.SummeRechnungsBetragTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priProRechnungBindingNavigator
            // 
            this.priProRechnungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.priProRechnungBindingNavigator.BindingSource = this.priProRechnungBindingSource;
            this.priProRechnungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.priProRechnungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.priProRechnungBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.priProRechnungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.priProRechnungBindingNavigator.Location = new System.Drawing.Point(0, 68);
            this.priProRechnungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.priProRechnungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.priProRechnungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.priProRechnungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.priProRechnungBindingNavigator.Name = "priProRechnungBindingNavigator";
            this.priProRechnungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.priProRechnungBindingNavigator.Size = new System.Drawing.Size(1200, 25);
            this.priProRechnungBindingNavigator.TabIndex = 2;
            this.priProRechnungBindingNavigator.Text = "bindingNavigator1";
            this.priProRechnungBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 22);
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
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 22);
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Text = "Daten speichern";
            this.priProLieferscheinRechnungBindingNavigatorSaveItem.Click += new System.EventHandler(this.priProLieferscheinRechnungBindingNavigatorSaveItem_Click);
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
            this.tableAdapterManager.PriProLieferscheinRechnungTableAdapter = null;
            this.tableAdapterManager.PriProRechnungTableAdapter = this.priProRechnungTableAdapter;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // priProRechnungTableAdapter
            // 
            this.priProRechnungTableAdapter.ClearBeforeFill = true;
            // 
            // Rechnung01_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1751, 665);
            this.Controls.Add(this.priProRechnungBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rechnung01_main";
            this.Text = "Rechnungen";
            this.Load += new System.EventHandler(this.Rechnung01_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priProRechnungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priProRechnungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priProRechnungBindingNavigator)).EndInit();
            this.priProRechnungBindingNavigator.ResumeLayout(false);
            this.priProRechnungBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_neueRechnung;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private System.Windows.Forms.Label label1;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource priProRechnungBindingSource;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator priProRechnungBindingNavigator;
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
        private System.Windows.Forms.DataGridView priProRechnungDataGridView;
        private System.Windows.Forms.Panel panel3;
        private DAL.DataSet1TableAdapters.PriProRechnungTableAdapter priProRechnungTableAdapter;
        private System.Windows.Forms.TextBox SummeRechnungsBetragTextBox;
        private System.Windows.Forms.TextBox zahlungsBetragTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offeneRechnungenTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn XLSX;
        private System.Windows.Forms.DataGridViewButtonColumn PDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projektnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungErsteller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rechnungsbetrag;
        private System.Windows.Forms.DataGridViewButtonColumn Ändern;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zahlungsziel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zahlungsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zahlungsbetrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn NochOffen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahnung1datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahnung2datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahnung3datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bemerkungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieferscheinNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE_Firmenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE_Strasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE_Stadt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE_Land;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungPfad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriProRechnungID;
    }
}