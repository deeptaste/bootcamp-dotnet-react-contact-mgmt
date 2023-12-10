using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;
using ContactServiceApi.Repositories;

namespace ContactServiceApi.Services
{
    public class ContacService : IContacService
    {
        private readonly IContactRepo _contactRepo;

        public ContacService(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public List<Contact> GetAllContacts()
        {
            return _contactRepo.GetAllContacts();
        }

        public Contact GetContactById(int id)
        {
            return _contactRepo.GetContactById(id);
        }
    }
}