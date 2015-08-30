using System.Data.Entity.ModelConfiguration;
using ApplicationDDD.Domain.Entities;

namespace ApplicationDDD.Data.EntityConfig
{
    public class ProductsMap : EntityTypeConfiguration<Products>
    {
        public ProductsMap()
        {
            HasKey(c => c.ID);

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId);
        }
    }
}
