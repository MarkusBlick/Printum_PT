namespace PrintumProjektverwaltung.Forms
{
    partial class Form7_AB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7_AB));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bestellungenDataGridView = new System.Windows.Forms.DataGridView();
            this.bestellungIDTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektnummerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istAbgeschicktDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.erstelltVonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geaendertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button5_alleBestellungenanzeigen = new System.Windows.Forms.Button();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bestellungPositionenDataGridView = new System.Windows.Forms.DataGridView();
            this.bestellungPositionenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5_speichern = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_alles = new System.Windows.Forms.Button();
            this.panel1_header = new System.Windows.Forms.Panel();
            this.button8_Adressen = new System.Windows.Forms.Button();
            this.button7_Auftragsbestaetigung = new System.Windows.Forms.Button();
            this.button6_WE = new System.Windows.Forms.Button();
            this.button1_PrintumProjekte = new System.Windows.Forms.Button();
            this.label_ganzOben = new System.Windows.Forms.Label();
            this.panelOb_balkenoben = new System.Windows.Forms.Panel();
            this.panelOb_balkenUnten = new System.Windows.Forms.Panel();
            this.bestellungPositionenTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.BestellungPositionenTableAdapter();
            this.bestellungenTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.BestellungenTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.bestaetigtCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aBdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABestaetiger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEingaenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellPosIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellnungIDTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stueckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelbezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieferterminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeLiefertermin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.einzelpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesammtpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionenBindingSource)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel1_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bestellungenDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel8);
            this.splitContainer1.Panel1.Controls.Add(this.panel11);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bestellungPositionenDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.panel10);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1520, 868);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 1;
            // 
            // bestellungenDataGridView
            // 
            this.bestellungenDataGridView.AllowUserToAddRows = false;
            this.bestellungenDataGridView.AllowUserToDeleteRows = false;
            this.bestellungenDataGridView.AutoGenerateColumns = false;
            this.bestellungenDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bestellungenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bestellungenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bestellungenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestellungenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bestellungIDTextDataGridViewTextBoxColumn,
            this.projektnummerDataGridViewTextBoxColumn1,
            this.adresseDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.istAbgeschicktDataGridViewCheckBoxColumn,
            this.erstelltVonDataGridViewTextBoxColumn,
            this.geaendertDataGridViewTextBoxColumn});
            this.bestellungenDataGridView.DataSource = this.bestellungenBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bestellungenDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.bestellungenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestellungenDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.bestellungenDataGridView.Location = new System.Drawing.Point(10, 70);
            this.bestellungenDataGridView.MultiSelect = false;
            this.bestellungenDataGridView.Name = "bestellungenDataGridView";
            this.bestellungenDataGridView.ReadOnly = true;
            this.bestellungenDataGridView.RowHeadersVisible = false;
            this.bestellungenDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bestellungenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bestellungenDataGridView.Size = new System.Drawing.Size(1500, 322);
            this.bestellungenDataGridView.TabIndex = 10;
            // 
            // bestellungIDTextDataGridViewTextBoxColumn
            // 
            this.bestellungIDTextDataGridViewTextBoxColumn.DataPropertyName = "BestellungIDText";
            this.bestellungIDTextDataGridViewTextBoxColumn.HeaderText = "Bestellung Nr";
            this.bestellungIDTextDataGridViewTextBoxColumn.Name = "bestellungIDTextDataGridViewTextBoxColumn";
            this.bestellungIDTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.bestellungIDTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // projektnummerDataGridViewTextBoxColumn1
            // 
            this.projektnummerDataGridViewTextBoxColumn1.DataPropertyName = "Projektnummer";
            this.projektnummerDataGridViewTextBoxColumn1.HeaderText = "Projektnummer";
            this.projektnummerDataGridViewTextBoxColumn1.Name = "projektnummerDataGridViewTextBoxColumn1";
            this.projektnummerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.projektnummerDataGridViewTextBoxColumn1.Width = 150;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 500;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // istAbgeschicktDataGridViewCheckBoxColumn
            // 
            this.istAbgeschicktDataGridViewCheckBoxColumn.DataPropertyName = "istAbgeschickt";
            this.istAbgeschicktDataGridViewCheckBoxColumn.HeaderText = "abgeschickt";
            this.istAbgeschicktDataGridViewCheckBoxColumn.Name = "istAbgeschicktDataGridViewCheckBoxColumn";
            this.istAbgeschicktDataGridViewCheckBoxColumn.ReadOnly = true;
            this.istAbgeschicktDataGridViewCheckBoxColumn.Width = 120;
            // 
            // erstelltVonDataGridViewTextBoxColumn
            // 
            this.erstelltVonDataGridViewTextBoxColumn.DataPropertyName = "ErstelltVon";
            this.erstelltVonDataGridViewTextBoxColumn.HeaderText = "ErstelltVon";
            this.erstelltVonDataGridViewTextBoxColumn.Name = "erstelltVonDataGridViewTextBoxColumn";
            this.erstelltVonDataGridViewTextBoxColumn.ReadOnly = true;
            this.erstelltVonDataGridViewTextBoxColumn.Width = 170;
            // 
            // geaendertDataGridViewTextBoxColumn
            // 
            this.geaendertDataGridViewTextBoxColumn.DataPropertyName = "geaendert";
            this.geaendertDataGridViewTextBoxColumn.HeaderText = "geaendert";
            this.geaendertDataGridViewTextBoxColumn.Name = "geaendertDataGridViewTextBoxColumn";
            this.geaendertDataGridViewTextBoxColumn.ReadOnly = true;
            this.geaendertDataGridViewTextBoxColumn.Width = 170;
            // 
            // bestellungenBindingSource
            // 
            this.bestellungenBindingSource.DataMember = "Bestellungen";
            this.bestellungenBindingSource.DataSource = this.dataSet11;
            this.bestellungenBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bestellungenBindingSource_ListChanged);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.button5_alleBestellungenanzeigen);
            this.panel3.Controls.Add(this.textBox1_suchen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1500, 30);
            this.panel3.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1230, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(17, 30);
            this.panel13.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1247, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(17, 30);
            this.panel12.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(1264, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(17, 30);
            this.panel14.TabIndex = 12;
            // 
            // button5_alleBestellungenanzeigen
            // 
            this.button5_alleBestellungenanzeigen.BackColor = System.Drawing.Color.IndianRed;
            this.button5_alleBestellungenanzeigen.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5_alleBestellungenanzeigen.FlatAppearance.BorderSize = 0;
            this.button5_alleBestellungenanzeigen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5_alleBestellungenanzeigen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button5_alleBestellungenanzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5_alleBestellungenanzeigen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5_alleBestellungenanzeigen.Location = new System.Drawing.Point(1281, 0);
            this.button5_alleBestellungenanzeigen.Name = "button5_alleBestellungenanzeigen";
            this.button5_alleBestellungenanzeigen.Size = new System.Drawing.Size(219, 30);
            this.button5_alleBestellungenanzeigen.TabIndex = 2;
            this.button5_alleBestellungenanzeigen.Text = "Bestellung anzeigen";
            this.button5_alleBestellungenanzeigen.UseVisualStyleBackColor = false;
            this.button5_alleBestellungenanzeigen.Visible = false;
            // 
            // textBox1_suchen
            // 
            this.textBox1_suchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_suchen.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1_suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_suchen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_suchen.Location = new System.Drawing.Point(0, 0);
            this.textBox1_suchen.Name = "textBox1_suchen";
            this.textBox1_suchen.Size = new System.Drawing.Size(200, 29);
            this.textBox1_suchen.TabIndex = 1;
            this.textBox1_suchen.TextChanged += new System.EventHandler(this.textBox1_suchen_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1500, 30);
            this.panel8.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bestellnummer";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(10, 392);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1500, 1);
            this.panel11.TabIndex = 9;
            // 
            // bestellungPositionenDataGridView
            // 
            this.bestellungPositionenDataGridView.AllowUserToAddRows = false;
            this.bestellungPositionenDataGridView.AllowUserToDeleteRows = false;
            this.bestellungPositionenDataGridView.AutoGenerateColumns = false;
            this.bestellungPositionenDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bestellungPositionenDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bestellungPositionenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestellungPositionenDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bestellungPositionenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bestellungPositionenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestellungPositionenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bestaetigtCheck,
            this.aBdatumDataGridViewTextBoxColumn,
            this.ABestaetiger,
            this.WEingaenger,
            this.bestellPosIDDataGridViewTextBoxColumn,
            this.projektnummerDataGridViewTextBoxColumn,
            this.bestellnungIDTestDataGridViewTextBoxColumn,
            this.posDataGridViewTextBoxColumn,
            this.stueckDataGridViewTextBoxColumn,
            this.artikelbezeichnungDataGridViewTextBoxColumn,
            this.lieferterminDataGridViewTextBoxColumn,
            this.changeLiefertermin,
            this.einzelpreisDataGridViewTextBoxColumn,
            this.gesammtpreisDataGridViewTextBoxColumn});
            this.bestellungPositionenDataGridView.DataSource = this.bestellungPositionenBindingSource;
            this.bestellungPositionenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestellungPositionenDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.bestellungPositionenDataGridView.Location = new System.Drawing.Point(10, 45);
            this.bestellungPositionenDataGridView.MultiSelect = false;
            this.bestellungPositionenDataGridView.Name = "bestellungPositionenDataGridView";
            this.bestellungPositionenDataGridView.RowHeadersVisible = false;
            this.bestellungPositionenDataGridView.RowTemplate.Height = 35;
            this.bestellungPositionenDataGridView.Size = new System.Drawing.Size(1500, 406);
            this.bestellungPositionenDataGridView.TabIndex = 1;
            this.bestellungPositionenDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bestellungPositionenDataGridView_CellClick);
            this.bestellungPositionenDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.bestellungPositionenDataGridView_CellValueChanged);
            // 
            // bestellungPositionenBindingSource
            // 
            this.bestellungPositionenBindingSource.DataMember = "BestellungPositionen";
            this.bestellungPositionenBindingSource.DataSource = this.dataSet11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button5_speichern);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.button1_alles);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1500, 35);
            this.panel10.TabIndex = 9;
            // 
            // button5_speichern
            // 
            this.button5_speichern.BackColor = System.Drawing.Color.IndianRed;
            this.button5_speichern.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5_speichern.FlatAppearance.BorderSize = 0;
            this.button5_speichern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5_speichern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button5_speichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5_speichern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5_speichern.Location = new System.Drawing.Point(1012, 0);
            this.button5_speichern.Name = "button5_speichern";
            this.button5_speichern.Size = new System.Drawing.Size(185, 35);
            this.button5_speichern.TabIndex = 13;
            this.button5_speichern.Text = "speichern";
            this.button5_speichern.UseVisualStyleBackColor = false;
            this.button5_speichern.Click += new System.EventHandler(this.button5_speichern_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(381, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 35);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(222, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bestell-Positionen";
            // 
            // button1_alles
            // 
            this.button1_alles.BackColor = System.Drawing.Color.IndianRed;
            this.button1_alles.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1_alles.FlatAppearance.BorderSize = 0;
            this.button1_alles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1_alles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1_alles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_alles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_alles.Location = new System.Drawing.Point(0, 0);
            this.button1_alles.Name = "button1_alles";
            this.button1_alles.Size = new System.Drawing.Size(222, 35);
            this.button1_alles.TabIndex = 3;
            this.button1_alles.Text = "alles bestätigen";
            this.button1_alles.UseVisualStyleBackColor = false;
            this.button1_alles.Click += new System.EventHandler(this.button1_alles_Click);
            // 
            // panel1_header
            // 
            this.panel1_header.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1_header.Controls.Add(this.button8_Adressen);
            this.panel1_header.Controls.Add(this.button7_Auftragsbestaetigung);
            this.panel1_header.Controls.Add(this.button6_WE);
            this.panel1_header.Controls.Add(this.button1_PrintumProjekte);
            this.panel1_header.Controls.Add(this.label_ganzOben);
            this.panel1_header.Controls.Add(this.panelOb_balkenoben);
            this.panel1_header.Controls.Add(this.panelOb_balkenUnten);
            this.panel1_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_header.Location = new System.Drawing.Point(0, 0);
            this.panel1_header.Name = "panel1_header";
            this.panel1_header.Padding = new System.Windows.Forms.Padding(5);
            this.panel1_header.Size = new System.Drawing.Size(1520, 46);
            this.panel1_header.TabIndex = 2;
            // 
            // button8_Adressen
            // 
            this.button8_Adressen.BackColor = System.Drawing.Color.IndianRed;
            this.button8_Adressen.FlatAppearance.BorderSize = 0;
            this.button8_Adressen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8_Adressen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button8_Adressen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8_Adressen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8_Adressen.Location = new System.Drawing.Point(657, 9);
            this.button8_Adressen.Name = "button8_Adressen";
            this.button8_Adressen.Size = new System.Drawing.Size(166, 32);
            this.button8_Adressen.TabIndex = 9;
            this.button8_Adressen.Text = "Adressen";
            this.button8_Adressen.UseVisualStyleBackColor = false;
            this.button8_Adressen.Visible = false;
            // 
            // button7_Auftragsbestaetigung
            // 
            this.button7_Auftragsbestaetigung.BackColor = System.Drawing.Color.IndianRed;
            this.button7_Auftragsbestaetigung.FlatAppearance.BorderSize = 0;
            this.button7_Auftragsbestaetigung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7_Auftragsbestaetigung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button7_Auftragsbestaetigung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7_Auftragsbestaetigung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7_Auftragsbestaetigung.Location = new System.Drawing.Point(874, 9);
            this.button7_Auftragsbestaetigung.Name = "button7_Auftragsbestaetigung";
            this.button7_Auftragsbestaetigung.Size = new System.Drawing.Size(166, 32);
            this.button7_Auftragsbestaetigung.TabIndex = 8;
            this.button7_Auftragsbestaetigung.Text = "Auftragsbestätigung";
            this.button7_Auftragsbestaetigung.UseVisualStyleBackColor = false;
            this.button7_Auftragsbestaetigung.Visible = false;
            // 
            // button6_WE
            // 
            this.button6_WE.BackColor = System.Drawing.Color.IndianRed;
            this.button6_WE.FlatAppearance.BorderSize = 0;
            this.button6_WE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6_WE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button6_WE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6_WE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6_WE.Location = new System.Drawing.Point(1091, 9);
            this.button6_WE.Name = "button6_WE";
            this.button6_WE.Size = new System.Drawing.Size(166, 32);
            this.button6_WE.TabIndex = 7;
            this.button6_WE.Text = "Wareneingang";
            this.button6_WE.UseVisualStyleBackColor = false;
            this.button6_WE.Visible = false;
            // 
            // button1_PrintumProjekte
            // 
            this.button1_PrintumProjekte.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1_PrintumProjekte.FlatAppearance.BorderSize = 0;
            this.button1_PrintumProjekte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1_PrintumProjekte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1_PrintumProjekte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_PrintumProjekte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_PrintumProjekte.Location = new System.Drawing.Point(1308, 9);
            this.button1_PrintumProjekte.Name = "button1_PrintumProjekte";
            this.button1_PrintumProjekte.Size = new System.Drawing.Size(166, 32);
            this.button1_PrintumProjekte.TabIndex = 6;
            this.button1_PrintumProjekte.Text = "Printum-Projekte";
            this.button1_PrintumProjekte.UseVisualStyleBackColor = false;
            this.button1_PrintumProjekte.Click += new System.EventHandler(this.button1_PrintumProjekte_Click);
            // 
            // label_ganzOben
            // 
            this.label_ganzOben.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_ganzOben.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ganzOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_ganzOben.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ganzOben.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_ganzOben.Location = new System.Drawing.Point(5, 6);
            this.label_ganzOben.Margin = new System.Windows.Forms.Padding(0);
            this.label_ganzOben.Name = "label_ganzOben";
            this.label_ganzOben.Size = new System.Drawing.Size(1510, 34);
            this.label_ganzOben.TabIndex = 4;
            this.label_ganzOben.Text = "Auftragsbestätigung";
            // 
            // panelOb_balkenoben
            // 
            this.panelOb_balkenoben.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelOb_balkenoben.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOb_balkenoben.Location = new System.Drawing.Point(5, 5);
            this.panelOb_balkenoben.Name = "panelOb_balkenoben";
            this.panelOb_balkenoben.Size = new System.Drawing.Size(1510, 1);
            this.panelOb_balkenoben.TabIndex = 3;
            // 
            // panelOb_balkenUnten
            // 
            this.panelOb_balkenUnten.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelOb_balkenUnten.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOb_balkenUnten.Location = new System.Drawing.Point(5, 40);
            this.panelOb_balkenUnten.Name = "panelOb_balkenUnten";
            this.panelOb_balkenUnten.Size = new System.Drawing.Size(1510, 1);
            this.panelOb_balkenUnten.TabIndex = 2;
            // 
            // bestellungPositionenTableAdapter
            // 
            this.bestellungPositionenTableAdapter.ClearBeforeFill = true;
            // 
            // bestellungenTableAdapter
            // 
            this.bestellungenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressenTableAdapter = null;
            this.tableAdapterManager.ArtikelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BestellungenTableAdapter = null;
            this.tableAdapterManager.BestellungPositionenTableAdapter = this.bestellungPositionenTableAdapter;
            this.tableAdapterManager.EinheitTableAdapter = null;
            this.tableAdapterManager.LieferungLieferscheinTableAdapter = null;
            this.tableAdapterManager.LieferungPositionenTableAdapter = null;
            this.tableAdapterManager.LieferungRechnungenTableAdapter = null;
            this.tableAdapterManager.LieferungTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bestaetigtCheck
            // 
            this.bestaetigtCheck.HeaderText = "bestätigt";
            this.bestaetigtCheck.Name = "bestaetigtCheck";
            this.bestaetigtCheck.Visible = false;
            // 
            // aBdatumDataGridViewTextBoxColumn
            // 
            this.aBdatumDataGridViewTextBoxColumn.DataPropertyName = "AB_datum";
            this.aBdatumDataGridViewTextBoxColumn.HeaderText = "AB Datum";
            this.aBdatumDataGridViewTextBoxColumn.Name = "aBdatumDataGridViewTextBoxColumn";
            this.aBdatumDataGridViewTextBoxColumn.Width = 140;
            // 
            // ABestaetiger
            // 
            this.ABestaetiger.DataPropertyName = "ABestaetiger";
            this.ABestaetiger.HeaderText = "ABestaetiger";
            this.ABestaetiger.Name = "ABestaetiger";
            this.ABestaetiger.Visible = false;
            // 
            // WEingaenger
            // 
            this.WEingaenger.DataPropertyName = "WEingaenger";
            this.WEingaenger.HeaderText = "WEingaenger";
            this.WEingaenger.Name = "WEingaenger";
            this.WEingaenger.Visible = false;
            // 
            // bestellPosIDDataGridViewTextBoxColumn
            // 
            this.bestellPosIDDataGridViewTextBoxColumn.DataPropertyName = "BestellPos_ID";
            this.bestellPosIDDataGridViewTextBoxColumn.HeaderText = "BestellPos_ID";
            this.bestellPosIDDataGridViewTextBoxColumn.Name = "bestellPosIDDataGridViewTextBoxColumn";
            this.bestellPosIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bestellPosIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // projektnummerDataGridViewTextBoxColumn
            // 
            this.projektnummerDataGridViewTextBoxColumn.DataPropertyName = "Projektnummer";
            this.projektnummerDataGridViewTextBoxColumn.HeaderText = "Projektnummer";
            this.projektnummerDataGridViewTextBoxColumn.Name = "projektnummerDataGridViewTextBoxColumn";
            this.projektnummerDataGridViewTextBoxColumn.Visible = false;
            this.projektnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // bestellnungIDTestDataGridViewTextBoxColumn
            // 
            this.bestellnungIDTestDataGridViewTextBoxColumn.DataPropertyName = "BestellnungIDTest";
            this.bestellnungIDTestDataGridViewTextBoxColumn.HeaderText = "Bestellnung Nr";
            this.bestellnungIDTestDataGridViewTextBoxColumn.Name = "bestellnungIDTestDataGridViewTextBoxColumn";
            this.bestellnungIDTestDataGridViewTextBoxColumn.Visible = false;
            this.bestellnungIDTestDataGridViewTextBoxColumn.Width = 150;
            // 
            // posDataGridViewTextBoxColumn
            // 
            this.posDataGridViewTextBoxColumn.DataPropertyName = "Pos";
            this.posDataGridViewTextBoxColumn.HeaderText = "Pos";
            this.posDataGridViewTextBoxColumn.Name = "posDataGridViewTextBoxColumn";
            this.posDataGridViewTextBoxColumn.Width = 70;
            // 
            // stueckDataGridViewTextBoxColumn
            // 
            this.stueckDataGridViewTextBoxColumn.DataPropertyName = "Stueck";
            this.stueckDataGridViewTextBoxColumn.HeaderText = "Stück";
            this.stueckDataGridViewTextBoxColumn.Name = "stueckDataGridViewTextBoxColumn";
            this.stueckDataGridViewTextBoxColumn.Width = 70;
            // 
            // artikelbezeichnungDataGridViewTextBoxColumn
            // 
            this.artikelbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Artikelbezeichnung";
            this.artikelbezeichnungDataGridViewTextBoxColumn.HeaderText = "Artikelbezeichnung";
            this.artikelbezeichnungDataGridViewTextBoxColumn.Name = "artikelbezeichnungDataGridViewTextBoxColumn";
            this.artikelbezeichnungDataGridViewTextBoxColumn.Width = 550;
            // 
            // lieferterminDataGridViewTextBoxColumn
            // 
            this.lieferterminDataGridViewTextBoxColumn.DataPropertyName = "Liefertermin";
            this.lieferterminDataGridViewTextBoxColumn.HeaderText = "Liefertermin";
            this.lieferterminDataGridViewTextBoxColumn.Name = "lieferterminDataGridViewTextBoxColumn";
            this.lieferterminDataGridViewTextBoxColumn.Width = 140;
            // 
            // changeLiefertermin
            // 
            this.changeLiefertermin.HeaderText = "Liefertermin ändern";
            this.changeLiefertermin.Name = "changeLiefertermin";
            this.changeLiefertermin.Visible = false;
            this.changeLiefertermin.Width = 140;
            // 
            // einzelpreisDataGridViewTextBoxColumn
            // 
            this.einzelpreisDataGridViewTextBoxColumn.DataPropertyName = "Einzelpreis";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.einzelpreisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.einzelpreisDataGridViewTextBoxColumn.HeaderText = "Einzel- preis";
            this.einzelpreisDataGridViewTextBoxColumn.Name = "einzelpreisDataGridViewTextBoxColumn";
            this.einzelpreisDataGridViewTextBoxColumn.Width = 140;
            // 
            // gesammtpreisDataGridViewTextBoxColumn
            // 
            this.gesammtpreisDataGridViewTextBoxColumn.DataPropertyName = "Gesammtpreis";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            this.gesammtpreisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.gesammtpreisDataGridViewTextBoxColumn.HeaderText = "Gesammt- preis";
            this.gesammtpreisDataGridViewTextBoxColumn.Name = "gesammtpreisDataGridViewTextBoxColumn";
            this.gesammtpreisDataGridViewTextBoxColumn.Width = 140;
            // 
            // Form7_AB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1520, 914);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1_header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7_AB";
            this.Text = "Auftragsbestätigung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_AB_FormClosing);
            this.Load += new System.EventHandler(this.Form7_AB_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionenBindingSource)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView bestellungenDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button5_alleBestellungenanzeigen;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView bestellungPositionenDataGridView;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_alles;
        private System.Windows.Forms.Panel panel1_header;
        private System.Windows.Forms.Button button8_Adressen;
        private System.Windows.Forms.Button button7_Auftragsbestaetigung;
        private System.Windows.Forms.Button button6_WE;
        private System.Windows.Forms.Button button1_PrintumProjekte;
        protected System.Windows.Forms.Label label_ganzOben;
        private System.Windows.Forms.Panel panelOb_balkenoben;
        private System.Windows.Forms.Panel panelOb_balkenUnten;
        private DAL.DataSet1 dataSet11;
        private DAL.DataSet1TableAdapters.BestellungPositionenTableAdapter bestellungPositionenTableAdapter;
        private DAL.DataSet1TableAdapters.BestellungenTableAdapter bestellungenTableAdapter;
        private System.Windows.Forms.BindingSource bestellungPositionenBindingSource;
        private System.Windows.Forms.BindingSource bestellungenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungIDTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektnummerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn istAbgeschicktDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn erstelltVonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geaendertDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5_speichern;
        private System.Windows.Forms.Panel panel1;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bestaetigtCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABestaetiger;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEingaenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellPosIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellnungIDTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stueckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelbezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieferterminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn changeLiefertermin;
        private System.Windows.Forms.DataGridViewTextBoxColumn einzelpreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesammtpreisDataGridViewTextBoxColumn;
    }
}