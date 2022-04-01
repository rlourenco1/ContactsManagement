using AutoMapper;
using Contacts.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Resources.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ContactViewModel> Contacts { get; set; } = new List<ContactViewModel>();

        public static void Mapping(Profile mapper)
        {
            mapper.CreateMap<PersonViewModel, Person>()
                .ForPath(dest => dest.Contacts, src => src.MapFrom(x => (x.Contacts.Count > 0 ? x.Contacts : null)))
                ;

            mapper.CreateMap<Person, PersonViewModel>();
        }
    }
}
