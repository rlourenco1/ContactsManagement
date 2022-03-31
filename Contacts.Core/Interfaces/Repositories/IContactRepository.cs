using Contacts.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Interfaces.Repositories
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
    }
}
