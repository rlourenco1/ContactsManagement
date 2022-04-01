using Contacts.Core.Domain.Entities;
using Contacts.Core.Interfaces.Repositories;
using Contacts.Core.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infrastructure.Data.Repositories
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(AppDbContext context) : base(context)
        {
        }

        IEnumerable<Contact> IContactRepository.GetByPersonId(int id)
        {
            return _context.Set<Contact>().Where(x => x.PersonId == id).ToList();
        }

        IEnumerable<Contact> IContactRepository.GetByTypeAndPersonId(ContactTypeEnum type, int id)
        {
            return _context.Set<Contact>()
                .Where(x => x.PersonId == id && x.ContactType == type)
                .ToList();
        }
    }
}
