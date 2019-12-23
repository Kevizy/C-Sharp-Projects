using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class MainMenu
    {
        public static void Main(string[] args)
        {
            // Control variable 
            int input = 6;

            Examples ex = new Examples(); 

            // do while 
            do
            {
                // Main menu
                Console.WriteLine("Welcome to my game!");
                Console.WriteLine("\n\nPlease make a selection:");
                Console.WriteLine("1) Demonstrate For Loop");
                Console.WriteLine("2) Show Multiplication Table");
                Console.WriteLine("3) Triple For Loops");
                Console.WriteLine("4) Demo Conditionals");
                Console.WriteLine("5) Demo Booleans");
                Console.WriteLine("6) Exit");

                // Gets input from user 
                input = int.Parse(Console.ReadLine());

                // Switch statement to check input 
                switch (input)
                {
                    case 1:
                        Console.Write("Please enter an int: ");      // Prompts user to enter an int
                        int temp = int.Parse(Console.ReadLine());   // Receives input from user 
                        ex.DemoForLoop(temp);       // Calls from other class 
                        break;
                    case 2:
                        Console.Write("Please enter an int: ");      // Prompts user to enter an int
                        int temp2 = int.Parse(Console.ReadLine());   // Receives input from user 
                        ex.MultiplicationTable(temp2);   // Calls from multiplication table class 
                        break;
                    case 3:
                        Console.Write("Please enter three ints: ");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        ex.TripleForLoops(a, b, c);
                        break;
                    case 4:
                        Console.Write("Please Enter Two Ints"); // Proompts user to enter an int
                        int x = int.Parse(Console.ReadLine());  // Receives input from user 
                        int y = int.Parse(Console.ReadLine());  // Receives input from user
                        ex.DemoConditionals(x, y); // Calls from Demo condiionals class 
                        break;
                    case 5:
                        Console.Write("Please Enter Two Ints"); // Proompts user to enter an int
                        int e = int.Parse(Console.ReadLine());  // Receives input from user 
                        int f = int.Parse(Console.ReadLine());  // Receives input from user
                        ex.DemoBooleans(e, f); // Calls from Demo condiionals class 
                        break; 
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Please enter 1 to 6 again.");
                        break;
                }

            } while (input != 6);

            // End program 
            Console.WriteLine("Thanks for playing, goodbye."); 
            Console.ReadKey(); 
        }
    }
}
