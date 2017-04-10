using System;

namespace MyPet
{
    internal class Program
    {
        private static void Main()
        {
            int userChoice;

            UserInteraction.GreetUser();    //Greeting user
            Console.WriteLine();

            var petPick = UserInteraction.PromptForPetChoice(); //Getting user's pet choice
            Console.WriteLine();

            switch (petPick)    //Executing proper code depending on which pet the user chose
            {
                case (1):
                    MyVirtualPet myCat = new Cat { Name = UserInteraction.GetPetName() };   //Instantiating a cat if that's what the 
                    Console.Clear();                                                        //user chose
                    do     //Cat menu is a do while loop, so it will run until the user wants to quit
                    {
                        myCat.ShowStats();  //Showing current stats and will update with each loop
                        userChoice = myCat.CareMenu();  //Showing user the options that are available for their pet
                        myCat.PerformChosenTask(userChoice, myCat); //Executes user's chosen action
                        myCat.Tick(myCat);  //Adds 1 to the value of one of the pet's properties randomly
                    } while (userChoice != 5);  //Loop will stop when user enters 5 to quit
                    break;

                case (2):
                    MyVirtualPet myDog = new Dog { Name = UserInteraction.GetPetName() };   //same as above but for a dog
                    Console.Clear();
                    do
                    {
                        myDog.ShowStats();
                        userChoice = myDog.CareMenu();
                        myDog.PerformChosenTask(userChoice, myDog);
                        myDog.Tick(myDog);
                    } while (userChoice != 5);
                    break;

                case (3):
                    MyVirtualPet myHamster = new Hamster { Name = UserInteraction.GetPetName() };   //same as above but for a hamster
                    Console.Clear();
                    do
                    {
                        myHamster.ShowStats();
                        userChoice = myHamster.CareMenu();
                        myHamster.PerformChosenTask(userChoice, myHamster);
                        myHamster.Tick(myHamster);
                    } while (userChoice != 5);
                    break;
            }
        }
    }
}
