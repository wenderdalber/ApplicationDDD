using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDDD.Domain.Entities;

namespace ApplicationDDD.Data.EntityConfig
{
    public class ClientsMap : EntityTypeConfiguration<Clients>
    {
        public ClientsMap()
        {
            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
