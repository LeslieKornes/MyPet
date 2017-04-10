using System;

namespace MyPet
{
    public static class UserInteraction
    {
        public static void GreetUser()
        {
            Console.WriteLine("Welcome to the virtual pet game!");
        }   //Generic user greeting

        public static int PromptForPetChoice()  //Asking the user which pet type they would like and returning their integer value
        {
            string petChoice;
            do     //Loop will execute until user chooses a valid pet type
            {
                Console.WriteLine("What kind of a pet would you like today? \n\n"); //Pet option menu
                Console.WriteLine("Enter 1 for a cat.");
                Console.WriteLine("      2 for a dog.");
                Console.WriteLine("      3 for a hamster.");
                petChoice = Console.ReadLine();
                if (petChoice != "1" && petChoice != "2" && petChoice != "3")   //Will execute if user presses a letter or invalid number choice
                {
                    Console.WriteLine("That is not a valid pet selection!\n");
                    System.Threading.Thread.Sleep(1000);
                }
            } while (petChoice != "1" && petChoice != "2" && petChoice != "3");
            int pet = Convert.ToInt32(petChoice);   //Converting user input 
            return pet; //Returning user input as int
        }

        public static string GetPetName()   
        {
            Console.WriteLine("Wonderful choice! What name have you chosen?");
            return Console.ReadLine();  //Returns the string so it can be assigned to the pet name 
        }//Obtains and returns pet name
    }
}
