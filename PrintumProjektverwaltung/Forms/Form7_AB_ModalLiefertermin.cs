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
    public partial class Form7_AB_ModalLiefertermin : Form
    {
        public Form7_AB_ModalLiefertermin()
        {
            InitializeComponent();
        }

        public DateTime letztesDatum { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            (Application.OpenForms["Form7_AB"] as Form7_AB).neuerLiefertermin = this.dateTimePicker1.Value;


            this.Close();
        }

        private void Form7_AB_ModalLiefertermin_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = letztesDatum;
            
        }
    }

}
