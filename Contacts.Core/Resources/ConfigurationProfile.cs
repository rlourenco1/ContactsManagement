using AutoMapper;
using Contacts.Core.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Resources
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            this.AllowNullCollections = true;

            PersonViewModel.Mapping(this);
            ContactViewModel.Mapping(this);
        }
    }
}
