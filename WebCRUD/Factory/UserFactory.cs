using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCRUD.Model;

namespace WebCRUD.Factory
{
    public class UserFactory
    {
        public static User createUser(string name, string email, string password)
        {
            User data = new User();
            data.name = name;
            data.email = email;
            data.password = password;

            return data;
        }
    }
}