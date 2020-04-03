using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintumProjektverwaltung.DAL;
using PrintumProjektverwaltung.Models;

namespace PrintumProjektverwaltung.Forms
{
    public partial class Ausliefer01_main : Form
    {
        public Ausliefer01_main()
        {
            InitializeComponent();
        }

        private int letzteAuftragID = -1;

        private void Ausliefer01_main_Load(object sender, EventArgs e)
        {
            this.lieferungTableAdapter.Fill(this.dataSet11.Lieferung);

            Datenladen();
            this.timer1_nachLoad.Start();

        }

        private void button1_neu_Click(object sender, EventArgs e)
        {
            Ausliefer02_neu A02 = new Ausliefer02_neu();
            A02.ShowDialog();
            Datenladen();
        }

        private void Datenladen()
        {

            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet11.LieferungRechnungen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.lieferungRechnungenTableAdapter.Fill(this.dataSet11.LieferungRechnungen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet11.LieferungLieferschein". Sie können sie bei Bedarf verschieben oder entfernen.
            this.lieferungLieferscheinTableAdapter.Fill(this.dataSet11.LieferungLieferschein);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet11.LieferungPositionen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.lieferungPositionenTableAdapter.FillBy(this.dataSet11.LieferungPositionen);
            if (this.letzteAuftragID > -1)
            {
                SetAlleBindingSourceFilter(this.letzteAuftragID);

            }
        }


        private void timer1_nachLoad_Tick(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                int letzter = this.dataGridView1.Rows.Count - 1;
                this.dataGridView1.Rows[letzter].Selected = true;
                //  this.dataGridView1.Rows[0].Selected = true;
                SetAlleBindingSourceFilter(this.letzteAuftragID);
            }
            this.timer1_nachLoad.Stop();
        }

        private void button_aendern_Click(object sender, EventArgs e)
        {

            try
            {
                var gridrows = this.dataGridView1.SelectedRows;

                var bounditem = gridrows[0].DataBoundItem;
                var rowview = ((DataRowView)bounditem).Row;

                DAL.DataSet1.LieferungRow selectedRow = (DAL.DataSet1.LieferungRow)rowview;
                Ausliefer05_aendern A05 = new Ausliefer05_aendern();
                A05.selectedRow = selectedRow;
                letzteAuftragID = selectedRow.AuftagID;
                A05.ShowDialog();
                Datenladen();
            }
            catch (Exception ex)
            {
                var name = "bla";
            }


        }

        private void button_Lieferposition_Click(object sender, EventArgs e)
        {
            var gridrows = this.dataGridView1.SelectedRows;
            var bounditem = gridrows[0].DataBoundItem;
            var rowview = ((DataRowView)bounditem).Row;
            DAL.DataSet1.LieferungRow selectedRow = (DAL.DataSet1.LieferungRow)rowview;
            letzteAuftragID = selectedRow.AuftagID;

            Ausliefer06_Positionen A06 = new Ausliefer06_Positionen();
            A06.selectedRow = selectedRow;
            A06.ShowDialog();
            Datenladen();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.Focused)
            {
                var senderGrid = (DataGridView)sender;
                var row = senderGrid.CurrentRow as DataGridViewRow;
                if (row != null)
                {

                    DataGridViewTextBoxCell AuftagID = row.Cells["AuftagID"] as DataGridViewTextBoxCell;
                    if (AuftagID != null)
                    {


                        if (AuftagID.Value != null)
                        {

                            Int32.TryParse(AuftagID.Value.ToString(), out this.letzteAuftragID);
                            SetAlleBindingSourceFilter(AuftagID.Value);
                        }
                    }
                }
            }


        }

        private void SetAlleBindingSourceFilter(object auftragID)
        {
            int dieId = -1;
            string id = auftragID.ToString().Trim();
            Int32.TryParse(id, out dieId);

            this.lieferungPositionenBindingSource.Filter = @" AuftragID = " + dieId;
            this.lieferungLieferscheinBindingSource.Filter = @" AuftagID = " + dieId;

            this.letzteAuftragID = dieId;

        }

        private void lieferungRechnungenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Lieferschein_Click(object sender, EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                var gridrows1 = this.dataGridView1.SelectedRows;
                var bounditem1 = gridrows1[0].DataBoundItem;
                var rowview1 = ((DataRowView)bounditem1).Row;
                DAL.DataSet1.LieferungRow selectedRow1 = (DAL.DataSet1.LieferungRow)rowview1;



                //              List<LieferungPositionen> posdt = makeTableFrom(this.lieferungPositionenDataGridView);
                if (selectedRow1 != null)
                {



                    ReportViewer_Lieferschein rl = new ReportViewer_Lieferschein();
                    rl.DieLieferung = makePrintumLieferung(selectedRow1);
                    rl.ShowDialog();
                    Datenladen();
                    this.Cursor = Cursors.Default;


                }
                else
                {
                    MessageBox.Show("...und welche Lieferung bitte?");
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                var name = "bla";
                this.Cursor = Cursors.Default;
            }
        }

        private printumLieferung makePrintumLieferung(DataSet1.LieferungRow selectedRow)
        {
            printumLieferung DieLieferung = new printumLieferung();

            if (selectedRow != null)
            {
                DieLieferung.AdressLieferLand = selectedRow.IsAdressLieferLandNull() ? null : selectedRow.AdressLieferLand;
                DieLieferung.AdressLieferName = selectedRow.IsAdressLieferNameNull() ? null : selectedRow.AdressLieferName;
                DieLieferung.AdressLieferOrt = selectedRow.IsAdressLieferOrtNull() ? null : selectedRow.AdressLieferOrt;
                DieLieferung.AdressLieferPLZ = selectedRow.IsAdressLieferPLZNull() ? null : selectedRow.AdressLieferPLZ;
                DieLieferung.AdressLieferStrasse = selectedRow.IsAdressLieferStrasseNull() ? null : selectedRow.AdressLieferStrasse;

                DieLieferung.AuftagID = selectedRow.AuftagID;
                DieLieferung.aktiv = selectedRow.IsaktivNull() ? -1 : selectedRow.aktiv;
                DieLieferung.AuftragNummer = selectedRow.IsAuftragNummerNull() ? null : selectedRow.AuftragNummer;
                DieLieferung.Bezeichnung = selectedRow.IsBezeichnungNull() ? null : selectedRow.Bezeichnung;
                DieLieferung.EinheitID = selectedRow.IsEinheitIDNull() ? -1 : selectedRow.EinheitID;
                DieLieferung.EinheitNummer = selectedRow.IsEinheitNummerNull() ? null : selectedRow.EinheitNummer;
                DieLieferung.LieferscheinID = selectedRow.IsLieferscheinIDNull() ? -1 : selectedRow.LieferscheinID;
                DieLieferung.LieferscheinNummer = selectedRow.IsLieferscheinNummerNull() ? null : selectedRow.LieferscheinNummer;
                DieLieferung.Projektname = selectedRow.IsProjektnameNull() ? null : selectedRow.Projektname;
                DieLieferung.Projektnummer = selectedRow.IsProjektnummerNull() ? -1 : selectedRow.Projektnummer;

                // DieLieferung.lieferungPositionen = posdt;
                DieLieferung.getPositionen();
            }
            return DieLieferung;
        }

    }
}
