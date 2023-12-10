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

        public Task<List<Contact>> GetAllContactsAsync()
        {
            return _contactRepo.GetAllContactsAsync();
        }

        public Task<Contact?> GetContactByIdAsync(int id)
        {
            return _contactRepo.GetContactByIdAsync(id);
        }

        public Task AddContactAsync(Contact contact)
        {
            return _contactRepo.AddContactAsync(contact);
        }

        public Task UpdateContactAsync(Contact contact)
        {
            return _contactRepo.UpdateContactAsync(contact);
        }

        public Task DeleteContactAsync(int id)
        {
            return _contactRepo.DeleteContactAsync(id);
        }
    }
}