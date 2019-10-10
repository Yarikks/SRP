using System;

namespace SRP
{
    class CreateU : User
    {
        public void CreateUser(string Name, int Age)
        {
            Users.Add(new User(Name, Age));
            Console.WriteLine($"{Name} - has been created");
        }
    }
}
