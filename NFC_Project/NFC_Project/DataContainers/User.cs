using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFC_Project.DataContainers
{
    class User
    {
        public string UniqueID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public User(string id, string first, string last, string email, string phone)
        {
            UniqueID = id;
            FirstName = first;
            LastName = last;
            EmailAddress = email;
            PhoneNumber = phone;
        }
    }
}
