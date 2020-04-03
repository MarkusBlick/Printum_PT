namespace PrintumProjektverwaltung.Forms
{
    partial class Ausliefer08_Artikel
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
            System.Windows.Forms.Label artikelIDLabel;
            System.Windows.Forms.Label artikelnummerLabel;
            System.Windows.Forms.Label beschreibungLabel;
            System.Windows.Forms.Label beschreibungEnglishLabel;
            System.Windows.Forms.Label preisLabel;
            System.Windows.Forms.Label einheitLabel;
            System.Windows.Forms.Label istBaugruppeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausliefer08_Artikel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.einheitDataGridView = new System.Windows.Forms.DataGridView();
            this.artikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_neu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.artikelIDTextBox = new System.Windows.Forms.TextBox();
            this.artikelnummerTextBox = new System.Windows.Forms.TextBox();
            this.beschreibungTextBox = new System.Windows.Forms.TextBox();
            this.beschreibungEnglishTextBox = new System.Windows.Forms.TextBox();
            this.preisTextBox = new System.Windows.Forms.TextBox();
            this.einheitTextBox = new System.Windows.Forms.TextBox();
            this.istBaugruppeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.artikelTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.ArtikelTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.artikelnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschreibungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschreibungEnglishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einheitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istBaugruppeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_neuAusAlt = new System.Windows.Forms.Button();
            artikelIDLabel = new System.Windows.Forms.Label();
            artikelnummerLabel = new System.Windows.Forms.Label();
            beschreibungLabel = new System.Windows.Forms.Label();
            beschreibungEnglishLabel = new System.Windows.Forms.Label();
            preisLabel = new System.Windows.Forms.Label();
            einheitLabel = new System.Windows.Forms.Label();
            istBaugruppeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.einheitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istBaugruppeCheckEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // artikelIDLabel
            // 
            artikelIDLabel.AutoSize = true;
            artikelIDLabel.Location = new System.Drawing.Point(1164, 14);
            artikelIDLabel.Name = "artikelIDLabel";
            artikelIDLabel.Size = new System.Drawing.Size(78, 20);
            artikelIDLabel.TabIndex = 0;
            artikelIDLabel.Text = "Artikel ID:";
            artikelIDLabel.Visible = false;
            // 
            // artikelnummerLabel
            // 
            artikelnummerLabel.AutoSize = true;
            artikelnummerLabel.Location = new System.Drawing.Point(27, 11);
            artikelnummerLabel.Name = "artikelnummerLabel";
            artikelnummerLabel.Size = new System.Drawing.Size(115, 20);
            artikelnummerLabel.TabIndex = 2;
            artikelnummerLabel.Text = "Artikelnummer:";
            // 
            // beschreibungLabel
            // 
            beschreibungLabel.AutoSize = true;
            beschreibungLabel.Location = new System.Drawing.Point(27, 35);
            beschreibungLabel.Name = "beschreibungLabel";
            beschreibungLabel.Size = new System.Drawing.Size(111, 20);
            beschreibungLabel.TabIndex = 4;
            beschreibungLabel.Text = "Beschreibung:";
            // 
            // beschreibungEnglishLabel
            // 
            beschreibungEnglishLabel.AutoSize = true;
            beschreibungEnglishLabel.Location = new System.Drawing.Point(746, 35);
            beschreibungEnglishLabel.Name = "beschreibungEnglishLabel";
            beschreibungEnglishLabel.Size = new System.Drawing.Size(167, 20);
            beschreibungEnglishLabel.TabIndex = 6;
            beschreibungEnglishLabel.Text = "Beschreibung English:";
            // 
            // preisLabel
            // 
            preisLabel.AutoSize = true;
            preisLabel.Location = new System.Drawing.Point(27, 450);
            preisLabel.Name = "preisLabel";
            preisLabel.Size = new System.Drawing.Size(48, 20);
            preisLabel.TabIndex = 8;
            preisLabel.Text = "Preis:";
            // 
            // einheitLabel
            // 
            einheitLabel.AutoSize = true;
            einheitLabel.Location = new System.Drawing.Point(27, 525);
            einheitLabel.Name = "einheitLabel";
            einheitLabel.Size = new System.Drawing.Size(62, 20);
            einheitLabel.TabIndex = 10;
            einheitLabel.Text = "Einheit:";
            // 
            // istBaugruppeLabel
            // 
            istBaugruppeLabel.AutoSize = true;
            istBaugruppeLabel.Location = new System.Drawing.Point(513, 525);
            istBaugruppeLabel.Name = "istBaugruppeLabel";
            istBaugruppeLabel.Size = new System.Drawing.Size(114, 20);
            istBaugruppeLabel.TabIndex = 12;
            istBaugruppeLabel.Text = "Ist Baugruppe:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.einheitDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 840);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // einheitDataGridView
            // 
            this.einheitDataGridView.AutoGenerateColumns = false;
            this.einheitDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.einheitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.einheitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelnummerDataGridViewTextBoxColumn,
            this.beschreibungDataGridViewTextBoxColumn,
            this.beschreibungEnglishDataGridViewTextBoxColumn,
            this.preisDataGridViewTextBoxColumn,
            this.einheitDataGridViewTextBoxColumn,
            this.istBaugruppeDataGridViewCheckBoxColumn});
            this.einheitDataGridView.DataSource = this.artikelBindingSource;
            this.einheitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.einheitDataGridView.Location = new System.Drawing.Point(5, 66);
            this.einheitDataGridView.Name = "einheitDataGridView";
            this.einheitDataGridView.RowHeadersVisible = false;
            this.einheitDataGridView.Size = new System.Drawing.Size(1474, 133);
            this.einheitDataGridView.TabIndex = 1;
            // 
            // artikelBindingSource
            // 
            this.artikelBindingSource.DataMember = "Artikel";
            this.artikelBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1_neu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(1474, 61);
            this.panel1.TabIndex = 0;
            // 
            // button1_neu
            // 
            this.button1_neu.BackColor = System.Drawing.Color.OliveDrab;
            this.button1_neu.ForeColor = System.Drawing.SystemColors.Info;
            this.button1_neu.Location = new System.Drawing.Point(946, 11);
            this.button1_neu.Name = "button1_neu";
            this.button1_neu.Size = new System.Drawing.Size(212, 32);
            this.button1_neu.TabIndex = 1;
            this.button1_neu.Text = "Neuer Artikel";
            this.button1_neu.UseVisualStyleBackColor = false;
            this.button1_neu.Click += new System.EventHandler(this.button1_neu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammdaten Artikel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(beschreibungLabel);
            this.panel3.Controls.Add(this.beschreibungTextBox);
            this.panel3.Controls.Add(beschreibungEnglishLabel);
            this.panel3.Controls.Add(this.beschreibungEnglishTextBox);
            this.panel3.Controls.Add(preisLabel);
            this.panel3.Controls.Add(this.preisTextBox);
            this.panel3.Controls.Add(einheitLabel);
            this.panel3.Controls.Add(this.einheitTextBox);
            this.panel3.Controls.Add(istBaugruppeLabel);
            this.panel3.Controls.Add(this.istBaugruppeCheckEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1474, 574);
            this.panel3.TabIndex = 1;
            // 
            // artikelIDTextBox
            // 
            this.artikelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikelBindingSource, "ArtikelID", true));
            this.artikelIDTextBox.Location = new System.Drawing.Point(1248, 11);
            this.artikelIDTextBox.Name = "artikelIDTextBox";
            this.artikelIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.artikelIDTextBox.TabIndex = 1;
            this.artikelIDTextBox.Visible = false;
            // 
            // artikelnummerTextBox
            // 
            this.artikelnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikelBindingSource, "Artikelnummer", true));
            this.artikelnummerTextBox.Location = new System.Drawing.Point(183, 8);
            this.artikelnummerTextBox.Name = "artikelnummerTextBox";
            this.artikelnummerTextBox.Size = new System.Drawing.Size(181, 26);
            this.artikelnummerTextBox.TabIndex = 3;
            // 
            // beschreibungTextBox
            // 
            this.beschreibungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikelBindingSource, "Beschreibung", true));
            this.beschreibungTextBox.Location = new System.Drawing.Point(31, 77);
            this.beschreibungTextBox.Multiline = true;
            this.beschreibungTextBox.Name = "beschreibungTextBox";
            this.beschreibungTextBox.Size = new System.Drawing.Size(692, 302);
            this.beschreibungTextBox.TabIndex = 5;
            // 
            // beschreibungEnglishTextBox
            // 
            this.beschreibungEnglishTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikelBindingSource, "BeschreibungEnglish", true));
            this.beschreibungEnglishTextBox.Location = new System.Drawing.Point(750, 77);
            this.beschreibungEnglishTextBox.Multiline = true;
            this.beschreibungEnglishTextBox.Name = "beschreibungEnglishTextBox";
            this.beschreibungEnglishTextBox.Size = new System.Drawing.Size(692, 302);
            this.beschreibungEnglishTextBox.TabIndex = 7;
            // 
            // preisTextBox
            // 
            this.preisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikelBindingSource, "Preis", true));
            this.preisTextBox.Location = new System.Drawing.Point(183, 450);
            this.preisTextBox.Name = "preisTextBox";
            this.preisTextBox.Size = new System.Drawing.Size(181, 26);
            this.preisTextBox.TabIndex = 9;
            // 
            // einheitTextBox
            // 
            this.einheitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikelBindingSource, "Einheit", true));
            this.einheitTextBox.Location = new System.Drawing.Point(183, 519);
            this.einheitTextBox.Name = "einheitTextBox";
            this.einheitTextBox.Size = new System.Drawing.Size(181, 26);
            this.einheitTextBox.TabIndex = 11;
            // 
            // istBaugruppeCheckEdit
            // 
            this.istBaugruppeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.artikelBindingSource, "IstBaugruppe", true));
            this.istBaugruppeCheckEdit.Location = new System.Drawing.Point(648, 526);
            this.istBaugruppeCheckEdit.Name = "istBaugruppeCheckEdit";
            this.istBaugruppeCheckEdit.Properties.Caption = "";
            this.istBaugruppeCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.istBaugruppeCheckEdit.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1_neuAusAlt);
            this.panel2.Controls.Add(artikelnummerLabel);
            this.panel2.Controls.Add(this.artikelnummerTextBox);
            this.panel2.Controls.Add(artikelIDLabel);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.artikelIDTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 46);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(648, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Änderung speichern";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // artikelTableAdapter
            // 
            this.artikelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressenTableAdapter = null;
            this.tableAdapterManager.ArtikelTableAdapter = this.artikelTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BestellungenTableAdapter = null;
            this.tableAdapterManager.BestellungPositionenTableAdapter = null;
            this.tableAdapterManager.EinheitTableAdapter = null;
            this.tableAdapterManager.LieferungLieferscheinTableAdapter = null;
            this.tableAdapterManager.LieferungPositionenTableAdapter = null;
            this.tableAdapterManager.LieferungRechnungenTableAdapter = null;
            this.tableAdapterManager.LieferungTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // artikelnummerDataGridViewTextBoxColumn
            // 
            this.artikelnummerDataGridViewTextBoxColumn.DataPropertyName = "Artikelnummer";
            this.artikelnummerDataGridViewTextBoxColumn.HeaderText = "Artikelnummer";
            this.artikelnummerDataGridViewTextBoxColumn.Name = "artikelnummerDataGridViewTextBoxColumn";
            this.artikelnummerDataGridViewTextBoxColumn.Width = 200;
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            this.beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            this.beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            this.beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            this.beschreibungDataGridViewTextBoxColumn.Width = 500;
            // 
            // beschreibungEnglishDataGridViewTextBoxColumn
            // 
            this.beschreibungEnglishDataGridViewTextBoxColumn.DataPropertyName = "BeschreibungEnglish";
            this.beschreibungEnglishDataGridViewTextBoxColumn.HeaderText = "BeschreibungEnglish";
            this.beschreibungEnglishDataGridViewTextBoxColumn.Name = "beschreibungEnglishDataGridViewTextBoxColumn";
            this.beschreibungEnglishDataGridViewTextBoxColumn.Width = 500;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            this.preisDataGridViewTextBoxColumn.Width = 200;
            // 
            // einheitDataGridViewTextBoxColumn
            // 
            this.einheitDataGridViewTextBoxColumn.DataPropertyName = "Einheit";
            this.einheitDataGridViewTextBoxColumn.HeaderText = "Einheit";
            this.einheitDataGridViewTextBoxColumn.Name = "einheitDataGridViewTextBoxColumn";
            // 
            // istBaugruppeDataGridViewCheckBoxColumn
            // 
            this.istBaugruppeDataGridViewCheckBoxColumn.DataPropertyName = "IstBaugruppe";
            this.istBaugruppeDataGridViewCheckBoxColumn.HeaderText = "IstBaugruppe";
            this.istBaugruppeDataGridViewCheckBoxColumn.Name = "istBaugruppeDataGridViewCheckBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1_neuAusAlt
            // 
            this.button1_neuAusAlt.BackColor = System.Drawing.Color.OliveDrab;
            this.button1_neuAusAlt.ForeColor = System.Drawing.SystemColors.Info;
            this.button1_neuAusAlt.Location = new System.Drawing.Point(946, 8);
            this.button1_neuAusAlt.Name = "button1_neuAusAlt";
            this.button1_neuAusAlt.Size = new System.Drawing.Size(212, 32);
            this.button1_neuAusAlt.TabIndex = 4;
            this.button1_neuAusAlt.Text = "Neuer Artikel aus Altem";
            this.button1_neuAusAlt.UseVisualStyleBackColor = false;
            this.button1_neuAusAlt.Click += new System.EventHandler(this.button1_neuAusAlt_Click);
            // 
            // Ausliefer08_Artikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1484, 840);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ausliefer08_Artikel";
            this.Text = "Stammdaten Artikel";
            this.Load += new System.EventHandler(this.Ausliefer08_Artikel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.einheitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istBaugruppeCheckEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView einheitDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_neu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource artikelBindingSource;
        private DAL.DataSet1TableAdapters.ArtikelTableAdapter artikelTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox artikelIDTextBox;
        private System.Windows.Forms.TextBox artikelnummerTextBox;
        private System.Windows.Forms.TextBox beschreibungTextBox;
        private System.Windows.Forms.TextBox beschreibungEnglishTextBox;
        private System.Windows.Forms.TextBox preisTextBox;
        private System.Windows.Forms.TextBox einheitTextBox;
        private DevExpress.XtraEditors.CheckEdit istBaugruppeCheckEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschreibungEnglishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einheitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn istBaugruppeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_neuAusAlt;
    }
}