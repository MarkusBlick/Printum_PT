using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PrintumProjektverwaltung.Forms;
using System.Data;

namespace PrintumProjektverwaltung.Reports
{
    public partial class XtraReport1_Lieferschein1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1_Lieferschein1()
        {
            InitializeComponent();
        }



        private void xrLabel1_PreviewDoubleClick(object sender, PreviewMouseEventArgs e)
        {
            ReportViewer1 frm = new ReportViewer1();
            XRLabel label = e.Brick.BrickOwner as XRLabel;

            var labelbinding = label.DataBindings["Text"];
            if (labelbinding != null)
            {


                var dmember = labelbinding.DataMember;
                int indess = DataMember.LastIndexOf('.') + 1;

                string fieldName = labelbinding.DataMember.Substring(label.DataBindings["Text"].DataMember.LastIndexOf('.') + 1);

                frm.str = ((DataRowView)e.Brick.Value)[fieldName].ToString();
          
            frm.ShowDialog();
            ((DataRowView)e.Brick.Value)[fieldName] = frm.str;  }
            this.CreateDocument(false);
        }
    }
}
