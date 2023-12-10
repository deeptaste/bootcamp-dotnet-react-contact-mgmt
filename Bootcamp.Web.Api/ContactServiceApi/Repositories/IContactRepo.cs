using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;

namespace ContactServiceApi.Repositories
{
    public interface IContactRepo
    {
        public List<Contact> GetAllContacts();
        public Contact GetContactById(int id);
    }
}