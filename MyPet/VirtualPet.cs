using System;

namespace MyPet
{

    public abstract class MyVirtualPet  //Abstract class that can be used for all 3 pet options
    {
        public int Hunger { get; set; } //Declaring and encapsulating properties for virtual pet
        public string Name { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int PottyNeeds { get; set; }
        public Random Rng = new Random();   //Instantiating a new Random number to use in our tick method
        private int _tickNum;   //Declaring an int for our tick

        public abstract int CareMenu(); //I let the derived classes have some abstract classes so the message printed after they chose 
                                        //these actions could be more specific
        public abstract void ShowStats();   //Abstract method to show animal stats

        public void Water(MyVirtualPet myPet)   //Method that executes when user chooses to give water to all pet types. 
        {
            if (myPet.Thirst == 0)  //Won't execute if animal doesn't need water
            {
                Console.WriteLine($"{myPet.Name} doesn't need any water right now!");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                myPet.Thirst--;
                Console.WriteLine($"{myPet.Name} is happy for the fresh water!");
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void Feed(MyVirtualPet myPet)
        {
            if (myPet.Hunger == 0)
            {
                Console.WriteLine($"{myPet.Name} doesn't need any food right now!");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                myPet.Hunger--;
                Console.WriteLine($"{myPet.Name} loooooves food!");
                System.Threading.Thread.Sleep(1000);
            }
        } //Similar to Water()

        public abstract void Play();    //Abstract method to reduce pet boredom

        public abstract void PottyDetail(); //Abstract method to reduce PottyNeeds

        public void Tick(MyVirtualPet myPet)    //Tick method to increase a property randomly. Runs in loop every time.
        {
            _tickNum = Rng.Next(1, 5);
            if (_tickNum == 1)
            {
                myPet.Hunger++;
            }
            else if (_tickNum == 2)
            {
                myPet.Thirst++;
            }
            else if (_tickNum == 3)
            {
                myPet.Boredom++;
            }
            else
            {
                myPet.PottyNeeds++;
            }
        }

        public void PerformChosenTask(int userChoice, MyVirtualPet myPet)   
        {
            if (userChoice == 1)
            {
                myPet.Feed(myPet);
            }
            else if (userChoice == 2)
            {
                myPet.Water(myPet);
            }
            else if (userChoice == 3)
            {
                myPet.Play();
            }
            else if (userChoice == 4)
            {
                myPet.PottyDetail();
            }
            else
            {
                Console.WriteLine("See you later!");
            }
        }//Executes users chosen task

    }
}
