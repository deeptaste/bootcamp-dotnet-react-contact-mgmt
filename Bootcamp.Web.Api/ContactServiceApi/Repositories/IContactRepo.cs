using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;

namespace ContactServiceApi.Repositories
{
    public interface IContactRepo
    {
        Task<List<Contact>> GetAllContactsAsync();
        Task<Contact> GetContactByIdAsync(int id);
    }
}