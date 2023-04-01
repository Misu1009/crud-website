using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebCRUD.Model;

namespace WebCRUD.Repository
{
    public class UserRepository
    {
        static UserDatabaseEntities db = new UserDatabaseEntities();

        public static void insertUser(User data)                 // CREATE / INSERT
        {
            db.Users.Add(data);
            db.SaveChanges();
        }
        public static Boolean updateUser(int id, string newName, string email, string password) 
        {                                                       // UPDATE
            if (id != 0)
            {
                User data = getUser(id);
                data.name = newName;
                data.email = email;
                data.password = password;
                db.SaveChanges();

                return true;
            }
            return false;
        }
        public static Boolean deleteUser(int id)                // DELETE
        {
            if(id != 0)
            {
                User data = getUser(id);
                db.Users.Remove(data);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static List<User> getAllUser()                   // READ
        {
            return db.Users.ToList();
        }

        public static int getUserIdBasedOnName(string name)
        {
            List<User> datas = getAllUser();
            foreach (User data in datas)
            {
                if (data.name.Equals(name)) return data.id;
            }
            return 0;
        }
        
        public static int getUserIdBasedOnEmail(string email)
        {
            List<User> datas = getAllUser();
            foreach (User data in datas)
            {
                if (data.email.Equals(email)) return data.id;
            }
            return 0;
        }
        public static User getUser(int id)
        {
            return db.Users.Find(id);
        }
        public static Boolean isExist()
        {
            return db.Users.Any();
        }

    }
}