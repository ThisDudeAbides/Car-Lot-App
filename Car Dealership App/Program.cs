using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            List<Car> AllCars = CarLot.GetCars();

            Console.WriteLine("Welcome to the Grand Circus Car Lot administartive system\n");
            while (repeat)
            { 
                Console.WriteLine("System menu\n\nPlease pick from the menue below\n1. Car List\n2. Add a car\n3. Remove a car\n4. Search car\n5. Replace car\n6. Quit");

                string UserInput = Console.ReadLine();

                Console.WriteLine();

            
            
                if (UserInput == "1")
                {
                    CarLot.PrintInfo(AllCars);
                }
                else if (UserInput == "2")
                {
                    CarLot.AddCars(AllCars);
                    CarLot.PrintInfo(AllCars);
                }
                else if (UserInput == "3")
                {
                    CarLot.RemoveCars(AllCars);
                    CarLot.PrintInfo(AllCars);
                }
                else if (UserInput == "4")
                {
                    CarLot.IndexSearch(AllCars);
                }
                else if (UserInput == "5")
                {
                    CarLot.ReplaceCar(AllCars);
                    CarLot.PrintInfo(AllCars);
                }      
                
                Console.WriteLine("would you like to quit? (1) quit (2) continue");
                int AskQuit = int.Parse(Console.ReadLine());
                if (AskQuit == 1)
                {
                    Console.WriteLine("bye");
                    repeat = false;
                }
                
            }
            
        }
        
    }
}

