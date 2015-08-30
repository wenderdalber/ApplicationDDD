using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDDD.Domain.Entities;

namespace ApplicationDDD.Data.EntityConfig
{
    public class CategoriesMap:EntityTypeConfiguration<Categories>
    {
        public CategoriesMap()
        {
            HasKey(c => c.ID);

            HasRequired(p => p.Product)
               .WithMany()
               .HasForeignKey(p => p.ProductId);
        }
    }
}
