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
    public partial class Form10_Baugruppe : Form
    {
        public Form10_Baugruppe()
        {
            InitializeComponent();
        }

        private void button1_PrintumProjekte_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form10_Baugruppe_Load(object sender, EventArgs e)
        {
            this.bestellungPositionen_ViewTableAdapter.Fill(this.dataSet1.BestellungPositionen_View);

        }

        private void textBox1_suchen_TextChanged(object sender, EventArgs e)
        {
            string filtertext = "CONVERT(Artikelbezeichnung, 'System.String') LIKE '*" + this.textBox1_suchen.Text.Trim() + "*' ";

            bestellungPositionen_ViewBindingSource.Filter = filtertext;
        }

        private void bestellungPositionen_ViewDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 3  && e.Value != null && this.textBox1_suchen.Text.Count()>0)
            {
                //string[] HighlightStrings = this.textBox1_suchen.Text.Trim().Split(' ');
                string s = this.textBox1_suchen.Text.Trim();
                string value = e.Value.ToString();
                //foreach (var s in HighlightStrings)
                //{
                    int i = 0;
                    while (i < value.Length && (i = value.IndexOf(s, i)) != -1)
                    {
                        if (!e.Handled)
                        {
                            e.Handled = true;
                            e.PaintBackground(e.ClipBounds, true);
                        }
                        StringFormat sf = StringFormat.GenericTypographic;
                        sf.LineAlignment = StringAlignment.Center;
                        RectangleF textBounds = GetTextBounds(e.Graphics,
                                                              value, i, s.Length,
                                                              e.CellBounds,
                                                              e.CellStyle.Font, sf);
                        //highlight it
                        e.Graphics.FillRectangle(Brushes.Yellow, textBounds);
                        i += s.Length;
                        using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                        {
                            //draw string , don't use PaintContent
                            e.Graphics.DrawString(value, e.CellStyle.Font, brush,
                                                  e.CellBounds, sf);
                        }
                    }
                //}
            }
        }

        public RectangleF GetTextBounds(Graphics g, string text,
                                int subIndex, int subLength,
                                RectangleF layout,
                                Font font, StringFormat sf)
        {
            var charRange = new CharacterRange(0, text.Length);
            var subCharRange = new CharacterRange(subIndex, subLength);
            sf.SetMeasurableCharacterRanges(new[] { charRange, subCharRange });
            var regions = g.MeasureCharacterRanges(text, font, layout, sf);
            return regions.Length < 2 ? RectangleF.Empty : regions[1].GetBounds(g);
        }
    }
}
