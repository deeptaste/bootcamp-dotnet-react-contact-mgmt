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
        public async Task<ActionResult<IEnumerable<Contact>>> GetAllContacts()
        {
            var contacts = await _contactService.GetAllContactsAsync();
            return contacts;
        }

        [HttpGet("{id}")] // api/contact/1
        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return contact;
        }
    }
}