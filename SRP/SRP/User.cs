using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class User
    {
        public string Name { get; set; }
        public int    Age  { get; set; }
        
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public User() { }

        public static List<User> Users = new List<User>();
    }
}
