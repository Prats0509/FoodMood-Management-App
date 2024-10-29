using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_OOP_2330506
{
    public static class UserManager
    {
        public static List<User> users = new List<User>();

        static UserManager()
        {
            users.Add(new User("admin", "Admin@123", "Administrator", new List<string>() { "None"}, new List<string>() { "None" }));
        }
       
        public static void RegisterUser(string username, string password, string fullname, List<string> dietaryRestrictions, List<string> allergies)
        {
            users.Add(new User(username,password,fullname,dietaryRestrictions,allergies));
        }

        public static bool AuthenticateUser(string username, string password)
        {
            bool userExists = false;
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    userExists = true;
                    break;
                }
            }
            return userExists;

        }
        public static User GetUserByUsername(string username)
        {
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null; 
        }
    }
}
