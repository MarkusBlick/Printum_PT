namespace PrintumProjektverwaltung.Forms
{
    partial class Ausliefer04_ProjektSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausliefer04_ProjektSelect));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_adresse = new System.Windows.Forms.Button();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.projekteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekteTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.ProjekteTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.projekteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_adresse);
            this.panel1.Controls.Add(this.textBox1_suchen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(803, 54);
            this.panel1.TabIndex = 3;
            // 
            // button_adresse
            // 
            this.button_adresse.BackColor = System.Drawing.Color.OliveDrab;
            this.button_adresse.ForeColor = System.Drawing.SystemColors.Info;
            this.button_adresse.Location = new System.Drawing.Point(403, 7);
            this.button_adresse.Name = "button_adresse";
            this.button_adresse.Size = new System.Drawing.Size(191, 32);
            this.button_adresse.TabIndex = 26;
            this.button_adresse.Text = "Projekt wählen";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 67);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projekt auswählen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projekteBindingSource
            // 
            this.projekteBindingSource.DataMember = "Projekte";
            this.projekteBindingSource.DataSource = this.dataSet1;
            // 
            // projekteTableAdapter
            // 
            this.projekteTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProjekteTableAdapter = this.projekteTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projekteDataGridView
            // 
            this.projekteDataGridView.AllowUserToAddRows = false;
            this.projekteDataGridView.AllowUserToDeleteRows = false;
            this.projekteDataGridView.AutoGenerateColumns = false;
            this.projekteDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.projekteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projekteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.projekteDataGridView.DataSource = this.projekteBindingSource;
            this.projekteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projekteDataGridView.Location = new System.Drawing.Point(0, 121);
            this.projekteDataGridView.MultiSelect = false;
            this.projekteDataGridView.Name = "projekteDataGridView";
            this.projekteDataGridView.ReadOnly = true;
            this.projekteDataGridView.RowHeadersVisible = false;
            this.projekteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projekteDataGridView.Size = new System.Drawing.Size(803, 629);
            this.projekteDataGridView.TabIndex = 5;
            this.projekteDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projekteDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Projektnummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Projektnummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Projektname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Projektname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 600;
            // 
            // Ausliefer04_ProjektSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(803, 750);
            this.Controls.Add(this.projekteDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ausliefer04_ProjektSelect";
            this.Text = "Projekt auswählen";
            this.Load += new System.EventHandler(this.Ausliefer04_ProjektSelect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_adresse;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource projekteBindingSource;
        private DAL.DataSet1TableAdapters.ProjekteTableAdapter projekteTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projekteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}