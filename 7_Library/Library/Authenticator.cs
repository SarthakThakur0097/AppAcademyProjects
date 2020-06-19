using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library
{
    public class Authenticator
    {
         private List<User> users;

        public Authenticator()
        {
            users = new List<User>
            {
                new User { Username = "James", Password="password" },
                new User { Username = "Bryan", Password="unicorn" },
            };
        }
        public User Authenticate(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}