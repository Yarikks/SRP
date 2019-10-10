using System;

namespace SRP
{
    class DeleteU : User
    {
        public void DeleteUser(string Name)
        {
            User user = Users.Find(u => u.Name == Name);
            Users.Remove(user);
            Console.WriteLine($"User - {user.Name} - successfully deleted.");
        }
    }
}
