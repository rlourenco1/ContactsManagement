using Contacts.Core.Interfaces.Services;
using Contacts.Core.Resources.Enums;
using Contacts.Core.Resources.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        [Route("{id}")]
        [HttpGet]
        public ContactViewModel Get(int id)
        {
            return _contactService.GetById(id);
        }

        [Route("byPersonId/{personId}")]
        [HttpGet]
        public IEnumerable<ContactViewModel> GetByPersonId(int personId)
        {
            return _contactService.GetByPersonId(personId);
        }

        [Route("byTypeAndPersonId")]
        [HttpGet]
        public IEnumerable<ContactViewModel> GetByTypeAndPersonId([FromQuery] ContactTypeEnum type, int personId)
        {
            return _contactService.GetByTypeAndPersonId(type, personId);
        }

        [HttpPut]
        public ContactViewModel Put([FromBody] ContactViewModel model)
        {
            return _contactService.Update(model);
        }

        [HttpPost]
        public ContactViewModel Post([FromBody] ContactViewModel model)
        {
            return _contactService.Create(model);
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ContactViewModel model)
        {
            _contactService.Delete(model);

            return Ok();
        }
    }
}
