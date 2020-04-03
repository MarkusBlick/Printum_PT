namespace PrintumProjektverwaltung.Forms
{
    partial class Ausliefer02_neu
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
            System.Windows.Forms.Label auftragNummerLabel;
            System.Windows.Forms.Label bezeichnungLabel;
            System.Windows.Forms.Label adressLieferNameLabel;
            System.Windows.Forms.Label adressRechnungNameLabel;
            System.Windows.Forms.Label adressLieferStrasseLabel;
            System.Windows.Forms.Label adressLieferPLZLabel;
            System.Windows.Forms.Label adressLieferOrtLabel;
            System.Windows.Forms.Label adressLieferLandLabel;
            System.Windows.Forms.Label adressRechnungStrasseLabel;
            System.Windows.Forms.Label adressRechnungPLZLabel;
            System.Windows.Forms.Label adressRechnungOrtLabel;
            System.Windows.Forms.Label adressRechnungLandLabel;
            System.Windows.Forms.Label projektnummerLabel;
            System.Windows.Forms.Label projektnameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausliefer02_neu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3_speichern = new System.Windows.Forms.Button();
            this.projektnameTextBox = new System.Windows.Forms.TextBox();
            this.projekteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektnummerTextBox = new System.Windows.Forms.TextBox();
            this.button2_ProjektWaehlen = new System.Windows.Forms.Button();
            this.button_adresse = new System.Windows.Forms.Button();
            this.adressRechnungLandTextBox = new System.Windows.Forms.TextBox();
            this.lieferungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressRechnungOrtTextBox = new System.Windows.Forms.TextBox();
            this.adressRechnungPLZTextBox = new System.Windows.Forms.TextBox();
            this.adressRechnungStrasseTextBox = new System.Windows.Forms.TextBox();
            this.adressLieferLandTextBox = new System.Windows.Forms.TextBox();
            this.adressLieferOrtTextBox = new System.Windows.Forms.TextBox();
            this.adressLieferPLZTextBox = new System.Windows.Forms.TextBox();
            this.adressLieferStrasseTextBox = new System.Windows.Forms.TextBox();
            this.adressRechnungNameTextBox = new System.Windows.Forms.TextBox();
            this.adressLieferNameTextBox = new System.Windows.Forms.TextBox();
            this.bezeichnungTextBox = new System.Windows.Forms.TextBox();
            this.auftragNummerTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lieferungTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.LieferungTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.lieferungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lieferungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.projekteTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.ProjekteTableAdapter();
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            auftragNummerLabel = new System.Windows.Forms.Label();
            bezeichnungLabel = new System.Windows.Forms.Label();
            adressLieferNameLabel = new System.Windows.Forms.Label();
            adressRechnungNameLabel = new System.Windows.Forms.Label();
            adressLieferStrasseLabel = new System.Windows.Forms.Label();
            adressLieferPLZLabel = new System.Windows.Forms.Label();
            adressLieferOrtLabel = new System.Windows.Forms.Label();
            adressLieferLandLabel = new System.Windows.Forms.Label();
            adressRechnungStrasseLabel = new System.Windows.Forms.Label();
            adressRechnungPLZLabel = new System.Windows.Forms.Label();
            adressRechnungOrtLabel = new System.Windows.Forms.Label();
            adressRechnungLandLabel = new System.Windows.Forms.Label();
            projektnummerLabel = new System.Windows.Forms.Label();
            projektnameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projekteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungBindingNavigator)).BeginInit();
            this.lieferungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // auftragNummerLabel
            // 
            auftragNummerLabel.AutoSize = true;
            auftragNummerLabel.Location = new System.Drawing.Point(70, 112);
            auftragNummerLabel.Name = "auftragNummerLabel";
            auftragNummerLabel.Size = new System.Drawing.Size(130, 20);
            auftragNummerLabel.TabIndex = 1;
            auftragNummerLabel.Text = "Auftrag Nummer:";
            // 
            // bezeichnungLabel
            // 
            bezeichnungLabel.AutoSize = true;
            bezeichnungLabel.Location = new System.Drawing.Point(94, 147);
            bezeichnungLabel.Name = "bezeichnungLabel";
            bezeichnungLabel.Size = new System.Drawing.Size(106, 20);
            bezeichnungLabel.TabIndex = 3;
            bezeichnungLabel.Text = "Bezeichnung:";
            // 
            // adressLieferNameLabel
            // 
            adressLieferNameLabel.AutoSize = true;
            adressLieferNameLabel.Location = new System.Drawing.Point(47, 258);
            adressLieferNameLabel.Name = "adressLieferNameLabel";
            adressLieferNameLabel.Size = new System.Drawing.Size(153, 20);
            adressLieferNameLabel.TabIndex = 5;
            adressLieferNameLabel.Text = "Adress Liefer Name:";
            // 
            // adressRechnungNameLabel
            // 
            adressRechnungNameLabel.AutoSize = true;
            adressRechnungNameLabel.Location = new System.Drawing.Point(614, 258);
            adressRechnungNameLabel.Name = "adressRechnungNameLabel";
            adressRechnungNameLabel.Size = new System.Drawing.Size(187, 20);
            adressRechnungNameLabel.TabIndex = 7;
            adressRechnungNameLabel.Text = "Adress Rechnung Name:";
            // 
            // adressLieferStrasseLabel
            // 
            adressLieferStrasseLabel.AutoSize = true;
            adressLieferStrasseLabel.Location = new System.Drawing.Point(40, 298);
            adressLieferStrasseLabel.Name = "adressLieferStrasseLabel";
            adressLieferStrasseLabel.Size = new System.Drawing.Size(166, 20);
            adressLieferStrasseLabel.TabIndex = 9;
            adressLieferStrasseLabel.Text = "Adress Liefer Strasse:";
            // 
            // adressLieferPLZLabel
            // 
            adressLieferPLZLabel.AutoSize = true;
            adressLieferPLZLabel.Location = new System.Drawing.Point(53, 340);
            adressLieferPLZLabel.Name = "adressLieferPLZLabel";
            adressLieferPLZLabel.Size = new System.Drawing.Size(140, 20);
            adressLieferPLZLabel.TabIndex = 11;
            adressLieferPLZLabel.Text = "Adress Liefer PLZ:";
            // 
            // adressLieferOrtLabel
            // 
            adressLieferOrtLabel.AutoSize = true;
            adressLieferOrtLabel.Location = new System.Drawing.Point(57, 386);
            adressLieferOrtLabel.Name = "adressLieferOrtLabel";
            adressLieferOrtLabel.Size = new System.Drawing.Size(133, 20);
            adressLieferOrtLabel.TabIndex = 13;
            adressLieferOrtLabel.Text = "Adress Liefer Ort:";
            // 
            // adressLieferLandLabel
            // 
            adressLieferLandLabel.AutoSize = true;
            adressLieferLandLabel.Location = new System.Drawing.Point(50, 433);
            adressLieferLandLabel.Name = "adressLieferLandLabel";
            adressLieferLandLabel.Size = new System.Drawing.Size(147, 20);
            adressLieferLandLabel.TabIndex = 15;
            adressLieferLandLabel.Text = "Adress Liefer Land:";
            // 
            // adressRechnungStrasseLabel
            // 
            adressRechnungStrasseLabel.AutoSize = true;
            adressRechnungStrasseLabel.Location = new System.Drawing.Point(601, 298);
            adressRechnungStrasseLabel.Name = "adressRechnungStrasseLabel";
            adressRechnungStrasseLabel.Size = new System.Drawing.Size(200, 20);
            adressRechnungStrasseLabel.TabIndex = 17;
            adressRechnungStrasseLabel.Text = "Adress Rechnung Strasse:";
            // 
            // adressRechnungPLZLabel
            // 
            adressRechnungPLZLabel.AutoSize = true;
            adressRechnungPLZLabel.Location = new System.Drawing.Point(627, 340);
            adressRechnungPLZLabel.Name = "adressRechnungPLZLabel";
            adressRechnungPLZLabel.Size = new System.Drawing.Size(174, 20);
            adressRechnungPLZLabel.TabIndex = 19;
            adressRechnungPLZLabel.Text = "Adress Rechnung PLZ:";
            // 
            // adressRechnungOrtLabel
            // 
            adressRechnungOrtLabel.AutoSize = true;
            adressRechnungOrtLabel.Location = new System.Drawing.Point(634, 386);
            adressRechnungOrtLabel.Name = "adressRechnungOrtLabel";
            adressRechnungOrtLabel.Size = new System.Drawing.Size(167, 20);
            adressRechnungOrtLabel.TabIndex = 21;
            adressRechnungOrtLabel.Text = "Adress Rechnung Ort:";
            // 
            // adressRechnungLandLabel
            // 
            adressRechnungLandLabel.AutoSize = true;
            adressRechnungLandLabel.Location = new System.Drawing.Point(620, 433);
            adressRechnungLandLabel.Name = "adressRechnungLandLabel";
            adressRechnungLandLabel.Size = new System.Drawing.Size(181, 20);
            adressRechnungLandLabel.TabIndex = 23;
            adressRechnungLandLabel.Text = "Adress Rechnung Land:";
            // 
            // projektnummerLabel
            // 
            projektnummerLabel.AutoSize = true;
            projektnummerLabel.Location = new System.Drawing.Point(80, 607);
            projektnummerLabel.Name = "projektnummerLabel";
            projektnummerLabel.Size = new System.Drawing.Size(120, 20);
            projektnummerLabel.TabIndex = 27;
            projektnummerLabel.Text = "Projektnummer:";
            // 
            // projektnameLabel
            // 
            projektnameLabel.AutoSize = true;
            projektnameLabel.Location = new System.Drawing.Point(404, 607);
            projektnameLabel.Name = "projektnameLabel";
            projektnameLabel.Size = new System.Drawing.Size(102, 20);
            projektnameLabel.TabIndex = 29;
            projektnameLabel.Text = "Projektname:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3_speichern);
            this.panel1.Controls.Add(projektnameLabel);
            this.panel1.Controls.Add(this.projektnameTextBox);
            this.panel1.Controls.Add(projektnummerLabel);
            this.panel1.Controls.Add(this.projektnummerTextBox);
            this.panel1.Controls.Add(this.button2_ProjektWaehlen);
            this.panel1.Controls.Add(this.button_adresse);
            this.panel1.Controls.Add(adressRechnungLandLabel);
            this.panel1.Controls.Add(this.adressRechnungLandTextBox);
            this.panel1.Controls.Add(adressRechnungOrtLabel);
            this.panel1.Controls.Add(this.adressRechnungOrtTextBox);
            this.panel1.Controls.Add(adressRechnungPLZLabel);
            this.panel1.Controls.Add(this.adressRechnungPLZTextBox);
            this.panel1.Controls.Add(adressRechnungStrasseLabel);
            this.panel1.Controls.Add(this.adressRechnungStrasseTextBox);
            this.panel1.Controls.Add(adressLieferLandLabel);
            this.panel1.Controls.Add(this.adressLieferLandTextBox);
            this.panel1.Controls.Add(adressLieferOrtLabel);
            this.panel1.Controls.Add(this.adressLieferOrtTextBox);
            this.panel1.Controls.Add(adressLieferPLZLabel);
            this.panel1.Controls.Add(this.adressLieferPLZTextBox);
            this.panel1.Controls.Add(adressLieferStrasseLabel);
            this.panel1.Controls.Add(this.adressLieferStrasseTextBox);
            this.panel1.Controls.Add(adressRechnungNameLabel);
            this.panel1.Controls.Add(this.adressRechnungNameTextBox);
            this.panel1.Controls.Add(adressLieferNameLabel);
            this.panel1.Controls.Add(this.adressLieferNameTextBox);
            this.panel1.Controls.Add(bezeichnungLabel);
            this.panel1.Controls.Add(this.bezeichnungTextBox);
            this.panel1.Controls.Add(auftragNummerLabel);
            this.panel1.Controls.Add(this.auftragNummerTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 773);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3_speichern
            // 
            this.button3_speichern.BackColor = System.Drawing.Color.OliveDrab;
            this.button3_speichern.ForeColor = System.Drawing.SystemColors.Info;
            this.button3_speichern.Location = new System.Drawing.Point(44, 710);
            this.button3_speichern.Name = "button3_speichern";
            this.button3_speichern.Size = new System.Drawing.Size(306, 32);
            this.button3_speichern.TabIndex = 31;
            this.button3_speichern.Text = "Speichern";
            this.button3_speichern.UseVisualStyleBackColor = false;
            this.button3_speichern.Click += new System.EventHandler(this.button3_speichern_Click);
            // 
            // projektnameTextBox
            // 
            this.projektnameTextBox.Location = new System.Drawing.Point(512, 604);
            this.projektnameTextBox.Name = "projektnameTextBox";
            this.projektnameTextBox.Size = new System.Drawing.Size(643, 26);
            this.projektnameTextBox.TabIndex = 30;
            // 
            // projektnummerTextBox
            // 
            this.projektnummerTextBox.Location = new System.Drawing.Point(206, 604);
            this.projektnummerTextBox.Name = "projektnummerTextBox";
            this.projektnummerTextBox.Size = new System.Drawing.Size(144, 26);
            this.projektnummerTextBox.TabIndex = 28;
            // 
            // button2_ProjektWaehlen
            // 
            this.button2_ProjektWaehlen.BackColor = System.Drawing.Color.OliveDrab;
            this.button2_ProjektWaehlen.ForeColor = System.Drawing.SystemColors.Info;
            this.button2_ProjektWaehlen.Location = new System.Drawing.Point(44, 543);
            this.button2_ProjektWaehlen.Name = "button2_ProjektWaehlen";
            this.button2_ProjektWaehlen.Size = new System.Drawing.Size(185, 32);
            this.button2_ProjektWaehlen.TabIndex = 26;
            this.button2_ProjektWaehlen.Text = "Projekt wählen";
            this.button2_ProjektWaehlen.UseVisualStyleBackColor = false;
            this.button2_ProjektWaehlen.Click += new System.EventHandler(this.button2_ProjektWaehlen_Click);
            // 
            // button_adresse
            // 
            this.button_adresse.BackColor = System.Drawing.Color.OliveDrab;
            this.button_adresse.ForeColor = System.Drawing.SystemColors.Info;
            this.button_adresse.Location = new System.Drawing.Point(44, 203);
            this.button_adresse.Name = "button_adresse";
            this.button_adresse.Size = new System.Drawing.Size(185, 32);
            this.button_adresse.TabIndex = 25;
            this.button_adresse.Text = "Adresse wählen";
            this.button_adresse.UseVisualStyleBackColor = false;
            this.button_adresse.Click += new System.EventHandler(this.button_adresse_Click);
            // 
            // adressRechnungLandTextBox
            // 
            this.adressRechnungLandTextBox.Location = new System.Drawing.Point(807, 430);
            this.adressRechnungLandTextBox.Name = "adressRechnungLandTextBox";
            this.adressRechnungLandTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressRechnungLandTextBox.TabIndex = 24;
            // 
            // adressRechnungOrtTextBox
            // 
            this.adressRechnungOrtTextBox.Location = new System.Drawing.Point(807, 383);
            this.adressRechnungOrtTextBox.Name = "adressRechnungOrtTextBox";
            this.adressRechnungOrtTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressRechnungOrtTextBox.TabIndex = 22;
            // 
            // adressRechnungPLZTextBox
            // 
            this.adressRechnungPLZTextBox.Location = new System.Drawing.Point(807, 337);
            this.adressRechnungPLZTextBox.Name = "adressRechnungPLZTextBox";
            this.adressRechnungPLZTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressRechnungPLZTextBox.TabIndex = 20;
            // 
            // adressRechnungStrasseTextBox
            // 
            this.adressRechnungStrasseTextBox.Location = new System.Drawing.Point(807, 295);
            this.adressRechnungStrasseTextBox.Name = "adressRechnungStrasseTextBox";
            this.adressRechnungStrasseTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressRechnungStrasseTextBox.TabIndex = 18;
            // 
            // adressLieferLandTextBox
            // 
            this.adressLieferLandTextBox.Location = new System.Drawing.Point(206, 430);
            this.adressLieferLandTextBox.Name = "adressLieferLandTextBox";
            this.adressLieferLandTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressLieferLandTextBox.TabIndex = 16;
            // 
            // adressLieferOrtTextBox
            // 
            this.adressLieferOrtTextBox.Location = new System.Drawing.Point(206, 383);
            this.adressLieferOrtTextBox.Name = "adressLieferOrtTextBox";
            this.adressLieferOrtTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressLieferOrtTextBox.TabIndex = 14;
            // 
            // adressLieferPLZTextBox
            // 
            this.adressLieferPLZTextBox.Location = new System.Drawing.Point(206, 337);
            this.adressLieferPLZTextBox.Name = "adressLieferPLZTextBox";
            this.adressLieferPLZTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressLieferPLZTextBox.TabIndex = 12;
            // 
            // adressLieferStrasseTextBox
            // 
            this.adressLieferStrasseTextBox.Location = new System.Drawing.Point(206, 295);
            this.adressLieferStrasseTextBox.Name = "adressLieferStrasseTextBox";
            this.adressLieferStrasseTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressLieferStrasseTextBox.TabIndex = 10;
            // 
            // adressRechnungNameTextBox
            // 
            this.adressRechnungNameTextBox.Location = new System.Drawing.Point(807, 255);
            this.adressRechnungNameTextBox.Name = "adressRechnungNameTextBox";
            this.adressRechnungNameTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressRechnungNameTextBox.TabIndex = 8;
            // 
            // adressLieferNameTextBox
            // 
            this.adressLieferNameTextBox.Location = new System.Drawing.Point(206, 255);
            this.adressLieferNameTextBox.Name = "adressLieferNameTextBox";
            this.adressLieferNameTextBox.Size = new System.Drawing.Size(348, 26);
            this.adressLieferNameTextBox.TabIndex = 6;
            // 
            // bezeichnungTextBox
            // 
            this.bezeichnungTextBox.Location = new System.Drawing.Point(206, 144);
            this.bezeichnungTextBox.Name = "bezeichnungTextBox";
            this.bezeichnungTextBox.Size = new System.Drawing.Size(949, 26);
            this.bezeichnungTextBox.TabIndex = 1;
            // 
            // auftragNummerTextBox
            // 
            this.auftragNummerTextBox.Enabled = false;
            this.auftragNummerTextBox.Location = new System.Drawing.Point(206, 109);
            this.auftragNummerTextBox.Name = "auftragNummerTextBox";
            this.auftragNummerTextBox.Size = new System.Drawing.Size(144, 26);
            this.auftragNummerTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 67);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neue Auslieferungen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lieferungTableAdapter
            // 
            this.lieferungTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LieferungTableAdapter = this.lieferungTableAdapter;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lieferungBindingNavigator
            // 
            this.lieferungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lieferungBindingNavigator.BindingSource = this.lieferungBindingSource;
            this.lieferungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lieferungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lieferungBindingNavigator.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lieferungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lieferungBindingNavigatorSaveItem});
            this.lieferungBindingNavigator.Location = new System.Drawing.Point(5, 5);
            this.lieferungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lieferungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lieferungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lieferungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lieferungBindingNavigator.Name = "lieferungBindingNavigator";
            this.lieferungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lieferungBindingNavigator.Size = new System.Drawing.Size(1170, 25);
            this.lieferungBindingNavigator.TabIndex = 1;
            this.lieferungBindingNavigator.Text = "bindingNavigator1";
            this.lieferungBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // lieferungBindingNavigatorSaveItem
            // 
            this.lieferungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lieferungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lieferungBindingNavigatorSaveItem.Image")));
            this.lieferungBindingNavigatorSaveItem.Name = "lieferungBindingNavigatorSaveItem";
            this.lieferungBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lieferungBindingNavigatorSaveItem.Text = "Daten speichern";
            this.lieferungBindingNavigatorSaveItem.Click += new System.EventHandler(this.lieferungBindingNavigatorSaveItem_Click);
            // 
            // projekteTableAdapter
            // 
            this.projekteTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ausliefer02_neu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1180, 783);
            this.Controls.Add(this.lieferungBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ausliefer02_neu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Neue Ausleiferung";
            this.Load += new System.EventHandler(this.Ausliefer02_neu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projekteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lieferungBindingNavigator)).EndInit();
            this.lieferungBindingNavigator.ResumeLayout(false);
            this.lieferungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lieferungBindingSource;
        private DAL.DataSet1TableAdapters.LieferungTableAdapter lieferungTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lieferungBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lieferungBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adressRechnungLandTextBox;
        private System.Windows.Forms.TextBox adressRechnungOrtTextBox;
        private System.Windows.Forms.TextBox adressRechnungPLZTextBox;
        private System.Windows.Forms.TextBox adressRechnungStrasseTextBox;
        private System.Windows.Forms.TextBox adressLieferLandTextBox;
        private System.Windows.Forms.TextBox adressLieferOrtTextBox;
        private System.Windows.Forms.TextBox adressLieferPLZTextBox;
        private System.Windows.Forms.TextBox adressLieferStrasseTextBox;
        private System.Windows.Forms.TextBox adressRechnungNameTextBox;
        private System.Windows.Forms.TextBox adressLieferNameTextBox;
        private System.Windows.Forms.TextBox bezeichnungTextBox;
        private System.Windows.Forms.TextBox auftragNummerTextBox;
        private System.Windows.Forms.Button button_adresse;
        private System.Windows.Forms.Button button2_ProjektWaehlen;
        private System.Windows.Forms.BindingSource projekteBindingSource;
        private DAL.DataSet1TableAdapters.ProjekteTableAdapter projekteTableAdapter;
        private System.Windows.Forms.Button button3_speichern;
        private System.Windows.Forms.TextBox projektnameTextBox;
        private System.Windows.Forms.TextBox projektnummerTextBox;
        private DAL.DataSet1 dataSet1;
    }
}