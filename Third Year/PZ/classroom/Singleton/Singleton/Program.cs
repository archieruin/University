using System;

namespace Singleton
{
    class User 
    {
        private User() {}

        private static User _instanse;

        public static User GetInstanse()
        {
            if (_instanse == null)
                _instanse = new User();
            return _instanse;
        }

        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User firstUser = User.GetInstanse();
            User secondUser = User.GetInstanse();

            if (firstUser == secondUser)
            {
                Console.WriteLine("Singleton works good :)");
            }
            else
            {
                Console.WriteLine("You have bad Singleton realization!");
            }
        }
    }
}
