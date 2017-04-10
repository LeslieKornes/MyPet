using System;

namespace MyPet
{
    internal class Hamster : MyVirtualPet
    {
        public Hamster()
        {
            Hunger = 3;
            Thirst = 3;
            Boredom = 3;
            PottyNeeds = 3;
        }

        public override void ShowStats()
        {
            Console.WriteLine("  q-p\n /\\\"/\\\n(`=*=')\n ^---^");
            Console.WriteLine($"\nCurrently, {Name} has:");
            Console.WriteLine();
            Console.WriteLine($"Hunger Level: {Hunger}");
            Console.WriteLine($"Thirst Level: {Thirst}");
            Console.WriteLine($"Boredom Level: {Boredom}");
            Console.WriteLine($"Cage Filth Level: {PottyNeeds}");
        }

        public override int CareMenu()
        {
            string userInput;
            do
            {
                Console.WriteLine($"\nWhat would you like to do for {Name}?\n\n");
                Console.WriteLine("Enter 1 to give your hamster food.\n");
                Console.WriteLine("      2 to give your hamster fresh water.\n");
                Console.WriteLine($"      3 to play with {Name}.\n");
                Console.WriteLine($"      4 to clean out {Name}'s cage.\n");
                Console.WriteLine("      5 to quit.");
                userInput = Console.ReadLine();
                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5")
                {
                    Console.WriteLine("That is not a valid choice!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();
                }
                Console.Clear();
            } while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5");

            return Convert.ToInt32(userInput);
        }

        public override void Play()
        {
            Boredom--;
            Console.WriteLine($"{Name} loves when you play with him!");
            System.Threading.Thread.Sleep(1000);
        }

        public override void PottyDetail()
        {
            PottyNeeds--;
            Console.WriteLine($"{Name}'s cage is a bit cleaner.");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
