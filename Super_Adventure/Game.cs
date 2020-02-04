using System;

namespace Super_Adventure
{
    public class Game
    {
        // Sets empty value for character name 
        static string characterName = "";


        // Method to start the game 
        public static void StartGame()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Super Adventure! You will be exploring the cool world.");
            Console.WriteLine();
            NameCharacter();
            CharacterChoice();

        } // End Start game


        // Method to name the character 
        public static void NameCharacter()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your character name: ");
            characterName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome to the world, {characterName}");

        } // End name character 


        // Method to choose a quest 
        public static void CharacterChoice()
        {
            Console.WriteLine();
            Console.WriteLine("\nYou want to earn extra money and ask the King for work.");
            Console.WriteLine("\nThe King has given you an option to slay a dragon or clear out a bandit lair.");
            Console.WriteLine($"\n{characterName}, press a to slay the dragon or b to clear out a bandit lair.");

            string input = Console.ReadLine();
            if (input == "a")
            {
                Console.WriteLine("\nYou have chosen to kill a dragon.");
                Console.WriteLine("\nThe king has given you a potion to resist fire for 60 seconds.");
                Story.DragonQuest();
            }
            else
            {
                Console.WriteLine("\nYou have chosen to kill a group of bandits at a lair.");
                Console.WriteLine("\nThe king has given you a special set of armor for protection.");
                Story.BanditQuest();
            }

        } // End Character choice 
    }
}
