using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCRUD.Controller
{
    public class Validation
    {
        public static Boolean emailAndPasswordValidation(string email, string password)
        {
            if (email.Equals("") || password.Equals(""))
                return false;

            if (!email.Contains("@gmail.com"))
                return false;

            return true;
        }
        public static Boolean nameValidate(string name)
        {
            if (name.Equals(""))
                return false;

            return true ;
        }
    }
}