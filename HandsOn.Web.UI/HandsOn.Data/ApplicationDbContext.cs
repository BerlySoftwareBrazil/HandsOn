using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Imports
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HandsOn.Data.Model;
#endregion
namespace HandsOn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("HandsOn"){}

        public DbSet<Place> Places { get; set; }
        public DbSet<Suspect> Suspects { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
