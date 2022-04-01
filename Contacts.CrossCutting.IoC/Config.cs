using Contacts.Core.Interfaces.Repositories;
using Contacts.Core.Interfaces.Services;
using Contacts.Core.Services;
using Contacts.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.CrossCutting.IoC
{
    public class Config
    {
        public static void DependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();

            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactService>();
        }
    }
}
