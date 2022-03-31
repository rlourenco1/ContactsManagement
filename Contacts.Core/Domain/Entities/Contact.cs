using Contacts.Core.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Domain.Entities
{
    public class Contact
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ContactValue { get; set; }

        public ContactTypeEnum ContactType { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}
