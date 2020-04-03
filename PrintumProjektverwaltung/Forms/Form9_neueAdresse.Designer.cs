namespace PrintumProjektverwaltung.Forms
{
    partial class Form9_neueAdresse
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
            System.Windows.Forms.Label adressIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label pLZLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label landLabel;
            System.Windows.Forms.Label zuHaendenVonLabel;
            System.Windows.Forms.Label firmennameLabel;
            System.Windows.Forms.Label email1AdresseLabel;
            System.Windows.Forms.Label telefon1Label;
            System.Windows.Forms.Label pLZundORTLabel;
            System.Windows.Forms.Label matchcodeLabel;
            System.Windows.Forms.Label email2AdresseLabel;
            System.Windows.Forms.Label jobTitleLabel;
            System.Windows.Forms.Label fileAsLabel;
            System.Windows.Forms.Label businessHomePageLabel;
            System.Windows.Forms.Label categoriesLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9_neueAdresse));
            this.label_ganzOben = new System.Windows.Forms.Label();
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.adressenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressenTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.AdressenTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.pLZTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.landTextBox = new System.Windows.Forms.TextBox();
            this.zuHaendenVonTextBox = new System.Windows.Forms.TextBox();
            this.firmennameTextBox = new System.Windows.Forms.TextBox();
            this.email1AdresseTextBox = new System.Windows.Forms.TextBox();
            this.telefon1TextBox = new System.Windows.Forms.TextBox();
            this.pLZundORTTextBox = new System.Windows.Forms.TextBox();
            this.matchcodeTextBox = new System.Windows.Forms.TextBox();
            this.email2AdresseTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.fileAsTextBox = new System.Windows.Forms.TextBox();
            this.businessHomePageTextBox = new System.Windows.Forms.TextBox();
            this.categoriesTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.button2_speichern = new System.Windows.Forms.Button();
            adressIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            pLZLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            landLabel = new System.Windows.Forms.Label();
            zuHaendenVonLabel = new System.Windows.Forms.Label();
            firmennameLabel = new System.Windows.Forms.Label();
            email1AdresseLabel = new System.Windows.Forms.Label();
            telefon1Label = new System.Windows.Forms.Label();
            pLZundORTLabel = new System.Windows.Forms.Label();
            matchcodeLabel = new System.Windows.Forms.Label();
            email2AdresseLabel = new System.Windows.Forms.Label();
            jobTitleLabel = new System.Windows.Forms.Label();
            fileAsLabel = new System.Windows.Forms.Label();
            businessHomePageLabel = new System.Windows.Forms.Label();
            categoriesLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adressIDLabel
            // 
            adressIDLabel.AutoSize = true;
            adressIDLabel.Location = new System.Drawing.Point(12, 95);
            adressIDLabel.Name = "adressIDLabel";
            adressIDLabel.Size = new System.Drawing.Size(98, 25);
            adressIDLabel.TabIndex = 7;
            adressIDLabel.Text = "Vorname:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 131);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 25);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(12, 167);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(85, 25);
            strasseLabel.TabIndex = 11;
            strasseLabel.Text = "Strasse:";
            // 
            // pLZLabel
            // 
            pLZLabel.AutoSize = true;
            pLZLabel.Location = new System.Drawing.Point(12, 203);
            pLZLabel.Name = "pLZLabel";
            pLZLabel.Size = new System.Drawing.Size(54, 25);
            pLZLabel.TabIndex = 13;
            pLZLabel.Text = "PLZ:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(12, 239);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(45, 25);
            ortLabel.TabIndex = 15;
            ortLabel.Text = "Ort:";
            // 
            // landLabel
            // 
            landLabel.AutoSize = true;
            landLabel.Location = new System.Drawing.Point(12, 275);
            landLabel.Name = "landLabel";
            landLabel.Size = new System.Drawing.Size(62, 25);
            landLabel.TabIndex = 17;
            landLabel.Text = "Land:";
            // 
            // zuHaendenVonLabel
            // 
            zuHaendenVonLabel.AutoSize = true;
            zuHaendenVonLabel.Location = new System.Drawing.Point(12, 311);
            zuHaendenVonLabel.Name = "zuHaendenVonLabel";
            zuHaendenVonLabel.Size = new System.Drawing.Size(167, 25);
            zuHaendenVonLabel.TabIndex = 19;
            zuHaendenVonLabel.Text = "Zu Haenden Von:";
            // 
            // firmennameLabel
            // 
            firmennameLabel.AutoSize = true;
            firmennameLabel.Location = new System.Drawing.Point(12, 347);
            firmennameLabel.Name = "firmennameLabel";
            firmennameLabel.Size = new System.Drawing.Size(127, 25);
            firmennameLabel.TabIndex = 21;
            firmennameLabel.Text = "Firmenname:";
            // 
            // email1AdresseLabel
            // 
            email1AdresseLabel.AutoSize = true;
            email1AdresseLabel.Location = new System.Drawing.Point(12, 383);
            email1AdresseLabel.Name = "email1AdresseLabel";
            email1AdresseLabel.Size = new System.Drawing.Size(150, 25);
            email1AdresseLabel.TabIndex = 23;
            email1AdresseLabel.Text = "Email1Adresse:";
            // 
            // telefon1Label
            // 
            telefon1Label.AutoSize = true;
            telefon1Label.Location = new System.Drawing.Point(12, 419);
            telefon1Label.Name = "telefon1Label";
            telefon1Label.Size = new System.Drawing.Size(95, 25);
            telefon1Label.TabIndex = 25;
            telefon1Label.Text = "Telefon1:";
            // 
            // pLZundORTLabel
            // 
            pLZundORTLabel.AutoSize = true;
            pLZundORTLabel.Location = new System.Drawing.Point(12, 455);
            pLZundORTLabel.Name = "pLZundORTLabel";
            pLZundORTLabel.Size = new System.Drawing.Size(134, 25);
            pLZundORTLabel.TabIndex = 27;
            pLZundORTLabel.Text = "PLZund ORT:";
            // 
            // matchcodeLabel
            // 
            matchcodeLabel.AutoSize = true;
            matchcodeLabel.Location = new System.Drawing.Point(12, 491);
            matchcodeLabel.Name = "matchcodeLabel";
            matchcodeLabel.Size = new System.Drawing.Size(115, 25);
            matchcodeLabel.TabIndex = 29;
            matchcodeLabel.Text = "Matchcode:";
            // 
            // email2AdresseLabel
            // 
            email2AdresseLabel.AutoSize = true;
            email2AdresseLabel.Location = new System.Drawing.Point(12, 527);
            email2AdresseLabel.Name = "email2AdresseLabel";
            email2AdresseLabel.Size = new System.Drawing.Size(150, 25);
            email2AdresseLabel.TabIndex = 31;
            email2AdresseLabel.Text = "Email2Adresse:";
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new System.Drawing.Point(12, 563);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new System.Drawing.Size(93, 25);
            jobTitleLabel.TabIndex = 33;
            jobTitleLabel.Text = "Job Title:";
            // 
            // fileAsLabel
            // 
            fileAsLabel.AutoSize = true;
            fileAsLabel.Location = new System.Drawing.Point(12, 599);
            fileAsLabel.Name = "fileAsLabel";
            fileAsLabel.Size = new System.Drawing.Size(78, 25);
            fileAsLabel.TabIndex = 35;
            fileAsLabel.Text = "File As:";
            // 
            // businessHomePageLabel
            // 
            businessHomePageLabel.AutoSize = true;
            businessHomePageLabel.Location = new System.Drawing.Point(12, 635);
            businessHomePageLabel.Name = "businessHomePageLabel";
            businessHomePageLabel.Size = new System.Drawing.Size(204, 25);
            businessHomePageLabel.TabIndex = 37;
            businessHomePageLabel.Text = "business Home Page:";
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Location = new System.Drawing.Point(12, 671);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new System.Drawing.Size(113, 25);
            categoriesLabel.TabIndex = 39;
            categoriesLabel.Text = "Categories:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 707);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(37, 25);
            iDLabel.TabIndex = 41;
            iDLabel.Text = "ID:";
            // 
            // label_ganzOben
            // 
            this.label_ganzOben.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_ganzOben.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ganzOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_ganzOben.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ganzOben.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_ganzOben.Location = new System.Drawing.Point(0, 0);
            this.label_ganzOben.Margin = new System.Windows.Forms.Padding(0);
            this.label_ganzOben.Name = "label_ganzOben";
            this.label_ganzOben.Size = new System.Drawing.Size(937, 48);
            this.label_ganzOben.TabIndex = 6;
            this.label_ganzOben.Text = "Neue Adresse für info@printum.de";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adressenBindingSource
            // 
            this.adressenBindingSource.DataMember = "Adressen";
            this.adressenBindingSource.DataSource = this.dataSet1;
            // 
            // adressenTableAdapter
            // 
            this.adressenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressenTableAdapter = this.adressenTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BestellungenTableAdapter = null;
            this.tableAdapterManager.BestellungPositionenTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "AdressID", true));
            this.vornameTextBox.Location = new System.Drawing.Point(222, 92);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(678, 30);
            this.vornameTextBox.TabIndex = 8;
            this.vornameTextBox.TextChanged += new System.EventHandler(this.TextBox_nichtLeer);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(222, 128);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(678, 30);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextChanged += new System.EventHandler(this.TextBox_nichtLeer);
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Strasse", true));
            this.strasseTextBox.Location = new System.Drawing.Point(222, 164);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(678, 30);
            this.strasseTextBox.TabIndex = 12;
            // 
            // pLZTextBox
            // 
            this.pLZTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "PLZ", true));
            this.pLZTextBox.Location = new System.Drawing.Point(222, 200);
            this.pLZTextBox.Name = "pLZTextBox";
            this.pLZTextBox.Size = new System.Drawing.Size(678, 30);
            this.pLZTextBox.TabIndex = 14;
            // 
            // ortTextBox
            // 
            this.ortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Ort", true));
            this.ortTextBox.Location = new System.Drawing.Point(222, 236);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(678, 30);
            this.ortTextBox.TabIndex = 16;
            // 
            // landTextBox
            // 
            this.landTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Land", true));
            this.landTextBox.Location = new System.Drawing.Point(222, 272);
            this.landTextBox.Name = "landTextBox";
            this.landTextBox.Size = new System.Drawing.Size(678, 30);
            this.landTextBox.TabIndex = 18;
            // 
            // zuHaendenVonTextBox
            // 
            this.zuHaendenVonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "ZuHaendenVon", true));
            this.zuHaendenVonTextBox.Location = new System.Drawing.Point(222, 308);
            this.zuHaendenVonTextBox.Name = "zuHaendenVonTextBox";
            this.zuHaendenVonTextBox.Size = new System.Drawing.Size(678, 30);
            this.zuHaendenVonTextBox.TabIndex = 20;
            // 
            // firmennameTextBox
            // 
            this.firmennameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Firmenname", true));
            this.firmennameTextBox.Location = new System.Drawing.Point(222, 344);
            this.firmennameTextBox.Name = "firmennameTextBox";
            this.firmennameTextBox.Size = new System.Drawing.Size(678, 30);
            this.firmennameTextBox.TabIndex = 22;
            // 
            // email1AdresseTextBox
            // 
            this.email1AdresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Email1Adresse", true));
            this.email1AdresseTextBox.Location = new System.Drawing.Point(222, 380);
            this.email1AdresseTextBox.Name = "email1AdresseTextBox";
            this.email1AdresseTextBox.Size = new System.Drawing.Size(678, 30);
            this.email1AdresseTextBox.TabIndex = 24;
            // 
            // telefon1TextBox
            // 
            this.telefon1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Telefon1", true));
            this.telefon1TextBox.Location = new System.Drawing.Point(222, 416);
            this.telefon1TextBox.Name = "telefon1TextBox";
            this.telefon1TextBox.Size = new System.Drawing.Size(678, 30);
            this.telefon1TextBox.TabIndex = 26;
            this.telefon1TextBox.TextChanged += new System.EventHandler(this.telefon1TextBox_TextChanged);
            // 
            // pLZundORTTextBox
            // 
            this.pLZundORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "PLZundORT", true));
            this.pLZundORTTextBox.Location = new System.Drawing.Point(222, 452);
            this.pLZundORTTextBox.Name = "pLZundORTTextBox";
            this.pLZundORTTextBox.Size = new System.Drawing.Size(678, 30);
            this.pLZundORTTextBox.TabIndex = 28;
            // 
            // matchcodeTextBox
            // 
            this.matchcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Matchcode", true));
            this.matchcodeTextBox.Location = new System.Drawing.Point(222, 488);
            this.matchcodeTextBox.Name = "matchcodeTextBox";
            this.matchcodeTextBox.Size = new System.Drawing.Size(678, 30);
            this.matchcodeTextBox.TabIndex = 30;
            // 
            // email2AdresseTextBox
            // 
            this.email2AdresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Email2Adresse", true));
            this.email2AdresseTextBox.Location = new System.Drawing.Point(222, 524);
            this.email2AdresseTextBox.Name = "email2AdresseTextBox";
            this.email2AdresseTextBox.Size = new System.Drawing.Size(678, 30);
            this.email2AdresseTextBox.TabIndex = 32;
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "JobTitle", true));
            this.jobTitleTextBox.Location = new System.Drawing.Point(222, 560);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(678, 30);
            this.jobTitleTextBox.TabIndex = 34;
            // 
            // fileAsTextBox
            // 
            this.fileAsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "FileAs", true));
            this.fileAsTextBox.Location = new System.Drawing.Point(222, 596);
            this.fileAsTextBox.Name = "fileAsTextBox";
            this.fileAsTextBox.Size = new System.Drawing.Size(678, 30);
            this.fileAsTextBox.TabIndex = 36;
            // 
            // businessHomePageTextBox
            // 
            this.businessHomePageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "businessHomePage", true));
            this.businessHomePageTextBox.Location = new System.Drawing.Point(222, 632);
            this.businessHomePageTextBox.Name = "businessHomePageTextBox";
            this.businessHomePageTextBox.Size = new System.Drawing.Size(678, 30);
            this.businessHomePageTextBox.TabIndex = 38;
            // 
            // categoriesTextBox
            // 
            this.categoriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "Categories", true));
            this.categoriesTextBox.Location = new System.Drawing.Point(222, 668);
            this.categoriesTextBox.Name = "categoriesTextBox";
            this.categoriesTextBox.Size = new System.Drawing.Size(678, 30);
            this.categoriesTextBox.TabIndex = 40;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adressenBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(222, 704);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(678, 30);
            this.iDTextBox.TabIndex = 42;
            // 
            // button2_speichern
            // 
            this.button2_speichern.BackColor = System.Drawing.Color.IndianRed;
            this.button2_speichern.FlatAppearance.BorderSize = 0;
            this.button2_speichern.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2_speichern.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2_speichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_speichern.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2_speichern.Location = new System.Drawing.Point(749, 759);
            this.button2_speichern.Name = "button2_speichern";
            this.button2_speichern.Size = new System.Drawing.Size(151, 32);
            this.button2_speichern.TabIndex = 43;
            this.button2_speichern.Text = "speichern";
            this.button2_speichern.UseVisualStyleBackColor = false;
            this.button2_speichern.Click += new System.EventHandler(this.button2_speichern_Click);
            // 
            // Form9_neueAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 817);
            this.Controls.Add(this.button2_speichern);
            this.Controls.Add(adressIDLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(strasseLabel);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(pLZLabel);
            this.Controls.Add(this.pLZTextBox);
            this.Controls.Add(ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(landLabel);
            this.Controls.Add(this.landTextBox);
            this.Controls.Add(zuHaendenVonLabel);
            this.Controls.Add(this.zuHaendenVonTextBox);
            this.Controls.Add(firmennameLabel);
            this.Controls.Add(this.firmennameTextBox);
            this.Controls.Add(email1AdresseLabel);
            this.Controls.Add(this.email1AdresseTextBox);
            this.Controls.Add(telefon1Label);
            this.Controls.Add(this.telefon1TextBox);
            this.Controls.Add(pLZundORTLabel);
            this.Controls.Add(this.pLZundORTTextBox);
            this.Controls.Add(matchcodeLabel);
            this.Controls.Add(this.matchcodeTextBox);
            this.Controls.Add(email2AdresseLabel);
            this.Controls.Add(this.email2AdresseTextBox);
            this.Controls.Add(jobTitleLabel);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(fileAsLabel);
            this.Controls.Add(this.fileAsTextBox);
            this.Controls.Add(businessHomePageLabel);
            this.Controls.Add(this.businessHomePageTextBox);
            this.Controls.Add(categoriesLabel);
            this.Controls.Add(this.categoriesTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.label_ganzOben);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form9_neueAdresse";
            this.Text = "neuer Adresse für     info@printum.de";
            this.Load += new System.EventHandler(this.Form9_neueAdresse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label_ganzOben;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource adressenBindingSource;
        private DAL.DataSet1TableAdapters.AdressenTableAdapter adressenTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox pLZTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.TextBox landTextBox;
        private System.Windows.Forms.TextBox zuHaendenVonTextBox;
        private System.Windows.Forms.TextBox firmennameTextBox;
        private System.Windows.Forms.TextBox email1AdresseTextBox;
        private System.Windows.Forms.TextBox telefon1TextBox;
        private System.Windows.Forms.TextBox pLZundORTTextBox;
        private System.Windows.Forms.TextBox matchcodeTextBox;
        private System.Windows.Forms.TextBox email2AdresseTextBox;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.TextBox fileAsTextBox;
        private System.Windows.Forms.TextBox businessHomePageTextBox;
        private System.Windows.Forms.TextBox categoriesTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button button2_speichern;
    }
}