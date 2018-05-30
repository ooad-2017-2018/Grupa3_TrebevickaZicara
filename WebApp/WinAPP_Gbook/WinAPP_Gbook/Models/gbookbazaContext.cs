using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WinAPP_Gbook.Models
{
    public class gbookbazaContext : DbContext
    {
         public gbookbazaContext() : base("AzureConnection") { }

        /*... ovdje mapiramo klase u gbookbazu
         public DbSet<ClanModel> Clan {get; set;} */

        /* funkcija za automatsko ukidanje mnozine u nazive */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}