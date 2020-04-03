using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintumProjektverwaltung.Models
{
    class printumLieferung
    {
        public int AuftagID { get; set; }
        public string AuftragNummer { get; set; }
        public string Bezeichnung { get; set; }
        public string AdressLieferName { get; set; }
        public string AdressLieferStrasse { get; set; }
        public string AdressLieferPLZ { get; set; }
        public string AdressLieferOrt { get; set; }
        public string AdressLieferLand { get; set; }

        public string AdressRechnungName { get; set; }
        public string AdressRechnungStrasse { get; set; }
        public string AdressRechnungPLZ { get; set; }
        public string AdressRechnungOrt { get; set; }
        public string AdressRechnungLand { get; set; }

        public Nullable<int> RechnungID1 { get; set; }
        public string RechnungNummer1 { get; set; }
        public Nullable<int> RechnungID2 { get; set; }
        public string RechnungNummer2 { get; set; }
        public Nullable<int> RechnungID3 { get; set; }
        public string RechnungNummer3 { get; set; }
        public Nullable<int> RechnungID4 { get; set; }
        public string RechnungNummer4 { get; set; }
        public Nullable<int> LieferscheinID { get; set; }
        public string LieferscheinNummer { get; set; }
        public Nullable<int> EinheitID { get; set; }
        public string EinheitNummer { get; set; }
        public Nullable<int> Projektnummer { get; set; }
        public string Projektname { get; set; }
        public Nullable<int> aktiv { get; set; }



        public List<DAL.LieferungLieferschein> lieferungLieferscheine { get; set; }
        public List<DAL.LieferungPositionen> lieferungPositionen { get; set; }




        public int getNextLieferscheinNr()
        {
            int dieNr = 0;


            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {
                try
                {
                    // liest die DB aus
                    int maxBestellnr = db.LieferungLieferschein.Max(x => x.LieferscheinID);

                    // die ersten 2 nummern der Bestellnummer auslesen
                    string maxStringganz = maxBestellnr.ToString();
                    string maxStringkurz = maxStringganz.Substring(0, 2);
                    int maxkurz = Convert.ToInt32(maxStringkurz);

                    // 2-stellige Jahr
                    string JahrString = DateTime.Now.Year.ToString().Substring(2);
                    int jahrkurz = Convert.ToInt32(JahrString);


                    // die Erste Bestellung im neuen Jahr
                    if (jahrkurz > maxkurz)
                    {
                        string neuesJahrString = DateTime.Now.Year.ToString().Substring(2) + "0501";
                        dieNr = Convert.ToInt32(neuesJahrString);
                    }
                    // einen höher zählen
                    else
                    {
                        dieNr = maxBestellnr + 1;
                    }
                    //this.LieferscheinID = dieNr;
                    // this.LieferscheinNummer = "L-" + dieNr;
                }
                catch (Exception ex)
                {
                    Helper.LogHelper.WriteDebugLog(ex.ToString());
                }

            }


            return dieNr;
        }

        public void getPositionen()
        {

            using (DAL.PrintumProjekteEntities db = new DAL.PrintumProjekteEntities())
            {
                try
                {
                    var q = from p in db.LieferungPositionen
                            where p.AuftragID == this.AuftagID && p.GeaenderAm == null && p.GeloeschtAm == null
                            orderby p.PositionNr
                            select p;
                    if (q.Count() > 0)
                    {
                        this.lieferungPositionen = q.ToList();

                    }
                }
                catch (Exception ex)
                {

                    var bla = ex.ToString();
                }

            }
        }

        private string getBestellungIDTextFrom(int dieNr)
        {
            string vorn = dieNr.ToString().Substring(0, 2);
            string hinten = dieNr.ToString().Substring(2);
            string textNr = vorn + "-" + hinten;
            return textNr;
        }



    }
}
