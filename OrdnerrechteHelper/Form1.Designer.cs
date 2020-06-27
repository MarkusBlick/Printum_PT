namespace OrdnerrechteHelper
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1_auslesen = new System.Windows.Forms.Button();
            this.button2_rechtesetzen = new System.Windows.Forms.Button();
            this.textBox1_ordner = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2_rechtesetzen);
            this.panel1.Controls.Add(this.button1_auslesen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1_ordner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(13);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(534, 523);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(534, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(13);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(666, 523);
            this.panel3.TabIndex = 2;
            // 
            // button1_auslesen
            // 
            this.button1_auslesen.BackColor = System.Drawing.Color.IndianRed;
            this.button1_auslesen.FlatAppearance.BorderSize = 0;
            this.button1_auslesen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1_auslesen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1_auslesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_auslesen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_auslesen.Location = new System.Drawing.Point(12, 12);
            this.button1_auslesen.Name = "button1_auslesen";
            this.button1_auslesen.Size = new System.Drawing.Size(180, 32);
            this.button1_auslesen.TabIndex = 10;
            this.button1_auslesen.Text = "auslesen";
            this.button1_auslesen.UseVisualStyleBackColor = false;
            this.button1_auslesen.Click += new System.EventHandler(this.button1_auslesen_Click);
            // 
            // button2_rechtesetzen
            // 
            this.button2_rechtesetzen.BackColor = System.Drawing.Color.IndianRed;
            this.button2_rechtesetzen.FlatAppearance.BorderSize = 0;
            this.button2_rechtesetzen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2_rechtesetzen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2_rechtesetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_rechtesetzen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2_rechtesetzen.Location = new System.Drawing.Point(262, 12);
            this.button2_rechtesetzen.Name = "button2_rechtesetzen";
            this.button2_rechtesetzen.Size = new System.Drawing.Size(180, 32);
            this.button2_rechtesetzen.TabIndex = 11;
            this.button2_rechtesetzen.Text = "rechte setzen";
            this.button2_rechtesetzen.UseVisualStyleBackColor = false;
            this.button2_rechtesetzen.Click += new System.EventHandler(this.button2_rechtesetzen_Click);
            // 
            // textBox1_ordner
            // 
            this.textBox1_ordner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1_ordner.Location = new System.Drawing.Point(10, 10);
            this.textBox1_ordner.Multiline = true;
            this.textBox1_ordner.Name = "textBox1_ordner";
            this.textBox1_ordner.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1_ordner.Size = new System.Drawing.Size(514, 503);
            this.textBox1_ordner.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(646, 503);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hilfsprogramm Ordnerrecht überwachen";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2_rechtesetzen;
        private System.Windows.Forms.Button button1_auslesen;
        private System.Windows.Forms.TextBox textBox1_ordner;
        private System.Windows.Forms.TextBox textBox1;
    }
}

