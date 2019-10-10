using System;

namespace SRP
{
    class Program
    {
        private static ShowU   show = new ShowU();
        private static CreateU create = new CreateU();
        private static DeleteU delete = new DeleteU();
        private static User u = new User();
        private static string[] name = { "Yaroslav", "Anton", "Boris", "Denis", "Andrey" };
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            
            //create
            for(int i =0;i< name.Length; i++)
            {
                create.CreateUser(name[i], rnd.Next(18, 45));
            }

            //show
            show.ShowUsers();
            
            //delete
            for(int i = 0; i < name.Length; i++)
            {
                delete.DeleteUser(name[i]);
            }

            //stops console
            Console.ReadLine();
        }
    }
}
