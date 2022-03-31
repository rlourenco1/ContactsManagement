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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        void IEntityTypeConfiguration<Contact>.Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.HasIndex(x => x.ID);
            builder.HasKey(x => x.ID);

            builder.Property(m => m.Name);

            builder.Property(m => m.ContactType);

            builder.Property(m => m.ContactValue);

            builder.Property(m => m.PersonId);
            builder.HasOne(m => m.Person)
                .WithMany(n => n.Contacts)
                .HasForeignKey(m => m.PersonId);
        }
    }
}
