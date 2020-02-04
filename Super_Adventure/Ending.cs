using System;

namespace Super_Adventure
{
    public class Ending
    {
        // Method to end the dragon quest 
        public static void DragonQuestEnd()
        {
            Console.WriteLine();
            Console.WriteLine("You have slayed the dragon and saved the kingdom. The king thanks you and rewards you with 500 gold.");

        } // End dragonquestend


        // Method to end the bandit quest 
        public static void BanditQuestEnd()
        {
            Console.WriteLine();
            Console.WriteLine("You have cleared out the bandit lair. Travelers passing by won't be harassed by bandits anymore. The king thanks you and rewards you with 500 gold.");

        } // End banditquestend 
    }
}
