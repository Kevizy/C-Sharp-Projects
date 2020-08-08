using System;

namespace User_Login
{
    class Program
    {
        public static void Main(string[] args)
        {
            string user;
            string pass;
            string confirmUser;
            string confirmPass;

            Console.WriteLine("Enter username: ");
            user = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Confirm username: ");
            confirmUser = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter Password: ");
            pass = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Confirm Password: ");
            confirmPass = Console.ReadLine(); 

            if (user != confirmUser || pass != confirmPass)
            {
                Console.WriteLine();
                Console.WriteLine("Usernames or passwords do not match.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Successfully logged in.");
            }

            Console.ReadKey(); 
        }
    }
}
