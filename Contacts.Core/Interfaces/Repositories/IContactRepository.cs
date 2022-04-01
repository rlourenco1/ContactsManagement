using Contacts.Core.Domain.Entities;
using Contacts.Core.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Interfaces.Repositories
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
        IEnumerable<Contact> GetByPersonId(int id);

        IEnumerable<Contact> GetByTypeAndPersonId(ContactTypeEnum type, int id);
    }
}
