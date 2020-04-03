namespace PrintumProjektverwaltung.Forms
{
    partial class Form10_Baugruppe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10_Baugruppe));
            this.panel1_header = new System.Windows.Forms.Panel();
            this.button1_PrintumProjekte = new System.Windows.Forms.Button();
            this.label_ganzOben = new System.Windows.Forms.Label();
            this.panelOb_balkenoben = new System.Windows.Forms.Panel();
            this.panelOb_balkenUnten = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1_suchen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSet1 = new PrintumProjektverwaltung.DAL.DataSet1();
            this.bestellungPositionen_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bestellungPositionen_ViewTableAdapter = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.BestellungPositionen_ViewTableAdapter();
            this.tableAdapterManager = new PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.bestellungPositionen_ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1_header.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionen_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionen_ViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_header
            // 
            this.panel1_header.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1_header.Controls.Add(this.button1_PrintumProjekte);
            this.panel1_header.Controls.Add(this.label_ganzOben);
            this.panel1_header.Controls.Add(this.panelOb_balkenoben);
            this.panel1_header.Controls.Add(this.panelOb_balkenUnten);
            this.panel1_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_header.Location = new System.Drawing.Point(0, 0);
            this.panel1_header.Name = "panel1_header";
            this.panel1_header.Padding = new System.Windows.Forms.Padding(5);
            this.panel1_header.Size = new System.Drawing.Size(1370, 54);
            this.panel1_header.TabIndex = 2;
            // 
            // button1_PrintumProjekte
            // 
            this.button1_PrintumProjekte.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1_PrintumProjekte.FlatAppearance.BorderSize = 0;
            this.button1_PrintumProjekte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1_PrintumProjekte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1_PrintumProjekte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_PrintumProjekte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_PrintumProjekte.Location = new System.Drawing.Point(1275, 9);
            this.button1_PrintumProjekte.Name = "button1_PrintumProjekte";
            this.button1_PrintumProjekte.Size = new System.Drawing.Size(166, 32);
            this.button1_PrintumProjekte.TabIndex = 6;
            this.button1_PrintumProjekte.Text = "Printum-Projekte";
            this.button1_PrintumProjekte.UseVisualStyleBackColor = false;
            this.button1_PrintumProjekte.Click += new System.EventHandler(this.button1_PrintumProjekte_Click);
            // 
            // label_ganzOben
            // 
            this.label_ganzOben.BackColor = System.Drawing.Color.LightGreen;
            this.label_ganzOben.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ganzOben.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_ganzOben.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ganzOben.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_ganzOben.Location = new System.Drawing.Point(5, 6);
            this.label_ganzOben.Margin = new System.Windows.Forms.Padding(0);
            this.label_ganzOben.Name = "label_ganzOben";
            this.label_ganzOben.Size = new System.Drawing.Size(1360, 42);
            this.label_ganzOben.TabIndex = 4;
            this.label_ganzOben.Text = "nach Baugruppe suchen";
            // 
            // panelOb_balkenoben
            // 
            this.panelOb_balkenoben.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelOb_balkenoben.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOb_balkenoben.Location = new System.Drawing.Point(5, 5);
            this.panelOb_balkenoben.Name = "panelOb_balkenoben";
            this.panelOb_balkenoben.Size = new System.Drawing.Size(1360, 1);
            this.panelOb_balkenoben.TabIndex = 3;
            // 
            // panelOb_balkenUnten
            // 
            this.panelOb_balkenUnten.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelOb_balkenUnten.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOb_balkenUnten.Location = new System.Drawing.Point(5, 48);
            this.panelOb_balkenUnten.Name = "panelOb_balkenUnten";
            this.panelOb_balkenUnten.Size = new System.Drawing.Size(1360, 1);
            this.panelOb_balkenUnten.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1_suchen);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1370, 49);
            this.panel3.TabIndex = 0;
            // 
            // textBox1_suchen
            // 
            this.textBox1_suchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_suchen.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1_suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_suchen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1_suchen.Location = new System.Drawing.Point(392, 5);
            this.textBox1_suchen.Name = "textBox1_suchen";
            this.textBox1_suchen.Size = new System.Drawing.Size(556, 29);
            this.textBox1_suchen.TabIndex = 0;
            this.textBox1_suchen.TextChanged += new System.EventHandler(this.textBox1_suchen_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 39);
            this.panel1.TabIndex = 11;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bestellungPositionen_ViewBindingSource
            // 
            this.bestellungPositionen_ViewBindingSource.DataMember = "BestellungPositionen_View";
            this.bestellungPositionen_ViewBindingSource.DataSource = this.dataSet1;
            // 
            // bestellungPositionen_ViewTableAdapter
            // 
            this.bestellungPositionen_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressenTableAdapter = null;
            this.tableAdapterManager.ArtikelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BestellungenTableAdapter = null;
            this.tableAdapterManager.BestellungPositionenTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EinheitTableAdapter = null;
            this.tableAdapterManager.LieferungLieferscheinTableAdapter = null;
            this.tableAdapterManager.LieferungPositionenTableAdapter = null;
            this.tableAdapterManager.LieferungRechnungenTableAdapter = null;
            this.tableAdapterManager.LieferungTableAdapter = null;
            this.tableAdapterManager.PriProLieferscheinRechnungTableAdapter = null;
            this.tableAdapterManager.PriProRechnungTableAdapter = null;
            this.tableAdapterManager.ProjekteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrintumProjektverwaltung.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bestellungPositionen_ViewDataGridView
            // 
            this.bestellungPositionen_ViewDataGridView.AutoGenerateColumns = false;
            this.bestellungPositionen_ViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bestellungPositionen_ViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bestellungPositionen_ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestellungPositionen_ViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.bestellungPositionen_ViewDataGridView.DataSource = this.bestellungPositionen_ViewBindingSource;
            this.bestellungPositionen_ViewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestellungPositionen_ViewDataGridView.Location = new System.Drawing.Point(0, 103);
            this.bestellungPositionen_ViewDataGridView.Name = "bestellungPositionen_ViewDataGridView";
            this.bestellungPositionen_ViewDataGridView.RowHeadersVisible = false;
            this.bestellungPositionen_ViewDataGridView.RowTemplate.Height = 24;
            this.bestellungPositionen_ViewDataGridView.Size = new System.Drawing.Size(1370, 647);
            this.bestellungPositionen_ViewDataGridView.TabIndex = 12;
            this.bestellungPositionen_ViewDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.bestellungPositionen_ViewDataGridView_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Projektnummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Projekt-Nr";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Projektname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Projektname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BestellnungIDTest";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bestell-Nr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Artikelbezeichnung";
            this.dataGridViewTextBoxColumn5.HeaderText = "Artikelbezeichnung";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 580;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Besteller";
            this.dataGridViewTextBoxColumn7.HeaderText = "Besteller";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Bestelldatum";
            this.dataGridViewTextBoxColumn8.HeaderText = "Bestelldatum";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 140;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Liefertermin";
            this.dataGridViewTextBoxColumn9.HeaderText = "Liefertermin";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 140;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "WE_datum";
            this.dataGridViewTextBoxColumn12.HeaderText = "WE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 140;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AB_datum";
            this.dataGridViewTextBoxColumn10.HeaderText = "AB";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Stueck";
            this.dataGridViewTextBoxColumn6.HeaderText = "Stueck";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Einzelpreis";
            this.dataGridViewTextBoxColumn14.HeaderText = "Einzelpreis";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Gesammtpreis";
            this.dataGridViewTextBoxColumn15.HeaderText = "Gesammtpreis";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Form10_Baugruppe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.bestellungPositionen_ViewDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1_header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form10_Baugruppe";
            this.Text = "Baugruppe suchen";
            this.Load += new System.EventHandler(this.Form10_Baugruppe_Load);
            this.panel1_header.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionen_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungPositionen_ViewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_header;
        private System.Windows.Forms.Button button1_PrintumProjekte;
        protected System.Windows.Forms.Label label_ganzOben;
        private System.Windows.Forms.Panel panelOb_balkenoben;
        private System.Windows.Forms.Panel panelOb_balkenUnten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1_suchen;
        private DAL.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bestellungPositionen_ViewBindingSource;
        private DAL.DataSet1TableAdapters.BestellungPositionen_ViewTableAdapter bestellungPositionen_ViewTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bestellungPositionen_ViewDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}