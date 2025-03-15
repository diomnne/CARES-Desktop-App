using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARES
{
    public class User
    {
        public int UserID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public int Role { get; set; }

        public byte[] ProfilePicture { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleInitial { get; set; }

        public User(int userID, string email, string password, DateTime dateCreated, int role, byte[] profilePicture, string firstName, string lastName, string middleInitial)
        {
            UserID = userID;
            Email = email;
            Password = password;
            DateCreated = dateCreated;
            Role = role;
            ProfilePicture = profilePicture;
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middleInitial;
        }


        public User() { }
    }
}
