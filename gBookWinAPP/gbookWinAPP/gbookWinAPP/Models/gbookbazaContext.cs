using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace gbookWinAPP.Models
{

    public class gbookbazaContext : DbContext
    {
        public gbookbazaContext() : base("AzureConnection") { }

        /*... ovdje mapiramo klase u gbookbazu*/
        public virtual DbSet<ZaposlenikModel> OOADZaposlenici { get; set; }
        public virtual DbSet<ClanModel> OOADClanovi { get; set; }
        public virtual DbSet<KarticaModel> OOADKartice { get; set; }
        public virtual DbSet<KnjigaModel> OOADKnjige { get; set; }
        public virtual DbSet<CitaonaModel> OOADCitaone { get; set; }
        public virtual DbSet<ClanarinaModel> OOADClanarine { get; set; }
        /* funkcija za automatsko ukidanje mnozine u nazive */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<ClanModel>().
            Property(e => e.ClanID).IsRequired();

            modelBuilder.Entity<ClanModel>().
            Property(e => e.UserName).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.Password).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.Ime).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.Prezime).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.DatumUclanjenja).IsRequired();


            modelBuilder.Entity<ClanModel>().
            Property(e => e.Grad).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.Adresa).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.BrojTel).
            IsUnicode(false);

            modelBuilder.Entity<ClanModel>().
            Property(e => e.Email).
            IsUnicode(false);


            modelBuilder.Entity<KnjigaModel>()
            .Property(t => t.Naziv).IsUnicode(false);

            modelBuilder.Entity<KnjigaModel>()
                .Property(t => t.Autor).IsUnicode(false);

            modelBuilder.Entity<KnjigaModel>()
                .Property(t => t.Izdavac).IsUnicode(false);

            modelBuilder.Entity<KnjigaModel>()
                .Property(t => t.ISBN);

            modelBuilder.Entity<KnjigaModel>()
                .Property(t => t.DatumIzdavanja);

            modelBuilder.Entity<KnjigaModel>()
                .Property(t => t.DatumVracanja);

            //.. Veza Clana i Knjige
            modelBuilder.Entity<ClanModel>().
            HasMany(t => t.knjigeCLID)
            .WithRequired(t => t.ClanModel)
            .HasForeignKey(t => t.KnjigaID);


        }


        
    }


  
}