namespace PrintumProjektverwaltung.Forms
{
    partial class Ausliefer06_PositionenNeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausliefer06_PositionenNeu));
            this.button1_speichern = new System.Windows.Forms.Button();
            this.labelPos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2_artikel = new System.Windows.Forms.Button();
            this.dataSet11 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.artikelTableAdapter1 = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.ArtikelTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.artikelDataGridView = new System.Windows.Forms.DataGridView();
            this.artikelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschreibungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschreibungEnglishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einheitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istBaugruppeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.artikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3_anzahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_speichern
            // 
            this.button1_speichern.BackColor = System.Drawing.Color.OliveDrab;
            this.button1_speichern.ForeColor = System.Drawing.SystemColors.Info;
            this.button1_speichern.Location = new System.Drawing.Point(1020, 34);
            this.button1_speichern.Name = "button1_speichern";
            this.button1_speichern.Size = new System.Drawing.Size(252, 43);
            this.button1_speichern.TabIndex = 7;
            this.button1_speichern.Text = "speichern";
            this.button1_speichern.UseVisualStyleBackColor = false;
            this.button1_speichern.Click += new System.EventHandler(this.button1_speichern_Click);
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(17, 8);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(36, 20);
            this.labelPos.TabIndex = 8;
            this.labelPos.Text = "Pos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pos";
            // 
            // button2_artikel
            // 
            this.button2_artikel.Location = new System.Drawing.Point(124, 39);
            this.button2_artikel.Name = "button2_artikel";
            this.button2_artikel.Size = new System.Drawing.Size(128, 33);
            this.button2_artikel.TabIndex = 11;
            this.button2_artikel.Text = "Artikel wählen";
            this.button2_artikel.UseVisualStyleBackColor = true;
            this.button2_artikel.Click += new System.EventHandler(this.button2_artikel_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikelTableAdapter1
            // 
            this.artikelTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3_anzahl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1_speichern);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2_artikel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelPos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 88);
            this.panel1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 26);
            this.textBox2.TabIndex = 12;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 353);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.artikelDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(114, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 353);
            this.panel3.TabIndex = 14;
            // 
            // artikelDataGridView
            // 
            this.artikelDataGridView.AutoGenerateColumns = false;
            this.artikelDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.artikelDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.artikelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelIDDataGridViewTextBoxColumn,
            this.artikelnummerDataGridViewTextBoxColumn,
            this.beschreibungDataGridViewTextBoxColumn,
            this.beschreibungEnglishDataGridViewTextBoxColumn,
            this.preisDataGridViewTextBoxColumn,
            this.einheitDataGridViewTextBoxColumn,
            this.istBaugruppeDataGridViewCheckBoxColumn});
            this.artikelDataGridView.DataSource = this.artikelBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.artikelDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.artikelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artikelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.artikelDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.artikelDataGridView.MultiSelect = false;
            this.artikelDataGridView.Name = "artikelDataGridView";
            this.artikelDataGridView.ReadOnly = true;
            this.artikelDataGridView.RowHeadersVisible = false;
            this.artikelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikelDataGridView.Size = new System.Drawing.Size(1225, 353);
            this.artikelDataGridView.TabIndex = 2;
            this.artikelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_CellContentClick);
            // 
            // artikelIDDataGridViewTextBoxColumn
            // 
            this.artikelIDDataGridViewTextBoxColumn.DataPropertyName = "ArtikelID";
            this.artikelIDDataGridViewTextBoxColumn.HeaderText = "ArtikelID";
            this.artikelIDDataGridViewTextBoxColumn.Name = "artikelIDDataGridViewTextBoxColumn";
            this.artikelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // artikelnummerDataGridViewTextBoxColumn
            // 
            this.artikelnummerDataGridViewTextBoxColumn.DataPropertyName = "Artikelnummer";
            this.artikelnummerDataGridViewTextBoxColumn.HeaderText = "Artikelnummer";
            this.artikelnummerDataGridViewTextBoxColumn.Name = "artikelnummerDataGridViewTextBoxColumn";
            this.artikelnummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikelnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            this.beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            this.beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            this.beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            this.beschreibungDataGridViewTextBoxColumn.ReadOnly = true;
            this.beschreibungDataGridViewTextBoxColumn.Width = 400;
            // 
            // beschreibungEnglishDataGridViewTextBoxColumn
            // 
            this.beschreibungEnglishDataGridViewTextBoxColumn.DataPropertyName = "BeschreibungEnglish";
            this.beschreibungEnglishDataGridViewTextBoxColumn.HeaderText = "BeschreibungEnglish";
            this.beschreibungEnglishDataGridViewTextBoxColumn.Name = "beschreibungEnglishDataGridViewTextBoxColumn";
            this.beschreibungEnglishDataGridViewTextBoxColumn.ReadOnly = true;
            this.beschreibungEnglishDataGridViewTextBoxColumn.Width = 400;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            this.preisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // einheitDataGridViewTextBoxColumn
            // 
            this.einheitDataGridViewTextBoxColumn.DataPropertyName = "Einheit";
            this.einheitDataGridViewTextBoxColumn.HeaderText = "Einheit";
            this.einheitDataGridViewTextBoxColumn.Name = "einheitDataGridViewTextBoxColumn";
            this.einheitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // istBaugruppeDataGridViewCheckBoxColumn
            // 
            this.istBaugruppeDataGridViewCheckBoxColumn.DataPropertyName = "IstBaugruppe";
            this.istBaugruppeDataGridViewCheckBoxColumn.HeaderText = "IstBaugruppe";
            this.istBaugruppeDataGridViewCheckBoxColumn.Name = "istBaugruppeDataGridViewCheckBoxColumn";
            this.istBaugruppeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.istBaugruppeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // artikelBindingSource
            // 
            this.artikelBindingSource.DataMember = "Artikel";
            this.artikelBindingSource.DataSource = this.dataSet11;
            // 
            // textBox3_anzahl
            // 
            this.textBox3_anzahl.Location = new System.Drawing.Point(800, 46);
            this.textBox3_anzahl.Name = "textBox3_anzahl";
            this.textBox3_anzahl.Size = new System.Drawing.Size(47, 26);
            this.textBox3_anzahl.TabIndex = 14;
            this.textBox3_anzahl.Text = "1";
            this.textBox3_anzahl.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Anzahl";
            // 
            // Ausliefer06_PositionenNeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1339, 441);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ausliefer06_PositionenNeu";
            this.Text = "Neue Position";
            this.Load += new System.EventHandler(this.Ausliefer06_PositionenNeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artikelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_speichern;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2_artikel;
        private DAL.DataSet1 dataSet11;
        private DAL.DataSet1TableAdapters.ArtikelTableAdapter artikelTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView artikelDataGridView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource artikelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschreibungEnglishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einheitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn istBaugruppeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox3_anzahl;
        private System.Windows.Forms.Label label2;
    }
}