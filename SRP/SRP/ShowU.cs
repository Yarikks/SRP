using System;

namespace SRP
{
    class ShowU : User
    {
        public void ShowUsers()
        {
            Console.WriteLine(new string('-', 10));
            foreach (User u in Users)
            {
                Console.WriteLine($"Name: {u.Name}\nAge: {u.Age}");
                Console.WriteLine(new string('-', 10));
            }
        }
    }
}