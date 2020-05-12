namespace PrintumProjektverwaltung.Forms
{
    partial class Rechnung07_Zahlungen
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
            System.Windows.Forms.Label lieferscheinNrLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnung07_Zahlungen));
            this.rechnungBetragTextBox = new System.Windows.Forms.TextBox();
            this.zahlungsBetragTextBox = new System.Windows.Forms.TextBox();
            this.zahlungsDatumTextBox = new System.Windows.Forms.TextBox();
            this.button2_adresse = new System.Windows.Forms.Button();
            lieferscheinNrLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lieferscheinNrLabel
            // 
            lieferscheinNrLabel.AutoSize = true;
            lieferscheinNrLabel.Location = new System.Drawing.Point(13, 21);
            lieferscheinNrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lieferscheinNrLabel.Name = "lieferscheinNrLabel";
            lieferscheinNrLabel.Size = new System.Drawing.Size(137, 20);
            lieferscheinNrLabel.TabIndex = 4;
            lieferscheinNrLabel.Text = "Rechnungsbetrag";
            // 
            // rechnungBetragTextBox
            // 
            this.rechnungBetragTextBox.Location = new System.Drawing.Point(152, 21);
            this.rechnungBetragTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rechnungBetragTextBox.Name = "rechnungBetragTextBox";
            this.rechnungBetragTextBox.Size = new System.Drawing.Size(148, 26);
            this.rechnungBetragTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(332, 21);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Zahlungsbetrag";
            // 
            // zahlungsBetragTextBox
            // 
            this.zahlungsBetragTextBox.Location = new System.Drawing.Point(489, 21);
            this.zahlungsBetragTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zahlungsBetragTextBox.Name = "zahlungsBetragTextBox";
            this.zahlungsBetragTextBox.Size = new System.Drawing.Size(148, 26);
            this.zahlungsBetragTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(332, 77);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 20);
            label2.TabIndex = 8;
            label2.Text = "Zahlungseingang";
            // 
            // zahlungsDatumTextBox
            // 
            this.zahlungsDatumTextBox.Location = new System.Drawing.Point(489, 77);
            this.zahlungsDatumTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zahlungsDatumTextBox.Name = "zahlungsDatumTextBox";
            this.zahlungsDatumTextBox.Size = new System.Drawing.Size(148, 26);
            this.zahlungsDatumTextBox.TabIndex = 9;
            // 
            // button2_adresse
            // 
            this.button2_adresse.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2_adresse.FlatAppearance.BorderSize = 0;
            this.button2_adresse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2_adresse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2_adresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_adresse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2_adresse.Location = new System.Drawing.Point(416, 132);
            this.button2_adresse.Name = "button2_adresse";
            this.button2_adresse.Size = new System.Drawing.Size(221, 36);
            this.button2_adresse.TabIndex = 15;
            this.button2_adresse.Text = "speichern";
            this.button2_adresse.UseVisualStyleBackColor = false;
            this.button2_adresse.Click += new System.EventHandler(this.button2_adresse_Click);
            // 
            // Rechnung07_Zahlungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(654, 195);
            this.Controls.Add(this.button2_adresse);
            this.Controls.Add(label2);
            this.Controls.Add(this.zahlungsDatumTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.zahlungsBetragTextBox);
            this.Controls.Add(lieferscheinNrLabel);
            this.Controls.Add(this.rechnungBetragTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rechnung07_Zahlungen";
            this.Text = "Zahlungseingänge erfassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rechnungBetragTextBox;
        private System.Windows.Forms.TextBox zahlungsBetragTextBox;
        private System.Windows.Forms.TextBox zahlungsDatumTextBox;
        private System.Windows.Forms.Button button2_adresse;
    }
}