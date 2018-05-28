using Autoukis.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Autoukis.Context
{
    public class FarmContext : DbContext
    {

        public FarmContext() : base("FarmContext")
        {
        }

        public DbSet<Dronas> Dronai { get; set; }
        public DbSet<Gyvulys> Gyvuliai { get; set; }
        public DbSet<Pozicija> Pozicijos { get; set; }
        public DbSet<Robotas> Robotai { get; set; }
        public DbSet<Daviklis> Davikliai { get; set; }
        public DbSet<Sesija> Sesijos { get; set; }
        public DbSet<Signalas> Signalai { get; set; }
        public DbSet<TechninePriemone> TechninesPriemones { get; set; }
        public DbSet<Uzklausa> Uzklausos { get; set; }
        public DbSet<ZemesPlotas> ZemesPlotai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
