﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrintumProjekteEntities : DbContext
    {
        public PrintumProjekteEntities()
            : base("name=PrintumProjekteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dateien> Dateien { get; set; }
        public virtual DbSet<Mails> Mails { get; set; }
        public virtual DbSet<Ordner> Ordner { get; set; }
        public virtual DbSet<Personen> Personen { get; set; }
        public virtual DbSet<Projekte> Projekte { get; set; }
        public virtual DbSet<Bestellungen> Bestellungen { get; set; }
        public virtual DbSet<BestellungPositionen> BestellungPositionen { get; set; }
        public virtual DbSet<Adressen> Adressen { get; set; }
        public virtual DbSet<Artikel> Artikel { get; set; }
        public virtual DbSet<Einheit> Einheit { get; set; }
        public virtual DbSet<Lieferung> Lieferung { get; set; }
        public virtual DbSet<BestellungPositionen_View> BestellungPositionen_View { get; set; }
        public virtual DbSet<BestellungProProjekt> BestellungProProjekt { get; set; }
        public virtual DbSet<LieferungLieferschein> LieferungLieferschein { get; set; }
        public virtual DbSet<LieferungRechnungen> LieferungRechnungen { get; set; }
        public virtual DbSet<LieferungPositionen> LieferungPositionen { get; set; }
        public virtual DbSet<PriProLieferscheinRechnung> PriProLieferscheinRechnung { get; set; }
        public virtual DbSet<PriProRechnung> PriProRechnung { get; set; }
    }
}
