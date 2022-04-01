using AutoMapper;
using Contacts.Core.Domain.Entities;
using Contacts.Core.Interfaces.Repositories;
using Contacts.Core.Interfaces.Services;
using Contacts.Core.Resources.Enums;
using Contacts.Core.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Services
{
    public class ContactService : BaseService<ContactViewModel, Contact>, IContactService
    {
        private readonly IContactRepository _repository;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        IEnumerable<ContactViewModel> IContactService.GetByPersonId(int id)
        {
            try
            {
                var data = this._repository.GetByPersonId(id);

                return _mapper.Map<IEnumerable<ContactViewModel>>(data);
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        IEnumerable<ContactViewModel> IContactService.GetByTypeAndPersonId(ContactTypeEnum type, int id)
        {
            try
            {
                var data = this._repository.GetByTypeAndPersonId(type, id);

                return _mapper.Map<IEnumerable<ContactViewModel>>(data);
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
