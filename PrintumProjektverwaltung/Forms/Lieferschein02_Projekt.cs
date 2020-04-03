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
    public partial class Lieferschein02_Projekt : Form
    {
        public DAL.DataSet1.ProjekteRow rrrow;

        public Lieferschein02_Projekt()
        {
            InitializeComponent();
        }

        private void projekteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projekteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Lieferschein02_Projekt_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Projekte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.projekteTableAdapter.Fill(this.dataSet1.Projekte);

            this.textBox1_suchen.Focus();

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
                    this.rrrow = (DAL.DataSet1.ProjekteRow)rowview;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    //var L05 = Application.OpenForms["Lieferschein05_neuerLS"] as Lieferschein05_neuerLS;

                    //if (L05 != null)
                    //{
                    //    var rrrow = (DAL.DataSet1.ProjekteRow)rowview;
                    //    L05.Projektname = rrrow.Projektname;
                    //    L05.Projektnummer = rrrow.Projektnummer;
                    //    L05.RootOrdner = rrrow.RootOrdner;
                    //}

                    //var R05 = Application.OpenForms["Rechnung05_neueRE"] as Rechnung05_neueRE;

                    //if (R05 != null)
                    //{
                    //    var rrrow = (DAL.DataSet1.ProjekteRow)rowview;
                    //    R05.Projektname = rrrow.Projektname;
                    //    R05.Projektnummer = rrrow.Projektnummer;
                    //   // R05.RootOrdner = rrrow.RootOrdner;
                    //}

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
