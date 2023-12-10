using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;
using ContactServiceApi.Repositories;

namespace ContactServiceApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepo _contactRepo;

        public ContactService(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await _contactRepo.GetAllContactsAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await _contactRepo.GetContactByIdAsync(id);
        }
    }
}