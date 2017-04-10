using System;

namespace MyPet
{
    public class Cat : MyVirtualPet //Class derived from VirtualPet class
    {
        public Cat()
        {
            Hunger = 3;
            Thirst = 3;
            Boredom = 3;
            PottyNeeds = 3;
        }

        public override void ShowStats()
        {
            Console.WriteLine("\n\t=^.,.^=\n");
            Console.WriteLine($"\nCurrently, {Name} has:");
            Console.WriteLine();
            Console.WriteLine($"Hunger Level: {Hunger}");
            Console.WriteLine($"Thirst Level: {Thirst}");
            Console.WriteLine($"Boredom Level: {Boredom}");
            Console.WriteLine($"Litter Box Filth Level: {PottyNeeds}");

        }

        public override int CareMenu()
        {
            string userInput;
            do
            {
                Console.WriteLine($"\nWhat would you like to do for {Name}?\n");
                Console.WriteLine("Enter 1 to give your cat food.\n");
                Console.WriteLine("      2 to give your kitty fresh water.\n");
                Console.WriteLine("      3 to play with your cat.\n");
                Console.WriteLine("      4 to scoop the stinky litterbox.\n");
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
            Console.WriteLine($"{Name} loves to play with the laser pointer!");
            System.Threading.Thread.Sleep(1000);
        }

        public override void PottyDetail()
        {
            PottyNeeds--;
            Console.WriteLine("The litterbox looks a bit better.");
            System.Threading.Thread.Sleep(1000);
        }
    }
}