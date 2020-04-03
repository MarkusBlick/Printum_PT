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
    public partial class Rechnung06_Lieferscheine : Form
    {
        public DAL.DataSet1.PriProLieferscheinRechnungRow rrrow;

        public Rechnung06_Lieferscheine()
        {
            InitializeComponent();
        }

        private void projekteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priProLieferscheinRechnungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Rechnung06_Lieferscheine_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.Projekte". Sie können sie bei Bedarf verschieben oder entfernen.
            this.priProLieferscheinRechnungTableAdapter1.Fill(this.dataSet1.PriProLieferscheinRechnung);

            this.textBox1_suchen.Focus();

        }

        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string suchtext = this.textBox1_suchen.Text.Trim();

            string filtertext1 = "CONVERT(LieferscheinNr, 'System.String') LIKE '*" + suchtext + "*'";
            string filtertext2 = "LieferscheinBeschreibung LIKE '*" + suchtext + "*'";
            string filtertext3 = "LS_Firmenname LIKE '*" + suchtext + "*'";


            this.priProLieferscheinRechnungBindingSource.Filter =
                                                filtertext1 + " OR " +
                                                filtertext2 + " OR " +
                                                filtertext3;
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
                    this.rrrow = (DAL.DataSet1.PriProLieferscheinRechnungRow)rowview;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    //var R05 = Application.OpenForms["Rechnung05_neueRE"] as Rechnung05_neueRE;

                    //if (R05 != null)
                    //{
                    //    var rrrow = (DAL.DataSet1.PriProLieferscheinRechnungRow)rowview;
                    //    R05.Projektname = rrrow.Projektname;
                    //    R05.Projektnummer = rrrow.Projektnummer;
                    //    R05.LieferscheinNr = rrrow.LieferscheinNr;
                    //    R05.LieferscheinBeschreibung = rrrow.LieferscheinBeschreibung;
                    //    R05.LieferscheinAdresse = rrrow.LS_Firmenname;
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
