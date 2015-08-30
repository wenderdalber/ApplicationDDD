using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ApplicationDDD.Domain.Entities;

namespace ApplicationDDD.Data.Context
{
    public class ApplicationDddContext : DbContext
    {
        public ApplicationDddContext()
            : base("ApplicationDDD")
        {
            
        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
