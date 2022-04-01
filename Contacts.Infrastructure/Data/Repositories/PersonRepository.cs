using Contacts.Core.Domain.Entities;
using Contacts.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Data.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {

        public PersonRepository(AppDbContext context) : base(context)
        {
        }


    }
}
