using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SystemInnovationContext : DbContext
    {
        public SystemInnovationContext() : base("SystemInnovationContext")
        {

        }

        public DbSet<costo_imp> costo_imps { get; set; }

        public DbSet<equipos> equipos { get; set; }

        public DbSet<impresiones> impresiones { get; set; }

        public DbSet<rentas> rentas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
