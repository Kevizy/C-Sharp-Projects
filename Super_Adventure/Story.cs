using System;

namespace Super_Adventure
{
    public class Story
    {
        // Method to start the dragon quest 
        public static void DragonQuest()
        {
            Console.WriteLine();
            Console.WriteLine("You Show up at the dragon lair and find it deep in its sleep.");
            Console.WriteLine("You find it would be easier for it to take extra damage.");
            Console.WriteLine("Press a to equip bow and arrow or Press b to equip a sword.");
            string equipBow = Console.ReadLine();
            switch (equipBow)
            {
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("You have decided to use a bow an arrow. The dragon takes extra damage from the sneak attack.");
                    Fight.DragonFight();
                    Ending.DragonQuestEnd();
                    break;
                case "b":
                    Console.WriteLine();
                    Console.WriteLine("Please continue to kill the dragon.");
                    Fight.DragonFight();
                    Ending.DragonQuestEnd();
                    break;
                default:
                    break;

            }

        } // End dragon quest


        // Method to start the bandit quest 
        public static void BanditQuest()
        {
            Console.WriteLine();
            Console.WriteLine("You stumble on the bandit camp and they don\'t seem to be friendly.");
            Console.WriteLine("However, a bandit stops in front of you and demands some gold.");
            Console.WriteLine($"Press a to give the bandit gold or b to fight!");

            string select = Console.ReadLine();
            switch (select)
            {
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("Oops, sorry. You left your gold at home.");
                    Console.WriteLine("It's time to fight!");
                    Fight.BanditFight();
                    Ending.BanditQuestEnd();
                    break;
                case "b":
                    Console.WriteLine();
                    Console.WriteLine("It's time to fight!");
                    Fight.BanditFight();
                    Ending.BanditQuestEnd();
                    break;
                default:
                    break;
            }

        } // End bandit quest 
    }
}
