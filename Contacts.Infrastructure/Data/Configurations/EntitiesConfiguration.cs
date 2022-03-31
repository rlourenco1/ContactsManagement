using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Data.Configurations
{
    public class EntitiesConfiguration
    {
        public EntitiesConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
        }
    }
}
