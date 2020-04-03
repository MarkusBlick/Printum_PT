namespace PrintumProjektverwaltung.Forms
{
    partial class Ausliefer06_Positionen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausliefer06_Positionen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2_speichern = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3_neu = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lieferungPositionenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPositionNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArtikelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArtikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikelnrButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBeschreibungEnglisch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMengeneinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loeschenButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aendernButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.speichernButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GeloeschtAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeloeschtVon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeloeschtGrund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeaenderAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeaendertVon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeaendertGrund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieferungPositionenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.ArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lieferungPositionenTableAdapter1 = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.LieferungPositionenTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.artikelTableAdapter1 = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.ArtikelTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungPositionenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungPositionenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 8, 8, 8);
            this.panel1.Size = new System.Drawing.Size(1664, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Positionen von: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2_speichern
            // 
            this.button2_speichern.BackColor = System.Drawing.Color.OliveDrab;
            this.button2_speichern.ForeColor = System.Drawing.SystemColors.Info;
            this.button2_speichern.Location = new System.Drawing.Point(1444, 30);
            this.button2_speichern.Name = "button2_speichern";
            this.button2_speichern.Size = new System.Drawing.Size(197, 32);
            this.button2_speichern.TabIndex = 2;
            this.button2_speichern.Text = "speichern";
            this.button2_speichern.UseVisualStyleBackColor = false;
            this.button2_speichern.Visible = false;
            this.button2_speichern.Click += new System.EventHandler(this.button2_speichern_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3_neu);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2_speichern);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lieferungPositionenDataGridView);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1664, 765);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 2;
            // 
            // button3_neu
            // 
            this.button3_neu.BackColor = System.Drawing.Color.OliveDrab;
            this.button3_neu.ForeColor = System.Drawing.SystemColors.Info;
            this.button3_neu.Location = new System.Drawing.Point(539, 30);
            this.button3_neu.Name = "button3_neu";
            this.button3_neu.Size = new System.Drawing.Size(239, 32);
            this.button3_neu.TabIndex = 6;
            this.button3_neu.Text = "neue Position  hinzufügen";
            this.button3_neu.UseVisualStyleBackColor = false;
            this.button3_neu.Click += new System.EventHandler(this.button3_neu_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1235, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Änderungen anzeigen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(20, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "sortieren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lieferungPositionenDataGridView
            // 
            this.lieferungPositionenDataGridView.AutoGenerateColumns = false;
            this.lieferungPositionenDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.lieferungPositionenDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lieferungPositionenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lieferungPositionenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgvPositionNr,
            this.dgvArtikelID,
            this.dgvArtikelnummer,
            this.ArtikelnrButton,
            this.dgvBeschreibung,
            this.dgvBeschreibungEnglisch,
            this.dgvAnzahl,
            this.dgvMengeneinheit,
            this.dgvPreis,
            this.dataGridViewTextBoxColumn8,
            this.dgvEinheit,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.loeschenButton,
            this.aendernButton,
            this.speichernButton,
            this.GeloeschtAm,
            this.GeloeschtVon,
            this.GeloeschtGrund,
            this.GeaenderAm,
            this.GeaendertVon,
            this.GeaendertGrund});
            this.lieferungPositionenDataGridView.DataSource = this.lieferungPositionenBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lieferungPositionenDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.lieferungPositionenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lieferungPositionenDataGridView.Location = new System.Drawing.Point(20, 0);
            this.lieferungPositionenDataGridView.Name = "lieferungPositionenDataGridView";
            this.lieferungPositionenDataGridView.RowHeadersVisible = false;
            this.lieferungPositionenDataGridView.Size = new System.Drawing.Size(1624, 681);
            this.lieferungPositionenDataGridView.TabIndex = 0;
            this.lieferungPositionenDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lieferungPositionenDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PositionenID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dgvPositionNr
            // 
            this.dgvPositionNr.DataPropertyName = "PositionNr";
            this.dgvPositionNr.HeaderText = "PositionNr";
            this.dgvPositionNr.Name = "dgvPositionNr";
            this.dgvPositionNr.ReadOnly = true;
            // 
            // dgvArtikelID
            // 
            this.dgvArtikelID.DataPropertyName = "ArtikeID";
            this.dgvArtikelID.HeaderText = "ArtikeID";
            this.dgvArtikelID.Name = "dgvArtikelID";
            this.dgvArtikelID.Visible = false;
            // 
            // dgvArtikelnummer
            // 
            this.dgvArtikelnummer.DataPropertyName = "Artikelnummer";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvArtikelnummer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtikelnummer.HeaderText = "Artikelnummer";
            this.dgvArtikelnummer.Name = "dgvArtikelnummer";
            this.dgvArtikelnummer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikelnummer.Width = 150;
            // 
            // ArtikelnrButton
            // 
            this.ArtikelnrButton.DataPropertyName = "Artikelnummer";
            this.ArtikelnrButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ArtikelnrButton.HeaderText = "Artikelnummer";
            this.ArtikelnrButton.Name = "ArtikelnrButton";
            this.ArtikelnrButton.ReadOnly = true;
            this.ArtikelnrButton.Text = "Artikelnr wählen";
            this.ArtikelnrButton.ToolTipText = "einmal klicken bitte";
            this.ArtikelnrButton.Visible = false;
            this.ArtikelnrButton.Width = 150;
            // 
            // dgvBeschreibung
            // 
            this.dgvBeschreibung.DataPropertyName = "Beschreibung";
            this.dgvBeschreibung.HeaderText = "Beschreibung";
            this.dgvBeschreibung.Name = "dgvBeschreibung";
            this.dgvBeschreibung.ReadOnly = true;
            this.dgvBeschreibung.Width = 530;
            // 
            // dgvBeschreibungEnglisch
            // 
            this.dgvBeschreibungEnglisch.DataPropertyName = "BeschreibungEnglish";
            this.dgvBeschreibungEnglisch.HeaderText = "BeschreibungEnglish";
            this.dgvBeschreibungEnglisch.Name = "dgvBeschreibungEnglisch";
            this.dgvBeschreibungEnglisch.ReadOnly = true;
            this.dgvBeschreibungEnglisch.Width = 450;
            // 
            // dgvAnzahl
            // 
            this.dgvAnzahl.DataPropertyName = "Anzahl";
            this.dgvAnzahl.HeaderText = "Anzahl";
            this.dgvAnzahl.Name = "dgvAnzahl";
            this.dgvAnzahl.Width = 70;
            // 
            // dgvMengeneinheit
            // 
            this.dgvMengeneinheit.DataPropertyName = "Mengeneinheit";
            this.dgvMengeneinheit.HeaderText = "ME";
            this.dgvMengeneinheit.Name = "dgvMengeneinheit";
            this.dgvMengeneinheit.Width = 50;
            // 
            // dgvPreis
            // 
            this.dgvPreis.DataPropertyName = "Preis";
            this.dgvPreis.HeaderText = "Preis";
            this.dgvPreis.Name = "dgvPreis";
            this.dgvPreis.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EinheitID";
            this.dataGridViewTextBoxColumn8.HeaderText = "EinheitID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dgvEinheit
            // 
            this.dgvEinheit.DataPropertyName = "Einheit";
            this.dgvEinheit.HeaderText = "Einheit";
            this.dgvEinheit.Name = "dgvEinheit";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AuftragID";
            this.dataGridViewTextBoxColumn10.HeaderText = "AuftragID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AuftragNummer";
            this.dataGridViewTextBoxColumn11.HeaderText = "AuftragNummer";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "HinzugefuegtAm";
            this.dataGridViewTextBoxColumn12.HeaderText = "HinzugefuegtAm";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "HinzugefuegtVon";
            this.dataGridViewTextBoxColumn13.HeaderText = "HinzugefuegtVon";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "HinzugefuegtGrund";
            this.dataGridViewTextBoxColumn14.HeaderText = "HinzugefuegtGrund";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // loeschenButton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loeschenButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.loeschenButton.HeaderText = "";
            this.loeschenButton.Name = "loeschenButton";
            this.loeschenButton.Text = "Löschen";
            this.loeschenButton.UseColumnTextForButtonValue = true;
            this.loeschenButton.Width = 70;
            // 
            // aendernButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.aendernButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.aendernButton.HeaderText = "";
            this.aendernButton.Name = "aendernButton";
            this.aendernButton.Text = "ändern";
            this.aendernButton.UseColumnTextForButtonValue = true;
            this.aendernButton.Width = 70;
            // 
            // speichernButton
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.speichernButton.DefaultCellStyle = dataGridViewCellStyle4;
            this.speichernButton.HeaderText = "";
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speichernButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speichernButton.Text = "speichern";
            this.speichernButton.UseColumnTextForButtonValue = true;
            this.speichernButton.Visible = false;
            this.speichernButton.Width = 70;
            // 
            // GeloeschtAm
            // 
            this.GeloeschtAm.DataPropertyName = "GeloeschtAm";
            this.GeloeschtAm.HeaderText = "GeloeschtAm";
            this.GeloeschtAm.Name = "GeloeschtAm";
            this.GeloeschtAm.ReadOnly = true;
            this.GeloeschtAm.Visible = false;
            // 
            // GeloeschtVon
            // 
            this.GeloeschtVon.DataPropertyName = "GeloeschtVon";
            this.GeloeschtVon.HeaderText = "GeloeschtVon";
            this.GeloeschtVon.Name = "GeloeschtVon";
            this.GeloeschtVon.ReadOnly = true;
            this.GeloeschtVon.Visible = false;
            // 
            // GeloeschtGrund
            // 
            this.GeloeschtGrund.DataPropertyName = "GeloeschtGrund";
            this.GeloeschtGrund.HeaderText = "GeloeschtGrund";
            this.GeloeschtGrund.Name = "GeloeschtGrund";
            this.GeloeschtGrund.Visible = false;
            // 
            // GeaenderAm
            // 
            this.GeaenderAm.DataPropertyName = "GeaenderAm";
            this.GeaenderAm.HeaderText = "GeaenderAm";
            this.GeaenderAm.Name = "GeaenderAm";
            this.GeaenderAm.Visible = false;
            // 
            // GeaendertVon
            // 
            this.GeaendertVon.DataPropertyName = "GeaendertVon";
            this.GeaendertVon.HeaderText = "GeaendertVon";
            this.GeaendertVon.Name = "GeaendertVon";
            this.GeaendertVon.Visible = false;
            // 
            // GeaendertGrund
            // 
            this.GeaendertGrund.DataPropertyName = "GeaendertGrund";
            this.GeaendertGrund.HeaderText = "GeaendertGrund";
            this.GeaendertGrund.Name = "GeaendertGrund";
            this.GeaendertGrund.Visible = false;
            // 
            // lieferungPositionenBindingSource
            // 
            this.lieferungPositionenBindingSource.DataMember = "LieferungPositionen";
            this.lieferungPositionenBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArtikelBindingSource
            // 
            this.ArtikelBindingSource.DataMember = "Artikel";
            this.ArtikelBindingSource.DataSource = this.dataSet1;
            // 
            // lieferungPositionenTableAdapter1
            // 
            this.lieferungPositionenTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressenTableAdapter = null;
            this.tableAdapterManager.ArtikelTableAdapter = this.artikelTableAdapter1;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BestellungenTableAdapter = null;
            this.tableAdapterManager.BestellungPositionenTableAdapter = null;
            this.tableAdapterManager.EinheitTableAdapter = null;
            this.tableAdapterManager.LieferungLieferscheinTableAdapter = null;
            this.tableAdapterManager.LieferungPositionenTableAdapter = this.lieferungPositionenTableAdapter1;
            this.tableAdapterManager.LieferungRechnungenTableAdapter = null;
            this.tableAdapterManager.LieferungTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // artikelTableAdapter1
            // 
            this.artikelTableAdapter1.ClearBeforeFill = true;
            // 
            // Ausliefer06_Positionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1664, 826);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ausliefer06_Positionen";
            this.Text = "Auslieferung Positionen";
            this.Load += new System.EventHandler(this.Ausliefer06_Positionen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lieferungPositionenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungPositionenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2_speichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DAL.DataSet1TableAdapters.LieferungPositionenTableAdapter lieferungPositionenTableAdapter1;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource lieferungPositionenBindingSource;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lieferungPositionenDataGridView;
        private DAL.DataSet1TableAdapters.ArtikelTableAdapter artikelTableAdapter1;
        private System.Windows.Forms.BindingSource ArtikelBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3_neu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPositionNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArtikelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArtikelnummer;
        private System.Windows.Forms.DataGridViewButtonColumn ArtikelnrButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBeschreibungEnglisch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMengeneinheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPreis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEinheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewButtonColumn loeschenButton;
        private System.Windows.Forms.DataGridViewButtonColumn aendernButton;
        private System.Windows.Forms.DataGridViewButtonColumn speichernButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeloeschtAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeloeschtVon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeloeschtGrund;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeaenderAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeaendertVon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeaendertGrund;
        private System.Windows.Forms.Timer timer1;
    }
}