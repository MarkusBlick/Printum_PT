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
    
    public partial class Artikel
    {
        public int ArtikelID { get; set; }
        public string Artikelnummer { get; set; }
        public string Beschreibung { get; set; }
        public string BeschreibungEnglish { get; set; }
        public Nullable<decimal> Preis { get; set; }
        public string Einheit { get; set; }
        public Nullable<bool> IstBaugruppe { get; set; }
        public string Mengeneinheit { get; set; }
    }
}
