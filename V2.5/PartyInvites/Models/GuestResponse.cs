using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Account { get; set; }
        public bool? Item { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string Zip { get; set; }
        
    }
}
