using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;
using ContactServiceApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactServiceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet] // api/contact
        public ActionResult<IEnumerable<Contact>> GetAllContacts()
        {
            return _contactService.GetAllContacts();
        }

        [HttpGet("{id}")] // api/contact/1
        public ActionResult<Contact> GetContactById(int id)
        {
            return _contactService.GetContactById(id);
        }
    }
}