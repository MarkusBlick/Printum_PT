using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Ausliefer04_ProjektSelect : Form
    {
        public Ausliefer04_ProjektSelect()
        {
            InitializeComponent();
        }

        private void projekteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projekteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Ausliefer04_ProjektSelect_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Projekte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.projekteTableAdapter.Fill(this.dataSet1.Projekte);

        }

        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string suchtext = this.textBox1_suchen.Text.Trim();

            string filtertext1 = "CONVERT(Projektnummer, 'System.String') LIKE '*" + suchtext + "*'";
            string filtertext2 = "Projektname LIKE '*" + suchtext + "*'";


            this.projekteBindingSource.Filter =
                                                filtertext1 + " OR " +
                                                filtertext2;
        }

        private void button_adresse_Click(object sender, EventArgs e)
        {
            ProjektWaehlenUndSchliessen();
        }

        private void projekteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjektWaehlenUndSchliessen();
        }

        private void ProjektWaehlenUndSchliessen()
        {
            var rows = this.projekteDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                try
                {
                    var bounditem = rows[0].DataBoundItem;
                    var rowview = ((DataRowView)bounditem).Row;

                    var A02 = Application.OpenForms["Ausliefer02_neu"] as Ausliefer02_neu;
                    var A05 = Application.OpenForms["Ausliefer05_aendern"] as Ausliefer05_aendern;

                    if (A02 != null)
                    {
                        A02.projektRow = (DAL.DataSet1.ProjekteRow)rowview;
                    }
                    if (A05 != null)
                    {
                        A05.projektRow = (DAL.DataSet1.ProjekteRow)rowview;
                    }


                }
                catch (Exception ex)
                {

                    var name = "bla";
                }
                finally
                {
                    this.Close();
                }
            }
        }
    }
}
