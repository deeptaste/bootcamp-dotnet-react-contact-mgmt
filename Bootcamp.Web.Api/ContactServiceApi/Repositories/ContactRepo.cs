using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactServiceApi.Models;

namespace ContactServiceApi.Repositories
{
    public class ContactRepo : IContactRepo
    {
        public static List<Contact> _contacts = new()
        {
            new() { Id = 1, FirstName = "John", LastName = "Doe", ContactType = ContactType.Email, ContactDetails = "john.doe@gmail.com" }
        };

        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public Contact GetContactById(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id) ?? throw new Exception("Contact not found");
        }
    }
}