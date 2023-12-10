using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;

namespace ContactServiceApi.Services
{
    public interface IContactService
    {
        public List<Contact> GetAllContacts();
        public Contact GetContactById(int id);
    }
}