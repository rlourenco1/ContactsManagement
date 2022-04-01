using AutoMapper;
using Contacts.Core.Domain.Entities;
using Contacts.Core.Resources.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Resources.ViewModels
{
    public class ContactViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public ContactTypeEnum Type { get; set; }

        public int PersonId { get; set; }

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<ContactViewModel, Contact>()
                .ForPath(dest => dest.ContactType, src => src.MapFrom(x => x.Type))
                .ForPath(dest => dest.ContactValue, src => src.MapFrom(x => x.Value))
                ;

            mapper.CreateMap<Contact, ContactViewModel>()
                .ForPath(dest => dest.Type, src => src.MapFrom(x => x.ContactType))
                .ForPath(dest => dest.Value, src => src.MapFrom(x => x.ContactValue))
                ;
        }
    }
}
