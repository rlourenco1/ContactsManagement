using Contacts.Core.Interfaces.Services;
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
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            this._personService = personService;
        }

        [HttpGet]
        public IEnumerable<PersonViewModel> GetAll()
        {
            return _personService.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public PersonViewModel Get(int id)
        {
            return _personService.GetById(id);
        }

        [HttpPut]
        public PersonViewModel Put([FromBody] PersonViewModel model)
        {
            return _personService.Update(model);
        }

        [HttpPost]
        public PersonViewModel Post([FromBody] PersonViewModel model)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest(CustomExtensions.GetErrorMessages(ModelState));

            return _personService.Create(model);

            //return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] PersonViewModel model)
        {
            _personService.Delete(model);

            return Ok();
        }
    }
}
