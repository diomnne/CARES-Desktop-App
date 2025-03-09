using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARES
{
    public class UserSession
    {
        private static UserSession _instance;
        public DateTime LastActivity { get; private set; }
        public int AccountId { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        private UserSession()
        {
            UpdateActivity();
        }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserSession();
                return _instance;
            }
        }

        public void SetUser(int accountId, string email, string role)
        {
            AccountId = accountId;
            Email = email;
            Role = role;
            UpdateActivity();
        }

        public void UpdateActivity()
        {
            LastActivity = DateTime.Now;
        }

        public void ClearSession()
        {
            AccountId = 0;
            Email = null;
            Role = null;
        }
    }
}
