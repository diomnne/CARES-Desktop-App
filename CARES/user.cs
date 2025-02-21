using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_Finals
{
    public enum user_role
    {
        admin,
        nurse, 
        staff,
        patient
    }

    public class user
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime date_joined { get; set; }
        public user_role role { get; set; }
        public byte[] profile_picture { get; set; }

        public user(int user_id, string first_name, string last_name, string email, string password, DateTime date_joined, user_role role, byte[] profile_picture)
        {
            this.user_id = user_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
            this.date_joined = date_joined;
            this.role = role;
            this.profile_picture = profile_picture;
        }

        public user() { }


    }
}