namespace gbookWinAPP.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Servis : DbContext
    {
        public Servis()
            : base("name=Servis")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<OOADClanModel> OOADClanModels { get; set; }
        public virtual DbSet<OOADKnjigaModel> OOADKnjigaModels { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.Grad)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.BrojTel)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<OOADClanModel>()
                .HasMany(e => e.OOADKnjigaModels)
                .WithRequired(e => e.OOADClanModel)
                .HasForeignKey(e => e.KnjigaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OOADKnjigaModel>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<OOADKnjigaModel>()
                .Property(e => e.Autor)
                .IsUnicode(false);

            modelBuilder.Entity<OOADKnjigaModel>()
                .Property(e => e.Izdavac)
                .IsUnicode(false);

            modelBuilder.Entity<OOADKnjigaModel>()
                .HasMany(e => e.OOADKnjigaModel1)
                .WithOptional(e => e.OOADKnjigaModel2)
                .HasForeignKey(e => new { e.OOADKnjige_KorisnikKnige, e.OOADKnjige_KnjigaID });

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
