using System;

namespace Super_Adventure
{
    public class Fight
    {
        // Method to start the dragon battle 
        public static void DragonFight()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to equip your potion?");
            Console.WriteLine("Press a to use potion or b to not use it.");
            string potionSelect = Console.ReadLine();
            switch (potionSelect)
            {
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("You have equipped the potion. You have 60 seconds of fire protection.");
                    break;
                case "b":
                    Console.WriteLine();
                    Console.WriteLine("You refuse to use the potion. You have intense burns from the dragon.");
                    break;
                default:
                    break;
            }

        } // End dragon fight 


        // Method to start the bandit battle 
        public static void BanditFight()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to use the armor? ");
            Console.WriteLine("Press a to equip or press b to not use it.");
            string armorEquip = Console.ReadLine();
            switch (armorEquip)
            {
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("You have equipped the armor and used the special sword. It came in handy with the fight.");
                    break;
                case "b":
                    Console.WriteLine();
                    Console.WriteLine("You refuse to use the armor and sword. You have a tough time fighting off the bandits.");
                    break;
                default:
                    break;
            }

        } // End bandit fight 
    }
}
