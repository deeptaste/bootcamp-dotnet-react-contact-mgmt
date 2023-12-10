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
            new() { Id = 1, FirstName = "John", LastName = "Doe", ContactType = ContactType.Email, ContactDetails = "john.doe@microsoft.com" },
            new() { Id = 2, FirstName = "Jane", LastName = "Smith", ContactType = ContactType.Email, ContactDetails = "jane.smith@gmail.com" },
            new() { Id = 3, FirstName = "John", LastName = "Doe", ContactType = ContactType.Phone, ContactDetails = "1234567890" },
            new() { Id = 4, FirstName = "Jane", LastName = "Smith", ContactType = ContactType.Phone, ContactDetails = "0987654321" }
        };

        public Task<List<Contact>> GetAllContactsAsync()
        {
            return Task.FromResult(_contacts);
        }

        public Task<Contact?> GetContactByIdAsync(int id)
        {
            return Task.FromResult(_contacts.FirstOrDefault(c => c.Id == id));
        }

        public Task AddContactAsync(Contact contact)
        {
            contact.Id = _contacts.Max(c => c.Id) + 1;
            _contacts.Add(contact);

            return Task.CompletedTask;
        }

        public Task UpdateContactAsync(Contact contact)
        {
            var existingContact = _contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.ContactType = contact.ContactType;
                existingContact.ContactDetails = contact.ContactDetails;
            }

            return Task.CompletedTask;
        }

        public Task DeleteContactAsync(int id)
        {
            var contactToDelete = _contacts.FirstOrDefault(c => c.Id == id);
            if (contactToDelete != null)
            {
                _contacts.Remove(contactToDelete);
            }
            return Task.CompletedTask;
        }
    }
}