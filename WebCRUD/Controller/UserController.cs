using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCRUD.Factory;
using WebCRUD.Model;
using WebCRUD.Repository;

namespace WebCRUD.Controller
{
    public class UserController
    {
        public static string login(string email, string password)
        {
            email = email.Trim();
            password = password.Trim();

            if (!Validation.emailAndPasswordValidation(email, password))
                return "Email or Password is Wrong";

            int id = UserRepository.getUserIdBasedOnEmail(email);
            if (id == 0) return "Email Not Found";

            User data = UserRepository.getUser(id);
            if (!data.password.Equals(password)) 
                return "Password Is Wrong";

            return "Succes";
        }
        
        public static string register(string name, string email, string password)
        {
            name = name.Trim();
            email = email.Trim();
            password = password.Trim();

            if (!Validation.nameValidate(name))
                return "Name is Wrong";

            if (!Validation.emailAndPasswordValidation(email, password))
                return "Email or Password is Wrong";

            if (duplicateEmail(email))
                return "Email Is Duplicate";

            User data = UserFactory.createUser(name, email, password);

            UserRepository.insertUser(data);
            return "Succes";
        }

        public static void delete(int id)
        {
            UserRepository.deleteUser(id);
        }
        
        public static List<User> getAllUser()
        {
            return UserRepository.getAllUser();
        }
        public static Boolean isExist()
        {
            return UserRepository.isExist();
        }
        public static Boolean duplicateEmail(string email)
        {
            int id = UserRepository.getUserIdBasedOnEmail(email);
            if (id == 0)
                return false;

            return true;
        }
    }
}