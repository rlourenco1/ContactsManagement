using Contacts.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        void IEntityTypeConfiguration<Person>.Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            
            builder.HasIndex(x => x.ID);
            builder.HasKey(x => x.ID);

            builder.Property(m => m.Name);
        }
    }
}
