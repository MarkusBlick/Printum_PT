namespace PrintumProjektverwaltung.Forms
{
    partial class Ausliefer03_AdressenSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausliefer03_AdressenSelect));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_adresse = new System.Windows.Forms.Button();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.adressenDataGridView = new System.Windows.Forms.DataGridView();
            this.firmennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zuHaendenVonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email2Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email1AdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLZundORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email2AdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileAsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 67);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresse auswählen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_adresse);
            this.panel1.Controls.Add(this.textBox1_suchen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1284, 54);
            this.panel1.TabIndex = 2;
            // 
            // button_adresse
            // 
            this.button_adresse.BackColor = System.Drawing.Color.OliveDrab;
            this.button_adresse.ForeColor = System.Drawing.SystemColors.Info;
            this.button_adresse.Location = new System.Drawing.Point(403, 7);
            this.button_adresse.Name = "button_adresse";
            this.button_adresse.Size = new System.Drawing.Size(383, 32);
            this.button_adresse.TabIndex = 26;
            this.button_adresse.Text = "Adresse wählen (oder Doppel-Klick auf die Zeile)";
            this.button_adresse.UseVisualStyleBackColor = false;
            this.button_adresse.Click += new System.EventHandler(this.button_adresse_Click);
            // 
            // textBox1_suchen
            // 
            this.textBox1_suchen.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1_suchen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_suchen.Location = new System.Drawing.Point(10, 10);
            this.textBox1_suchen.Name = "textBox1_suchen";
            this.textBox1_suchen.Size = new System.Drawing.Size(248, 26);
            this.textBox1_suchen.TabIndex = 0;
            this.textBox1_suchen.TextChanged += new System.EventHandler(this.textBox1_suchen_TextChanged);
            // 
            // adressenDataGridView
            // 
            this.adressenDataGridView.AllowUserToAddRows = false;
            this.adressenDataGridView.AllowUserToDeleteRows = false;
            this.adressenDataGridView.AutoGenerateColumns = false;
            this.adressenDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.adressenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adressenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmennameDataGridViewTextBoxColumn,
            this.strasseDataGridViewTextBoxColumn,
            this.pLZDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.landDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.JobTitle,
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.zuHaendenVonDataGridViewTextBoxColumn,
            this.categoriesDataGridViewTextBoxColumn,
            this.Email1Adresse,
            this.Email2Adresse,
            this.FileAs,
            this.adressIDDataGridViewTextBoxColumn,
            this.email1AdresseDataGridViewTextBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.pLZundORTDataGridViewTextBoxColumn,
            this.matchcodeDataGridViewTextBoxColumn,
            this.email2AdresseDataGridViewTextBoxColumn,
            this.fileAsDataGridViewTextBoxColumn,
            this.businessHomePageDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.telefonMobileDataGridViewTextBoxColumn});
            this.adressenDataGridView.DataSource = this.adressenBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adressenDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.adressenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adressenDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.adressenDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.adressenDataGridView.Location = new System.Drawing.Point(0, 121);
            this.adressenDataGridView.MultiSelect = false;
            this.adressenDataGridView.Name = "adressenDataGridView";
            this.adressenDataGridView.ReadOnly = true;
            this.adressenDataGridView.RowHeadersVisible = false;
            this.adressenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adressenDataGridView.ShowCellErrors = false;
            this.adressenDataGridView.Size = new System.Drawing.Size(1284, 640);
            this.adressenDataGridView.TabIndex = 4;
            this.adressenDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adressenDataGridView_CellContentClick);
            // 
            // firmennameDataGridViewTextBoxColumn
            // 
            this.firmennameDataGridViewTextBoxColumn.DataPropertyName = "Firmenname";
            this.firmennameDataGridViewTextBoxColumn.HeaderText = "Firmenname";
            this.firmennameDataGridViewTextBoxColumn.Name = "firmennameDataGridViewTextBoxColumn";
            this.firmennameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmennameDataGridViewTextBoxColumn.Width = 200;
            // 
            // strasseDataGridViewTextBoxColumn
            // 
            this.strasseDataGridViewTextBoxColumn.DataPropertyName = "Strasse";
            this.strasseDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.strasseDataGridViewTextBoxColumn.Name = "strasseDataGridViewTextBoxColumn";
            this.strasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLZDataGridViewTextBoxColumn
            // 
            this.pLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ";
            this.pLZDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.pLZDataGridViewTextBoxColumn.Name = "pLZDataGridViewTextBoxColumn";
            this.pLZDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            this.ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.DataPropertyName = "Land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Land";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            this.landDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // JobTitle
            // 
            this.JobTitle.DataPropertyName = "JobTitle";
            this.JobTitle.HeaderText = "JobTitle";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            this.JobTitle.Width = 200;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zuHaendenVonDataGridViewTextBoxColumn
            // 
            this.zuHaendenVonDataGridViewTextBoxColumn.DataPropertyName = "ZuHaendenVon";
            this.zuHaendenVonDataGridViewTextBoxColumn.HeaderText = "ZuHaendenVon";
            this.zuHaendenVonDataGridViewTextBoxColumn.Name = "zuHaendenVonDataGridViewTextBoxColumn";
            this.zuHaendenVonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriesDataGridViewTextBoxColumn
            // 
            this.categoriesDataGridViewTextBoxColumn.DataPropertyName = "Categories";
            this.categoriesDataGridViewTextBoxColumn.HeaderText = "Categories";
            this.categoriesDataGridViewTextBoxColumn.Name = "categoriesDataGridViewTextBoxColumn";
            this.categoriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Email1Adresse
            // 
            this.Email1Adresse.DataPropertyName = "Email1Adresse";
            this.Email1Adresse.HeaderText = "Email1Adresse";
            this.Email1Adresse.Name = "Email1Adresse";
            this.Email1Adresse.ReadOnly = true;
            this.Email1Adresse.Width = 300;
            // 
            // Email2Adresse
            // 
            this.Email2Adresse.DataPropertyName = "Email2Adresse";
            this.Email2Adresse.HeaderText = "Email2Adresse";
            this.Email2Adresse.Name = "Email2Adresse";
            this.Email2Adresse.ReadOnly = true;
            // 
            // FileAs
            // 
            this.FileAs.DataPropertyName = "FileAs";
            this.FileAs.HeaderText = "FileAs";
            this.FileAs.Name = "FileAs";
            this.FileAs.ReadOnly = true;
            this.FileAs.Width = 300;
            // 
            // adressIDDataGridViewTextBoxColumn
            // 
            this.adressIDDataGridViewTextBoxColumn.DataPropertyName = "AdressID";
            this.adressIDDataGridViewTextBoxColumn.HeaderText = "AdressID";
            this.adressIDDataGridViewTextBoxColumn.Name = "adressIDDataGridViewTextBoxColumn";
            this.adressIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // email1AdresseDataGridViewTextBoxColumn
            // 
            this.email1AdresseDataGridViewTextBoxColumn.DataPropertyName = "Email1Adresse";
            this.email1AdresseDataGridViewTextBoxColumn.HeaderText = "Email1Adresse";
            this.email1AdresseDataGridViewTextBoxColumn.Name = "email1AdresseDataGridViewTextBoxColumn";
            this.email1AdresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefon1DataGridViewTextBoxColumn
            // 
            this.telefon1DataGridViewTextBoxColumn.DataPropertyName = "Telefon1";
            this.telefon1DataGridViewTextBoxColumn.HeaderText = "Telefon1";
            this.telefon1DataGridViewTextBoxColumn.Name = "telefon1DataGridViewTextBoxColumn";
            this.telefon1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLZundORTDataGridViewTextBoxColumn
            // 
            this.pLZundORTDataGridViewTextBoxColumn.DataPropertyName = "PLZundORT";
            this.pLZundORTDataGridViewTextBoxColumn.HeaderText = "PLZundORT";
            this.pLZundORTDataGridViewTextBoxColumn.Name = "pLZundORTDataGridViewTextBoxColumn";
            this.pLZundORTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchcodeDataGridViewTextBoxColumn
            // 
            this.matchcodeDataGridViewTextBoxColumn.DataPropertyName = "Matchcode";
            this.matchcodeDataGridViewTextBoxColumn.HeaderText = "Matchcode";
            this.matchcodeDataGridViewTextBoxColumn.Name = "matchcodeDataGridViewTextBoxColumn";
            this.matchcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // email2AdresseDataGridViewTextBoxColumn
            // 
            this.email2AdresseDataGridViewTextBoxColumn.DataPropertyName = "Email2Adresse";
            this.email2AdresseDataGridViewTextBoxColumn.HeaderText = "Email2Adresse";
            this.email2AdresseDataGridViewTextBoxColumn.Name = "email2AdresseDataGridViewTextBoxColumn";
            this.email2AdresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileAsDataGridViewTextBoxColumn
            // 
            this.fileAsDataGridViewTextBoxColumn.DataPropertyName = "FileAs";
            this.fileAsDataGridViewTextBoxColumn.HeaderText = "FileAs";
            this.fileAsDataGridViewTextBoxColumn.Name = "fileAsDataGridViewTextBoxColumn";
            this.fileAsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessHomePageDataGridViewTextBoxColumn
            // 
            this.businessHomePageDataGridViewTextBoxColumn.DataPropertyName = "businessHomePage";
            this.businessHomePageDataGridViewTextBoxColumn.HeaderText = "businessHomePage";
            this.businessHomePageDataGridViewTextBoxColumn.Name = "businessHomePageDataGridViewTextBoxColumn";
            this.businessHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonMobileDataGridViewTextBoxColumn
            // 
            this.telefonMobileDataGridViewTextBoxColumn.DataPropertyName = "TelefonMobile";
            this.telefonMobileDataGridViewTextBoxColumn.HeaderText = "TelefonMobile";
            this.telefonMobileDataGridViewTextBoxColumn.Name = "telefonMobileDataGridViewTextBoxColumn";
            this.telefonMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressenBindingSource
            // 
            this.adressenBindingSource.DataMember = "Adressen";
            this.adressenBindingSource.DataSource = this.dataSet1;
            // 
            // Ausliefer03_AdressenSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.adressenDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ausliefer03_AdressenSelect";
            this.Text = "Addresse Auswählwn";
            this.Load += new System.EventHandler(this.Ausliefer03_AdressenSelect_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adressenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private System.Windows.Forms.DataGridView adressenDataGridView;
        private System.Windows.Forms.BindingSource adressenBindingSource;
        private System.Windows.Forms.Button button_adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zuHaendenVonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email2Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileAs;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email1AdresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLZundORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email2AdresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileAsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonMobileDataGridViewTextBoxColumn;
    }
}