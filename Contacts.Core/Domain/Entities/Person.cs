using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Domain.Entities
{
    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Contact> Contacts = new List<Contact>();
    }
}
