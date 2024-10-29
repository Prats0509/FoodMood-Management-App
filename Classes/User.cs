using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_2330506
{
    public class User
    {
        private string username;
        private string password;
        private string fullname;
        private List<string> dietaryrestrictions = new List<string>();
        private List<string> allergies = new List<string>();
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullname; set => fullname = value; }
        public List<string> DietaryRestrictions { get => dietaryrestrictions; set => dietaryrestrictions = value; }
        public List<string> Allergies { get => allergies; set => allergies = value; }
        public User() { }

        public User(string username, string password, string fullName, List<string> dietaryRestrictions, List<string> allergies)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            DietaryRestrictions = dietaryRestrictions;
            Allergies = allergies;
        }
    }
}
