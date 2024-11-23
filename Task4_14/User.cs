using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_14
{
        public class User
        {
            public int UserID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ContactNumber { get; set; }
            public string Address { get; set; }

            public User(int userID, string name, string email, string contactNumber, string address)
            {
                UserID = userID;
                Name = name;
                Email = email;
                Password = PasswordGenerator.GenerateSecurePassword(12); // Generate a secure password
                ContactNumber = contactNumber;
                Address = address;
            }
        }
}


