using Contacts.Core.Domain.Entities;
using Contacts.Core.Resources.Enums;
using Contacts.Core.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Interfaces.Services
{
    public interface IContactService : IBaseService<ContactViewModel, Contact>
    {
        IEnumerable<ContactViewModel> GetByPersonId(int id);

        IEnumerable<ContactViewModel> GetByTypeAndPersonId(ContactTypeEnum type, int id);
    }
}
