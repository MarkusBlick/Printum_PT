//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintumProjektverwaltung.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dateien
    {
        public int Datei_ID { get; set; }
        public string Name { get; set; }
        public string Pfad { get; set; }
        public string Typ { get; set; }
        public string Schlagworte { get; set; }
        public Nullable<System.DateTime> erstellt { get; set; }
        public Nullable<System.DateTime> geaendert { get; set; }
        public string erstelltVon { get; set; }
        public string geaendertVon { get; set; }
        public Nullable<int> Projektnummer { get; set; }
    }
}
