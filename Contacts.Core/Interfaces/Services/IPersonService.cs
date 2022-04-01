using Contacts.Core.Domain.Entities;
using Contacts.Core.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Interfaces.Services
{
    public interface IPersonService : IBaseService<PersonViewModel, Person>
    {
    }
}
