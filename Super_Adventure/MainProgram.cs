using System;

namespace Super_Adventure
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            TitleScreen();

            MainMenu();


            Console.ReadKey();
        }


        // Method to print title screen 
        public static void TitleScreen()
        {
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine("Super Adventure RPG");
            Console.WriteLine();
            Console.WriteLine("==============================");

        } // End title screen 


        // Method to run the main menu 
        public static void MainMenu()
        {
            bool endMenu = false;  // This will keep the program running as long as user doesn't press to exit. 
            int selection;  // Value to store input for menu selection 

            do
            {
                Console.WriteLine();
                Console.WriteLine("1) Play Game");
                Console.WriteLine("2) View Stats");
                Console.WriteLine("3) Options");
                Console.WriteLine("4) Credits");
                Console.WriteLine("5) Quit Game");

                // stores input from user 
                selection = int.Parse(Console.ReadLine());   
                
                // statement to check input 
                switch (selection)
                {
                    case 1:
                        Game.StartGame();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("The stats section will be up soon. Please be patient.");
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("The options menu will be up soon. Please be patient.");
                        break;
                    case 4:
                        GameCredits();
                        break;
                    case 5:
                        GameQuit();
                        endMenu = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter 1, 2, 3, 4, or 5.");
                        break;
                }

            } while (endMenu != true);

        } // End main menu 


        // Method to print game credits 
        public static void GameCredits()
        {
            Console.WriteLine();
            Console.WriteLine("This game was developed by: Kevin Izykowski.");
            Console.WriteLine("Copyright (c) 2020");
            Console.WriteLine();

        } // end game credits 


        // Method to quit the game 
        public static void GameQuit()
        {
            Console.WriteLine();
            Console.WriteLine("The game will now exit.");
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to close the window....");

        } // End game quit 
    }
}
