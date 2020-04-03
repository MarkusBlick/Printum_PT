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
    public partial class _test_Form : Form
    {
        public _test_Form()
        {
            InitializeComponent();
        }

        private void bestellungPositionenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bestellungPositionenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void _test_Form_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.BestellungPositionen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bestellungPositionenTableAdapter.Fill(this.dataSet1.BestellungPositionen);

        }
    }
}
