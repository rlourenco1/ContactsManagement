using AutoMapper;
using Contacts.Core.Domain.Entities;
using Contacts.Core.Interfaces.Repositories;
using Contacts.Core.Interfaces.Services;
using Contacts.Core.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Services
{
    public class PersonService : BaseService<PersonViewModel, Person>, IPersonService
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
    }
}
