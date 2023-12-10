using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactServiceApi.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ContactType ContactType { get; set; }
        public string ContactDetails { get; set; } = string.Empty;
    }
}